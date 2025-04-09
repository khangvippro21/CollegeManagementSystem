namespace CollegeMS
{
    partial class UserControlFee
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
            this.dataGridViewFee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnusercontrolFee = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnusercontrolFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFee
            // 
            this.dataGridViewFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewFee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFee.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFee.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewFee.Name = "dataGridViewFee";
            this.dataGridViewFee.Size = new System.Drawing.Size(619, 338);
            this.dataGridViewFee.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 52);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Học Phí";
            // 
            // pnusercontrolFee
            // 
            this.pnusercontrolFee.Controls.Add(this.dataGridViewFee);
            this.pnusercontrolFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnusercontrolFee.Location = new System.Drawing.Point(0, 0);
            this.pnusercontrolFee.Name = "pnusercontrolFee";
            this.pnusercontrolFee.Size = new System.Drawing.Size(619, 388);
            this.pnusercontrolFee.TabIndex = 3;
            // 
            // UserControlFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnusercontrolFee);
            this.Name = "UserControlFee";
            this.Size = new System.Drawing.Size(619, 388);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnusercontrolFee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnusercontrolFee;
    }
}
