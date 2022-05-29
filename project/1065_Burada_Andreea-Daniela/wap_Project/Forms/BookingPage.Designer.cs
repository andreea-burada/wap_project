namespace wap_Project.Forms
{
    partial class BookingPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingPage));
            this.lvAllRooms = new System.Windows.Forms.ListView();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnAllBookings = new System.Windows.Forms.Button();
            this.picBoxRoom = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuAccountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelBackground.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAllRooms
            // 
            this.lvAllRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAllRooms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAllRooms.FullRowSelect = true;
            this.lvAllRooms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAllRooms.HideSelection = false;
            this.lvAllRooms.Location = new System.Drawing.Point(27, 185);
            this.lvAllRooms.MultiSelect = false;
            this.lvAllRooms.Name = "lvAllRooms";
            this.lvAllRooms.Size = new System.Drawing.Size(886, 236);
            this.lvAllRooms.TabIndex = 0;
            this.lvAllRooms.UseCompatibleStateImageBehavior = false;
            this.lvAllRooms.Click += new System.EventHandler(this.lvAllRooms_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarTitleBackColor = System.Drawing.Color.PowderBlue;
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.CadetBlue;
            this.dtpStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(940, 214);
            this.dtpStartDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2022, 5, 21, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(129, 27);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.Value = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            this.dtpStartDate.CloseUp += new System.EventHandler(this.dtpStartDate_CloseUp);
            this.dtpStartDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpStartDate_Validating);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarTitleBackColor = System.Drawing.Color.PowderBlue;
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.Color.CadetBlue;
            this.dtpEndDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(1117, 214);
            this.dtpEndDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(2022, 5, 21, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(129, 27);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.CloseUp += new System.EventHandler(this.dtpEndDate_CloseUp);
            this.dtpEndDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEndDate_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 30);
            this.panel1.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogout.Location = new System.Drawing.Point(582, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "button1";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(940, 301);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(306, 28);
            this.comboBoxRoom.TabIndex = 5;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            this.comboBoxRoom.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxRoom_Validating);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(940, 389);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(306, 28);
            this.lbTotalPrice.TabIndex = 6;
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(1112, 766);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(134, 56);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "BOOK NOW";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnAllBookings
            // 
            this.btnAllBookings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBookings.Location = new System.Drawing.Point(969, 766);
            this.btnAllBookings.Name = "btnAllBookings";
            this.btnAllBookings.Size = new System.Drawing.Size(137, 56);
            this.btnAllBookings.TabIndex = 8;
            this.btnAllBookings.Text = "See my booking";
            this.btnAllBookings.UseVisualStyleBackColor = true;
            this.btnAllBookings.Click += new System.EventHandler(this.btnAllBookings_Click);
            // 
            // picBoxRoom
            // 
            this.picBoxRoom.BackColor = System.Drawing.Color.White;
            this.picBoxRoom.Location = new System.Drawing.Point(928, 275);
            this.picBoxRoom.Name = "picBoxRoom";
            this.picBoxRoom.Size = new System.Drawing.Size(306, 212);
            this.picBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRoom.TabIndex = 9;
            this.picBoxRoom.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(27, 39);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(120, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book Your Dream Vacation";
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.label7);
            this.panelBackground.Controls.Add(this.panel5);
            this.panelBackground.Controls.Add(this.label6);
            this.panelBackground.Controls.Add(this.picBoxRoom);
            this.panelBackground.Controls.Add(this.lbDescription);
            this.panelBackground.Controls.Add(this.label5);
            this.panelBackground.Controls.Add(this.label4);
            this.panelBackground.Controls.Add(this.label3);
            this.panelBackground.Controls.Add(this.label2);
            this.panelBackground.Controls.Add(this.panel4);
            this.panelBackground.Controls.Add(this.panel3);
            this.panelBackground.Controls.Add(this.panel2);
            this.panelBackground.Location = new System.Drawing.Point(12, 176);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1249, 509);
            this.panelBackground.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(12, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(889, 44);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bookings are permanent unless cancelled. Once you submit a booking request, you c" +
    "annot edit the details. Please be careful when you input your data.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Location = new System.Drawing.Point(16, 407);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(889, 2);
            this.panel5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Description:";
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(12, 275);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(889, 130);
            this.lbDescription.TabIndex = 18;
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(928, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(924, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pick a Room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(1101, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(928, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Location = new System.Drawing.Point(928, 243);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 2);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Location = new System.Drawing.Point(928, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 2);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Location = new System.Drawing.Point(928, 153);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 2);
            this.panel2.TabIndex = 12;
            // 
            // menuAccountButton
            // 
            this.menuAccountButton.BackColor = System.Drawing.Color.White;
            this.menuAccountButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogoutButton});
            this.menuAccountButton.Name = "menuAccountButton";
            this.menuAccountButton.Size = new System.Drawing.Size(149, 26);
            this.menuAccountButton.Text = "Account: @account";
            // 
            // menuLogoutButton
            // 
            this.menuLogoutButton.Name = "menuLogoutButton";
            this.menuLogoutButton.Size = new System.Drawing.Size(128, 22);
            this.menuLogoutButton.Text = "Log Out";
            this.menuLogoutButton.Click += new System.EventHandler(this.menuLogoutButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccountButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1273, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // BookingPage
            // 
            this.AcceptButton = this.btnLogout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 834);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnAllBookings);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvAllRooms);
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BookingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Make a Booking";
            this.Load += new System.EventHandler(this.BookingPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAllRooms;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAllBookings;
        private System.Windows.Forms.PictureBox picBoxRoom;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem menuAccountButton;
        private System.Windows.Forms.ToolStripMenuItem menuLogoutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}