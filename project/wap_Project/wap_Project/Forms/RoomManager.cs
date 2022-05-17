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
    public partial class RoomManager : Form
    {
        protected Room _room;
        public RoomManager()
        {
            InitializeComponent();
        }

        public RoomManager(Room _current_room) : this()
        {
            _room = _current_room;
        }
        private void RoomManager_Load(object sender, EventArgs e)
        {
            tbName.Text = _room.room_name;
            updownId.Value = _room.room_id;
            updownCapacity.Value = _room.capacity;
            tbDescription.Text = _room.description;
            tbPrice.Text = _room.price.ToString();
            tbImagePath.Text = _room.picture_name;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // if we have errors
            if ( 1 == 0 )
            {

            }
            else
            {
                _room.room_id = Int32.Parse(updownId.Value.ToString());
                _room.room_name = tbName.Text;
                _room.price = Int32.Parse(tbPrice.Text);
                _room.capacity = Int32.Parse(updownCapacity.Value.ToString());
                _room.description = tbDescription.Text;
                _room.picture_name = tbImagePath.Text;
            }
        }

        #region FieldClickChangeColor
        private void updownId_Enter(object sender, EventArgs e)
        {
            updownId.BackColor = Color.CadetBlue;
        }

        private void updownId_Leave(object sender, EventArgs e)
        {
            updownId.BackColor = Color.PowderBlue;
        }

        private void tbDescription_Enter(object sender, EventArgs e)
        {
            tbDescription.BackColor = Color.CadetBlue;
        }
        private void tbDescription_Leave(object sender, EventArgs e)
        {
            tbDescription.BackColor = Color.PowderBlue;
        }


        #endregion

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagePathWindow = new OpenFileDialog();
            imagePathWindow.Filter = "JPG Files | *.jpg";
            imagePathWindow.Title = "Open Room Image ...";

            if (imagePathWindow.ShowDialog() == DialogResult.OK)
            {
                tbImagePath.Text = imagePathWindow.FileName;
            }
        }
    }
}
