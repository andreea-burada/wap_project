using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wap_Project.Entities;

namespace wap_Project.Forms
{
    public partial class BookingPage : Form
    {
        #region Attributes
        protected Client _client;
        protected List<Room> _rooms;
        protected List<Booking> _bookings;
        private const string ConnectionString = "Data Source=Databases/Rooms_Database.db";
        private const string ConnectionString_Bookings = "Data Source=Databases/Bookings_Database.db";
        #endregion

        public BookingPage()
        {
            InitializeComponent();
            _rooms = new List<Room>();
        }

        public BookingPage(Client _current_client, List<Booking> _bookings_list) : this()
        {
            _client = _current_client;
            _bookings = _bookings_list;
            loadRoomsDB();
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            // load room names in drop down 
            foreach (Room room_drop in _rooms)
            {
                comboBoxRoom.Items.Add(room_drop.room_name);
            }

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
            menuAccountButton.Text = "Account: @" + _client.username;
            //lvAllRooms.View = View.List;
            //lvAllRooms.View = View.Tile;
            //lvAllRooms.View = View.LargeIcon;
            //lvAllRooms.View = View.SmallIcon;
            lvAllRooms.View = View.Details;
            lvAllRooms.Columns.Add("Room Name", 220);
            lvAllRooms.Columns.Add("Price", 60);
            lvAllRooms.Columns.Add("Max. No. People", 150);
            lvAllRooms.Columns.Add("Description", 1500);
            displayRooms();
        }

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

        public void displayRooms()
        {
            lvAllRooms.Items.Clear();

            foreach (Room room in _rooms)
            {
                var listViewItem = new ListViewItem(room.room_name);
                listViewItem.SubItems.Add(room.price.ToString());
                listViewItem.SubItems.Add(room.capacity.ToString());
                listViewItem.SubItems.Add(room.description.Substring(0, room.description.Length > 50 ? 50 : room.description.Length/2) + "[...]");

                ////approximate calculation of the age 
                //if ((DateTime.Now - participant.BirthDate).TotalDays / 365 >= 18)
                //    listViewItem.ImageKey = "adult.png";
                //else
                //    listViewItem.ImageKey = "child.png";
                listViewItem.ImageKey = room.picture_name;
                listViewItem.Tag = room.picture_name;
                listViewItem.Group = lvAllRooms.Groups["Hotel Rooms"];

                lvAllRooms.Items.Add(listViewItem);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            areDatesValid();
            isComboBoxValid();
            //if we have errors
            if (errorProvider.GetError(dtpEndDate) != string.Empty || errorProvider.GetError(comboBoxRoom) != string.Empty)
            {
                MessageBox.Show("Invalid Data! Please check your input data for mistakes.",
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int no_days = dtpEndDate.Value.Subtract(dtpStartDate.Value).Days;
                if (MessageBox.Show("Are you sure you want to book this vacation?\n" + 
                    "\nStart Date: " + dtpStartDate.Value.ToShortDateString() +
                    "\nEnd Date: " + dtpEndDate.Value.ToShortDateString() +
                    "\nRoom: " + comboBoxRoom.Text +
                    "\nTotal Price: " + (_rooms.Find(x => x.room_name == comboBoxRoom.Text).price * no_days).ToString() +
                    "\n(You can only book one stay per account.)",
                    "Booking Prompt",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (isClientValid() == true)
                    {
                        Booking newBooking = new Booking(_client.id, DateTime.Parse(dtpStartDate.Value.ToShortDateString()), DateTime.Parse(dtpEndDate.Value.ToShortDateString()), _rooms.Find(x => x.room_name == comboBoxRoom.Text).room_id);
                        _bookings.Add(newBooking);
                        addBookingDB(newBooking);

                        MessageBox.Show("Booking confirmed!", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Action Denied! You can only book one vacation per account!",
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    }
                    dtpStartDate.Value = DateTime.Now;
                    dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
                    comboBoxRoom.SelectedIndex = -1;
                }
            }
        }

        #region Validations
        public void areDatesValid()
        {
            int no_days = dtpEndDate.Value.Subtract(dtpStartDate.Value).Days;
            if (no_days < 1)
                errorProvider.SetError(dtpEndDate, "Start Date must be before End Date");
            else
                errorProvider.SetError(dtpEndDate, string.Empty);
        }
        private void dtpStartDate_Validating(object sender, CancelEventArgs e)
        {
            areDatesValid();
           
        }
        private void dtpEndDate_Validating(object sender, CancelEventArgs e)
        {
            areDatesValid();
        }
        private void isComboBoxValid()
        {
            if (comboBoxRoom.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBoxRoom, "Please pick a room");
            }
            else
            {
                errorProvider.SetError(comboBoxRoom, string.Empty);
            }
        }
        private void comboBoxRoom_Validating(object sender, CancelEventArgs e)
        {
            isComboBoxValid();
        }
        #endregion

        #region RoomPictureDisplay
        private void lvAllRooms_Click(object sender, EventArgs e)
        {
            if (lvAllRooms.SelectedItems.Count == 1)
            {
                string source;
                try
                {
                    source = (string)lvAllRooms.SelectedItems[0].Tag;
                    picBoxRoom.Image = Image.FromFile(source);                 
                }
                catch (FileNotFoundException fnfex)
                {
                    source = Path.Combine(Environment.CurrentDirectory, @"Images\Rooms", "error.jpg");
                    picBoxRoom.Image = Image.FromFile(source);
                }
                picBoxRoom.Refresh();

                // display description
                lbDescription.Text = _rooms.Find(x => x.picture_name == lvAllRooms.SelectedItems[0].Tag.ToString()).description;
            }
            else
            {
                lbDescription.Text = String.Empty;
            }
        }
        #endregion

        #region PriceDisplay
        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int no_days = dtpEndDate.Value.Subtract(dtpStartDate.Value).Days;
            if (comboBoxRoom.SelectedIndex >= 0 && no_days > 0)
            {
                string price = String.Empty;
                price += (_rooms.Find(x => x.room_name == comboBoxRoom.Text).price * no_days).ToString();
                price += "€ (" + no_days + " nights)";
                lbTotalPrice.Text = price;
            }
            else
            {
                lbTotalPrice.Text = String.Empty;
            }
        }

        private void dtpStartDate_CloseUp(object sender, EventArgs e)
        {
            int no_days = dtpEndDate.Value.Subtract(dtpStartDate.Value).Days;
            if (comboBoxRoom.SelectedIndex >= 0 && no_days > 0)
            {
                string price = String.Empty;
                price += (_rooms.Find(x => x.room_name == comboBoxRoom.Text).price * no_days).ToString();
                price += "€ (" + no_days + " nights)";
                lbTotalPrice.Text = price;
            }
            else
            {
                lbTotalPrice.Text = String.Empty;
            }
        }

        private void dtpEndDate_CloseUp(object sender, EventArgs e)
        {
            int no_days = dtpEndDate.Value.Subtract(dtpStartDate.Value).Days;
            if (comboBoxRoom.SelectedIndex >= 0 && no_days > 0)
            {
                string price = String.Empty;
                price += (_rooms.Find(x => x.room_name == comboBoxRoom.Text).price * no_days).ToString();
                price += "€ (" + no_days + " nights)";
                lbTotalPrice.Text = price;
            }
            else
            {
                lbTotalPrice.Text = String.Empty;
            }
        }
        #endregion


        // check if a client has a booking already or not
        private bool isClientValid()
        {
            long countVal;
            string query = "select count(id) from Bookings where client_id = @ClientID";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString_Bookings))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@ClientID", _client.id.ToString());

                dbConnection.Open();
                countVal = (long)command.ExecuteScalar();  // because we return ONE value 

            }

            return countVal == 0 ? true : false;
        }

        private void addBookingDB(Booking toAdd)
        {
            string query = "insert into Bookings(id, client_id, start_date, end_date, room_id) values " +
                "(@Id, @ClientID, @StartDate, @EndDate, @RoomID)";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString_Bookings))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@Id", toAdd.id.ToString());
                command.Parameters.AddWithValue("@ClientID", toAdd.client_id.ToString());
                command.Parameters.AddWithValue("@StartDate", toAdd.start_date.ToString());
                command.Parameters.AddWithValue("@EndDate", toAdd.end_date.ToString());
                command.Parameters.AddWithValue("@RoomID", toAdd.room_id);


                dbConnection.Open();
                command.ExecuteNonQuery();  // because we return nothing 
            }
        }

        private void menuLogoutButton_Click(object sender, EventArgs e)
        {
            btnLogout.PerformClick();
            btnLogout_Click(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }

        private void btnAllBookings_Click(object sender, EventArgs e)
        {
            if (isClientValid() == false)
            {
                Booking _myBooking = getMyBooking();
                int no_days = _myBooking.end_date.Subtract(_myBooking.start_date).Days;
                if (MessageBox.Show("You currently have one booking.\n" +
                        "\nStart Date: " + _myBooking.start_date.ToShortDateString() +
                        "\nEnd Date: " + _myBooking.end_date.ToShortDateString() +
                        "\nRoom: " + _rooms.Find(x => x.room_id == _myBooking.room_id).room_name +
                        "\nTotal Price: " + (_rooms.Find(x => x.room_id == _myBooking.room_id).price * no_days).ToString() + "€" +
                        "\n\nDo you wish to delete your current booking?",
                        "Booking View",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteBookingDB();
                    _bookings.Remove(_bookings.Find(x => x.client_id == _client.id));
                    MessageBox.Show("Booking cancelled successfully!", "Booking Cancellation", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("You currently have no vacation booked with us.", 
                        "No Booking",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
                    
        }

        private Booking getMyBooking()
        {
            Booking _myBooking = null;
            if (isClientValid() == false)
            {
                string query = "select * from Bookings where client_id = @ClientID";

                using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString_Bookings))
                {
                    var formats = new[] { "dd.MM.yyyy HH:mm:ss", "d MMM yyyy HH:mm:ss", "M/d/yyyy HH:mm:ss", "M/d/yy HH:mm:ss",
                        "MM/dd/yy HH:mm:ss", "MM/dd/yyyy HH:mm:ss", "dd-MMM-yy HH:mm:ss", "dd.MM.yy HH:mm:ss", "dd-MM-yy HH:mm:ss",
                    "dd-MMM-yy HH:mm:ss", "dd/MM/yy HH:mm:ss", "dd.MMM.yyyy HH:mm:ss", "d-M-yyyy HH:mm:ss", "d-M-yy HH:mm:ss"};
                    dbConnection.Open(); 
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    command.Parameters.AddWithValue("@ClientID", _client.id.ToString());

                    using (SQLiteDataReader reader = command.ExecuteReader())  // because we return an entire row
                    {
                        while (reader.Read())
                        {
                            Guid id = Guid.Parse((string)reader["id"]);
                            Guid client_id = Guid.Parse((string)reader["client_id"]);
                            DateTime start_date = DateTime.Now;
                            DateTime.TryParseExact((string)reader["start_date"], formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out start_date);
                            DateTime end_date = DateTime.Now;
                            DateTime.TryParseExact((string)reader["end_date"], formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out end_date);
                            int room_id = Int32.Parse(reader["room_id"].ToString());

                            _myBooking = new Booking(client_id, start_date, end_date, room_id);
                        }
                    }
                }
            }
            return _myBooking;
        }

        private void deleteBookingDB()
        {
            string query = "delete from Bookings where client_id = @ClientID";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString_Bookings))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@ClientID", _client.id.ToString());

                dbConnection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
