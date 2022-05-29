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
    public partial class RoomManager : Form
    {
        protected Room _room;
        private const string ConnectionString = "Data Source=Databases/Rooms_Database.db";
        bool isNew;
        public RoomManager()
        {
            InitializeComponent();
        }

        public RoomManager(Room _current_room, bool check) : this()
        {
            _room = _current_room;
            isNew = check;
        }
        private void RoomManager_Load(object sender, EventArgs e)
        {
            tbName.Text = _room.room_name;
            updownId.Value = _room.room_id;
            updownCapacity.Value = _room.capacity;
            tbDescription.Text = _room.description;
            tbPrice.Text = _room.price.ToString();
            //tbImagePath.Text = _room.picture_name;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            validateID();
            validateCapacity();
            validateName();
            validatePrice();
            // if we have errors
            if ( errorProvider.GetError(updownId) != string.Empty || errorProvider.GetError(updownCapacity) != string.Empty || 
                errorProvider.GetError(tbName) != string.Empty || errorProvider.GetError(tbPrice) != string.Empty)
            {
                MessageBox.Show("Invalid Action! You have input errors. Please check your data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _room.room_id = Int32.Parse(updownId.Value.ToString());
                _room.room_name = tbName.Text;
                _room.price = Int32.Parse(tbPrice.Text);
                _room.capacity = Int32.Parse(updownCapacity.Value.ToString());
                _room.description = tbDescription.Text;
                string path = Path.Combine(Environment.CurrentDirectory, @"Images\Rooms", _room.room_name + ".jpg");
                _room.picture_name = path;
                if (isNew == true)
                    addRoomDB(_room);
                else
                    updateRoomDB(_room);
            }
        }
        private void RoomManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((errorProvider.GetError(updownId) != string.Empty || errorProvider.GetError(updownCapacity) != string.Empty ||
                errorProvider.GetError(tbName) != string.Empty || errorProvider.GetError(tbPrice) != string.Empty)
                && this.DialogResult == DialogResult.OK)
            e.Cancel = true;
        }

        #region Validations
        private void validateID()
        {
            if (isIDValid() == false)
            {
                errorProvider.SetError(updownId, "Room ID must be unique");
            }
            else
            {
                errorProvider.SetError(updownId, string.Empty);
            }
        }
        private bool isIDValid()
        {
            long countVal;
            string query = "select count(name) from Rooms where id = @roomID";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@roomID", updownId.Value);

                dbConnection.Open();
                countVal = (long)command.ExecuteScalar();  // because we return ONE value 

            }

            return countVal == 0 ? true : false;
        }
        private void updownId_Validating(object sender, CancelEventArgs e)
        {
            validateID();
        }

        private void validateCapacity()
        {
            if (updownCapacity.Value < 1)
            {
                errorProvider.SetError(updownCapacity, "Capacity value cannot be 0");
            }
            else
            {
                errorProvider.SetError(updownCapacity, string.Empty);
            }
        }
        private void updownCapacity_Validating(object sender, CancelEventArgs e)
        {
            validateCapacity();
        }

        private void validateName()
        {
            if (tbName.Text == string.Empty)
            {
                errorProvider.SetError(tbName, "Name field cannot be blank");
            }
            else
            {
                errorProvider.SetError(tbName, string.Empty);
            }
        }
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            validateName();
        }

        private void validatePrice()
        {
            if (tbPrice.Text == string.Empty)
            {
                errorProvider.SetError(tbPrice, "Price field cannot be empty");
            }
            else if (tbPrice.Text == "0")
            {
                errorProvider.SetError(tbPrice, "Price cannot be 0");
            }
            else
            {
                errorProvider.SetError(tbPrice, string.Empty);
            }
        }
        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            validatePrice();
        }
        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            if (tbPrice.Text.Length > 5 && e.KeyChar != '\b')
                e.Handled = true;
        }
        #endregion

        private void addRoomDB(Room toAdd)
        {
            string query = "insert into Rooms(id, name, capacity, description, picture_name, price) values " +
                "(@room_id, @room_name, @room_cap, @room_desc, @room_pic, @room_price)";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@room_id", toAdd.room_id);
                command.Parameters.AddWithValue("@room_name", toAdd.room_name);
                command.Parameters.AddWithValue("@room_cap", toAdd.capacity);
                command.Parameters.AddWithValue("@room_desc", toAdd.description);
                command.Parameters.AddWithValue("@room_pic", toAdd.picture_name);
                command.Parameters.AddWithValue("@room_price", toAdd.price);

                dbConnection.Open();
                command.ExecuteNonQuery();
            }

        }

        private void updateRoomDB(Room toAdd)
        {
            string query = "update Rooms set name = @room_name, capacity = @room_cap, description = @room_desc, picture_name = @room_pic, price = @room_price " +
                "where id = @room_id";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@room_id", toAdd.room_id);
                command.Parameters.AddWithValue("@room_name", toAdd.room_name);
                command.Parameters.AddWithValue("@room_cap", toAdd.capacity);
                command.Parameters.AddWithValue("@room_desc", toAdd.description);
                command.Parameters.AddWithValue("@room_pic", toAdd.picture_name);
                command.Parameters.AddWithValue("@room_price", toAdd.price);

                dbConnection.Open();
                command.ExecuteNonQuery();
            }

        }

        #region FieldClickChangeColor
        private void updownId_Enter(object sender, EventArgs e)
        {
            updownId.BackColor = Color.DarkCyan;
        }
        private void updownId_Leave(object sender, EventArgs e)
        {
            updownId.BackColor = Color.CadetBlue;
        }
        private void tbDescription_Enter(object sender, EventArgs e)
        {
            tbDescription.BackColor = Color.DarkCyan;
        }
        private void tbDescription_Leave(object sender, EventArgs e)
        {
            tbDescription.BackColor = Color.CadetBlue;
        }
        private void updownCapacity_Enter(object sender, EventArgs e)
        {
            updownCapacity.BackColor = Color.DarkCyan;
        }
        private void updownCapacity_Leave(object sender, EventArgs e)
        {
            updownCapacity.BackColor = Color.CadetBlue;
        }
        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.BackColor = Color.DarkCyan;
        }
        private void tbName_Leave(object sender, EventArgs e)
        {
            tbName.BackColor = Color.CadetBlue;
        }
        private void tbPrice_Enter(object sender, EventArgs e)
        {
            tbPrice.BackColor = Color.DarkCyan;
        }
        private void tbPrice_Leave(object sender, EventArgs e)
        {
            tbPrice.BackColor = Color.CadetBlue;
        }




        #endregion

        
    }
}
