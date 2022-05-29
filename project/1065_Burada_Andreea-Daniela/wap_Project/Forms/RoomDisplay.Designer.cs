namespace wap_Project.Forms
{
    partial class RoomDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDisplay));
            this.lbAddEditRoom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddEditRoom
            // 
            this.lbAddEditRoom.AutoSize = true;
            this.lbAddEditRoom.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditRoom.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbAddEditRoom.Location = new System.Drawing.Point(44, 28);
            this.lbAddEditRoom.Name = "lbAddEditRoom";
            this.lbAddEditRoom.Size = new System.Drawing.Size(160, 36);
            this.lbAddEditRoom.TabIndex = 6;
            this.lbAddEditRoom.Text = "Rooms List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.dgvRooms);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAddEdit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(-2, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 563);
            this.panel1.TabIndex = 5;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToOrderColumns = true;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.capacity,
            this.description,
            this.pic_name});
            this.dgvRooms.Location = new System.Drawing.Point(19, 17);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(868, 446);
            this.dgvRooms.TabIndex = 39;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 25;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 75;
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 50;
            this.price.Name = "price";
            this.price.Width = 50;
            // 
            // capacity
            // 
            this.capacity.HeaderText = "Max No Pers.";
            this.capacity.MinimumWidth = 85;
            this.capacity.Name = "capacity";
            this.capacity.Width = 95;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 150;
            this.description.Name = "description";
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.description.Width = 350;
            // 
            // pic_name
            // 
            this.pic_name.HeaderText = "Image Path";
            this.pic_name.MinimumWidth = 120;
            this.pic_name.Name = "pic_name";
            this.pic_name.Width = 180;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(574, 468);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 42);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete Room";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.Location = new System.Drawing.Point(713, 468);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(174, 42);
            this.btnAddEdit.TabIndex = 15;
            this.btnAddEdit.Text = "Add/Edit Room";
            this.btnAddEdit.UseVisualStyleBackColor = false;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
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
            // RoomDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 628);
            this.Controls.Add(this.lbAddEditRoom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Display Rooms";
            this.Load += new System.EventHandler(this.RoomDisplay_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddEditRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn pic_name;
    }
}