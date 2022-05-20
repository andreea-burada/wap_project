using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wap_Project.Entities;

namespace wap_Project.Forms
{
    public partial class LoginForm : Form
    {
        public List<Client> _clients;
        private const string ConnectionString = "Data Source=Databases/Client_Database.db";

        public LoginForm()
        {
            _clients = new List<Client>();
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e) 
        { 
            loadClientsDB();
        }

        // load clients from db
        private void loadClientsDB()
        {
            const string query = "select * from Clients";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //long id = (long)reader["Id"];
                        //string lastName = (string)reader["LastName"];
                        //string firstName = (string)reader["FirstName"];
                        //DateTime birthDate = DateTime.Parse((string)reader["BirthDate"]);

                        Guid id = Guid.Parse((string)reader["id"]);
                        string first_name = (string)reader["first_name"];
                        string last_name = (string)reader["last_name"];
                        string email = (string)reader["email"];
                        string username = (string)reader["username"];
                        int age = Int32.Parse(reader["age"].ToString());
                        long phone_number = Int64.Parse(reader["phone_number"].ToString());
                        string password = (string)reader["password"];
                        int pronoun = Int32.Parse(reader["pronoun"].ToString());
                        int question_id = Int32.Parse(reader["security_index"].ToString());
                        string security_q_answer = (string)reader["security_answer"];

                        Client _newClient = new Client(id, first_name, last_name, email, age, username, password,
                            question_id, security_q_answer, pronoun, phone_number);
                        _clients.Add(_newClient);
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // we check if the username exists
            if (tbUsername.Text == string.Empty || tbPassword.Text == string.Empty)
            {
                if (tbUsername.Text == string.Empty)
                {
                    lbInvalidUsername.Text = "Username field blank";
                }
                else
                {
                    lbInvalidUsername.Text = "";
                }
                if (tbPassword.Text == string.Empty)
                {
                    lbInvalidPassword.Text = "Password field blank";
                }
                else
                {
                    lbInvalidPassword.Text = "";
                }
            }
            else if (usernameExists(tbUsername.Text) == true)
            {
                lbInvalidUsername.Text = "";
                // we check if the password is right
                if (passwordCorrect(tbUsername.Text).Equals(tbPassword.Text) == true)
                {
                    // we open the booking interface
                    lbInvalidPassword.Text = "";
                    
                    this.Hide();
                    if (tbUsername.Text == "admin")
                    {
                        AdminPage adminWindow = new AdminPage();
                        if (adminWindow.ShowDialog() == DialogResult.OK)
                        {

                        }
                    }
                    else
                    {
                        BookingPage bookingWindow = new BookingPage();
                        if (bookingWindow.ShowDialog() == DialogResult.OK)
                        {

                        }
                    }
                    // tbUsername.Text = "";
                    tbPassword.Text = "";
                    this.Show();
                }
                else
                {
                    lbInvalidPassword.Text = "Password is incorrect";
                }
            }
            else
            {
                lbInvalidUsername.Text = "Username does not exist";
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupWindow = new SignupForm(_clients);
            this.Hide();
            if (signupWindow.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        } 

        #region Validations
        private bool usernameExists(string usernameToCheck)
        {
            long countVal;
            string query = "select count(id) from Clients where username = @username";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@username", usernameToCheck);

                dbConnection.Open();
                countVal = (long)command.ExecuteScalar();  // because we return ONE value 

            }

            return countVal == 1 ? true : false;
        }
        private string passwordCorrect(string username4PasswordToCheck)
        {
            string returnedPassword;
            string query = "select password from Clients where username = @username";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@username", username4PasswordToCheck);

                dbConnection.Open();
                returnedPassword = command.ExecuteScalar().ToString();  // because we return ONE value 

            }

            return returnedPassword;
        }
        private void chkbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxPassword.Checked == true)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '●';
        }
        #endregion

        #region CustomButtons
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
