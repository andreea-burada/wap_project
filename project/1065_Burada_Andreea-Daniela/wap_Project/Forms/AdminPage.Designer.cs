namespace wap_Project.Forms
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBookings.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.Location = new System.Drawing.Point(217, 61);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(125, 61);
            this.btnBookings.TabIndex = 17;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            this.btnBookings.MouseLeave += new System.EventHandler(this.btnBookings_MouseLeave);
            this.btnBookings.MouseHover += new System.EventHandler(this.btnBookings_MouseHover);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClients.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(86, 61);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(127, 61);
            this.btnClients.TabIndex = 16;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            this.btnClients.MouseLeave += new System.EventHandler(this.btnClients_MouseLeave);
            this.btnClients.MouseHover += new System.EventHandler(this.btnClients_MouseHover);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRooms.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(346, 61);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(125, 61);
            this.btnRooms.TabIndex = 19;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            this.btnRooms.MouseLeave += new System.EventHandler(this.btnRooms_MouseLeave);
            this.btnRooms.MouseHover += new System.EventHandler(this.btnRooms_MouseHover);
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.Transparent;
            this.group1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.group1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group1.ForeColor = System.Drawing.Color.White;
            this.group1.Location = new System.Drawing.Point(56, 23);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(444, 125);
            this.group1.TabIndex = 20;
            this.group1.TabStop = false;
            this.group1.Text = "Display";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(11, 159);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 29);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 195);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(553, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // AdminPage
            // 
            this.AcceptButton = this.btnLogout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 217);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.group1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}