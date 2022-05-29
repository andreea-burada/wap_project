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
    public partial class ClientsDisplay : Form
    {
        protected List<Client> _clients;
        private const string ConnectionString = "Data Source=Databases/Client_Database.db";
        public ClientsDisplay()
        {
            InitializeComponent();
            _clients = new List<Client>();
        }

        private void ClientsDisplay_Load(object sender, EventArgs e)
        {
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadClientsDB();
            displayClients();
        }

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

        private void displayClients()
        {
            _clients.Sort();
            dgvClients.Rows.Clear();
            foreach (Client client in _clients)
            {
                int index = dgvClients.Rows.Add(new object[] { client.id, client.last_name, client.first_name, client.password, client.username, client.email,
                client.age, "0" + client.phone_number.ToString(), client.security_question.questionId, client.security_question.question_answer});
                dgvClients.Rows[index].Tag = client;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before you delete.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = "Are you sure you want to delete ";
            message += dgvClients.SelectedRows.Count == 1 ? "1 row?" : (dgvClients.SelectedRows.Count.ToString() + " rows?");
            if (MessageBox.Show(message, "Row Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (dgvClients.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow client in dgvClients.SelectedRows)
                    {
                        _clients.Remove((Client)client.Tag);
                        // removing from database as well
                        deleteClientDB((Client)client.Tag);
                    }
                    displayClients();
                }
            }
        }

        private void deleteClientDB(Client toDelete)
        {
            string query = "delete from Clients where id = @ID";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@ID", toDelete.id.ToString());

                dbConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before you try to edit it.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dgvClients.SelectedRows.Count > 1)
            {
                MessageBox.Show("You cannot edit multiple accounts at once", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvClients.SelectedRows.Count > 0)
            {
                // delete from db first then reinsert
                deleteClientDB((Client)dgvClients.SelectedRows[0].Tag);
                SignupForm editWindow = new SignupForm((Client)dgvClients.SelectedRows[0].Tag, _clients);
                if(editWindow.ShowDialog() == DialogResult.Cancel)
                {
                    // we re-add the client
                    addClientDB((Client)dgvClients.SelectedRows[0].Tag);
                    _clients.Add((Client)dgvClients.SelectedRows[0].Tag);
                }
                displayClients();
            }
            
        }
        private void addClientDB(Client clientToAdd)
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
    }
}
