namespace wap_Project.Forms
{
    partial class BookingsDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingsDisplay));
            this.lbAddEditBooking = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuText = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAddEditBooking
            // 
            this.lbAddEditBooking.AutoSize = true;
            this.lbAddEditBooking.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditBooking.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbAddEditBooking.Location = new System.Drawing.Point(46, 45);
            this.lbAddEditBooking.Name = "lbAddEditBooking";
            this.lbAddEditBooking.Size = new System.Drawing.Size(193, 36);
            this.lbAddEditBooking.TabIndex = 8;
            this.lbAddEditBooking.Text = "Bookings List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.dgvBookings);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 533);
            this.panel1.TabIndex = 7;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToOrderColumns = true;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.clientId,
            this.start_date,
            this.end_date,
            this.room_id});
            this.dgvBookings.Location = new System.Drawing.Point(19, 17);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBookings.Size = new System.Drawing.Size(878, 446);
            this.dgvBookings.TabIndex = 39;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 150;
            this.id.Name = "id";
            this.id.Width = 200;
            // 
            // clientId
            // 
            this.clientId.HeaderText = "Client ID";
            this.clientId.MinimumWidth = 150;
            this.clientId.Name = "clientId";
            this.clientId.Width = 200;
            // 
            // start_date
            // 
            this.start_date.HeaderText = "Start Date";
            this.start_date.MinimumWidth = 150;
            this.start_date.Name = "start_date";
            this.start_date.Width = 180;
            // 
            // end_date
            // 
            this.end_date.HeaderText = "End Date";
            this.end_date.MinimumWidth = 150;
            this.end_date.Name = "end_date";
            this.end_date.Width = 180;
            // 
            // room_id
            // 
            this.room_id.HeaderText = "Room ID";
            this.room_id.MinimumWidth = 50;
            this.room_id.Name = "room_id";
            this.room_id.Width = 75;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(731, 468);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 42);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete Booking";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(19, 468);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBinary,
            this.menuXML,
            this.menuText});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(912, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuBinary
            // 
            this.menuBinary.Name = "menuBinary";
            this.menuBinary.Size = new System.Drawing.Size(89, 20);
            this.menuBinary.Text = "&Binary Export";
            this.menuBinary.Click += new System.EventHandler(this.menuBinary_Click);
            // 
            // menuXML
            // 
            this.menuXML.Name = "menuXML";
            this.menuXML.Size = new System.Drawing.Size(80, 20);
            this.menuXML.Text = "&XML Export";
            this.menuXML.Click += new System.EventHandler(this.menuXML_Click);
            // 
            // menuText
            // 
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(77, 20);
            this.menuText.Text = "&Text Export";
            this.menuText.Click += new System.EventHandler(this.menuText_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "ALT Shortcuts Available. Try Alt+B; Alt+X; Alt+T";
            // 
            // BookingsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddEditBooking);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "BookingsDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Display Bookings";
            this.Load += new System.EventHandler(this.BookingsDisplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookingsDisplay_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddEditBooking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuBinary;
        private System.Windows.Forms.ToolStripMenuItem menuXML;
        private System.Windows.Forms.ToolStripMenuItem menuText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
    }
}