namespace ExpensesApp
{
    partial class DetailsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChartItem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitleChart = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartItem
            // 
            chartArea4.Name = "ChartArea1";
            this.pieChartItem.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.pieChartItem.Legends.Add(legend4);
            this.pieChartItem.Location = new System.Drawing.Point(12, 3);
            this.pieChartItem.Name = "pieChartItem";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "s1";
            this.pieChartItem.Series.Add(series4);
            this.pieChartItem.Size = new System.Drawing.Size(776, 435);
            this.pieChartItem.TabIndex = 0;
            this.pieChartItem.Text = "chart1";
            // 
            // lblTitleChart
            // 
            this.lblTitleChart.AutoSize = true;
            this.lblTitleChart.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChart.Location = new System.Drawing.Point(185, 481);
            this.lblTitleChart.Name = "lblTitleChart";
            this.lblTitleChart.Size = new System.Drawing.Size(419, 35);
            this.lblTitleChart.TabIndex = 1;
            this.lblTitleChart.Text = "Biểu đồ tháng 8 năm 2022";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(227, 519);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(296, 62);
            this.btnSendEmail.TabIndex = 2;
            this.btnSendEmail.Text = "Gửi báo cáo về email của bạn";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 593);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.lblTitleChart);
            this.Controls.Add(this.pieChartItem);
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChartItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartItem;
        private System.Windows.Forms.Label lblTitleChart;
        private System.Windows.Forms.Button btnSendEmail;
    }
}