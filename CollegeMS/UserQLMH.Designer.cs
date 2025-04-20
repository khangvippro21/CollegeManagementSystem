namespace CollegeMS
{
    partial class UserControlQLMH
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
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.btThemMH = new System.Windows.Forms.Button();
            this.z = new System.Windows.Forms.Label();
            this.btSuaMH = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMaMH = new System.Windows.Forms.TextBox();
            this.tbTenMH = new System.Windows.Forms.TextBox();
            this.tbSoTinChi = new System.Windows.Forms.TextBox();
            this.btXoaMH = new System.Windows.Forms.Button();
            this.btHuyMH = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTimMH = new System.Windows.Forms.TextBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btTimMH = new System.Windows.Forms.Button();
            this.tbMoTaMH = new System.Windows.Forms.TextBox();
            this.pnXoaSuaStu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).BeginInit();
            this.pnXoaSuaStu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMH
            // 
            this.dgvMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMH.Location = new System.Drawing.Point(3, 376);
            this.dgvMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMH.Name = "dgvMH";
            this.dgvMH.RowHeadersWidth = 62;
            this.dgvMH.RowTemplate.Height = 28;
            this.dgvMH.Size = new System.Drawing.Size(1748, 564);
            this.dgvMH.TabIndex = 37;
            // 
            // btThemMH
            // 
            this.btThemMH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThemMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btThemMH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThemMH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btThemMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btThemMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThemMH.ForeColor = System.Drawing.Color.White;
            this.btThemMH.Image = global::CollegeMS.Properties.Resources.Add;
            this.btThemMH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemMH.Location = new System.Drawing.Point(435, 294);
            this.btThemMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThemMH.Name = "btThemMH";
            this.btThemMH.Size = new System.Drawing.Size(157, 50);
            this.btThemMH.TabIndex = 10;
            this.btThemMH.Text = " Thêm";
            this.btThemMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMH.UseVisualStyleBackColor = false;
            this.btThemMH.Click += new System.EventHandler(this.btThemMH_Click_1);
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.ForeColor = System.Drawing.Color.White;
            this.z.Location = new System.Drawing.Point(307, 25);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(120, 25);
            this.z.TabIndex = 89;
            this.z.Text = "Mã môn học";
            // 
            // btSuaMH
            // 
            this.btSuaMH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSuaMH.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSuaMH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSuaMH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSuaMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btSuaMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSuaMH.ForeColor = System.Drawing.Color.White;
            this.btSuaMH.Image = global::CollegeMS.Properties.Resources.Edit;
            this.btSuaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaMH.Location = new System.Drawing.Point(653, 294);
            this.btSuaMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSuaMH.Name = "btSuaMH";
            this.btSuaMH.Size = new System.Drawing.Size(157, 50);
            this.btSuaMH.TabIndex = 36;
            this.btSuaMH.Text = "Cập nhật";
            this.btSuaMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaMH.UseVisualStyleBackColor = false;
            this.btSuaMH.Click += new System.EventHandler(this.btSuaMH_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(307, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Tên môn học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(307, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 92;
            this.label9.Text = "Số tín chỉ";
            // 
            // tbMaMH
            // 
            this.tbMaMH.BackColor = System.Drawing.Color.White;
            this.tbMaMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaMH.Location = new System.Drawing.Point(450, 23);
            this.tbMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.Size = new System.Drawing.Size(343, 30);
            this.tbMaMH.TabIndex = 90;
            // 
            // tbTenMH
            // 
            this.tbTenMH.BackColor = System.Drawing.Color.White;
            this.tbTenMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenMH.Location = new System.Drawing.Point(450, 74);
            this.tbTenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Size = new System.Drawing.Size(343, 30);
            this.tbTenMH.TabIndex = 97;
            // 
            // tbSoTinChi
            // 
            this.tbSoTinChi.BackColor = System.Drawing.Color.White;
            this.tbSoTinChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTinChi.Location = new System.Drawing.Point(447, 122);
            this.tbSoTinChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoTinChi.Name = "tbSoTinChi";
            this.tbSoTinChi.Size = new System.Drawing.Size(346, 30);
            this.tbSoTinChi.TabIndex = 98;
            // 
            // btXoaMH
            // 
            this.btXoaMH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXoaMH.BackColor = System.Drawing.Color.Red;
            this.btXoaMH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btXoaMH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btXoaMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btXoaMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btXoaMH.ForeColor = System.Drawing.Color.White;
            this.btXoaMH.Image = global::CollegeMS.Properties.Resources.Trash;
            this.btXoaMH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaMH.Location = new System.Drawing.Point(868, 294);
            this.btXoaMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoaMH.Name = "btXoaMH";
            this.btXoaMH.Size = new System.Drawing.Size(157, 50);
            this.btXoaMH.TabIndex = 37;
            this.btXoaMH.Text = "   Xóa";
            this.btXoaMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaMH.UseVisualStyleBackColor = false;
            this.btXoaMH.Click += new System.EventHandler(this.btXoaMH_Click_1);
            // 
            // btHuyMH
            // 
            this.btHuyMH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHuyMH.BackColor = System.Drawing.Color.Olive;
            this.btHuyMH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHuyMH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btHuyMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btHuyMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuyMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHuyMH.ForeColor = System.Drawing.Color.White;
            this.btHuyMH.Image = global::CollegeMS.Properties.Resources.Erase;
            this.btHuyMH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuyMH.Location = new System.Drawing.Point(1071, 294);
            this.btHuyMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHuyMH.Name = "btHuyMH";
            this.btHuyMH.Size = new System.Drawing.Size(157, 50);
            this.btHuyMH.TabIndex = 38;
            this.btHuyMH.Text = "  Hủy";
            this.btHuyMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuyMH.UseVisualStyleBackColor = false;
            this.btHuyMH.Click += new System.EventHandler(this.btHuyMH_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(943, 30);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 93;
            this.label8.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 99;
            this.label3.Text = "Mô tả";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Location = new System.Drawing.Point(1104, 25);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(344, 30);
            this.dtpNgayBatDau.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(940, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 94;
            this.label7.Text = "Ngày kết thúc";
            // 
            // tbTimMH
            // 
            this.tbTimMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimMH.Location = new System.Drawing.Point(447, 235);
            this.tbTimMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTimMH.Multiline = true;
            this.tbTimMH.Name = "tbTimMH";
            this.tbTimMH.Size = new System.Drawing.Size(495, 31);
            this.tbTimMH.TabIndex = 39;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(1104, 124);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(344, 30);
            this.dtpNgayKetThuc.TabIndex = 96;
            // 
            // btTimMH
            // 
            this.btTimMH.BackColor = System.Drawing.Color.White;
            this.btTimMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimMH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTimMH.Location = new System.Drawing.Point(312, 235);
            this.btTimMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTimMH.Name = "btTimMH";
            this.btTimMH.Size = new System.Drawing.Size(85, 32);
            this.btTimMH.TabIndex = 40;
            this.btTimMH.Text = "TÌM";
            this.btTimMH.UseVisualStyleBackColor = false;
            this.btTimMH.Click += new System.EventHandler(this.btTimMH_Click_1);
            // 
            // tbMoTaMH
            // 
            this.tbMoTaMH.BackColor = System.Drawing.Color.White;
            this.tbMoTaMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMoTaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoTaMH.Location = new System.Drawing.Point(447, 176);
            this.tbMoTaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMoTaMH.Name = "tbMoTaMH";
            this.tbMoTaMH.Size = new System.Drawing.Size(346, 30);
            this.tbMoTaMH.TabIndex = 100;
            // 
            // pnXoaSuaStu
            // 
            this.pnXoaSuaStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnXoaSuaStu.Controls.Add(this.tbMoTaMH);
            this.pnXoaSuaStu.Controls.Add(this.btTimMH);
            this.pnXoaSuaStu.Controls.Add(this.dtpNgayKetThuc);
            this.pnXoaSuaStu.Controls.Add(this.tbTimMH);
            this.pnXoaSuaStu.Controls.Add(this.label7);
            this.pnXoaSuaStu.Controls.Add(this.dtpNgayBatDau);
            this.pnXoaSuaStu.Controls.Add(this.label3);
            this.pnXoaSuaStu.Controls.Add(this.label8);
            this.pnXoaSuaStu.Controls.Add(this.btHuyMH);
            this.pnXoaSuaStu.Controls.Add(this.btXoaMH);
            this.pnXoaSuaStu.Controls.Add(this.tbSoTinChi);
            this.pnXoaSuaStu.Controls.Add(this.tbTenMH);
            this.pnXoaSuaStu.Controls.Add(this.tbMaMH);
            this.pnXoaSuaStu.Controls.Add(this.label9);
            this.pnXoaSuaStu.Controls.Add(this.label10);
            this.pnXoaSuaStu.Controls.Add(this.btSuaMH);
            this.pnXoaSuaStu.Controls.Add(this.z);
            this.pnXoaSuaStu.Controls.Add(this.btThemMH);
            this.pnXoaSuaStu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnXoaSuaStu.Location = new System.Drawing.Point(0, 0);
            this.pnXoaSuaStu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnXoaSuaStu.Name = "pnXoaSuaStu";
            this.pnXoaSuaStu.Size = new System.Drawing.Size(1754, 370);
            this.pnXoaSuaStu.TabIndex = 36;
            // 
            // UserControlQLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMH);
            this.Controls.Add(this.pnXoaSuaStu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlQLMH";
            this.Size = new System.Drawing.Size(1754, 999);
            this.Load += new System.EventHandler(this.UserControlQLMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).EndInit();
            this.pnXoaSuaStu.ResumeLayout(false);
            this.pnXoaSuaStu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMH;
        private System.Windows.Forms.Button btThemMH;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Button btSuaMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMaMH;
        private System.Windows.Forms.TextBox tbTenMH;
        private System.Windows.Forms.TextBox tbSoTinChi;
        private System.Windows.Forms.Button btXoaMH;
        private System.Windows.Forms.Button btHuyMH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTimMH;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btTimMH;
        private System.Windows.Forms.TextBox tbMoTaMH;
        private System.Windows.Forms.Panel pnXoaSuaStu;
    }
}
