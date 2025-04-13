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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewFee = new System.Windows.Forms.DataGridView();
            this.chartHocphi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHocphi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFee
            // 
            this.dataGridViewFee.AllowUserToAddRows = false;
            this.dataGridViewFee.AllowUserToResizeColumns = false;
            this.dataGridViewFee.AllowUserToResizeRows = false;
            this.dataGridViewFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridViewFee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFee.EnableHeadersVisualStyles = false;
            this.dataGridViewFee.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewFee.Location = new System.Drawing.Point(0, 248);
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
            this.dataGridViewFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFee.Size = new System.Drawing.Size(1022, 306);
            this.dataGridViewFee.TabIndex = 0;
            // 
            // chartHocphi
            // 
            this.chartHocphi.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chartHocphi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHocphi.Legends.Add(legend1);
            this.chartHocphi.Location = new System.Drawing.Point(18, 3);
            this.chartHocphi.Name = "chartHocphi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHocphi.Series.Add(series1);
            this.chartHocphi.Size = new System.Drawing.Size(418, 273);
            this.chartHocphi.TabIndex = 4;
            this.chartHocphi.Text = "chart1";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(475, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(544, 273);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // UserControlFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartHocphi);
            this.Controls.Add(this.dataGridViewFee);
            this.Name = "UserControlFee";
            this.Size = new System.Drawing.Size(1022, 554);
            this.Load += new System.EventHandler(this.UserControlFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHocphi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFee;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHocphi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
