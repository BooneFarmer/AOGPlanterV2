namespace AOGPlanterV2.OldFarmer
{
	partial class FormPopChart
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            timer2 = new System.Windows.Forms.Timer(components);
            popchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnExitPop = new Button();
            lblGraphPop = new Label();
            btnPopChart = new Button();
            ((System.ComponentModel.ISupportInitialize)popchart).BeginInit();
            SuspendLayout();
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 200;
            timer2.Tick += timer2_Tick;
            // 
            // popchart
            // 
            popchart.BackColor = Color.LightGray;
            chartArea1.AxisX.Maximum = 17D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Row";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisY.MajorGrid.Interval = 5D;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.BackColor = Color.LightGray;
            chartArea1.BackSecondaryColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            popchart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            popchart.Legends.Add(legend1);
            popchart.Location = new Point(31, 0);
            popchart.Margin = new Padding(3, 4, 3, 4);
            popchart.Name = "popchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Row        ";
            series1.Name = "Population";
            series1.Points.Add(dataPoint1);
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            popchart.Series.Add(series1);
            popchart.Series.Add(series2);
            popchart.Size = new Size(410, 172);
            popchart.TabIndex = 0;
            popchart.Text = "chart1";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Population % from Target ->";
            popchart.Titles.Add(title1);
            popchart.Click += popchart_Click;
            // 
            // btnExitPop
            // 
            btnExitPop.BackColor = Color.Maroon;
            btnExitPop.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitPop.ForeColor = Color.White;
            btnExitPop.Location = new Point(0, 0);
            btnExitPop.Margin = new Padding(3, 4, 3, 4);
            btnExitPop.Name = "btnExitPop";
            btnExitPop.Size = new Size(36, 172);
            btnExitPop.TabIndex = 1;
            btnExitPop.Text = "EXI T";
            btnExitPop.UseVisualStyleBackColor = false;
            btnExitPop.Click += btnExitPop_Click;
            // 
            // lblGraphPop
            // 
            lblGraphPop.AutoSize = true;
            lblGraphPop.BackColor = Color.LightGray;
            lblGraphPop.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGraphPop.Location = new Point(311, 0);
            lblGraphPop.Name = "lblGraphPop";
            lblGraphPop.Size = new Size(97, 25);
            lblGraphPop.TabIndex = 2;
            lblGraphPop.Text = "199,000";
            lblGraphPop.Click += lblGraphPop_Click;
            // 
            // btnPopChart
            // 
            btnPopChart.BackColor = Color.Maroon;
            btnPopChart.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPopChart.ForeColor = SystemColors.ButtonFace;
            btnPopChart.Location = new Point(283, 135);
            btnPopChart.Margin = new Padding(3, 4, 3, 4);
            btnPopChart.Name = "btnPopChart";
            btnPopChart.Size = new Size(158, 37);
            btnPopChart.TabIndex = 3;
            btnPopChart.Text = "Pop Graph 2";
            btnPopChart.UseVisualStyleBackColor = false;
            btnPopChart.Click += btnPopChart_Click;
            // 
            // FormPopChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 176);
            Controls.Add(btnPopChart);
            Controls.Add(lblGraphPop);
            Controls.Add(btnExitPop);
            Controls.Add(popchart);
            Location = new Point(40, 160);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPopChart";
            StartPosition = FormStartPosition.Manual;
            Text = "Form Pop Chart";
            Load += FormPopChart_Load;
            ((System.ComponentModel.ISupportInitialize)popchart).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart popchart;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Button btnExitPop;
		private System.Windows.Forms.Label lblGraphPop;
		private System.Windows.Forms.Button btnPopChart;
	}
}
