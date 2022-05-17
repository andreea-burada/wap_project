namespace wap_Project.Forms
{
    partial class RoomManager
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.updownId = new System.Windows.Forms.NumericUpDown();
            this.updownCapacity = new System.Windows.Forms.NumericUpDown();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbAddEditRoom = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.PowderBlue;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(58, 143);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(706, 20);
            this.tbName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnImageBrowse);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tbImagePath);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.updownCapacity);
            this.panel1.Controls.Add(this.updownId);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(-2, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 498);
            this.panel1.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.PowderBlue;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.Color.White;
            this.tbDescription.Location = new System.Drawing.Point(58, 274);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(706, 145);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Enter += new System.EventHandler(this.tbDescription_Enter);
            this.tbDescription.Leave += new System.EventHandler(this.tbDescription_Leave);
            // 
            // updownId
            // 
            this.updownId.BackColor = System.Drawing.Color.PowderBlue;
            this.updownId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updownId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownId.ForeColor = System.Drawing.Color.White;
            this.updownId.Location = new System.Drawing.Point(58, 76);
            this.updownId.Name = "updownId";
            this.updownId.Size = new System.Drawing.Size(290, 19);
            this.updownId.TabIndex = 4;
            this.updownId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownId.Enter += new System.EventHandler(this.updownId_Enter);
            this.updownId.Leave += new System.EventHandler(this.updownId_Leave);
            // 
            // updownCapacity
            // 
            this.updownCapacity.BackColor = System.Drawing.Color.PowderBlue;
            this.updownCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updownCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownCapacity.ForeColor = System.Drawing.Color.White;
            this.updownCapacity.Location = new System.Drawing.Point(481, 76);
            this.updownCapacity.Name = "updownCapacity";
            this.updownCapacity.Size = new System.Drawing.Size(290, 19);
            this.updownCapacity.TabIndex = 5;
            this.updownCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.PowderBlue;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.Location = new System.Drawing.Point(481, 209);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(283, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // lbAddEditRoom
            // 
            this.lbAddEditRoom.AutoSize = true;
            this.lbAddEditRoom.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditRoom.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbAddEditRoom.Location = new System.Drawing.Point(50, 22);
            this.lbAddEditRoom.Name = "lbAddEditRoom";
            this.lbAddEditRoom.Size = new System.Drawing.Size(227, 36);
            this.lbAddEditRoom.TabIndex = 4;
            this.lbAddEditRoom.Text = "Add/Edit Room";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(58, 423);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(680, 423);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 42);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(58, 93);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 2);
            this.panel7.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(481, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 2);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(58, 161);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 2);
            this.panel3.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(58, 417);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(706, 2);
            this.panel5.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Room ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(477, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Room Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(477, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Room Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CadetBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Room Description";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(481, 227);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 2);
            this.panel4.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(58, 227);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 2);
            this.panel6.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Room Image File";
            // 
            // tbImagePath
            // 
            this.tbImagePath.BackColor = System.Drawing.Color.PowderBlue;
            this.tbImagePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbImagePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbImagePath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImagePath.ForeColor = System.Drawing.Color.White;
            this.tbImagePath.Location = new System.Drawing.Point(58, 209);
            this.tbImagePath.Margin = new System.Windows.Forms.Padding(2);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.ReadOnly = true;
            this.tbImagePath.Size = new System.Drawing.Size(228, 20);
            this.tbImagePath.TabIndex = 34;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImageBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImageBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImageBrowse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageBrowse.Location = new System.Drawing.Point(284, 206);
            this.btnImageBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(64, 21);
            this.btnImageBrowse.TabIndex = 37;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = false;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // RoomManager
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(825, 575);
            this.Controls.Add(this.lbAddEditRoom);
            this.Controls.Add(this.panel1);
            this.Name = "RoomManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomManager";
            this.Load += new System.EventHandler(this.RoomManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.NumericUpDown updownCapacity;
        private System.Windows.Forms.NumericUpDown updownId;
        private System.Windows.Forms.Label lbAddEditRoom;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbImagePath;
    }
}