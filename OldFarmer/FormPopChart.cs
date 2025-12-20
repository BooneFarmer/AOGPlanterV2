using System.Windows.Forms.DataVisualization.Charting;

namespace AOGPlanterV2.OldFarmer
{
    public partial class FormPopChart : Form
    {

        private readonly FormAOP mf = null;

        public FormPopChart(Form callingForm)
        {
            mf = callingForm as FormAOP;
            InitializeComponent();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            Series s = popchart.Series["Population"];
            s.Points.Clear();
            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                popchart.Series["Population"].Points.AddXY(i + 1, mf.rc.rcPopulationPercent[i]);
            }
            lblGraphPop.Text = Properties.Settings.Default.setPlanterTargetPopulation.ToString();
            popchart.ResetAutoValues();

            for (int kk = 0; kk < mf.tool.numOfSections; kk++)
            {
                //					mf.rc.rcPopulation[kk] = 0;
                //					mf.rc.rcPopulationPercent[kk] = 0;
            }
        }
        private void FormPopChart_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1;
            //			timer1.Interval = (int)((1 / (double)mf.fixUpdateHz) * 1000);
        }
        private void popchart_Click(object sender, EventArgs e)
        {

        }

        private void btnExitPop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGraphPop_Click(object sender, EventArgs e)
        {

        }

        private void btnPopChart_Click(object sender, EventArgs e)
        {
            Close();

            Form formJ = new OldFarmer.PopulationChart2(mf);
            formJ.Show(mf);
        }
    }
}
