namespace CollegeMS
{
    partial class UserControlStudents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsearchStu = new System.Windows.Forms.Button();
            this.txtsearchStu = new System.Windows.Forms.TextBox();
            this.dataGridViewStu = new System.Windows.Forms.DataGridView();
            this.pnXoaSuaStu = new System.Windows.Forms.Panel();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStu = new System.Windows.Forms.DateTimePicker();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.pictureBoxStu = new System.Windows.Forms.PictureBox();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).BeginInit();
            this.pnXoaSuaStu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearchStu
            // 
            this.btnsearchStu.BackColor = System.Drawing.Color.White;
            this.btnsearchStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchStu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsearchStu.Location = new System.Drawing.Point(636, 24);
            this.btnsearchStu.Name = "btnsearchStu";
            this.btnsearchStu.Size = new System.Drawing.Size(68, 31);
            this.btnsearchStu.TabIndex = 7;
            this.btnsearchStu.Text = "TÌM";
            this.btnsearchStu.UseVisualStyleBackColor = false;
            this.btnsearchStu.Click += new System.EventHandler(this.btnsearchStu_Click_1);
            // 
            // txtsearchStu
            // 
            this.txtsearchStu.Location = new System.Drawing.Point(307, 30);
            this.txtsearchStu.Name = "txtsearchStu";
            this.txtsearchStu.Size = new System.Drawing.Size(294, 20);
            this.txtsearchStu.TabIndex = 6;
            // 
            // dataGridViewStu
            // 
            this.dataGridViewStu.AllowUserToAddRows = false;
            this.dataGridViewStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStu.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewStu.EnableHeadersVisualStyles = false;
            this.dataGridViewStu.Location = new System.Drawing.Point(20, 331);
            this.dataGridViewStu.Name = "dataGridViewStu";
            this.dataGridViewStu.RowHeadersWidth = 62;
            this.dataGridViewStu.Size = new System.Drawing.Size(958, 250);
            this.dataGridViewStu.TabIndex = 8;
            this.dataGridViewStu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStu_CellContentClick);
            // 
            // pnXoaSuaStu
            // 
            this.pnXoaSuaStu.Controls.Add(this.btHuy);
            this.pnXoaSuaStu.Controls.Add(this.btXoa);
            this.pnXoaSuaStu.Controls.Add(this.btSua);
            this.pnXoaSuaStu.Controls.Add(this.pictureBoxStu);
            this.pnXoaSuaStu.Controls.Add(this.btThem);
            this.pnXoaSuaStu.Controls.Add(this.txtPic);
            this.pnXoaSuaStu.Controls.Add(this.txtDiachi);
            this.pnXoaSuaStu.Controls.Add(this.txtEmail);
            this.pnXoaSuaStu.Controls.Add(this.txtsdt);
            this.pnXoaSuaStu.Controls.Add(this.txthoten);
            this.pnXoaSuaStu.Controls.Add(this.label8);
            this.pnXoaSuaStu.Controls.Add(this.dtpStu);
            this.pnXoaSuaStu.Controls.Add(this.cbgioitinh);
            this.pnXoaSuaStu.Controls.Add(this.label7);
            this.pnXoaSuaStu.Controls.Add(this.label6);
            this.pnXoaSuaStu.Controls.Add(this.label5);
            this.pnXoaSuaStu.Controls.Add(this.label4);
            this.pnXoaSuaStu.Controls.Add(this.label3);
            this.pnXoaSuaStu.Controls.Add(this.label2);
            this.pnXoaSuaStu.Location = new System.Drawing.Point(3, 68);
            this.pnXoaSuaStu.Name = "pnXoaSuaStu";
            this.pnXoaSuaStu.Size = new System.Drawing.Size(1061, 248);
            this.pnXoaSuaStu.TabIndex = 9;
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(523, 108);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(237, 20);
            this.txtPic.TabIndex = 34;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(523, 64);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(237, 20);
            this.txtDiachi.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(118, 111);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(237, 20);
            this.txtsdt.TabIndex = 27;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(118, 22);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(237, 20);
            this.txthoten.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "picturePath:";
            // 
            // dtpStu
            // 
            this.dtpStu.Location = new System.Drawing.Point(523, 22);
            this.dtpStu.Name = "dtpStu";
            this.dtpStu.Size = new System.Drawing.Size(237, 20);
            this.dtpStu.TabIndex = 32;
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.DisplayMember = "nam";
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(117, 67);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(65, 21);
            this.cbgioitinh.TabIndex = 31;
            this.cbgioitinh.SelectedIndexChanged += new System.EventHandler(this.cbgioitinh_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày sinh: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Họ và tên:";
            // 
            // btHuy
            // 
            this.btHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Image = global::CollegeMS.Properties.Resources.Erase;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuy.Location = new System.Drawing.Point(626, 204);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(86, 41);
            this.btHuy.TabIndex = 38;
            this.btHuy.Text = "  Hủy";
            this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXoa.BackColor = System.Drawing.Color.Red;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Image = global::CollegeMS.Properties.Resources.Trash;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.Location = new System.Drawing.Point(508, 204);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 41);
            this.btXoa.TabIndex = 37;
            this.btXoa.Text = "   Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btSua
            // 
            this.btSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Image = global::CollegeMS.Properties.Resources.Edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.Location = new System.Drawing.Point(387, 204);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(87, 41);
            this.btSua.TabIndex = 36;
            this.btSua.Text = "Cập nhật";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // pictureBoxStu
            // 
            this.pictureBoxStu.Location = new System.Drawing.Point(831, 22);
            this.pictureBoxStu.Name = "pictureBoxStu";
            this.pictureBoxStu.Size = new System.Drawing.Size(177, 147);
            this.pictureBoxStu.TabIndex = 35;
            this.pictureBoxStu.TabStop = false;
            // 
            // btThem
            // 
            this.btThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Image = global::CollegeMS.Properties.Resources.Add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.Location = new System.Drawing.Point(266, 204);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 41);
            this.btThem.TabIndex = 10;
            this.btThem.Text = " Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnXoaSuaStu);
            this.Controls.Add(this.dataGridViewStu);
            this.Controls.Add(this.btnsearchStu);
            this.Controls.Add(this.txtsearchStu);
            this.Name = "UserControlStudents";
            this.Size = new System.Drawing.Size(1064, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).EndInit();
            this.pnXoaSuaStu.ResumeLayout(false);
            this.pnXoaSuaStu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsearchStu;
        private System.Windows.Forms.TextBox txtsearchStu;
        private System.Windows.Forms.DataGridView dataGridViewStu;
        private System.Windows.Forms.Panel pnXoaSuaStu;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.DateTimePicker dtpStu;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxStu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btHuy;
    }
}
