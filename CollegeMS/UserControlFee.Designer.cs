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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewFee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartHocphi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHocphi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFee
            // 
            this.dataGridViewFee.AllowUserToAddRows = false;
            this.dataGridViewFee.AllowUserToResizeColumns = false;
            this.dataGridViewFee.AllowUserToResizeRows = false;
            this.dataGridViewFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFee.EnableHeadersVisualStyles = false;
            this.dataGridViewFee.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewFee.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewFee.Name = "dataGridViewFee";
            this.dataGridViewFee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFee.RowHeadersVisible = false;
            this.dataGridViewFee.RowHeadersWidth = 62;
            this.dataGridViewFee.Size = new System.Drawing.Size(1560, 666);
            this.dataGridViewFee.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 80);
            this.panel1.TabIndex = 2;
            // 
            // chartHocphi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHocphi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHocphi.Legends.Add(legend1);
            this.chartHocphi.Location = new System.Drawing.Point(642, 80);
            this.chartHocphi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartHocphi.Name = "chartHocphi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHocphi.Series.Add(series1);
            this.chartHocphi.Size = new System.Drawing.Size(837, 497);
            this.chartHocphi.TabIndex = 3;
            this.chartHocphi.Text = "chart1";
            // 
            // UserControlFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartHocphi);
            this.Controls.Add(this.dataGridViewFee);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlFee";
            this.Size = new System.Drawing.Size(1560, 746);
            this.Load += new System.EventHandler(this.UserControlFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHocphi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHocphi;
    }
}
