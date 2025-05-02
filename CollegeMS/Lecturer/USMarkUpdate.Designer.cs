namespace CollegeMS.Lecturer
{
    partial class USMarkUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHocvien = new System.Windows.Forms.DataGridView();
            this.dgvMonhoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStdId = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Học viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Môn học";
            // 
            // dgvHocvien
            // 
            this.dgvHocvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHocvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocvien.Location = new System.Drawing.Point(804, 121);
            this.dgvHocvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHocvien.Name = "dgvHocvien";
            this.dgvHocvien.ReadOnly = true;
            this.dgvHocvien.RowHeadersWidth = 51;
            this.dgvHocvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocvien.Size = new System.Drawing.Size(788, 720);
            this.dgvHocvien.TabIndex = 6;
            this.dgvHocvien.SelectionChanged += new System.EventHandler(this.dgvHocvien_SelectionChanged);
            // 
            // dgvMonhoc
            // 
            this.dgvMonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonhoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonhoc.Location = new System.Drawing.Point(0, 85);
            this.dgvMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMonhoc.Name = "dgvMonhoc";
            this.dgvMonhoc.ReadOnly = true;
            this.dgvMonhoc.RowHeadersWidth = 51;
            this.dgvMonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonhoc.Size = new System.Drawing.Size(603, 342);
            this.dgvMonhoc.TabIndex = 5;
            this.dgvMonhoc.SelectionChanged += new System.EventHandler(this.dgvMonhoc_SelectionChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStdId);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMark);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Location = new System.Drawing.Point(92, 523);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 318);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(36, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã sinh viên";
            // 
            // txtStdId
            // 
            this.txtStdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStdId.Location = new System.Drawing.Point(176, 51);
            this.txtStdId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdId.Name = "txtStdId";
            this.txtStdId.ReadOnly = true;
            this.txtStdId.Size = new System.Drawing.Size(389, 30);
            this.txtStdId.TabIndex = 5;
            // 
            // btSave
            // 
            this.btSave.BackgroundImage = global::CollegeMS.Properties.Resources.Tick_Box;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Location = new System.Drawing.Point(469, 184);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(97, 83);
            this.btSave.TabIndex = 4;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(38, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhập điểm";
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMark.Location = new System.Drawing.Point(177, 184);
            this.txtMark.Margin = new System.Windows.Forms.Padding(4);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(196, 30);
            this.txtMark.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(38, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ và tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoten.Location = new System.Drawing.Point(177, 116);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(389, 30);
            this.txtHoten.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvMonhoc);
            this.panel2.Location = new System.Drawing.Point(92, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 427);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(804, 57);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 784);
            this.panel3.TabIndex = 12;
            // 
            // USMarkUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHocvien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USMarkUpdate";
            this.Size = new System.Drawing.Size(2493, 1337);
            this.Load += new System.EventHandler(this.USMarkUpdate_Load);
            this.VisibleChanged += new System.EventHandler(this.USMarkUpdate_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHocvien;
        private System.Windows.Forms.DataGridView dgvMonhoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStdId;
        private System.Windows.Forms.Panel panel3;
    }
}
