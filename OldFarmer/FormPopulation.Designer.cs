namespace AOGPlanterV2.OldFarmer
{
	partial class PopulationChart2
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            popChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTargetPop = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnExitPop = new Button();
            btnPopChart = new Button();
            ((System.ComponentModel.ISupportInitialize)popChart2).BeginInit();
            SuspendLayout();
            // 
            // popChart2
            // 
            popChart2.BackColor = Color.LightGray;
            popChart2.BackSecondaryColor = Color.Red;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Maximum = 17D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Row";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.BackColor = Color.LightGray;
            chartArea1.BackSecondaryColor = Color.White;
            chartArea1.Name = "ChartArea1";
            popChart2.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            popChart2.Legends.Add(legend1);
            popChart2.Location = new Point(43, 0);
            popChart2.Margin = new Padding(4, 3, 4, 3);
            popChart2.Name = "popChart2";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Row";
            series1.Name = "SeriesPop";
            series1.Points.Add(dataPoint1);
            popChart2.Series.Add(series1);
            popChart2.Size = new Size(424, 183);
            popChart2.TabIndex = 0;
            popChart2.Text = "chart1";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Population Target";
            popChart2.Titles.Add(title1);
            // 
            // lblTargetPop
            // 
            lblTargetPop.AutoSize = true;
            lblTargetPop.BackColor = Color.LightGray;
            lblTargetPop.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTargetPop.Location = new Point(288, 7);
            lblTargetPop.Margin = new Padding(4, 0, 4, 0);
            lblTargetPop.Name = "lblTargetPop";
            lblTargetPop.Size = new Size(97, 25);
            lblTargetPop.TabIndex = 1;
            lblTargetPop.Text = "999,999";
            lblTargetPop.Click += lblTargetPop_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // btnExitPop
            // 
            btnExitPop.BackColor = Color.Maroon;
            btnExitPop.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitPop.ForeColor = Color.White;
            btnExitPop.Location = new Point(1, 0);
            btnExitPop.Margin = new Padding(4, 3, 4, 3);
            btnExitPop.Name = "btnExitPop";
            btnExitPop.Size = new Size(36, 183);
            btnExitPop.TabIndex = 2;
            btnExitPop.Text = "EXI T";
            btnExitPop.UseVisualStyleBackColor = false;
            btnExitPop.Click += btnExitPop_Click;
            // 
            // btnPopChart
            // 
            btnPopChart.BackColor = Color.Maroon;
            btnPopChart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPopChart.ForeColor = SystemColors.ButtonFace;
            btnPopChart.Location = new Point(315, 147);
            btnPopChart.Margin = new Padding(4, 3, 4, 3);
            btnPopChart.Name = "btnPopChart";
            btnPopChart.Size = new Size(152, 37);
            btnPopChart.TabIndex = 4;
            btnPopChart.Text = "Pop Graph 1";
            btnPopChart.UseVisualStyleBackColor = false;
            btnPopChart.Click += btnPopChart_Click;
            // 
            // PopulationChart2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 185);
            Controls.Add(btnPopChart);
            Controls.Add(btnExitPop);
            Controls.Add(lblTargetPop);
            Controls.Add(popChart2);
            Location = new Point(40, 160);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PopulationChart2";
            StartPosition = FormStartPosition.Manual;
            Text = "Population";
            Load += PopulationChart2_Load;
            ((System.ComponentModel.ISupportInitialize)popChart2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart popChart2;
		private System.Windows.Forms.Label lblTargetPop;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnExitPop;
		private System.Windows.Forms.Button btnPopChart;
	}
}
