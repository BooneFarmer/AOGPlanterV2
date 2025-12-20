using System.Windows.Forms.DataVisualization.Charting;

namespace AOGPlanterV2
{
    public partial class FormSkipsChart : Form
    {
        private readonly FormAOP mf = null;
        int lastHelloFromPlanter = 0;
        int msgSpacer = 0;
        public event EventHandler TickSync;

        public FormSkipsChart(Form callingForm)
        {
            mf = callingForm as FormAOP;
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawChart();
            TickSync?.Invoke(this, EventArgs.Empty);
        }

        private void DrawChart()
        {
            Series s = skipChart.Series["Skips"];
            Series d = skipChart.Series["Doubles"];
            s.Points.Clear();
            d.Points.Clear();
            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                skipChart.Series["Skips"].Points.AddXY(i + 1, mf.rc.rcSkips[i]);
                skipChart.Series["Doubles"].Points.AddXY(i + 1, mf.rc.rcDoubles[i]);
            }
            skipChart.ResetAutoValues();

            msgSpacer++;
            if (msgSpacer > 100)
            {
                if (mf.rc.fbFeedbackCounter == lastHelloFromPlanter)
                {
//                    mf.lblDisconnected.Visible = true;
                    if (Properties.Settings.Default.setPlanterSimulator_Active == false)
                    {
                        //for (int kk = 0; kk < mf.tool.numOfSections; kk++)
                        //{
                        //    mf.rc.rcPopulation[kk] = 0;
                        //    mf.rc.rcPopulationPercent[kk] = 0;
                        //}
                    }
                    if (Properties.Settings.Default.setPlanterAlarm_Active && (Properties.Settings.Default.setPlanter_Active = true)) mf.sounds.sndDisconnected.Play();
                }
                else
                {
//                    mf.lblDisconnected.Visible = false;
                }
                msgSpacer = 0;
                lastHelloFromPlanter = mf.rc.fbFeedbackCounter;
            }

        }

        private void FormSkipChart_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            //			timer1.Interval = (int)((1 / (double)mf.fixUpdateHz) * 1000);
            if (Properties.Settings.Default.setPlanterAlarm_Active == true)
            {
                btnAlarm.BackColor = System.Drawing.Color.Green;
                btnAlarm.ForeColor = SystemColors.ButtonFace;
                btnAlarm.Text = "Alarm On";
            }
            else
            {
                btnAlarm.BackColor = System.Drawing.Color.Red;
                btnAlarm.ForeColor = SystemColors.ControlText;
                btnAlarm.Text = "Alarm Off";
            }
        }
        private void btnSkipExit(object sender, EventArgs e)
        {
            Close();
        }

        private void skipChart_Click(object sender, EventArgs e)
        {

        }

        private void AlarmClicked(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.setPlanterAlarm_Active == true)
            {
                Properties.Settings.Default.setPlanterAlarm_Active = false;
                btnAlarm.Text = "Alarm Off";
                btnAlarm.BackColor = System.Drawing.Color.Red;
                btnAlarm.ForeColor = SystemColors.ControlText;
            }
            else
            {
                Properties.Settings.Default.setPlanterAlarm_Active = true;
                btnAlarm.Text = "Alarm On";
                btnAlarm.BackColor = System.Drawing.Color.Green;
                btnAlarm.ForeColor = SystemColors.ButtonFace;
            }
        }
    }
}
