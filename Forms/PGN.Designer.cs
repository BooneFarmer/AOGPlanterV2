using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AOGPlanterV2
{
	public partial class FormAOP
	{
        //*********************************************
        //Row Crop configB going out
        public class CPGN_E9
        {
            /// <Arduino configB>
            /// PGN - 233 - E9
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE9, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcConfigB = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            public int arraySpeed = 5;

            // PGN
            int crc = 0;

            public CPGN_E9()
            {
                pgn[arraySpeed] = 0;
            }


            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //Row Crop skips array data coming in
        public class CPGN_E8
        {
            /// <skip & doubles detail>
            /// PGN - 232 - E8
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE8, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcArraySkips = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E8()
            {
                rcArraySkips[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //*********************************************
        //Row Crop doubles array data coming in
        public class CPGN_E7
        {
            /// <doubles detail>
            /// PGN - 231 - E7
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE7, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcArrayDoubles = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E7()
            {
                rcArrayDoubles[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }


        //*********************************************
        //Row Crop data coming in
        public class CPGN_E6
		{
			/// <summary>
			/// PGN - 230 - E6
			/// Row data 1 to 8 in [6]
			/// Row data 9 to 16 in [7]
			/// </summary>
			public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE6, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


			//where in the pgn is data
			public int[] rcStatus = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



			// PGN 
			int crc = 0;

			public CPGN_E6()
			{
				rcStatus[3] = pgn[5] & 0b000011;  // first byte with data
				pgn[5] = ((byte)(pgn[5] >> 2));
				rcStatus[2] = pgn[5] & 0b000011;



			}
			public void MakeCRC()
			{
				crc = 0;
				for (int i = 2; i < pgn.Length - 1; i++)
				{
					crc += pgn[i];
				}
				pgn[pgn.Length - 1] = (byte)crc;
			}

			public void Reset()
			{
			}
		}

		//*********************************************
		//*********************************************
		//Row Crop data coming in
		public class CPGN_E5
		{
			/// <summary>
			/// PGN - 229 - E5
			/// Row crop summary population, etc.
			/// </summary>
			public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE5, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


			//where in the pgn is data
			public int[] rcSummary = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



			// PGN 
			int crc = 0;

			public CPGN_E5()
			{
				rcSummary[3] = pgn[5] & 0b000011;  // first byte with data
				pgn[5] = ((byte)(pgn[5] >> 2));
				rcSummary[2] = pgn[5] & 0b000011;



			}
			public void MakeCRC()
			{
				crc = 0;
				for (int i = 2; i < pgn.Length - 1; i++)
				{
					crc += pgn[i];
				}
				pgn[pgn.Length - 1] = (byte)crc;
			}

			public void Reset()
			{
			}
		}
        //*********************************************
        //Row Crop data coming in
        public class CPGN_E4
        {
            /// <skip & doubles detail>
            /// PGN - 228 - E4
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE4, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcSkips = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E4()
            {
                rcSkips[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }
        //*********************************************
        //Row Crop data coming in
        public class CPGN_E3
        {
            /// <doubles detail>
            /// PGN - 227 - E3
            /// Summary
            public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE3, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


            //where in the pgn is data
            public int[] rcDoubles = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // PGN 
            int crc = 0;

            public CPGN_E3()
            {
                rcDoubles[1] = pgn[5] & 0b000011;  // first byte with data

            }
            public void MakeCRC()
            {
                crc = 0;
                for (int i = 2; i < pgn.Length - 1; i++)
                {
                    crc += pgn[i];
                }
                pgn[pgn.Length - 1] = (byte)crc;
            }

            public void Reset()
            {
            }
        }

        //*********************************************
        //Row Crop data coming in
        public class CPGN_E2
		{
			/// <pop by row detail>
			/// PGN - 226 - E2
			/// Summary
			public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE2, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


			//where in the pgn is data
			public int[] rcPopByRow = { 0, 0, 0, 0, 0, 0, 0, 0 };

			// PGN 
			int crc = 0;

			public CPGN_E2()
			{
				rcPopByRow[1] = pgn[5] & 0b000011;  // first byte with data

			}
			public void MakeCRC()
			{
				crc = 0;
				for (int i = 2; i < pgn.Length - 1; i++)
				{
					crc += pgn[i];
				}
				pgn[pgn.Length - 1] = (byte)crc;
			}

			public void Reset()
			{
			}
		}

		//*********************************************
		//Row Crop data coming in
		public class CPGN_E1
		{
			/// <PopByRow detail>
			/// PGN - 225 - E1
			/// Summary
			public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE1, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


			//where in the pgn is data
			public int[] rcPop2ByRow = { 0, 0, 0, 0, 0, 0, 0, 0 };

			// PGN 
			int crc = 0;

			public CPGN_E1()
			{
				rcPop2ByRow[1] = pgn[5] & 0b000011;  // first byte with data

			}
			public void MakeCRC()
			{
				crc = 0;
				for (int i = 2; i < pgn.Length - 1; i++)
				{
					crc += pgn[i];
				}
				pgn[pgn.Length - 1] = (byte)crc;
			}

			public void Reset()
			{
			}
		}

		//*********************************************
		//Row Crop config going out
		public class CPGN_E0
		{
			/// <Arduino config>
			/// PGN - 224 - E0
			/// Summary
			public byte[] pgn = new byte[] { 0x80, 0x81, 0x7b, 0xE0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0xCC };


			//where in the pgn is data
			public int[] rcConfig = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			public int numSections = 5;
			public int targetSpeedX10 = 6;
			public int highRowWidthX10 = 7;
			public int lowRowWidthX10 = 8;
			public int highTargetPopulation = 9;
			public int lowTargetPopulation = 10;
			public int doublesFactor = 11;
			public int isMetric = 12;
			// PGN
			int crc = 0;

			public CPGN_E0()
			{
				pgn[numSections] = 0;
				pgn[targetSpeedX10] = 0;
				pgn[lowRowWidthX10] = 0;
				pgn[highRowWidthX10] = 0;
				pgn[highTargetPopulation] = 0;
				pgn[lowTargetPopulation] = 0;
				pgn[doublesFactor] = 0;
				pgn[isMetric] = 0;
			}


			public void MakeCRC()
			{
				crc = 0;
				for (int i = 2; i < pgn.Length - 1; i++)
				{
					crc += pgn[i];
				}
				pgn[pgn.Length - 1] = (byte)crc;
			}

			public void Reset()
			{
			}
		}
        //*********************************************
        //pgn instances

        /// <summary>
        /// autoSteerData - FE - 254 - 
        /// </summary>
        //public CPGN_FE p_254 = new CPGN_FE();

        //      /// <summary>
        //      /// autoSteerSettings PGN - 252 - FC
        //      /// </summary>
        //      public CPGN_FC p_252 = new CPGN_FC();

        //      /// <summary>
        //      /// autoSteerConfig PGN - 251 - FB
        //      /// </summary>
        //      public CPGN_FB p_251 = new CPGN_FB();


        //      /// <summary>
        //      /// machineData PGN - 239 - EF
        //      /// </summary>
        //      public CPGN_EF p_239 = new CPGN_EF();

        //      /// <summary>
        //      /// machineConfig PGN - 238 - EE
        //      /// </summary>
        //      public CPGN_EE p_238 = new CPGN_EE();

        //      /// <summary>
        //      /// relayConfig PGN - 236 - EC
        //      /// </summary>
        //      public CPGN_EC p_236 = new CPGN_EC();


        /// <summary>
        /// rowCropSkipsArray PGN 232 - E8
        /// </summary>
        public CPGN_E8 p_232 = new CPGN_E8();

            /// <summary>
            /// rowCropDoublesArray PGN 231 - E7
            /// </summary>
            public CPGN_E7 p_231 = new CPGN_E7();

            /// <summary>
            /// rowCropData PGN - 230 - E6
            /// </summary>
            public CPGN_E6 rcData = new CPGN_E6();

			/// <summary>
			/// rowCropSkipData PGN - 228 - E4
			/// </summary>
			public CPGN_E4 p_228 = new CPGN_E4();

			/// <summary>
			/// rowCropDoublesByRow PGN - 227 - E3
			/// </summary>
			public CPGN_E3 p_227 = new CPGN_E3();

			/// <summary>
			/// rowCropPopByRow PGN - 226 - E2
			/// </summary>
			public CPGN_E2 p_226 = new CPGN_E2();

			/// <summary>
			/// rowCropPopByRow PGN - 225 - E1
			/// </summary>
			public CPGN_E1 p_225 = new CPGN_E1();

			/// <summary>
			/// rowCropConfig PGN - 228 - E0
			/// </summary>
			public CPGN_E0 p_224 = new CPGN_E0();
		}
	}
    
