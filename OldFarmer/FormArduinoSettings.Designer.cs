using System;
using AOGPlanterV2;
using System.Collections.Generic;
using AOGPlanterV2.Properties;


namespace AOGPlanterV2.OldFarmer
{
	partial class FormArduinoSettings
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
            label1 = new Label();
            lblTargetPopulation = new Label();
            lblRowSpacing = new Label();
            lblPlantingSpeed = new Label();
            label5 = new Label();
            btnSavePlanterSettings = new Button();
            nUDPopulation = new NumericUpDown();
            nudRowSpacing = new NumericUpDown();
            nudPlantingSpeed = new NumericUpDown();
            btnPlanterMonitorActive = new Button();
            btnSeedAlarm = new Button();
            btnSendPlanterConfigPGN = new Button();
            lblPMSS = new Label();
            lblCurPopulation = new Label();
            lblCurRowWidth = new Label();
            lblCurTargetSpeed = new Label();
            lblCurNumSections = new Label();
            label2 = new Label();
            label3 = new Label();
            nudPlanterDoublesFactor = new NumericUpDown();
            label4 = new Label();
            lblCurDoubleFactor = new Label();
            btnPlanterSimulator = new Button();
            numRows = new NumericUpDown();
            lblArraySpeed = new Label();
            nudArraySpeed = new NumericUpDown();
            btnMetric = new Button();
            ((System.ComponentModel.ISupportInitialize)nUDPopulation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRowSpacing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlantingSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlanterDoublesFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudArraySpeed).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(245, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 31);
            label1.TabIndex = 0;
            label1.Text = "Planter Monitor Settings";
            // 
            // lblTargetPopulation
            // 
            lblTargetPopulation.AutoSize = true;
            lblTargetPopulation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTargetPopulation.ForeColor = SystemColors.ButtonFace;
            lblTargetPopulation.Location = new Point(78, 230);
            lblTargetPopulation.Margin = new Padding(4, 0, 4, 0);
            lblTargetPopulation.Name = "lblTargetPopulation";
            lblTargetPopulation.Size = new Size(234, 20);
            lblTargetPopulation.TabIndex = 3;
            lblTargetPopulation.Text = "Target Population (per acre)";
            // 
            // lblRowSpacing
            // 
            lblRowSpacing.AutoSize = true;
            lblRowSpacing.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRowSpacing.ForeColor = SystemColors.ButtonFace;
            lblRowSpacing.Location = new Point(78, 303);
            lblRowSpacing.Margin = new Padding(4, 0, 4, 0);
            lblRowSpacing.Name = "lblRowSpacing";
            lblRowSpacing.Size = new Size(183, 20);
            lblRowSpacing.TabIndex = 4;
            lblRowSpacing.Text = "Row Spacing (inches)";
            // 
            // lblPlantingSpeed
            // 
            lblPlantingSpeed.AutoSize = true;
            lblPlantingSpeed.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlantingSpeed.ForeColor = SystemColors.ButtonFace;
            lblPlantingSpeed.Location = new Point(78, 373);
            lblPlantingSpeed.Margin = new Padding(4, 0, 4, 0);
            lblPlantingSpeed.Name = "lblPlantingSpeed";
            lblPlantingSpeed.Size = new Size(182, 20);
            lblPlantingSpeed.TabIndex = 6;
            lblPlantingSpeed.Text = "Planting Speed (mph)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(78, 542);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(225, 20);
            label5.TabIndex = 8;
            label5.Text = "Number of Rows (sections)";
            // 
            // btnSavePlanterSettings
            // 
            btnSavePlanterSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSavePlanterSettings.BackColor = Color.FromArgb(50, 50, 70);
            btnSavePlanterSettings.FlatAppearance.BorderSize = 0;
            btnSavePlanterSettings.FlatStyle = FlatStyle.Flat;
            btnSavePlanterSettings.ForeColor = SystemColors.ButtonFace;
            btnSavePlanterSettings.Image = Resources.Cancel64;
            btnSavePlanterSettings.Location = new Point(607, 539);
            btnSavePlanterSettings.Margin = new Padding(4, 3, 4, 3);
            btnSavePlanterSettings.Name = "btnSavePlanterSettings";
            btnSavePlanterSettings.Size = new Size(97, 91);
            btnSavePlanterSettings.TabIndex = 213;
            btnSavePlanterSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSavePlanterSettings.UseVisualStyleBackColor = false;
            btnSavePlanterSettings.Click += PMS_Exit;
            // 
            // nUDPopulation
            // 
            nUDPopulation.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nUDPopulation.Location = new Point(385, 209);
            nUDPopulation.Margin = new Padding(4, 3, 4, 3);
            nUDPopulation.Maximum = new decimal(new int[] { 210000, 0, 0, 0 });
            nUDPopulation.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDPopulation.Name = "nUDPopulation";
            nUDPopulation.Size = new Size(136, 38);
            nUDPopulation.TabIndex = 214;
            nUDPopulation.Value = new decimal(new int[] { 32500, 0, 0, 0 });
            nUDPopulation.ValueChanged += nudPopulation_ValueChanged;
            nUDPopulation.Click += nudPopulation_Click;
            // 
            // nudRowSpacing
            // 
            nudRowSpacing.DecimalPlaces = 1;
            nudRowSpacing.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudRowSpacing.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudRowSpacing.Location = new Point(385, 283);
            nudRowSpacing.Margin = new Padding(4, 3, 4, 3);
            nudRowSpacing.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRowSpacing.Name = "nudRowSpacing";
            nudRowSpacing.Size = new Size(136, 38);
            nudRowSpacing.TabIndex = 215;
            nudRowSpacing.Value = new decimal(new int[] { 30, 0, 0, 0 });
            nudRowSpacing.ValueChanged += nudRowSpacing_valueChanged;
            nudRowSpacing.Click += nudRowSpacing_Clicked;
            // 
            // nudPlantingSpeed
            // 
            nudPlantingSpeed.DecimalPlaces = 1;
            nudPlantingSpeed.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudPlantingSpeed.Location = new Point(385, 352);
            nudPlantingSpeed.Margin = new Padding(4, 3, 4, 3);
            nudPlantingSpeed.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            nudPlantingSpeed.Name = "nudPlantingSpeed";
            nudPlantingSpeed.Size = new Size(136, 38);
            nudPlantingSpeed.TabIndex = 216;
            nudPlantingSpeed.Value = new decimal(new int[] { 45, 0, 0, 65536 });
            nudPlantingSpeed.ValueChanged += nudPlantingSpeed_ValueChanged;
            nudPlantingSpeed.Click += nudPlantingSpeed_Clicked;
            // 
            // btnPlanterMonitorActive
            // 
            btnPlanterMonitorActive.BackColor = Color.LawnGreen;
            btnPlanterMonitorActive.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlanterMonitorActive.Location = new Point(46, 84);
            btnPlanterMonitorActive.Margin = new Padding(4, 3, 4, 3);
            btnPlanterMonitorActive.Name = "btnPlanterMonitorActive";
            btnPlanterMonitorActive.Size = new Size(350, 81);
            btnPlanterMonitorActive.TabIndex = 220;
            btnPlanterMonitorActive.Text = "Planter Monitor is Active";
            btnPlanterMonitorActive.UseVisualStyleBackColor = false;
            btnPlanterMonitorActive.Click += pmonitorActive_Clicked;
            // 
            // btnSeedAlarm
            // 
            btnSeedAlarm.BackColor = Color.LawnGreen;
            btnSeedAlarm.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeedAlarm.Location = new Point(552, 84);
            btnSeedAlarm.Margin = new Padding(4, 3, 4, 3);
            btnSeedAlarm.Name = "btnSeedAlarm";
            btnSeedAlarm.Size = new Size(350, 81);
            btnSeedAlarm.TabIndex = 221;
            btnSeedAlarm.Text = "Seed Alarm is Active";
            btnSeedAlarm.UseVisualStyleBackColor = false;
            btnSeedAlarm.Click += seedAlarm_Clicked;
            // 
            // btnSendPlanterConfigPGN
            // 
            btnSendPlanterConfigPGN.BackColor = Color.Transparent;
            btnSendPlanterConfigPGN.FlatAppearance.BorderSize = 0;
            btnSendPlanterConfigPGN.FlatStyle = FlatStyle.Flat;
            btnSendPlanterConfigPGN.Image = Resources.ToolAcceptChange;
            btnSendPlanterConfigPGN.ImeMode = ImeMode.NoControl;
            btnSendPlanterConfigPGN.Location = new Point(747, 478);
            btnSendPlanterConfigPGN.Margin = new Padding(4, 3, 4, 3);
            btnSendPlanterConfigPGN.Name = "btnSendPlanterConfigPGN";
            btnSendPlanterConfigPGN.Size = new Size(155, 72);
            btnSendPlanterConfigPGN.TabIndex = 502;
            btnSendPlanterConfigPGN.UseVisualStyleBackColor = false;
            btnSendPlanterConfigPGN.Click += btnSendPlanterConfigPGN_Click;
            // 
            // lblPMSS
            // 
            lblPMSS.BackColor = Color.Transparent;
            lblPMSS.Font = new Font("Tahoma", 15.75F);
            lblPMSS.ForeColor = SystemColors.ButtonFace;
            lblPMSS.ImeMode = ImeMode.NoControl;
            lblPMSS.Location = new Point(685, 561);
            lblPMSS.Margin = new Padding(4, 0, 4, 0);
            lblPMSS.Name = "lblPMSS";
            lblPMSS.Size = new Size(201, 35);
            lblPMSS.TabIndex = 503;
            lblPMSS.Text = "Send +  Save";
            lblPMSS.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurPopulation
            // 
            lblCurPopulation.AutoSize = true;
            lblCurPopulation.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurPopulation.ForeColor = Color.LightGreen;
            lblCurPopulation.Location = new Point(147, 257);
            lblCurPopulation.Margin = new Padding(4, 0, 4, 0);
            lblCurPopulation.Name = "lblCurPopulation";
            lblCurPopulation.Size = new Size(24, 30);
            lblCurPopulation.TabIndex = 504;
            lblCurPopulation.Text = "0";
            // 
            // lblCurRowWidth
            // 
            lblCurRowWidth.AutoSize = true;
            lblCurRowWidth.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurRowWidth.ForeColor = Color.LightGreen;
            lblCurRowWidth.Location = new Point(147, 339);
            lblCurRowWidth.Margin = new Padding(4, 0, 4, 0);
            lblCurRowWidth.Name = "lblCurRowWidth";
            lblCurRowWidth.Size = new Size(22, 25);
            lblCurRowWidth.TabIndex = 505;
            lblCurRowWidth.Text = "0";
            // 
            // lblCurTargetSpeed
            // 
            lblCurTargetSpeed.AutoSize = true;
            lblCurTargetSpeed.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurTargetSpeed.ForeColor = Color.LightGreen;
            lblCurTargetSpeed.Location = new Point(147, 407);
            lblCurTargetSpeed.Margin = new Padding(4, 0, 4, 0);
            lblCurTargetSpeed.Name = "lblCurTargetSpeed";
            lblCurTargetSpeed.Size = new Size(22, 25);
            lblCurTargetSpeed.TabIndex = 506;
            lblCurTargetSpeed.Text = "0";
            // 
            // lblCurNumSections
            // 
            lblCurNumSections.AutoSize = true;
            lblCurNumSections.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurNumSections.ForeColor = Color.LightGreen;
            lblCurNumSections.Location = new Point(147, 576);
            lblCurNumSections.Margin = new Padding(4, 0, 4, 0);
            lblCurNumSections.Name = "lblCurNumSections";
            lblCurNumSections.Size = new Size(22, 25);
            lblCurNumSections.TabIndex = 507;
            lblCurNumSections.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(63, 257);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 508;
            label2.Text = "Current";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(78, 460);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 509;
            label3.Text = "A Double =";
            // 
            // nudPlanterDoublesFactor
            // 
            nudPlanterDoublesFactor.DecimalPlaces = 2;
            nudPlanterDoublesFactor.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudPlanterDoublesFactor.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPlanterDoublesFactor.Location = new Point(195, 448);
            nudPlanterDoublesFactor.Margin = new Padding(4, 3, 4, 3);
            nudPlanterDoublesFactor.Maximum = new decimal(new int[] { 55, 0, 0, 131072 });
            nudPlanterDoublesFactor.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPlanterDoublesFactor.Name = "nudPlanterDoublesFactor";
            nudPlanterDoublesFactor.Size = new Size(140, 38);
            nudPlanterDoublesFactor.TabIndex = 510;
            nudPlanterDoublesFactor.Value = new decimal(new int[] { 49, 0, 0, 131072 });
            nudPlanterDoublesFactor.ValueChanged += numericUpDown1_ValueChanged;
            nudPlanterDoublesFactor.Click += nudPlanterDoublesFactor_clicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(365, 460);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 511;
            label4.Text = "X Normal Spacing";
            label4.Click += label4_Click;
            // 
            // lblCurDoubleFactor
            // 
            lblCurDoubleFactor.AutoSize = true;
            lblCurDoubleFactor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurDoubleFactor.ForeColor = Color.LightGreen;
            lblCurDoubleFactor.Location = new Point(150, 501);
            lblCurDoubleFactor.Margin = new Padding(4, 0, 4, 0);
            lblCurDoubleFactor.Name = "lblCurDoubleFactor";
            lblCurDoubleFactor.Size = new Size(22, 25);
            lblCurDoubleFactor.TabIndex = 512;
            lblCurDoubleFactor.Text = "0";
            // 
            // btnPlanterSimulator
            // 
            btnPlanterSimulator.BackColor = Color.LawnGreen;
            btnPlanterSimulator.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlanterSimulator.Location = new Point(46, 612);
            btnPlanterSimulator.Margin = new Padding(4, 3, 4, 3);
            btnPlanterSimulator.Name = "btnPlanterSimulator";
            btnPlanterSimulator.Size = new Size(252, 47);
            btnPlanterSimulator.TabIndex = 513;
            btnPlanterSimulator.Text = "Simulator on";
            btnPlanterSimulator.UseVisualStyleBackColor = false;
            btnPlanterSimulator.Click += SimulatorClicked;
            // 
            // numRows
            // 
            numRows.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numRows.Location = new Point(385, 544);
            numRows.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            numRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRows.Name = "numRows";
            numRows.Size = new Size(120, 38);
            numRows.TabIndex = 514;
            numRows.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numRows.ValueChanged += NumRows_Changed;
            numRows.Click += numRowsClick;
            // 
            // lblArraySpeed
            // 
            lblArraySpeed.AutoSize = true;
            lblArraySpeed.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArraySpeed.ForeColor = SystemColors.ButtonFace;
            lblArraySpeed.Location = new Point(580, 230);
            lblArraySpeed.Margin = new Padding(4, 0, 4, 0);
            lblArraySpeed.Name = "lblArraySpeed";
            lblArraySpeed.Size = new Size(211, 20);
            lblArraySpeed.TabIndex = 515;
            lblArraySpeed.Text = "Array update speed (sec)";
            // 
            // nudArraySpeed
            // 
            nudArraySpeed.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudArraySpeed.Location = new Point(830, 212);
            nudArraySpeed.Margin = new Padding(4, 3, 4, 3);
            nudArraySpeed.Maximum = new decimal(new int[] { 210000, 0, 0, 0 });
            nudArraySpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudArraySpeed.Name = "nudArraySpeed";
            nudArraySpeed.Size = new Size(72, 38);
            nudArraySpeed.TabIndex = 516;
            nudArraySpeed.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudArraySpeed.ValueChanged += nudArraySpeed_ValueChanged;
            nudArraySpeed.Click += ArraySpeed_Click;
            // 
            // btnMetric
            // 
            btnMetric.BackColor = Color.ForestGreen;
            btnMetric.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMetric.ForeColor = SystemColors.ButtonFace;
            btnMetric.Location = new Point(330, 612);
            btnMetric.Margin = new Padding(4, 3, 4, 3);
            btnMetric.Name = "btnMetric";
            btnMetric.Size = new Size(175, 47);
            btnMetric.TabIndex = 517;
            btnMetric.Text = "Imperial ?";
            btnMetric.UseVisualStyleBackColor = false;
            btnMetric.Click += Metric_Click;
            // 
            // FormArduinoSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 70);
            ClientSize = new Size(933, 689);
            Controls.Add(btnMetric);
            Controls.Add(nudArraySpeed);
            Controls.Add(lblArraySpeed);
            Controls.Add(numRows);
            Controls.Add(btnPlanterSimulator);
            Controls.Add(lblCurDoubleFactor);
            Controls.Add(label4);
            Controls.Add(nudPlanterDoublesFactor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCurNumSections);
            Controls.Add(lblCurTargetSpeed);
            Controls.Add(lblCurRowWidth);
            Controls.Add(lblCurPopulation);
            Controls.Add(lblPMSS);
            Controls.Add(btnSendPlanterConfigPGN);
            Controls.Add(btnSeedAlarm);
            Controls.Add(btnPlanterMonitorActive);
            Controls.Add(nudPlantingSpeed);
            Controls.Add(nudRowSpacing);
            Controls.Add(nUDPopulation);
            Controls.Add(btnSavePlanterSettings);
            Controls.Add(label5);
            Controls.Add(lblPlantingSpeed);
            Controls.Add(lblRowSpacing);
            Controls.Add(lblTargetPopulation);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormArduinoSettings";
            Text = "Arduino Settings";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nUDPopulation).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRowSpacing).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlantingSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlanterDoublesFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudArraySpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTargetPopulation;
		private System.Windows.Forms.Label lblRowSpacing;
		private System.Windows.Forms.Label lblPlantingSpeed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSavePlanterSettings;
		private System.Windows.Forms.NumericUpDown nUDPopulation;
		private System.Windows.Forms.NumericUpDown nudRowSpacing;
		private System.Windows.Forms.NumericUpDown nudPlantingSpeed;
		private System.Windows.Forms.Button btnPlanterMonitorActive;
		private System.Windows.Forms.Button btnSeedAlarm;
		private System.Windows.Forms.Button btnSendPlanterConfigPGN;
		private System.Windows.Forms.Label lblPMSS;
		private System.Windows.Forms.Label lblCurPopulation;
		private System.Windows.Forms.Label lblCurRowWidth;
		private System.Windows.Forms.Label lblCurTargetSpeed;
		private System.Windows.Forms.Label lblCurNumSections;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudPlanterDoublesFactor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblCurDoubleFactor;
		private System.Windows.Forms.Button btnPlanterSimulator;
        private NumericUpDown numRows;
        private Label lblArraySpeed;
        private NumericUpDown nudArraySpeed;
        private Button btnMetric;
    }
}
