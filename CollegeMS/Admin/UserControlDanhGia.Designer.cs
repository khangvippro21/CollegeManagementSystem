namespace CollegeMS.Admin
{
    partial class UserControlDanhGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhGia = new System.Windows.Forms.DataGridView();
            this.ReviewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhGia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvDanhGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewId,
            this.StId,
            this.LeId,
            this.CId,
            this.Comment});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhGia.EnableHeadersVisualStyles = false;
            this.dgvDanhGia.Location = new System.Drawing.Point(178, 182);
            this.dgvDanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhGia.Name = "dgvDanhGia";
            this.dgvDanhGia.ReadOnly = true;
            this.dgvDanhGia.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvDanhGia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhGia.RowTemplate.Height = 24;
            this.dgvDanhGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhGia.Size = new System.Drawing.Size(1575, 645);
            this.dgvDanhGia.TabIndex = 2;
            // 
            // ReviewId
            // 
            this.ReviewId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReviewId.DataPropertyName = "ReviewId";
            this.ReviewId.HeaderText = "Mã Đánh Giá";
            this.ReviewId.MinimumWidth = 8;
            this.ReviewId.Name = "ReviewId";
            this.ReviewId.ReadOnly = true;
            this.ReviewId.Width = 187;
            // 
            // StId
            // 
            this.StId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StId.DataPropertyName = "StId";
            this.StId.HeaderText = "Mã Học Viên";
            this.StId.MinimumWidth = 8;
            this.StId.Name = "StId";
            this.StId.ReadOnly = true;
            this.StId.Width = 185;
            // 
            // LeId
            // 
            this.LeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeId.DataPropertyName = "LeId";
            this.LeId.HeaderText = "Mã Giảng Viên";
            this.LeId.MinimumWidth = 8;
            this.LeId.Name = "LeId";
            this.LeId.ReadOnly = true;
            this.LeId.Width = 206;
            // 
            // CId
            // 
            this.CId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CId.DataPropertyName = "CId";
            this.CId.HeaderText = "Mã Môn Học";
            this.CId.MinimumWidth = 8;
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            this.CId.Width = 184;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Chi Tiết Đánh Giá";
            this.Comment.MinimumWidth = 8;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // UserControlDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dgvDanhGia);
            this.Name = "UserControlDanhGia";
            this.Size = new System.Drawing.Size(1930, 1008);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}
