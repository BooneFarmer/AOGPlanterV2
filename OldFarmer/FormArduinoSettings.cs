using OpenTK.Audio.OpenAL;

namespace AOGPlanterV2.OldFarmer
//namespace AOGPlanterV2
{
    public partial class FormArduinoSettings : Form
    {
        private NumericUpDown nudUpDown;

        //        public float numberOfRows = 1;
        private AOPUDP udp = null;

        //private FormArduinoSettings fas = null;

        /// <summary>
        /// ///
        //		private readonly Form1 mf = null;
        private FormAOP mf = null;
        public FormArduinoSettings(Form callingForm)
        {
            mf = callingForm as FormAOP;
            udp = mf.udp;
            InitializeComponent();
            nudUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudUpDown).BeginInit();
            //            SuspendLayout();
            // 
            // numericUpDown1
            // 
            nudUpDown.DecimalPlaces = 2;
            //            nudUpDown.Location = new Point(50, 30);
            nudUpDown.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            nudUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUpDown.Name = "numericUpDown1";
            nudUpDown.Size = new Size(120, 23);
            nudUpDown.TabIndex = 0;
            nudUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });

            // numericUpDown1.Click += btnNumericUpDown;
            // 
            // Inputs
            // 
            // ClientSize = new Size(300, 150);
            Controls.Add(nudUpDown);
            Name = "Inputs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inputs";
            ((System.ComponentModel.ISupportInitialize)nudUpDown).EndInit();
            ResumeLayout(false);

        }/// 
         /// </summary>
        public FormArduinoSettings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //			nUDPopulation.Value = (decimal)mf.rc.rcTargetPopulation;
            numRows.Value = (int)AOGPlanterV2.Properties.Settings.Default.setPlanterNumRows;
            nUDPopulation.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterTargetPopulation;
            nudRowSpacing.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterRowWidth;
            nudPlantingSpeed.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterSpeed;
            nudPlanterDoublesFactor.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterDoublesFactor;
            nudArraySpeed.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterArraySpeed;
            //            int numberOfSections = AOGPlanterV2.Properties.Settings.Default.setPlanterNumRows;
            //            nudUpDown.Value = numberOfSections; // AOGPlanterV2.Properties.Settings.Default.setPlanterNumRows;
            lblCurNumSections.Text = mf.rc.fbNumSections.ToString();
            lblCurPopulation.Text = mf.rc.fbTargetPopulation.ToString();
            lblCurRowWidth.Text = mf.rc.fbRowWidth.ToString("N1");
            lblCurTargetSpeed.Text = mf.rc.fbTargetSpeed.ToString();
            lblCurDoubleFactor.Text = mf.rc.fbDoublesFactor.ToString("N2");

            if (AOGPlanterV2.Properties.Settings.Default.setPlanterAlarm_Active == true)
            {
                btnSeedAlarm.BackColor = System.Drawing.Color.Green;
                btnSeedAlarm.ForeColor = SystemColors.ButtonFace;
                btnSeedAlarm.Text = "Seed Alarm is Active";
            }
            else
            {
                btnSeedAlarm.BackColor = System.Drawing.Color.Red;
                btnSeedAlarm.ForeColor = SystemColors.ControlText;
                btnSeedAlarm.Text = "Seed Alarm is Off";
            }

            if (AOGPlanterV2.Properties.Settings.Default.setPlanter_Active == true)
            {
                btnPlanterMonitorActive.Text = "Planter Monitor is Active";
                btnPlanterMonitorActive.BackColor = System.Drawing.Color.Green;
                btnPlanterMonitorActive.ForeColor = SystemColors.ButtonFace;
            }
            else
            {
                btnPlanterMonitorActive.Text = "Planter Monitor is Off";
                btnPlanterMonitorActive.BackColor = System.Drawing.Color.Red;
                btnPlanterMonitorActive.ForeColor = SystemColors.ControlText;
            }

            if (AOGPlanterV2.Properties.Settings.Default.setMenu_isMetric)
            {
                lblTargetPopulation.Text = "Target Population (per ha)";
                lblPlantingSpeed.Text = "Planter Speed (kph)";
                lblRowSpacing.Text = "Row Spacing (cm)";
                //				nUDPopulation.Value = (decimal)(mf.rc.rcTargetPopulation * 2.471052f);
                //				nudPlantingSpeed.Value = (decimal)(mf.rc.rcTargetSpeed * 1.609344f);
                //				nudRowSpacing.Value = (decimal)(mf.rc.rcRowSpacing * 2.54f);
            }

            if (AOGPlanterV2.Properties.Settings.Default.setPlanterSimulator_Active == false)
            {
                btnPlanterSimulator.Text = "Simulator is Off";
                btnPlanterSimulator.BackColor = System.Drawing.Color.Green;
                btnPlanterSimulator.ForeColor = SystemColors.ControlText;
            }
            else
            {
                btnPlanterSimulator.Text = "Simulator is On";
                btnPlanterSimulator.BackColor = System.Drawing.Color.Red;
                btnPlanterSimulator.ForeColor = SystemColors.ButtonFace;
            }

            if (AOGPlanterV2.Properties.Settings.Default.setMenu_isMetric == false)
            {
                btnMetric.Text = "Imperial";
            }
            else
            {
                btnMetric.Text = "Metric Units";
            }
        }

        private void PMS_Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void nudPopulation_Click(object sender, EventArgs e)
        {
            using (var keypad = new NumericKeypad(nudUpDown.Value))
            {
                nudUpDown.DecimalPlaces = 1;
                //                nudUpDown.Location = new Point(50, 30);
                nudUpDown.Maximum = new decimal(new int[] { 210000, 0, 0, 0 });
                nudUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
                nudUpDown.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterTargetPopulation;
                keypad.StartPosition = FormStartPosition.CenterParent;
                keypad.ShowInTaskbar = false;
                keypad.Owner = this;
                keypad.TopMost = true;
                var result = keypad.ShowDialog(); // Show keypad

                if (result == DialogResult.OK)
                {
                    nudUpDown.Value = keypad.Result;
                }

                // Always return focus to numericUpDown1
                //numericUpDown1.Focus();
                nUDPopulation.Value = nudUpDown.Value;
                Properties.Settings.Default.setPlanterTargetPopulation = (float)nudUpDown.Value;
                btnSavePlanterSettings.Focus();
            }
        }


        private void nudPopulation_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.setPlanterTargetPopulation = (float)nUDPopulation.Value;
            Properties.Settings.Default.Save();
            btnSavePlanterSettings.Focus();
        }


        private void nudRowSpacing_Clicked(object sender, EventArgs e)
        {
            nudUpDown.DecimalPlaces = 1;
            //            nudUpDown.Location = new Point(50, 30);
            nudUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudUpDown.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            //                numericUpDown1.Minimum = new float.Single(new float[] { .1f, 0, 0, 0 });
            nudUpDown.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterRowWidth;
            using (var keypad = new NumericKeypad(nudUpDown.Value))
            {
                keypad.StartPosition = FormStartPosition.CenterParent;
                keypad.ShowInTaskbar = false;
                keypad.Owner = this;
                keypad.TopMost = true;
                var result = keypad.ShowDialog(); // Show keypad

                if (result == DialogResult.OK)
                {
                    nudUpDown.Value = keypad.Result;
                }

                // Always return focus to numericUpDown1
                //  numericUpDown1.Focus();
                nudRowSpacing.Value = nudUpDown.Value;
                Properties.Settings.Default.setPlanterRowWidth = (float)nudUpDown.Value;
                btnSavePlanterSettings.Focus();
            }
        }

        private void nudRowSpacing_valueChanged(object sender, EventArgs e)
        {
            AOGPlanterV2.Properties.Settings.Default.setPlanterRowWidth = (float)nudRowSpacing.Value;
            Properties.Settings.Default.Save();
            btnSavePlanterSettings.Focus();
        }

        private void nudPlantingSpeed_Clicked(object sender, EventArgs e)
        {
            nudUpDown.DecimalPlaces = 1;
            //            nudUpDown.Location = new Point(50, 30);
            nudUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUpDown.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterSpeed;
            using (var keypad = new NumericKeypad(nudUpDown.Value))
            {
                keypad.StartPosition = FormStartPosition.CenterParent;
                keypad.ShowInTaskbar = false;
                keypad.Owner = this;
                keypad.TopMost = true;
                var result = keypad.ShowDialog(); // Show keypad

                if (result == DialogResult.OK)
                {
                    nudUpDown.Value = keypad.Result;
                }

                // Always return focus to numericUpDown1
                //  numericUpDown1.Focus();
                nudPlantingSpeed.Value = nudUpDown.Value;
                Properties.Settings.Default.setPlanterSpeed = (float)nudUpDown.Value;
                Properties.Settings.Default.Save();
                btnSavePlanterSettings.Focus();
            }
        }

        private void nudPlantingSpeed_ValueChanged(object sender, EventArgs e)
        {
            AOGPlanterV2.Properties.Settings.Default.setPlanterSpeed = (float)nudPlantingSpeed.Value;
            Properties.Settings.Default.Save();
            btnSavePlanterSettings.Focus();

        }

        private void pmonitorActive_Clicked(object sender, EventArgs e)
        {
            if (AOGPlanterV2.Properties.Settings.Default.setPlanter_Active == true)
            {
                AOGPlanterV2.Properties.Settings.Default.setPlanter_Active = false;
                btnPlanterMonitorActive.Text = "Planter Monitor is Off";
                btnPlanterMonitorActive.BackColor = System.Drawing.Color.Red;
                btnPlanterMonitorActive.ForeColor = SystemColors.ControlText;

                AOGPlanterV2.Properties.Settings.Default.setPlanterSimulator_Active = false;
                btnPlanterSimulator.Text = "Simulator is Off";
                btnPlanterSimulator.BackColor = System.Drawing.Color.Green;
                btnPlanterSimulator.ForeColor = SystemColors.ControlText;

                //for (int i = 0; i <= mf.tool.numOfSections; i++)
                //{
                //    String curstate = mf.rc.GetCurrentState(i);
                //    if (!(curstate == "Normal"))
                //    {
                //        mf.rc.SetStateNormal(i);
                //    }
                //}
            }
            else
            {
                AOGPlanterV2.Properties.Settings.Default.setPlanter_Active = true;
                btnPlanterMonitorActive.Text = "Planter Monitor is Active";
                btnPlanterMonitorActive.BackColor = System.Drawing.Color.Green;
                btnPlanterMonitorActive.ForeColor = SystemColors.ButtonFace;
            }

        }

        private void seedAlarm_Clicked(object sender, EventArgs e)
        {
            if (AOGPlanterV2.Properties.Settings.Default.setPlanterAlarm_Active == true)
            {
                AOGPlanterV2.Properties.Settings.Default.setPlanterAlarm_Active = false;
                btnSeedAlarm.BackColor = System.Drawing.Color.Red;
                btnSeedAlarm.ForeColor = SystemColors.ButtonFace;
                btnSeedAlarm.Text = "Seed Alarm is Off";
                Properties.Settings.Default.Save();
            }
            else
            {
                AOGPlanterV2.Properties.Settings.Default.setPlanterAlarm_Active = true;
                btnSeedAlarm.BackColor = System.Drawing.Color.Green;
                btnSeedAlarm.ForeColor = SystemColors.ControlText;
                btnSeedAlarm.Text = "Seed Alarm is Active";
                Properties.Settings.Default.Save();
            }
        }


        private void btnSendPlanterConfigPGN_Click(object sender, EventArgs e)
        {
            SavePMSettings();
            //			SendMachineModulePort(mf.p_224.pgn, mf.p_224.pgn.Length);
            //mf.SendPgnToLoop(mf.p_224.pgn);

            //mf.TimedMessageBox(1000, gStr.gsAutoSteerPort, "Settings Sent To Planter Monitor Module");
            udp.p_224.pgn[udp.p_224.highRowWidthX10] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f) >> 8));
            udp.p_224.pgn[udp.p_224.lowRowWidthX10] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f));
            udp.p_224.pgn[udp.p_224.numSections] = (byte)Properties.Settings.Default.setPlanterNumRows;
            udp.p_224.pgn[udp.p_224.targetSpeedX10] = (byte)(Properties.Settings.Default.setPlanterSpeed * 10.0f);
            udp.p_224.pgn[udp.p_224.highTargetPopulation] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterTargetPopulation / 10) >> 8));
            udp.p_224.pgn[udp.p_224.lowTargetPopulation] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterTargetPopulation / 10));
            udp.p_224.pgn[udp.p_224.doublesFactor] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterDoublesFactor * 100.0f));
            if (Properties.Settings.Default.setMenu_isMetric)
            {
                udp.p_224.pgn[udp.p_224.isMetric] = unchecked((byte)(int)1);
            }
            else
            {
                udp.p_224.pgn[udp.p_224.isMetric] = unchecked((byte)(int)0);
            }
            udp.p_233.pgn[udp.p_233.arraySpeed] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterArraySpeed));
            udp.SendPgnToLoop(udp.p_224.pgn);
            udp.SendPgnToLoop(udp.p_233.pgn);
        }


        private void SavePMSettings()
        {
            //	mf.p_224.pgn[mf.p_224.highRowWidthX10] = unchecked((byte)((int)(AOGPlanterV2.Properties.Settings.Default.setPlanterRowWidth * 10.0f) >> 8));
            //	mf.p_224.pgn[mf.p_224.lowRowWidthX10] = unchecked((byte)(int)(AOGPlanterV2.Properties.Settings.Default.setPlanterRowWidth * 10.0f));
            //	mf.p_224.pgn[mf.p_224.numSections] = (byte)AOGPlanterV2.Properties.Settings.Default.setVehicle_numSections;
            //	mf.p_224.pgn[mf.p_224.targetSpeedX10] = (byte)(AOGPlanterV2.Properties.Settings.Default.setPlanterSpeed * 10.0f);
            //	mf.p_224.pgn[mf.p_224.highTargetPopulation] = unchecked((byte)((int)(AOGPlanterV2.Properties.Settings.Default.setPlanterTargetPopulation / 10) >> 8));
            //	mf.p_224.pgn[mf.p_224.lowTargetPopulation] = unchecked((byte)(int)(AOGPlanterV2.Properties.Settings.Default.setPlanterTargetPopulation / 10));
            //	mf.p_224.pgn[mf.p_224.doublesFactor] = unchecked((byte)(int)(AOGPlanterV2.Properties.Settings.Default.setPlanterDoublesFactor * 100.0f));
            //if (AOGPlanterV2.Properties.Settings.Default.setMenu_isMetric)
            //{
            //	mf.p_224.pgn[mf.p_224.isMetric] = unchecked((byte)(int)1);
            //}
            //else
            //{
            //	mf.p_224.pgn[mf.p_224.isMetric] = unchecked((byte)(int)0);
            //}

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AOGPlanterV2.Properties.Settings.Default.setPlanterDoublesFactor = (float)nudPlanterDoublesFactor.Value;
            btnSavePlanterSettings.Focus();
        }

        private void nudPlanterDoublesFactor_clicked(object sender, EventArgs e)
        {
            nudUpDown.DecimalPlaces = 2;
            //            nudUpDown.Location = new Point(50, 30);
            nudUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUpDown.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudUpDown.Value = (decimal)AOGPlanterV2.Properties.Settings.Default.setPlanterDoublesFactor;
            using (var keypad = new NumericKeypad(nudUpDown.Value))
            {
                keypad.StartPosition = FormStartPosition.CenterParent;
                keypad.ShowInTaskbar = false;
                keypad.Owner = this;
                keypad.TopMost = true;
                var result = keypad.ShowDialog(); // Show keypad

                if (result == DialogResult.OK)
                {
                    nudUpDown.Value = keypad.Result;
                }

                // Always return focus to numericUpDown1
                //  numericUpDown1.Focus();
                nudPlanterDoublesFactor.Value = nudUpDown.Value;
                Properties.Settings.Default.setPlanterDoublesFactor = (float)nudUpDown.Value;
                Properties.Settings.Default.Save();
                btnSavePlanterSettings.Focus();
            }

        }

        private void SimulatorClicked(object sender, EventArgs e)
        {
            if (AOGPlanterV2.Properties.Settings.Default.setPlanterSimulator_Active == true)
            {
                AOGPlanterV2.Properties.Settings.Default.setPlanterSimulator_Active = false;
                btnPlanterSimulator.Text = "Simulator is Off";
                btnPlanterSimulator.BackColor = System.Drawing.Color.Green;
                btnPlanterSimulator.ForeColor = SystemColors.ControlText;
                Properties.Settings.Default.Save();
            }
            else
            {
                AOGPlanterV2.Properties.Settings.Default.setPlanterSimulator_Active = true;
                btnPlanterSimulator.Text = "Simulator is On";
                btnPlanterSimulator.BackColor = System.Drawing.Color.Red;
                btnPlanterSimulator.ForeColor = SystemColors.ButtonFace;
                Properties.Settings.Default.Save();
            }

        }

        //private void nudUpDown_ValueChanged(object sender, EventArgs e)
        //{
        //    AOGPlanterV2.Properties.Settings.Default.setPlanterNumRows = numberOfRows;
        //    btnSavePlanterSettings.Focus();
        //}

        private void numRowsClick(object sender, EventArgs e)
        {
            nudUpDown.DecimalPlaces = 0;
            //            nudUpDown.Location = new Point(50, 30);
            nudUpDown.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            nudUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUpDown.Value = (decimal)Properties.Settings.Default.setPlanterNumRows;
            using (var keypad = new NumericKeypad(nudUpDown.Value))
            {
                keypad.StartPosition = FormStartPosition.CenterParent;
                keypad.ShowInTaskbar = false;
                keypad.Owner = this;
                keypad.TopMost = true;
                var result = keypad.ShowDialog(); // Show keypad

                if (result == DialogResult.OK)
                {
                    numRows.Value = keypad.Result;
                }

                // Always return focus to numericUpDown1
                //  NumericKeypad.Focus();
                //     numRows.Value = (decimal)numberOfRows;
                Properties.Settings.Default.setPlanterNumRows = (float)numRows.Value;
                Properties.Settings.Default.Save();
                btnSavePlanterSettings.Focus();
            }
        }

        private void NumRows_Changed(object sender, EventArgs e)
        {
            AOGPlanterV2.Properties.Settings.Default.setPlanterNumRows = (float)numRows.Value;
            Properties.Settings.Default.Save();
            btnSavePlanterSettings.Focus();
        }

        private void ArraySpeed_Click(object sender, EventArgs e)
        {
            nudUpDown.DecimalPlaces = 0;
            //            nudUpDown.Location = new Point(50, 30);
            nudUpDown.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUpDown.Value = Properties.Settings.Default.setPlanterArraySpeed;
            using (var keypad = new NumericKeypad(nudUpDown.Value))
            {
                keypad.StartPosition = FormStartPosition.CenterParent;
                keypad.ShowInTaskbar = false;
                keypad.Owner = this;
                keypad.TopMost = true;
                var result = keypad.ShowDialog(); // Show keypad

                if (result == DialogResult.OK)
                {
                    nudArraySpeed.Value = keypad.Result;
                }

                // Always return focus to numericUpDown1
                //  NumericKeypad.Focus();
                //     numRows.Value = (decimal)numberOfRows;
                Properties.Settings.Default.setPlanterArraySpeed = (int)nudArraySpeed.Value;
                Properties.Settings.Default.Save();
                btnSavePlanterSettings.Focus();
            }
        }

        private void nudArraySpeed_ValueChanged(object sender, EventArgs e)
        {
            AOGPlanterV2.Properties.Settings.Default.setPlanterArraySpeed = (int)nudArraySpeed.Value;
            Properties.Settings.Default.Save();
            btnSavePlanterSettings.Focus();

        }

        private void Metric_Click(object sender, EventArgs e)
        {
            if (AOGPlanterV2.Properties.Settings.Default.setMenu_isMetric == false)
            {
                AOGPlanterV2.Properties.Settings.Default.setMenu_isMetric = true;
                btnMetric.Text = "Metric Units";
            }
            else
            {
                AOGPlanterV2.Properties.Settings.Default.setMenu_isMetric = false;
                btnMetric.Text = "Imperial";
            }
        }
    }
}
