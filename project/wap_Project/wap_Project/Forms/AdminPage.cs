using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wap_Project.Forms
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomDisplay roomDisplay = new RoomDisplay();
            roomDisplay.ShowDialog();
        }
    }
}
