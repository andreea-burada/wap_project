using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wap_Project.Entities;

namespace wap_Project.Forms
{

    public partial class SignupForm : Form
    {
        #region Attributes
        protected Client _newClient;
        protected List<Client> _clients;
        private const string ConnectionString = "Data Source=Databases/Client_Database.db";
        #endregion
        public SignupForm()
        {
            InitializeComponent();
        }

        public SignupForm(List<Client> _client_list) : this()
        {
            _clients = _client_list;
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            // adding ages to age drop down
            for (var i = 18; i < 100; i++)
                comboBoxAge.Items.Add(i.ToString());

            // adding the security questions drop down
            for (var i = 0; i < SecurityQuestion.all_questions.Count; i++)
                comboBoxSecQ.Items.Add(SecurityQuestion.all_questions[i].ToString());

            // adding the pronouns
            comboBoxPronouns.Items.Add("Mr.");
            comboBoxPronouns.Items.Add("Ms.");
            comboBoxPronouns.Items.Add("Mx.");

            this.Focus();
            this.Select();
        }

        private void AddClientToDB(Client clientToAdd)
        {
            //string query = "insert into Clients(id, username, first_name, last_name, email, age, phone_number, password, pronoun, security_index, security_answer) values ('" +
            //    clientToAdd.id + "', '" + clientToAdd.username + "', '" + clientToAdd.first_name + "', '" + clientToAdd.last_name + "', '" + clientToAdd.email + "', " +
            //    clientToAdd.age + ", " + clientToAdd.phone_number + ", '" + clientToAdd.password + "', " + clientToAdd.pronoun + ", " + clientToAdd.security_question.questionId +
            //    ", '" + clientToAdd.security_question.question_answer + "')";

            string query = "insert into Clients(id, username, first_name, last_name, email, age, phone_number, password, pronoun, security_index, security_answer) values " +
                "(@Id, @Username, @firstName, @lastName, @Email, @Age, @phoneNumber, @Password, @Pronoun, @securityId, @securityAnswer)";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@Id", clientToAdd.id.ToString());
                command.Parameters.AddWithValue("@Username", clientToAdd.username);
                command.Parameters.AddWithValue("@firstName", clientToAdd.first_name);
                command.Parameters.AddWithValue("@lastName", clientToAdd.last_name);
                command.Parameters.AddWithValue("@Email", clientToAdd.email);
                command.Parameters.AddWithValue("@Age", clientToAdd.age);
                command.Parameters.AddWithValue("@phoneNumber", clientToAdd.phone_number);
                command.Parameters.AddWithValue("@Password", clientToAdd.password);
                command.Parameters.AddWithValue("@Pronoun", clientToAdd.pronoun);
                command.Parameters.AddWithValue("@securityId", clientToAdd.security_question.questionId);
                command.Parameters.AddWithValue("@securityAnswer", clientToAdd.security_question.question_answer);

                dbConnection.Open();
                command.ExecuteNonQuery();  // because we return nothing 
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            tbEmail.Focus();
            tbFirstname.Focus();
            tbLastname.Focus();
            tbPhone.Focus();
            tbPassword.Focus();
            tbPasswordVer.Focus();
            tbSecurityQuestion.Focus();
            comboBoxSecQ.Focus();
            comboBoxPronouns.Focus();
            comboBoxAge.Focus();
            tbUsername.Focus();

            if (signupErrors.GetError(tbUsername) != string.Empty || signupErrors.GetError(tbEmail) != string.Empty ||
                signupErrors.GetError(tbFirstname) != string.Empty || signupErrors.GetError(tbLastname) != string.Empty ||
                signupErrors.GetError(tbPhone) != string.Empty || signupErrors.GetError(tbPassword) != string.Empty ||
                signupErrors.GetError(tbPasswordVer) != string.Empty || signupErrors.GetError(tbSecurityQuestion) != string.Empty ||
                signupErrors.GetError(comboBoxSecQ) != string.Empty || signupErrors.GetError(comboBoxPronouns) != string.Empty ||
                signupErrors.GetError(comboBoxAge) != string.Empty)
            {
                MessageBox.Show("Invalid data. Please check your input data.", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.AcceptButton = btnSignup;
                btnSignup.DialogResult = DialogResult.OK;
                string first_name = tbFirstname.Text;
                string last_name = tbLastname.Text;
                string email = tbEmail.Text;
                string username = tbUsername.Text;
                int age = Int32.Parse(comboBoxAge.Items[comboBoxAge.SelectedIndex].ToString());
                long phone_number = Int64.Parse(tbPhone.Text);
                string password = tbPassword.Text;
                int pronoun = comboBoxPronouns.SelectedIndex;
                int question_id = comboBoxSecQ.SelectedIndex;
                string security_q_answer = tbSecurityQuestion.Text;

                _newClient = new Client(first_name, last_name, email, age, username, password, question_id, security_q_answer, pronoun, phone_number);
                _clients.Add(_newClient);

                AddClientToDB(_newClient);
            }

        }

        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbEmail.Focus();
            tbFirstname.Focus();
            tbLastname.Focus();
            tbPhone.Focus();
            tbPassword.Focus();
            tbPasswordVer.Focus();
            tbSecurityQuestion.Focus();
            comboBoxSecQ.Focus();
            comboBoxPronouns.Focus();
            comboBoxAge.Focus();
            tbUsername.Focus();

            if ((signupErrors.GetError(tbUsername) != string.Empty || signupErrors.GetError(tbEmail) != string.Empty ||
                signupErrors.GetError(tbFirstname) != string.Empty || signupErrors.GetError(tbLastname) != string.Empty ||
                signupErrors.GetError(tbPhone) != string.Empty || signupErrors.GetError(tbPassword) != string.Empty ||
                signupErrors.GetError(tbPasswordVer) != string.Empty || signupErrors.GetError(tbSecurityQuestion) != string.Empty ||
                signupErrors.GetError(comboBoxSecQ) != string.Empty || signupErrors.GetError(comboBoxPronouns) != string.Empty ||
                signupErrors.GetError(comboBoxAge) != string.Empty)
                && this.DialogResult == DialogResult.OK)
                e.Cancel = true;
        }


        #region Validations
        private bool usernameCheck(string usernameToCheck)    // true - is not used | false - already used
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

            return countVal == 0 ? true : false;
        }
        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (usernameCheck(tbUsername.Text) == false)
            {
                lbInvalidUsername.Text = "Username not available.";
                signupErrors.SetError(tbUsername, "Username must be unique");
            }
            else if (tbUsername.Text == string.Empty)
            {
                lbInvalidUsername.Text = "Username cannot be blank.";
                signupErrors.SetError(tbUsername, "Username field cannot be empty");
            }
            else
            {
                lbInvalidUsername.Text = "";
                signupErrors.SetError(tbUsername, string.Empty);
            }
        }
        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
            usernameCheck(lbUsername.Text);
            string notValid = "'\"@$%^&*()!?{}[]\\/<>+=,;:~` ";
            if (notValid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
                lbInvalidUsername.Text = "Invalid character";
            }
            else
            {
                lbInvalidUsername.Text = "";
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text != tbPasswordVer.Text)
            {
                lbInvalidPassword.Text = "Passwords must match";
                signupErrors.SetError(tbPasswordVer, "Must be the same as \"Password\"");
            }
            else if (tbPassword.Text == string.Empty || tbPasswordVer.Text == string.Empty)
            {
                if (tbPassword.Text == string.Empty)
                {
                    //lbInvalidUsername.Text = "Username cannot be blank.";
                    signupErrors.SetError(tbPassword, "Password field cannot be empty");
                }
                if (tbPasswordVer.Text == string.Empty)
                {
                    signupErrors.SetError(tbPasswordVer, "Password verification field cannot be empty");
                }
            }
            else
            {
                lbInvalidPassword.Text = "";
                signupErrors.SetError(tbPasswordVer, string.Empty);
                signupErrors.SetError(tbPassword, string.Empty);
            }
        }
        private void chkbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxPassword.Checked == true)
            {
                tbPassword.PasswordChar = '\0';
                tbPasswordVer.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '●';
                tbPasswordVer.PasswordChar = '●';
            }
        }

        private void tbFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstname.Text == string.Empty)
            {
                lbInvalidFirstname.Text = "First Name cannot be blank.";
                signupErrors.SetError(tbFirstname, "First Name field cannot be empty");
            }
            else
            {
                lbInvalidFirstname.Text = "";
                signupErrors.SetError(tbFirstname, string.Empty);
            }
        }
        private void tbFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
            string notValid = "'\"@$%^&*()!?{}[]\\/<>+=,;:~`_";
            if (notValid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
                lbInvalidFirstname.Text = "Invalid character";
            }
            else
            {
                lbInvalidFirstname.Text = "";
            }
        }

        private void tbLastname_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastname.Text == string.Empty)
            {
                lbInvalidLastname.Text = "Last Name cannot be blank.";
                signupErrors.SetError(tbLastname, "Last Name field cannot be empty");
            }
            else
            {
                lbInvalidLastname.Text = "";
                signupErrors.SetError(tbLastname, string.Empty);
            }
        }
        private void tbLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
            string notValid = "'\"@$%^&*()!?{}[]\\/<>+=,;:~`_";
            if (notValid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
                lbInvalidLastname.Text = "Invalid character";
            }
            else
            {
                lbInvalidLastname.Text = "";
            }
        }

        private bool emailCheck(string emailToCheck)    // true - is not used | false - already used
        {
            long countVal;
            string query = "select count(id) from Clients where email = @email";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@email", emailToCheck);

                dbConnection.Open();
                countVal = (long)command.ExecuteScalar();  // because we return ONE value 

            }

            return countVal == 0 ? true : false;
        }
        private bool emailIsValid(string emailToCheck)
        {
            try
            {
                MailAddress m = new MailAddress(emailToCheck);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (emailCheck(tbEmail.Text) == false)
            {
                //e.Cancel = true;
                lbInvalidEmail.Text = "Email not available.";
                signupErrors.SetError(tbEmail, "Email already in use");
            }
            else if (tbEmail.Text == string.Empty)
            {
                lbInvalidEmail.Text = "Email cannot be blank.";
                signupErrors.SetError(tbEmail, "Email field cannot be empty");
            }
            else if (emailIsValid(tbEmail.Text) == false)
            {
                lbInvalidEmail.Text = "Email format not valid.";
                signupErrors.SetError(tbEmail, "Not a valid email address");
            }
            else
            {
                lbInvalidEmail.Text = "";
                signupErrors.SetError(tbEmail, string.Empty);
            }
        }
        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
            string notValid = "'\"$%^&*()!?{}[]\\/<>+=,;:~` ";
            if (notValid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
                lbInvalidEmail.Text = "Invalid character";
            }
            else
            {
               lbInvalidEmail.Text = "";
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (tbPhone.Text == string.Empty)
            {
                lbInvalidPhone.Text = "Phone Number cannot be blank.";
                signupErrors.SetError(tbPhone, "Phone Number field cannot be empty");
            }
            else if (tbPhone.Text.Length < 10)
            {
                lbInvalidPhone.Text = "Phone Number field is invalid.";
                signupErrors.SetError(tbPhone, "Phone Number needs to have 10 digits");
            }
            else
            {
                lbInvalidPhone.Text = "";
                signupErrors.SetError(tbPhone, string.Empty);
            }
        }
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);

            List<char> valid = new List<char>();
            valid.Add('\b');
            for (var i = 0; i < 10; i++)
            {
                valid.Add((char)(i + '0'));
            }

            if (!valid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
            }
            if (tbPhone.Text.Length > 9 && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tbSecurityQuestion_Validating(object sender, CancelEventArgs e)
        {
            if (tbSecurityQuestion.Text == string.Empty)
            {
                lbInvalidAnswer.Text = "Security Answer cannot be blank.";
                signupErrors.SetError(tbSecurityQuestion, "Security Answer field cannot be empty");
            }
            else
            {
                lbInvalidAnswer.Text = "";
                signupErrors.Clear();
            }
        }
        private void tbSecurityQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
            string notValid = "'\"@$%^&*()!?{}[]\\/<>+=,;:~`_";
            if (notValid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
                lbInvalidAnswer.Text = "Invalid character";
            }
            else if (tbSecurityQuestion.Text.Length > 50)
            {
                e.Handled = true;
                lbInvalidAnswer.Text = "Text too long.";
            }
            else
            {
                lbInvalidAnswer.Text = "";
            }
        }

        #region AntiSQLInjection
        private void antiSqlInjection(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
            string notValid = "'\"@$%^&*()!?{}[]\\/<>+=,;:~`";
            if (notValid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
                lbInvalidUsername.Text = "Invalid character";
            }
            else
            {
                lbInvalidUsername.Text = "";
            }
        }
        #endregion

        #endregion

        #region TextBoxSelectColorChange
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            tbEmail.BackColor = Color.LightSlateGray;
        }
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            tbEmail.BackColor = Color.SlateGray;
        }
        private void tbFirstname_Enter(object sender, EventArgs e)
        {
            tbFirstname.BackColor = Color.LightSlateGray;
        }
        private void tbFirstname_Leave(object sender, EventArgs e)
        {
            tbFirstname.BackColor = Color.SlateGray;
        }
        private void tbLastname_Enter(object sender, EventArgs e)
        {
            tbLastname.BackColor = Color.LightSlateGray;
        }
        private void tbLastname_Leave(object sender, EventArgs e)
        {
            tbLastname.BackColor = Color.SlateGray;
        }
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.LightSlateGray;
        }
        private void tbUsername_Leave(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.SlateGray;
        }
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.LightSlateGray;
        }
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.SlateGray;
        }
        private void tbPasswordVer_Enter(object sender, EventArgs e)
        {
            tbPasswordVer.BackColor = Color.LightSlateGray;
        }
        private void tbPasswordVer_Leave(object sender, EventArgs e)
        {
            tbPasswordVer.BackColor = Color.SlateGray;
        }
        private void tbPhone_Enter(object sender, EventArgs e)
        {
            tbPhone.BackColor = Color.LightSlateGray;
        }
        private void tbPhone_Leave(object sender, EventArgs e)
        {
            tbPhone.BackColor = Color.SlateGray;
        }
        private void tbSecurityQuestion_Enter(object sender, EventArgs e)
        {
            tbSecurityQuestion.BackColor = Color.LightSlateGray;

        }
        private void tbSecurityQuestion_Leave(object sender, EventArgs e)
        {
            tbSecurityQuestion.BackColor = Color.SlateGray;
        }


        #endregion

        // TESTING
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select count(id) from Clients where username = @username";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@username", "admin");


                dbConnection.Open();
                long returnedId = (long)command.ExecuteScalar();  // because we return ONE value 
                int a = 2;
            }
        }

        private void comboBoxSecQ_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxSecQ.SelectedIndex < 0)
            {
                signupErrors.SetError(comboBoxSecQ, "Please select a Security Question");
            }
            else
            {
                signupErrors.SetError(comboBoxSecQ, string.Empty);
            }
        }

        private void comboBoxPronouns_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxPronouns.SelectedIndex < 0)
            {
                signupErrors.SetError(comboBoxPronouns, "Please select a Pronoun option");
            }
            else
            {
                signupErrors.SetError(comboBoxPronouns, string.Empty);
            }
        }

        private void comboBoxAge_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxAge.SelectedIndex < 0)
            {
                signupErrors.SetError(comboBoxAge, "Please select an Age option");
            }
            else
            {
                signupErrors.SetError(comboBoxAge, string.Empty);
            }
        }
    }  
}
