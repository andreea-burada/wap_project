using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wap_Project.Entities;

namespace wap_Project.Forms
{
    public partial class AdminPage : Form
    {
        protected List<Room> _rooms;
        public List<Booking> _bookings;
        private const string ConnectionString = "Data Source=Databases/Rooms_Database.db";
        public AdminPage()
        {
            InitializeComponent();
            _rooms = new List<Room>();
        }

        public AdminPage(List<Booking> _b) : this()
        {
            _bookings = _b;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            loadRoomsDB();
        }

        // load from db
        public void loadRoomsDB()
        {
            const string query = "select * from Rooms";

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

                        int id = Int32.Parse(reader["id"].ToString());
                        string name = (string)reader["name"];            
                        int capacity = Int32.Parse(reader["capacity"].ToString());
                        string description = (string)reader["description"];
                        string pic_name = (string)reader["picture_name"];
                        int price = Int32.Parse(reader["price"].ToString()); 

                        Room _newRoom = new Room(id, name, capacity, description, pic_name, price);
                        string path = Path.Combine(Environment.CurrentDirectory, @"Images\Rooms", _newRoom.room_name + ".jpg");
                        _newRoom.picture_name = path;

                        _rooms.Add(_newRoom);
                    }
                }

                // we update the image paths with relative paths to the project
                foreach (Room room in _rooms)
                {
                    string update_query = "update Rooms set picture_name = @path where id = @room_id";
                    SQLiteCommand update_command = new SQLiteCommand(update_query, connection);
                    update_command.Parameters.AddWithValue("@path", room.picture_name);
                    update_command.Parameters.AddWithValue("@room_id", room.room_id);

                    update_command.ExecuteNonQuery();
                }
            }
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomDisplay roomDisplay = new RoomDisplay(_rooms);
            this.Hide();
            roomDisplay.ShowDialog();
            this.Show();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingsDisplay bookingsDisplay = new BookingsDisplay(_bookings);
            this.Hide();
            bookingsDisplay.ShowDialog();
            this.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsDisplay clientsDisplay = new ClientsDisplay();
            this.Hide();
            clientsDisplay.ShowDialog();
            this.Show();
        }

        private void btnRooms_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Display all rooms. Available features: ADD; EDIT; DELETE";
        }

        private void btnRooms_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
        }

        private void btnBookings_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Display all bookings. Available features: DELETE";
        }

        private void btnBookings_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
        }

        private void btnClients_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Display all client accounts. Available features: EDIT; DELETE";
        }

        private void btnClients_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
        }

       
    }
}
