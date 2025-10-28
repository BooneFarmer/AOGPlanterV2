using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOGPlanterV2.OF
{
	public class OfRowCrop
	{
		#region Constructor and Vars
		public const string Normal = "normal";

        private FormAOP mf { get; }
        //		private Dictionary<string, vec3> conditionLookup { get; set; }
        private Dictionary<int, SectionState> sectionState { get; set; }
		public OfRowCrop(FormAOP _f)
		{
			mf = _f;
			InitSkip();
//			InitSectionState();
		}
		//where in the pgn is data
		public int[] rcRowStatus = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		public int[] rcSkips = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		public int[] rcDoubles = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		public float[] rcPopulation = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		public float[] rcPopulationPercent = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		public int fbNumSections = 0;
		public float fbRowWidth = 0.0f;
		public float fbTargetSpeed = 0.0f;
		public float fbTargetPopulation = 0.0f;
		public float fbDoublesFactor = 0.0f;
		public int fbFeedbackCounter = 0;
		public bool fbIsMetric = false;

		internal class SectionState
		{
			public string state { get; set; }
			public bool changed { get; set; }

			public void ChangeState(string state)
			{
				if (this.state != state)
				{
					this.state = state;
					changed = true;
				}
			}
			public string GetCurrentState() { return state; }
			public string GetState() { changed = false; return GetCurrentState(); }
			public bool HasStateChanged() { return changed; }
		}
		private void InitSectionState()
		{
			sectionState = new Dictionary<int, SectionState>();

			for (int j = 0; j < mf.tool.numOfSections + 1; j++)
				sectionState.Add(j, new SectionState() { state = Normal, changed = true });
		}

		private void InitSkip()
		{
		//	conditionLookup = new Dictionary<string, vec3>();
		//	conditionLookup.Add("skip", new vec3(255, 255, 0)); // yellow
		//	conditionLookup.Add("double", new vec3(200, 35, 200)); // purple
		//	conditionLookup.Add("out", new vec3(255, 0, 0));  // red
		}
		#endregion

		#region Color Control
		public bool HasChanged(int section)
		{
			// something changed so force a repaint
			if (sectionState[section].changed)
			{
				sectionState[section].changed = false;
				return true;
			}
			else
				return false;
		}
		public bool IsNormal()
		{
			for (int j = 0; j < mf.tool.numOfSections; j++)
				if (!IsNormal(j))
					return false;

			return true;
		}
		public bool IsNormal(int section)
		{
			var currentState = sectionState[section].GetCurrentState();
			if (currentState == Normal)
				return true;
			else
				return false;

		}
		//public vec3 GetColor(int section)
		//{
		//	if (!IsNormal(section))
		//		return conditionLookup[sectionState[section].GetState()];
		//	else if (!mf.tool.isMultiColoredSections)
		//		return new vec3(mf.sectionColorDay.R, mf.sectionColorDay.G, mf.sectionColorDay.B);
		//	else
		//		return new vec3(mf.tool.secColors[section].R, mf.tool.secColors[section].G, mf.tool.secColors[section].B);
		//}

		public void SetStateSkip(int section) { if (sectionState.ContainsKey(section)) sectionState[section].ChangeState("skip"); }
		public void SetStateDouble(int section) { sectionState[section].ChangeState("double"); }
		public void SetStateOut(int section) { sectionState[section].ChangeState("out"); }
		public void SetStateNormal(int section) { sectionState[section].ChangeState(Normal); }
		public bool HasStateChanged(int section) { return sectionState[section].HasStateChanged(); }
		public string GetCurrentState(int section) { return sectionState.ContainsKey(section) ? sectionState[section].GetCurrentState() : Normal; }
		#endregion
	}
}
