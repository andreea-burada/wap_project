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
    public partial class RoomDisplay : Form
    {
        protected List<Room> _rooms;
        private const string ConnectionString = "Data Source=Databases/Rooms_Database.db";
        public RoomDisplay()
        {
            InitializeComponent();
        }

        public RoomDisplay(List<Room> _current_rooms) : this()
        {
            _rooms = _current_rooms;
        }

        private void RoomDisplay_Load(object sender, EventArgs e)
        {
            displayRooms();
        }

        public void displayRooms()
        {
            _rooms.Sort();
            dgvRooms.Rows.Clear();
            foreach(Room toDisplay in _rooms)
            {
                int index = dgvRooms.Rows.Add(new object[] { toDisplay.room_id, toDisplay.room_name, toDisplay.price, 
                    toDisplay.capacity, toDisplay.description, toDisplay.picture_name });
                dgvRooms.Rows[index].Tag = toDisplay;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            bool isNew = true;
            Room toAddEdit = new Room(0, string.Empty, 0, "", "", 0);
            if (dgvRooms.SelectedRows.Count == 1)
            {
                toAddEdit = dgvRooms.SelectedRows[0].Tag as Room;
                isNew = false;
            }
            if (dgvRooms.SelectedRows.Count > 1)
            {
                MessageBox.Show("You cannot edit multiple rows at the same time.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RoomManager roomFormWindow = new RoomManager(toAddEdit, isNew);
            this.Hide();
            if (roomFormWindow.ShowDialog() == DialogResult.OK)
            {
                if (isNew == true)
                    _rooms.Add(toAddEdit);
                displayRooms();
            }
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before you delete.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = "Are you sure you want to delete ";
            message += dgvRooms.SelectedRows.Count == 1 ? "1 row?" : (dgvRooms.SelectedRows.Count.ToString() + " rows?");

            if (dgvRooms.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow room in dgvRooms.SelectedRows)
                {
                    _rooms.Remove((Room)room.Tag);
                    // removing from database as well
                    deleteRoomDB((Room)room.Tag);
                }
                displayRooms();
            }

        }

        public void deleteRoomDB(Room toDelete)
        {
            string query = "delete from Rooms where id = @room_id";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@room_id", toDelete.room_id);

                dbConnection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
