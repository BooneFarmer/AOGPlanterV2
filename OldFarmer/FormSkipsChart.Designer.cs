namespace AOGPlanterV2
{
	partial class FormSkipsChart
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            timer1 = new System.Windows.Forms.Timer(components);
            skipChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnExitSC = new Button();
            btnAlarm = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)skipChart).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // skipChart
            // 
            skipChart.BackColor = Color.LightGray;
            chartArea1.AxisX.Maximum = 17D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Row";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisX2.Maximum = 17D;
            chartArea1.AxisX2.Minimum = 0D;
            chartArea1.AxisY.Maximum = 7D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY2.Maximum = 7D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.BackColor = Color.LightGray;
            chartArea1.BackSecondaryColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            skipChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.LightGray;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            skipChart.Legends.Add(legend1);
            skipChart.Location = new Point(42, -7);
            skipChart.Margin = new Padding(3, 4, 3, 4);
            skipChart.Name = "skipChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Yellow;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Skips";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.Violet;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Doubles";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            skipChart.Series.Add(series1);
            skipChart.Series.Add(series2);
            skipChart.Size = new Size(415, 200);
            skipChart.TabIndex = 0;
            skipChart.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Skips & Doubles - 3 second look";
            skipChart.Titles.Add(title1);
//            skipChart.Click += skipChart_Click;
            // 
            // btnExitSC
            // 
            btnExitSC.BackColor = Color.Maroon;
            btnExitSC.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExitSC.ForeColor = Color.White;
            btnExitSC.Location = new Point(14, 14);
            btnExitSC.Margin = new Padding(3, 4, 3, 4);
            btnExitSC.Name = "btnExitSC";
            btnExitSC.Size = new Size(40, 173);
            btnExitSC.TabIndex = 1;
            btnExitSC.Text = "EX I T";
            btnExitSC.UseVisualStyleBackColor = false;
            btnExitSC.Click += btnSkipExit;
            // 
            // btnAlarm
            // 
            btnAlarm.BackColor = Color.Maroon;
            btnAlarm.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlarm.ForeColor = Color.White;
            btnAlarm.Location = new Point(286, 160);
            btnAlarm.Margin = new Padding(3, 4, 3, 4);
            btnAlarm.Name = "btnAlarm";
            btnAlarm.Size = new Size(171, 34);
            btnAlarm.TabIndex = 2;
            btnAlarm.Text = "ALARM";
            btnAlarm.UseVisualStyleBackColor = false;
            btnAlarm.Click += AlarmClicked;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gray;
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Yellow;
            textBox1.Location = new Point(68, 160);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 21);
            textBox1.TabIndex = 3;
            textBox1.Text = "Skips";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Violet;
            textBox2.Location = new Point(134, 160);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(71, 21);
            textBox2.TabIndex = 4;
            textBox2.Text = "Doubles";
            // 
            // FormSkipsChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 193);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAlarm);
            Controls.Add(btnExitSC);
            Controls.Add(skipChart);
            Location = new Point(1400, 120);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSkipsChart";
            StartPosition = FormStartPosition.Manual;
            Text = "Form Skip Chart";
            Load += FormSkipChart_Load;
            ((System.ComponentModel.ISupportInitialize)skipChart).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart skipChart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnExitSC;
		private System.Windows.Forms.Button btnAlarm;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
	}
}
