namespace CollegeMS.Student
{
    partial class Xemhocphi
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
            this.dgvdshocphi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongph = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshocphi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdshocphi
            // 
            this.dgvdshocphi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdshocphi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdshocphi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvdshocphi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdshocphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshocphi.Location = new System.Drawing.Point(3, 3);
            this.dgvdshocphi.Name = "dgvdshocphi";
            this.dgvdshocphi.Size = new System.Drawing.Size(875, 233);
            this.dgvdshocphi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng học phí:";
            // 
            // txttongph
            // 
            this.txttongph.Location = new System.Drawing.Point(187, 283);
            this.txttongph.Name = "txttongph";
            this.txttongph.ReadOnly = true;
            this.txttongph.Size = new System.Drawing.Size(190, 20);
            this.txttongph.TabIndex = 2;
            // 
            // Xemhocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.txttongph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdshocphi);
            this.Name = "Xemhocphi";
            this.Size = new System.Drawing.Size(881, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshocphi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdshocphi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongph;
    }
}
