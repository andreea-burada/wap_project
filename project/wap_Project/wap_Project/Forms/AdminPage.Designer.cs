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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRooms = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(179, 49);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(125, 87);
            this.btnAccept.TabIndex = 17;
            this.btnAccept.Text = "Display Bookings";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClients.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(48, 49);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(127, 87);
            this.btnClients.TabIndex = 16;
            this.btnClients.Text = "Display Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 200);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRooms.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(308, 50);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(125, 87);
            this.btnRooms.TabIndex = 19;
            this.btnRooms.Text = "Display Rooms";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 222);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnClients);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnRooms;
    }
}