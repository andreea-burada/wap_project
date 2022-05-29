using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using wap_Project.Entities;
using wap_Project.ViewModel;

namespace wap_Project.Forms
{
    public partial class BookingsDisplay : Form
    {
        protected List<Booking> _bookings;
        protected const string ConnectionString_Bookings = "Data Source=Databases/Bookings_Database.db";
        private readonly MainFormViewModel _viewModel;
        public BookingsDisplay()
        {
            InitializeComponent();
            _viewModel = new MainFormViewModel();
        }
        public BookingsDisplay(List<Booking> _b) : this()
        {
            _bookings = _b;
        }
        private void BookingsDisplay_Load(object sender, EventArgs e)
        {
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayBookings();
        }

        public void displayBookings()
        {
            _bookings.Sort();
            dgvBookings.Rows.Clear();
            foreach (Booking booking in _bookings)
            {
                int index = dgvBookings.Rows.Add(new object[] { booking.id, booking.client_id, booking.start_date.ToShortDateString(),
                    booking.end_date.ToShortDateString(), booking.room_id });
                dgvBookings.Rows[index].Tag = booking;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before you delete.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = "Are you sure you want to delete ";
            message += dgvBookings.SelectedRows.Count == 1 ? "1 row?" : (dgvBookings.SelectedRows.Count.ToString() + " rows?");
            if (MessageBox.Show(message, "Row Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (dgvBookings.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow booking in dgvBookings.SelectedRows)
                    {
                        _bookings.Remove((Booking)booking.Tag);
                        // removing from database as well
                        deleteBookingDB((Booking)booking.Tag);
                    }
                    displayBookings();
                }
            }

        }

        public void deleteBookingDB(Booking toDelete)
        {
            string query = "delete from Bookings where client_id = @ID";

            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString_Bookings))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@ID", toDelete.client_id.ToString());

                dbConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        // alt shortcuts
        private void BookingsDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.B)
            {
                this.menuBinary.Select();
            }
            if (e.Alt && e.KeyCode == Keys.X)
            {
                this.menuXML.Select();
            }
            if (e.Alt && e.KeyCode == Keys.T)
            {
                this.menuText.Select();
            }
        }

        private void menuBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Binary Files | *.bin";
            saveWindow.Title = "Save Bookings Report as Binary File";

            // if we click ok
            if (saveWindow.ShowDialog() == DialogResult.OK)
            {
                // we serialize the data
                BinaryFormatter binSerializer = new BinaryFormatter();
                using (FileStream outFile = File.Create(saveWindow.FileName))
                    binSerializer.Serialize(outFile, _bookings);
            }
        }

        private void menuXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "XML Files | *.xml";
            saveWindow.Title = "Save Bookings Report as XML File";

            // if we click ok
            if (saveWindow.ShowDialog() == DialogResult.OK)
            {
                // we serialize the data
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Booking>));
                using (FileStream outFile = File.Create(saveWindow.FileName))
                    xmlSerializer.Serialize(outFile, _bookings);
            }
        }

        private void menuText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Text Files | *.txt";
            saveWindow.Title = "Save Bookings Report as Text File";
            if (saveWindow.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveWindow.FileName))
                {
                    sw.WriteLine("\t\tThe Lost Paradise - Bookings Text Export\n____________________________________________________________________________________\n");
                    sw.WriteLine("List of all Bookings: \n");
                    sw.WriteLine("ID                                  \tClient_ID                           \tStart Date\tEnd Date\tRoom ID\n");

                    foreach (var booking in _bookings)
                    {
                        sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\n"
                                    , booking.id
                                    , booking.client_id
                                    , booking.start_date.ToShortDateString()
                                    , booking.end_date.ToShortDateString()
                                    , booking.room_id);
                    }
                    sw.WriteLine("\n\nThis text report was issued on " + DateTime.Now.ToShortDateString() + " at " + DateTime.Now.ToShortTimeString());
                }
            }
        }
    }
}
