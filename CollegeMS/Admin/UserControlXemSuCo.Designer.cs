namespace CollegeMS
{
    partial class UserControlXemSuCo
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
            this.dgvBaoCaoSuCo = new System.Windows.Forms.DataGridView();
            this.ProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSuCo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaoCaoSuCo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvBaoCaoSuCo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCaoSuCo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCaoSuCo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBaoCaoSuCo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoSuCo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCaoSuCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCaoSuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoSuCo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProId,
            this.StuId,
            this.CourseId,
            this.Detail,
            this.ReportedDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCaoSuCo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCaoSuCo.EnableHeadersVisualStyles = false;
            this.dgvBaoCaoSuCo.Location = new System.Drawing.Point(182, 159);
            this.dgvBaoCaoSuCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBaoCaoSuCo.Name = "dgvBaoCaoSuCo";
            this.dgvBaoCaoSuCo.ReadOnly = true;
            this.dgvBaoCaoSuCo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvBaoCaoSuCo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBaoCaoSuCo.RowTemplate.Height = 24;
            this.dgvBaoCaoSuCo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCaoSuCo.Size = new System.Drawing.Size(1575, 645);
            this.dgvBaoCaoSuCo.TabIndex = 1;
            // 
            // ProId
            // 
            this.ProId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProId.DataPropertyName = "ProId";
            this.ProId.HeaderText = "Mã Báo Cáo";
            this.ProId.MinimumWidth = 8;
            this.ProId.Name = "ProId";
            this.ProId.ReadOnly = true;
            this.ProId.Width = 166;
            // 
            // StuId
            // 
            this.StuId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StuId.DataPropertyName = "StuId";
            this.StuId.HeaderText = "Mã Học Viên";
            this.StuId.MinimumWidth = 8;
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
            this.StuId.Width = 170;
            // 
            // CourseId
            // 
            this.CourseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "Mã Môn Học";
            this.CourseId.MinimumWidth = 8;
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Width = 169;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Chi Tiết Báo Cáo";
            this.Detail.MinimumWidth = 8;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // ReportedDate
            // 
            this.ReportedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReportedDate.DataPropertyName = "ReportedDate";
            this.ReportedDate.HeaderText = "Ngày Báo Cáo";
            this.ReportedDate.MinimumWidth = 8;
            this.ReportedDate.Name = "ReportedDate";
            this.ReportedDate.ReadOnly = true;
            this.ReportedDate.Width = 147;
            // 
            // UserControlXemSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dgvBaoCaoSuCo);
            this.Name = "UserControlXemSuCo";
            this.Size = new System.Drawing.Size(1930, 1008);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSuCo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaoCaoSuCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportedDate;
    }
}
