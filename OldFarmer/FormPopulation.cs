using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AOGPlanterV2.OldFarmer
{
	public partial class PopulationChart2 : Form
	{
		private readonly FormAOP mf = null;

		public PopulationChart2(Form callingForm)
		{
			mf = callingForm as FormAOP;
			InitializeComponent();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			DrawChart();
		}

		private void DrawChart()
		{
			Series s = popChart2.Series["SeriesPop"];
			s.Points.Clear();
			for (int i = 0; i < mf.tool.numOfSections; i++)
			{
				popChart2.Series["SeriesPop"].Points.AddXY(i + 1, mf.rc.rcPopulation[i]);
			}
			lblTargetPop.Text = Properties.Settings.Default.setPlanterTargetPopulation.ToString();
			popChart2.ResetAutoValues();
		}
		
		public PopulationChart2()
		{
			InitializeComponent();
		}

		private void PopulationChart2_Load(object sender, EventArgs e)
		{
			timer1.Interval = 1;
		}

		private void btnExitPop_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnPopChart_Click(object sender, EventArgs e)
		{
			Close();
			Form formD = new OldFarmer.FormPopChart(mf);
			formD.Show(mf);
		}

		private void lblTargetPop_Click(object sender, EventArgs e)
		{

		}
	}
}
