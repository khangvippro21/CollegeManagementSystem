namespace CollegeMS
{
    partial class UCStuDKKH
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
            this.dgvDKKH = new System.Windows.Forms.DataGridView();
            this.btnDki = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDKKH
            // 
            this.dgvDKKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDKKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDKKH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDKKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKKH.Location = new System.Drawing.Point(0, 0);
            this.dgvDKKH.Name = "dgvDKKH";
            this.dgvDKKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDKKH.Size = new System.Drawing.Size(767, 232);
            this.dgvDKKH.TabIndex = 0;
            this.dgvDKKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDKKH_CellContentClick);
            // 
            // btnDki
            // 
            this.btnDki.Location = new System.Drawing.Point(237, 288);
            this.btnDki.Name = "btnDki";
            this.btnDki.Size = new System.Drawing.Size(75, 23);
            this.btnDki.TabIndex = 1;
            this.btnDki.Text = "Đăng kí";
            this.btnDki.UseVisualStyleBackColor = true;
            this.btnDki.Click += new System.EventHandler(this.btnDki_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(395, 288);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // UCStuDKKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDki);
            this.Controls.Add(this.dgvDKKH);
            this.Name = "UCStuDKKH";
            this.Size = new System.Drawing.Size(767, 528);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDKKH;
        private System.Windows.Forms.Button btnDki;
        private System.Windows.Forms.Button btnHuy;
    }
}
