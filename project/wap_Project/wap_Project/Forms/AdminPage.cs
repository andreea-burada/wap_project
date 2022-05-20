using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public AdminPage()
        {
            InitializeComponent();
            _rooms = new List<Room>();
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            loadRoomsDB();
        }

        // load from db
        public void loadRoomsDB()
        { }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomDisplay roomDisplay = new RoomDisplay(_rooms);
            roomDisplay.ShowDialog();
        }

        
    }
}
