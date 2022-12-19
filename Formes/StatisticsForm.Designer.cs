namespace Hotel
{
    partial class StaticsticsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0,0,0,0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.hotelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelChart)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelChart
            // 
            this.hotelChart.BackColor = System.Drawing.Color.Transparent;
            this.hotelChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.hotelChart.ChartAreas.Add(chartArea1);
            this.hotelChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.hotelChart.Legends.Add(legend1);
            this.hotelChart.Location = new System.Drawing.Point(0, 0);
            this.hotelChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hotelChart.Name = "hotelChart";
            this.hotelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Макс.цена";
            series1.Points.Add(dataPoint1);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 10;
            series2.ChartArea = "ChartArea1";
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            series2.Legend = "Legend1";
            series2.Name = "Мин.цена";
            series2.Points.Add(dataPoint2);
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Средняя цена";
            series3.Points.Add(dataPoint3);
            this.hotelChart.Series.Add(series1);
            this.hotelChart.Series.Add(series2);
            this.hotelChart.Series.Add(series3);
            this.hotelChart.Size = new System.Drawing.Size(878, 313);
            this.hotelChart.TabIndex = 0;
            this.hotelChart.Enter += new System.EventHandler(this.EmployersForm_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "СТАТИСТИКА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "СТАТИСТИКА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "СТАТИСТИКА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "СТАТИСТИКА";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "СТАТИСТИКА";
            // 
            // StaticsticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(878, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotelChart);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StaticsticsForm";
            this.Text = "EmployersForm";
            this.VisibleChanged += new System.EventHandler(this.EmployersForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.hotelChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart hotelChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}