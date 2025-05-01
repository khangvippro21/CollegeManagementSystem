namespace CollegeMS
{
    partial class USDangkylichday
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
            this.dgvMonhocTrong = new System.Windows.Forms.DataGridView();
            this.dgvMonhoc = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel_1 = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCancel_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhocTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMonhocTrong
            // 
            this.dgvMonhocTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonhocTrong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMonhocTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonhocTrong.Location = new System.Drawing.Point(13, 19);
            this.dgvMonhocTrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMonhocTrong.Name = "dgvMonhocTrong";
            this.dgvMonhocTrong.ReadOnly = true;
            this.dgvMonhocTrong.RowHeadersWidth = 51;
            this.dgvMonhocTrong.RowTemplate.Height = 24;
            this.dgvMonhocTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonhocTrong.Size = new System.Drawing.Size(1050, 419);
            this.dgvMonhocTrong.TabIndex = 0;
            // 
            // dgvMonhoc
            // 
            this.dgvMonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonhoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonhoc.Location = new System.Drawing.Point(13, 468);
            this.dgvMonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMonhoc.Name = "dgvMonhoc";
            this.dgvMonhoc.ReadOnly = true;
            this.dgvMonhoc.RowHeadersWidth = 51;
            this.dgvMonhoc.RowTemplate.Height = 24;
            this.dgvMonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonhoc.Size = new System.Drawing.Size(1050, 497);
            this.dgvMonhoc.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(1139, 19);
            this.btSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(102, 50);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "SAVE";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel_1
            // 
            this.btCancel_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel_1.Location = new System.Drawing.Point(1139, 93);
            this.btCancel_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel_1.Name = "btCancel_1";
            this.btCancel_1.Size = new System.Drawing.Size(102, 50);
            this.btCancel_1.TabIndex = 3;
            this.btCancel_1.Text = "CANCEL";
            this.btCancel_1.UseVisualStyleBackColor = true;
            this.btCancel_1.Click += new System.EventHandler(this.btCancel_1_Click);
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(1139, 468);
            this.btRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(107, 50);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "REMOVE";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.dgvMonhocTrong);
            this.panel1.Controls.Add(this.btCancel_1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1746, 453);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btCancel_2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dgvMonhoc);
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1633, 991);
            this.panel2.TabIndex = 6;
            // 
            // btCancel_2
            // 
            this.btCancel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel_2.Location = new System.Drawing.Point(1139, 538);
            this.btCancel_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel_2.Name = "btCancel_2";
            this.btCancel_2.Size = new System.Drawing.Size(102, 50);
            this.btCancel_2.TabIndex = 4;
            this.btCancel_2.Text = "CANCEL";
            this.btCancel_2.UseVisualStyleBackColor = true;
            this.btCancel_2.Click += new System.EventHandler(this.btCancel_2_Click);
            // 
            // USDangkylichday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "USDangkylichday";
            this.Size = new System.Drawing.Size(1633, 991);
            this.Load += new System.EventHandler(this.USDangkylichday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhocTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonhocTrong;
        private System.Windows.Forms.DataGridView dgvMonhoc;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel_1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCancel_2;
    }
}
