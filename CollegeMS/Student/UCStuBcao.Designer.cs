namespace CollegeMS
{
    partial class UCStuBcao
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhoahoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbreport = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbreview = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdtgv = new System.Windows.Forms.TextBox();
            this.txtmailgv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttengv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn khóa học";
            // 
            // cbbKhoahoc
            // 
            this.cbbKhoahoc.FormattingEnabled = true;
            this.cbbKhoahoc.Location = new System.Drawing.Point(194, 51);
            this.cbbKhoahoc.Name = "cbbKhoahoc";
            this.cbbKhoahoc.Size = new System.Drawing.Size(241, 21);
            this.cbbKhoahoc.TabIndex = 3;
            this.cbbKhoahoc.SelectedIndexChanged += new System.EventHandler(this.cbbKhoahoc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rtbreport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbKhoahoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 575);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Báo cáo sự cố";
            // 
            // rtbreport
            // 
            this.rtbreport.Location = new System.Drawing.Point(172, 301);
            this.rtbreport.Name = "rtbreport";
            this.rtbreport.Size = new System.Drawing.Size(241, 124);
            this.rtbreport.TabIndex = 4;
            this.rtbreport.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.rtbreview);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtsdtgv);
            this.panel2.Controls.Add(this.txtmailgv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txttengv);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(564, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 575);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(257, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Gửi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbreview
            // 
            this.rtbreview.Location = new System.Drawing.Point(189, 301);
            this.rtbreview.Name = "rtbreview";
            this.rtbreview.Size = new System.Drawing.Size(241, 124);
            this.rtbreview.TabIndex = 8;
            this.rtbreview.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Đánh giá giảng viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điện thoại:";
            // 
            // txtsdtgv
            // 
            this.txtsdtgv.Location = new System.Drawing.Point(139, 176);
            this.txtsdtgv.Name = "txtsdtgv";
            this.txtsdtgv.ReadOnly = true;
            this.txtsdtgv.Size = new System.Drawing.Size(219, 20);
            this.txtsdtgv.TabIndex = 5;
            // 
            // txtmailgv
            // 
            this.txtmailgv.Location = new System.Drawing.Point(139, 124);
            this.txtmailgv.Name = "txtmailgv";
            this.txtmailgv.ReadOnly = true;
            this.txtmailgv.Size = new System.Drawing.Size(219, 20);
            this.txtmailgv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // txttengv
            // 
            this.txttengv.Location = new System.Drawing.Point(139, 76);
            this.txttengv.Name = "txttengv";
            this.txttengv.ReadOnly = true;
            this.txttengv.Size = new System.Drawing.Size(219, 20);
            this.txttengv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin giảng viên";
            // 
            // UCStuBcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCStuBcao";
            this.Size = new System.Drawing.Size(1068, 575);
            this.Load += new System.EventHandler(this.UCStuBcao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoahoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdtgv;
        private System.Windows.Forms.TextBox txtmailgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbreport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbreview;
        private System.Windows.Forms.Label label7;
    }
}
