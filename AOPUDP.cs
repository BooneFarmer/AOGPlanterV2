using AOGPlanterV2.OF;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace AOGPlanterV2
{
   public class AOPUDP 
    {
        public static UdpClient udpServer;
        private static Thread listenThread;
        private static int port = 9999; // Port to listen on
        private static AOPUDP udp;
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

        public void UpdateLabel(string text)
        {
            if (mf.InvokeRequired)
            {
                _ = mf.Invoke((MethodInvoker)(() => mf.txtSkips.Text = text));

            }
            else
            {
                mf.txtPopulation.Text = text;
            }
        }
        public void StartUDPServer()
        {
            if (mf.InvokeRequired)
            {
                _ = mf.Invoke((MethodInvoker)(() => mf.txtPopulation.Text = "1234"));

            }
            else
            {
                mf.txtPopulation.Text = "5678 from UDP";
                mf.rc.rcSkips[2] = 4;
            }

            udpServer = new UdpClient(port);
            listenThread = new Thread(new ThreadStart(ListenForMessages));
            listenThread.Start();

    //        udpServer.Close(); // where would I put this?
        }
        public static int msgCount = 0;

        private  void ListenForMessages()
        {
            while (true)
            {
                msgCount += 1;
                UpdateLabel("XOXO");
                try
                {
                    // Listen for UDP packets on the given port
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
                    byte[] data = udpServer.Receive(ref endPoint);
                    string receivedData = Encoding.UTF8.GetString(data);
                    msgCount += 1;
                    UpdateLabel("123");  // doesn't work
                    mf.rc.rcSkips[3] = 4;

                    //        udp.mf.UpdateLabel("123"); //"; // receivedData;
                    //                    Console.WriteLine($"Received: {receivedData} from {endPoint.Address}:{endPoint.Port}");
                    //if (mf != null)
                    //{ 
                   //if (mf.InvokeRequired)
                   // {
                   //         mf.Invoke((MethodInvoker)(() => mf.txtPopulation.Text = "OH!"));  //Population.Text = text));
                   // }

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
/*                switch (data[3])
                {
                    //// Feedback from Arduino Planter Monitor
/*
//                    case 224:
//                        {
//                            rc.fbNumSections = (int)data[5];
//                            rc.fbTargetSpeed = (float)data[6] / 10.0f;
//                            rc.fbRowWidth = ((float)(data[7] << 8) + (float)data[8]) * .1f; // + (float)data[8]; // ; mc.actualSteerAngleChart = (Int16)((data[6] << 8) + data[5]);
//                            rc.fbTargetPopulation = ((int)(data[9] << 8) + (float)data[10]) * 10.0f;
//                            rc.fbDoublesFactor = (float)data[11] / 100.0f;

//                            if (data[12] == 1)
//                            {
//                                rc.fbIsMetric = true;
//                            }
//                            else
//                            {
//                                rc.fbIsMetric = false;
//                            }
//                            if (rc.fbNumSections != Properties.Vehicle.Default.setVehicle_numSections ||
//                                    rc.fbTargetSpeed != Properties.Settings.Default.setPlanterSpeed ||
//                                    Math.Abs(rc.fbRowWidth - Properties.Settings.Default.setPlanterRowWidth) > .001 ||
//                                    rc.fbTargetPopulation != Properties.Settings.Default.setPlanterTargetPopulation ||
//                                    rc.fbDoublesFactor != Properties.Settings.Default.setPlanterDoublesFactor ||
//                                    rc.fbIsMetric != Properties.Settings.Default.setMenu_isMetric)
//                            {
///* sending data
//                                p_224.pgn[p_224.highRowWidthX10] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f) >> 8));
//                                p_224.pgn[p_224.lowRowWidthX10] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterRowWidth * 10.0f));
//                                p_224.pgn[p_224.numSections] = (byte)Properties.Vehicle.Default.setVehicle_numSections;
//                                p_224.pgn[p_224.targetSpeedX10] = (byte)(Properties.Settings.Default.setPlanterSpeed * 10.0f);
//                                p_224.pgn[p_224.highTargetPopulation] = unchecked((byte)((int)(Properties.Settings.Default.setPlanterTargetPopulation / 10) >> 8));
//                                p_224.pgn[p_224.lowTargetPopulation] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterTargetPopulation / 10));
//                                p_224.pgn[p_224.doublesFactor] = unchecked((byte)(int)(Properties.Settings.Default.setPlanterDoublesFactor * 100.0f));
//                                if (Properties.Settings.Default.setMenu_isMetric)
//                                {
//                                    p_224.pgn[p_224.isMetric] = unchecked((byte)(int)1);
//                                }
//                                else
//                                {
//                                    p_224.pgn[p_224.isMetric] = unchecked((byte)(int)0);
//                                }

//                                SendPgnToLoop(p_224.pgn);

//                           //     TimedMessageBox(2000, gStr.gsAutoSteerPort, "Settings Sent To Planter Monitor Module");
//                            } // end case
//                            break;
//                        }
                    //// Population by row ////
                    case 225:
                        {
                            int popIndex = 7;
                            for (int i = 5; i < 13; i++)
                            {
                                popIndex += 1;
                                //								if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                //								rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / (float.Parse(Properties.Settings.Default.setPlanterTargetPopulation))) - 100f;
                                rc.rcPopulation[popIndex] = data[i] * 1000f;
                                rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                if (rc.rcPopulationPercent[popIndex] < -15f) rc.rcPopulationPercent[popIndex] = -15f;
                                if (rc.rcPopulationPercent[popIndex] > 115f) rc.rcPopulationPercent[popIndex] = 115f;

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
                                //								if (data[i] < 0) data[i] = 250;  // occurs with overflow situation
                                rc.rcPopulation[popIndex] = data[i] * 1000f;
                                rc.rcPopulationPercent[popIndex] = (data[i] * 100000f / Properties.Settings.Default.setPlanterTargetPopulation) - 100f;
                                if (rc.rcPopulationPercent[popIndex] < -15f) rc.rcPopulationPercent[popIndex] = -15f;
                                if (rc.rcPopulationPercent[popIndex] > 115f) rc.rcPopulationPercent[popIndex] = 115f;
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
                                rc.rcDoubles[doubleIndex] = (byte)data[i] & 0b000111;
                                data[i] = ((byte)(data[i] >> 4));
                                doubleIndex -= 1;
                                rc.rcDoubles[doubleIndex] = (byte)data[i] & 0b000111;
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
                                rc.rcSkips[skipIndex] = (byte)data[i] & 0b000111;
                                data[i] = ((byte)(data[i] >> 4));
                                skipIndex -= 1;
                                rc.rcSkips[skipIndex] = (byte)data[i] & 0b000111;
                            }
                            break;
                        }
                    //// Row crop summary ////
                    case 229:
                        {
                            population = (Int16)((data[6] << 8) + data[5]);
                            population *= 10;
                            singulation = (Int16)((data[12] << 8) + data[11]);
                            singulation = singulation / 10;
                            skipPercent = (Int16)((data[8] << 8) + data[7]);
                            skipPercent = skipPercent / 10;
                            doublesPercent = (Int16)((data[10] << 8) + data[9]);
                            doublesPercent = doublesPercent / 10;
                            break;
                        }
                    //// Row crop status by row -- sets color ////
                    case 230:   // test by Jim to catch row sensor state 16 rows stored in data[5] and data[6]
                          {


                            int jptest = 0;
                            int numToTest = 4;
                            if (tool.numOfSections < 4) numToTest = tool.numOfSections;
                            for (int i = 0; i < numToTest; i++)
                             {
                                jptest = data[5];
                                jptest = (byte)data[5] & 0b000011;
                                if (jptest == 0)
                                {
                                    rc.SetStateNormal(i);
                                }
                                else if (jptest == 1)
                                {
                                    rc.SetStateOut(i);
                                    if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                }
                                else if (jptest == 2)
                                {
                                    rc.SetStateSkip(i);
                                }
                                else if (jptest == 3)
                                {
                                    rc.SetStateDouble(i);
                                }

                                data[5] = ((byte)(data[5] >> 2));
                            }

                            numToTest = 8;
                            if (tool.numOfSections < 8) numToTest = tool.numOfSections;
                            for (int i = 4; i < numToTest; i++)
                            {
                                jptest = data[6] & 0b000011;
                                if (jptest == 0)
                                {
                                    rc.SetStateNormal(i);
                                }
                                else if (jptest == 1)
                                {
                                    rc.SetStateOut(i);
                                    if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                }
                                else if (jptest == 2)
                                {
                                    rc.SetStateSkip(i);
                                }
                                else if (jptest == 3)
                                {
                                    rc.SetStateDouble(i);
                                }

                                data[6] = ((byte)(data[6] >> 2));
                            }

                            numToTest = 12;
                            if (tool.numOfSections < 12) numToTest = tool.numOfSections;
                            for (int i = 8; i < numToTest; i++)
                            {
                                jptest = data[7] & 0b000011;
                                if (jptest == 0)
                                {
                                    rc.SetStateNormal(i);
                                }
                                else if (jptest == 1)
                                {
                                    rc.SetStateOut(i);
                                    if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                }
                                else if (jptest == 2)
                                {
                                    rc.SetStateSkip(i);
                                }
                                else if (jptest == 3)
                                {
                                    rc.SetStateDouble(i);
                                }

                                data[7] = ((byte)(data[7] >> 2));
                            }

                            numToTest = 16;
                            if (tool.numOfSections < 16) numToTest = tool.numOfSections;
                            for (int i = 12; i < numToTest; i++)
                            {
                                jptest = data[8] & 0b000011;
                                if (jptest == 0)
                                {
                                    rc.SetStateNormal(i);
                                }
                                else if (jptest == 1)
                                {
                                    rc.SetStateOut(i);
                                    if (Properties.Settings.Default.setPlanterAlarm_Active) sounds.sndDisconnected.Play();
                                }
                                else if (jptest == 2)
                                {
                                    rc.SetStateSkip(i);
                                }
                                else if (jptest == 3)
                                {
                                    rc.SetStateDouble(i);
                                }

                                data[8] = ((byte)(data[8] >> 2));
                            }

                            rc.fbFeedbackCounter = (int)data[9];

                            break;

                          }
                    }
*/
                       }
                }
                catch (Exception ex)
                {
                    //                    Console.WriteLine($"Error receiving message: {ex.Message}");
                }

            }
        }
        
                  // Call to update the label safely

   }
}


