
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AOGPlanterV2
{
    public class AOPUDP
    {
        public static UdpClient udpServer;
        private static Thread listenThread;
        private static int port = 9998; // Port to listen on
        private static AOPUDP udp;
        private float summaryPopulation = 32000.0f;
        private float summarySingulation = 96.7f;
        private float summaryDoublePercent = 1.1f;
        private float summarySkipPercent = 2.2f;
        private byte[] myByteData = {0x00};

       

        private FormAOP mf;
        //        private OfRowCrop rc;  
        public AOPUDP(FormAOP _form)
        {
            mf = _form;
        }
        //        public AOPUDP(OfRowCrop _r)
        //        {
        //            rc = _r;
        //        }

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
        }

            //*********************************************
            //Row Crop array data coming in
            public class CPGN_E8
        {
            /// <skip & doubles detail>
            /// PGN - 228 - E4
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
        //Row Crop array data coming in
        public class CPGN_E7
        {
            /// <doubles detail>
            /// PGN - 227 - E3
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
        public void UpdateLabel(string text)
        {
            if (udp.mf.InvokeRequired)
            {
                udp.mf.Invoke((MethodInvoker)(() => udp.mf.txtSkips.Text = text));

            }
            else
            {
                udp.mf.txtPopulation.Text = text;
            }
        }


        //*********************************************
        //pgn instances

        /// <summary>
        /// rowCropData PGN - 233 - E9
        /// </summary>
        public CPGN_E9 p_233 = new CPGN_E9();
        /// <summary>
        /// rowCropData PGN - 232 - E8
        /// </summary>
        public CPGN_E8 p_232 = new CPGN_E8();
        /// <summary>
        /// rowCropData PGN - 231 - E7
        /// </summary>
        public CPGN_E7 p_231 = new CPGN_E7();
        /// <summary>
        /// rowCropData PGN - 230 - E6
        /// </summary>
        public CPGN_E6 rcData = new CPGN_E6();
        /// <summary>
        /// rowCropData PGN - 230 - E6
        /// </summary>
        public CPGN_E5 p_229 = new CPGN_E5();

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

        public void StartUDPServer()
        {
         /*    //This area used foe tresting
          if (mf.InvokeRequired)
          {
              _ = mf.Invoke((MethodInvoker)(() => mf.txtPopulation.Text = "1234"));

          }
          else
          {
              mf.txtPopulation.Text = "5678 from UDP"; // this is displayed
              udp.mf.rc.rcSkips[2] = 3;
          }
          */
            udpServer = new UdpClient(port);
            listenThread = new Thread(new ThreadStart(ListenForMessages));
            listenThread.Start();

            //        udpServer.Close(); // where would I put this?
        }
        public static int msgCount = 0;

        private void ListenForMessages()
        {
            //udp.mf.rc.rcSkips[4] = 5;  // for testing.  This works
            while (true)
            {
                msgCount += 1;
               //                 UpdateLabel("XOXO");  // this test works
               //                 udp.mf.rc.rcSkips[3] = 4;
                

                try
                {
                    // Listen for UDP packets on the given port
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = udpServer.Receive(ref endPoint);
                    string receivedData = Encoding.UTF8.GetString(data);
                    msgCount += 1;
                  // UpdateLabel("123");  // works if AgOpenGPS is started
//                    mf.rc.rcSkips[5] = 6;  // likewise

                    if (data.Length > 4 && data[0] == 0x80 && data[1] == 0x81)
                    {
                        int Length = Math.Max((data[4]) + 5, 5);
                        if (data.Length > Length)
                        {
                            byte CK_A = 0;
                            for (int j = 2; j < Length; j++)
                            {
                                CK_A += data[j];
                            }

                            if (data[Length] != (byte)CK_A)
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                        switch (data[3])
                        {
                            //// Feedback from Arduino Planter Monitor

                            case 224:
                                {
                                    mf.rc.fbNumSections = (int)data[5];
                                    mf.rc.fbTargetSpeed = (float)data[6] / 10.0f;
                                    mf.rc.fbRowWidth = ((float)(data[7] << 8) + (float)data[8]) * .1f; // + (float)data[8]; // ; mc.actualSteerAngleChart = (Int16)((data[6] << 8) + data[5]);
                                    mf.rc.fbTargetPopulation = ((int)(data[9] << 8) + (float)data[10]) * 10.0f;
                                    mf.rc.fbDoublesFactor = (float)data[11] / 100.0f;

                                    if (data[12] == 1)
                                    {
                                        mf.rc.fbIsMetric = true;
                                    }
                                    else
                                    {
                                        mf.rc.fbIsMetric = false;
                                    }
                                    if (mf.rc.fbNumSections != Properties.Settings.Default.setPlanterNumRows ||
                                            mf.rc.fbTargetSpeed != Properties.Settings.Default.setPlanterSpeed ||
                                            Math.Abs(mf.rc.fbRowWidth - Properties.Settings.Default.setPlanterRowWidth) > .001 ||
                                            mf.rc.fbTargetPopulation != Properties.Settings.Default.setPlanterTargetPopulation ||
                                            mf.rc.fbDoublesFactor != Properties.Settings.Default.setPlanterDoublesFactor ||
                                            mf.rc.fbIsMetric != Properties.Settings.Default.setMenu_isMetric)
                                    {

                                        // sending data

                                        p_224.pgn[p_224.highRowWidthX10] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f) >> 8));
                                        p_224.pgn[p_224.lowRowWidthX10] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f));
                                        p_224.pgn[p_224.numSections] = (byte)Properties.Settings.Default.setPlanterNumRows;
                                        p_224.pgn[p_224.targetSpeedX10] = (byte)(Properties.Settings.Default.setPlanterSpeed * 10.0f);
                                        p_224.pgn[p_224.highTargetPopulation] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterTargetPopulation / 10) >> 8));
                                        p_224.pgn[p_224.lowTargetPopulation] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterTargetPopulation / 10));
                                        p_224.pgn[p_224.doublesFactor] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterDoublesFactor * 100.0f));
                                        if (Properties.Settings.Default.setMenu_isMetric)
                                        {
                                            p_224.pgn[p_224.isMetric] = unchecked((byte)(int)1);
                                        }
                                        else
                                        {
                                            p_224.pgn[p_224.isMetric] = unchecked((byte)(int)0);
                                        }

                                        SendPgnToLoop(p_224.pgn);

                                        //     TimedMessageBox(2000, gStr.gsAutoSteerPort, "Settings Sent To Planter Monitor Module");
                                    } // end case
                                    break;
                                }

                            //// Population by row ////
                            case 225:
                                {
                                    int popIndex = 7;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        popIndex += 1;
                                        //	if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                        //	rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / (float.Parse(Properties.Settings.Default.setPlanterTargetPopulation))) - 100f;
                                        mf.rc.rcPopulation[popIndex] = data[i] * 1000f;
                                        mf.rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                        if (mf.rc.rcPopulationPercent[popIndex] < -15f) mf.rc.rcPopulationPercent[popIndex] = -15f;
                                        if (mf.rc.rcPopulationPercent[popIndex] > 115f) mf.rc.rcPopulationPercent[popIndex] = 115f;

                                    }
                                    break;
                                }


                            //// Population by row ////
                            case 226:
                                {
                                    int popIndex = -1;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        popIndex += 1;
                                        //	if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                        mf.rc.rcPopulation[popIndex] = data[i] * 1000f;
                                        mf.rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                        if (mf.rc.rcPopulationPercent[popIndex] < -15f) mf.rc.rcPopulationPercent[popIndex] = -15f;
                                        if (mf.rc.rcPopulationPercent[popIndex] > 115f) mf.rc.rcPopulationPercent[popIndex] = 115f;
                                    }
                                    break;
                                }
                            //// Doubles by row ////
                            case 227:
                                {

                                    int doubleIndex = -2;

                                    for (int i = 5; i < 13; i++)
                                    {
                                        doubleIndex += 3;
                                        mf.rc.rcDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        doubleIndex -= 1;
                                        mf.rc.rcDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                            //// Skips by row ////
                            case 228:
                                {
                                    int skipIndex = -2;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        skipIndex += 3;
                                        mf.rc.rcSkips[skipIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        skipIndex -= 1;
                                        mf.rc.rcSkips[skipIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                            //// Row crop summary ////
                            case 229:
                                {
                                    summaryPopulation = (Int16)((data[6] << 8) + data[5]);
                                    summaryPopulation *= 10;
                                    summarySingulation = (Int16)((data[12] << 8) + data[11]);
                                    summarySingulation = summarySingulation / 10;
                                    summarySkipPercent = (Int16)((data[8] << 8) + data[7]);
                                    summarySkipPercent = summarySkipPercent / 10;
                                    summaryDoublePercent = (Int16)((data[10] << 8) + data[9]);
                                    summaryDoublePercent = summaryDoublePercent / 10;
                                    mf.rc.sumSkipPercent = summarySkipPercent;
                                    mf.rc.sumDoublePercent = summaryDoublePercent;
                                    mf.rc.sumPopulation = summaryPopulation;
                                    mf.rc.sumSingulation = summarySingulation;
                                    mf.rc.timeDataReceived = DateTime.Now;
                                    break;
                                }
                            ////// Row crop status by row -- sets color ////
                            //case 230:   // test by Jim to catch row sensor state 16 rows stored in data[5] and data[6]
                            //    {


                            //        int jptest = 0;
                            //        int numToTest = 4;
                            //        if (tool.numOfSections < 4) numToTest = tool.numOfSections;
                            //        for (int i = 0; i < numToTest; i++)
                            //        {
                            //            jptest = data[5];
                            //            jptest = (byte)data[5] & 0b000011;
                            //            if (jptest == 0)
                            //            {
                            //                udp.mf.rc.SetStateNormal(i);
                            //            }
                            //            else if (jptest == 1)
                            //            {
                            //                udp.mf.rc.SetStateOut(i);
                            //                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                            //            }
                            //            else if (jptest == 2)
                            //            {
                            //                udp.mf.rc.SetStateSkip(i);
                            //            }
                            //            else if (jptest == 3)
                            //            {
                            //                udp.mf.rc.SetStateDouble(i);
                            //            }

                            //            data[5] = ((byte)(data[5] >> 2));
                            //        }

                            //        numToTest = 8;
                            //        if (tool.numOfSections < 8) numToTest = tool.numOfSections;
                            //        for (int i = 4; i < numToTest; i++)
                            //        {
                            //            jptest = data[6] & 0b000011;
                            //            if (jptest == 0)
                            //            {
                            //                udp.mf.rc.SetStateNormal(i);
                            //            }
                            //            else if (jptest == 1)
                            //            {
                            //                udp.mf.rc.SetStateOut(i);
                            //                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                            //            }
                            //            else if (jptest == 2)
                            //            {
                            //                udp.mf.rc.SetStateSkip(i);
                            //            }
                            //            else if (jptest == 3)
                            //            {
                            //                udp.mf.rc.SetStateDouble(i);
                            //            }

                            //            data[6] = ((byte)(data[6] >> 2));
                            //        }

                            //        numToTest = 12;
                            //        if (tool.numOfSections < 12) numToTest = tool.numOfSections;
                            //        for (int i = 8; i < numToTest; i++)
                            //        {
                            //            jptest = data[7] & 0b000011;
                            //            if (jptest == 0)
                            //            {
                            //                udp.mf.rc.SetStateNormal(i);
                            //            }
                            //            else if (jptest == 1)
                            //            {
                            //                udp.mf.rc.SetStateOut(i);
                            //                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                            //            }
                            //            else if (jptest == 2)
                            //            {
                            //                udp.mf.rc.SetStateSkip(i);
                            //            }
                            //            else if (jptest == 3)
                            //            {
                            //                udp.mf.rc.SetStateDouble(i);
                            //            }

                            //            data[7] = ((byte)(data[7] >> 2));
                            //        }

                            //        numToTest = 16;
                            //        if (tool.numOfSections < 16) numToTest = tool.numOfSections;
                            //        for (int i = 12; i < numToTest; i++)
                            //        {
                            //            jptest = data[8] & 0b000011;
                            //            if (jptest == 0)
                            //            {
                            //                udp.mf.rc.SetStateNormal(i);
                            //            }
                            //            else if (jptest == 1)
                            //            {
                            //                udp.mf.rc.SetStateOut(i);
                            //                if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                            //            }
                            //            else if (jptest == 2)
                            //            {
                            //                udp.mf.rc.SetStateSkip(i);
                            //            }
                            //            else if (jptest == 3)
                            //            {
                            //                udp.mf.rc.SetStateDouble(i);
                            //            }

                            //            data[8] = ((byte)(data[8] >> 2));
                            //        }

                            //        udp.mf.rc.fbFeedbackCounter = (int)data[9];

                            //        break;

                            //    }
                            //// Doubles array by row ////
                            case 232:
                                {

                                    int doubleIndex = -2;

                                    for (int i = 5; i < 13; i++)
                                    {
                                        doubleIndex += 3;
                                        mf.rc.rcArrayDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        doubleIndex -= 1;
                                        mf.rc.rcArrayDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                            //// Skips array by row ////
                            case 231:
                                {
                                    int skipIndex = -2;
                                    for (int i = 5; i < 13; i++)
                                    {
                                        skipIndex += 3;
                                        mf.rc.rcArraySkips[skipIndex] = (byte)data[i] & 0b000111;
                                        data[i] = ((byte)(data[i] >> 4));
                                        skipIndex -= 1;
                                        mf.rc.rcArraySkips[skipIndex] = (byte)data[i] & 0b000111;
                                    }
                                    break;
                                }
                        }

                    }
                }
                catch (Exception ex)
                {
                    //                    Console.WriteLine($"Error receiving message: {ex.Message}");
                }
            }
        }
        //    }
        public void SendPgnToLoop(byte[] byteData)
        {
            //UdpClient client = new UdpClient();
            udpServer.Send(byteData, byteData.Length, "192.168.1.192", 9998);
        }
        public void StartHelloLoop(string targetIp, int targetPort)
        {
            new Thread(() =>
            {
                using (UdpClient udp = new UdpClient())
                {
                    byte[] data = Encoding.ASCII.GetBytes("hello");

                    while (true)
                    {
                        udp.Send(data, data.Length, "192.168.1.192", 9998);
                        Thread.Sleep(1000); // once per second
                    }
                }
            })
            { IsBackground = true }.Start();
        }

    }
}



