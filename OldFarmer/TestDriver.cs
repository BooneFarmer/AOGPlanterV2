using AOGPlanterV2;
using AOGPlanterV2.Properties;
using AOGPlanterV2.OF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOGPlanterV2
{
	public class OfTestDriver

	{

        private OfTestDriver()
		{
			timeSpacer = DateTimeOffset.UtcNow;
			graphSpacer = DateTimeOffset.UtcNow;
		}

        #region Constructor and Vars
        private static readonly OfTestDriver instance = new OfTestDriver();
        public static OfTestDriver Instance { get { return instance; } }
        private DateTimeOffset timeSpacer { get; set; }
        private DateTimeOffset graphSpacer { get; set; }
        private int SectionToDrive = 0;
        //		private string LastState = OfRowCrop.Normal;
        #endregion

        #region Ticker
        //		const int SecondsToUpdate = 1;
        const int SecondsForGraphUpdate = 3;  
		public void UpdateRc(FormAOP mf)
		{
			var now = DateTimeOffset.UtcNow;

			//if ((now - timeSpacer).TotalSeconds > SecondsToUpdate)
			//{
			//	TestDriver(mf);
			//	timeSpacer = now;
			//}
			 if ((now - graphSpacer).TotalSeconds > SecondsForGraphUpdate)
			{ 
				SimGraphs(mf);
				graphSpacer = now;
			}
		}
		#endregion

		#region Test Driver
		public void TestDriver(FormAOP mf)
		{

			//for (int i = 0; i <= mf.tool.numOfSections; i++)
			//{
			//	String curstate = mf.rc.GetCurrentState(i);
			//	if (!(curstate == OfRowCrop.Normal))
			//	{
			//		mf.rc.SetStateNormal(i);
			//	}
			//}

			//Random rnd = new Random();
			//for (SectionToDrive = 0; SectionToDrive < mf.tool.numOfSections; SectionToDrive++) { 
			//int num = rnd.Next(1, 100);

			//if (num > 1 && num < 3)
			//{
			//	mf.rc.SetStateDouble(SectionToDrive);
			//}
			//else if (num > 3 && num < 5)
			//{
			//	mf.rc.SetStateOut(SectionToDrive);
			//}
			//else if (num > 5 && num < 9)
			//{
			//	mf.rc.SetStateSkip(SectionToDrive);
			//}
			//else
			//{
			//	mf.rc.SetStateNormal(SectionToDrive);
			//}
//		}
			/*
						switch (LastState)
						{
							case "skip":
								mf.rc.SetStateDouble(SectionToDrive);
								break;
							case "double":
								mf.rc.SetStateOut(SectionToDrive);
								break;
							case "out":
								mf.rc.SetStateNormal(SectionToDrive);
								break;
							case OfRowCrop.Normal:
								mf.rc.SetStateSkip(SectionToDrive);
								break;
						}
						LastState = mf.rc.GetCurrentState(SectionToDrive);

						SectionToDrive++;
						if (SectionToDrive >= mf.tool.numOfSections)
							SectionToDrive = 0;
			*/
		}
		#endregion
		#region SimGraphs
		public void SimGraphs(FormAOP mf)
		{
			if (mf.rc.rcSkips[3] == 0)
			{
				mf.rc.rcSkips[0] = 0;
				mf.rc.rcSkips[3] = 3;
				mf.rc.rcSkips[6] = 1;
				mf.rc.rcSkips[8] = 6;
				mf.rc.rcDoubles[6] = 4;
				mf.rc.rcDoubles[13] = 2;
				mf.rc.rcDoubles[15] = 0;
				for (int i = 0; i < mf.tool.numOfSections; i++)
				{
					mf.rc.rcPopulation[i] = AOGPlanterV2.Properties.Settings.Default.setPlanterTargetPopulation;
					mf.rc.rcPopulationPercent[i] = 10f;
				}
				mf.rc.rcPopulation[3] = AOGPlanterV2.Properties.Settings.Default.setPlanterTargetPopulation * .95f;
				mf.rc.rcPopulation[6] = AOGPlanterV2.Properties.Settings.Default.setPlanterTargetPopulation * .90f;

			}
			else
			{
				mf.rc.rcSkips[0] = 1;
				mf.rc.rcSkips[3] = 0;
				mf.rc.rcSkips[6] = 0;
				mf.rc.rcSkips[8] = 3;
				mf.rc.rcDoubles[6] = 2;
				mf.rc.rcDoubles[13] = 0;
				mf.rc.rcDoubles[15] = 1;
				for (int i = 0; i < mf.tool.numOfSections; i++)
				{
					mf.rc.rcPopulation[i] = Properties.Settings.Default.setPlanterTargetPopulation;
					mf.rc.rcPopulationPercent[i] = 5.0f;
				}
				mf.rc.rcPopulation[2] = Properties.Settings.Default.setPlanterTargetPopulation * .85f;
				mf.rc.rcPopulation[7] = Properties.Settings.Default.setPlanterTargetPopulation * .95f;
			}
		}
		#endregion
	}
}
