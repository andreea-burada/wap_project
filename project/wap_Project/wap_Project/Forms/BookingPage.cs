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
    public partial class BookingPage : Form
    {
        #region Attributes
        protected Client _client;
        #endregion
        public BookingPage()
        {
            InitializeComponent();
        }

        public BookingPage(Client _current_client) : this()
        {
            _client = _current_client;
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
        }
    }
}
