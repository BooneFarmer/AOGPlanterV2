using AOGPlanterV2.OF;
using AOGPlanterV2.OldFarmer;
using System.Net;
using System.Net.Sockets;
using System.Timers;

namespace AOGPlanterV2
{
    public partial class FormAOP : Form
    {

        //To bring forward AgIO if running
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWind, int nCmdShow);


        // UDP Socket
 //       private Socket UDPSocket;
 //       private EndPoint endPointUDP = new IPEndPoint(IPAddress.Any, 0);


        // Data stream
        private byte[] buffer = new byte[1024];
        public double nudNumber = 0;
        public double nudValue = 0;
        // row crop path
        public OfRowCrop rc;

        /// <summary>
        /// Sound
        /// </summary>
        public CSound sounds;

        public AOPUDP udp;

        private DateTime curTime;
        public FormAOP()
        {

            InitializeComponent();

             udp = new AOPUDP(this);
            //AOPUDP.msgCount
            //jim CheckSettingsNotNull();
            // Row Crop Planter Data
            rc = new OfRowCrop(this);
            lblSkipPercent.Text = "15.2%";
            lblDoublesPercent.Text = "2.4%";
            this.BackColor = Color.Lime;          // pick a color that you don't use elsewhere
            this.TransparencyKey = Color.Lime;    // everything that color becomes transparent

            tool = new CTool(this);
            sounds = new CSound();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1000 ms = 1 second
            timer1.Tick += Timer1_Tick; // attach event handler
            timer1.Start(); // start the timer

            //timerSim = new System.Windows.Forms.Timer();
            //timerSim.Interval = 93; // 1000 ms = 1 second
            //timerSim.Tick += TimerSim_Tick; // attach event handler
            //timerSim.Start(); // start the timer

            SetupTimer();
        }

        //Current directory of Tools
        public string toolsDirectory, toolFileName = "Tools";

        //current directory of Environments
        public string envDirectory, envFileName = "Env";

        //The base directory where AgOpenGPS will be stored and fields and vehicles branch from
        public string baseDirectory;

        private bool leftMouseDownOnOpenGL; //mousedown event in opengl window
        public int flagNumberPicked = 0;


        public CTool tool;
        private System.Timers.Timer timerSim;

        public void UpdatePopulation(string text)
        {
            if (InvokeRequired)
                Invoke((System.Windows.Forms.MethodInvoker)(() => txtPopulation.Text = text));
            else
                txtPopulation.Text = text;
        }


        private void SetupTimer()
        {
            // Create and configure timer
            timerSim = new System.Timers.Timer();
            timerSim.Interval = 93; // every 100 ms (10 times per second)
            timerSim.Elapsed += TimerSim_Elapsed;
            timerSim.AutoReset = true; // keeps repeating
            timerSim.Start(); // start automatically
        }

        // Generates a random number within a range.       
        //public double RandomNumber(double min, double max)
        //{
        //    return min + _random.NextDouble() * (max - min);
        //}

        //private readonly Random _random = new Random();
        public void UpdateSkipPercent(string value)
        {

            // Row Crop Planter Data
            lblSkipPercent.Text = value;
            //                       rc.rowSkip = 1;


        }
        public void UpdateDoublePercent(string value)
        {

            // Row Crop Planter Data
            lblDoublesPercent.Text = value;
            //            rc.rowSkip = 1;


        }

        private void Population_Click(object sender, EventArgs e)
        {
            //check if window already exists
            //            Form fcg = Application.OpenForms["FormSteerGraph"];
            Form fcg = Application.OpenForms["FormSkipsChart"];
            Form fch = Application.OpenForms["FormPopChart"];
            if (fcg != null)
            {
                fcg.Focus();
                return;
            }
            if (fch != null)
            {
                fch.Focus();
                return;
            }

            Form formH = new FormSkipsChart(this);
            Form formG = new OldFarmer.FormPopChart(this);
            formG.Show(this);
            formH.Show(this);
        }

        private void lblPopulation_Click(object sender, EventArgs e)
        {

        }

        private void lblSkipPercent_Click(object sender, EventArgs e)
        {

        }
        public bool KeypadToNUD(NumericUpDown sender, Form owner)
        {
            sender.BackColor = Color.Red;
            sender.Value = Math.Round(sender.Value, sender.DecimalPlaces);

            using (FormNumeric form = new FormNumeric((double)sender.Minimum, (double)sender.Maximum, (double)sender.Value))
            {
                DialogResult result = form.ShowDialog(owner);
                if (result == DialogResult.OK)
                {
                    sender.Value = (decimal)form.ReturnValue;
                    sender.BackColor = Color.AliceBlue;
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    sender.BackColor = Color.AliceBlue;
                }
                return false;
            }
        }

        public void KeyboardToText(TextBox sender, Form owner)
        {
            sender.BackColor = Color.Red;
            using (FormKeyboard form = new FormKeyboard(sender.Text))
            {
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    sender.Text = form.ReturnString;
                }
            }
            sender.BackColor = Color.AliceBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPopulation_Click_1(object sender, EventArgs e)
        {
            //check if window already exists
            //            Form fcg = Application.OpenForms["FormSteerGraph"];
            Form fcg = Application.OpenForms["FormSkipsChart"];
            Form fch = Application.OpenForms["FormPopChart"];
            if (fcg != null)
            {
                fcg.Focus();
                return;
            }
            if (fch != null)
            {
                fch.Focus();
                return;
            }

            Form formH = new FormSkipsChart(this);
            Form formG = new OldFarmer.FormPopChart(this);
            formG.Show(this);
            formH.Show(this);
        }

        private void on_Load(object sender, EventArgs e)
        {

            Form fst = Application.OpenForms["Form_First"];
            if (fst != null)
            {
                fst.Focus();
                return;
            }

            Form formF = new Form_First(this);
            formF.Show(this);
            formF.Focus();

            udp = new AOPUDP(this);  // create instance
            udp.StartHelloLoop("192.168.1.192", 9998);
            udp.StartUDPServer();
        }

        private void clickSetup(object sender, EventArgs e)
        {

            Form formA = new FormArduinoSettings(this);
            formA.Show(this);
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPopulation_Click(object sender, EventArgs e)
        {

        }

        private void txtSingulation_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtUpTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblPopulation.Text = rc.sumPopulation.ToString("F0");
            lblSingulation.Text = rc.sumSingulation.ToString("F1") + "%";
            lblSkipPercent.Text = rc.sumSkipPercent.ToString("F1") + "%";
            lblDoublesPercent.Text = rc.sumDoublePercent.ToString("F1") + "%";
            curTime = DateTime.Now;
            TimeSpan diff = curTime - rc.timeDataReceived;

            if (diff.TotalMilliseconds > 3500) {
                lblPopulation.Text = "0";
                lblSingulation.Text = "0%";
                lblSkipPercent.Text = "0%";
                lblDoublesPercent.Text = "0%";
                for (int kk = 0; kk < rc.fbNumSections; kk++)
                {
                    rc.rcPopulation[kk] = 0;
                    rc.rcPopulationPercent[kk] = 0;
                    rc.rcDoubles[kk] = 0;
                    rc.rcSkips[kk] = 0;
                }
                lblDisconnected.Visible = true;
            }
            else
            {
                lblDisconnected.Visible = false;
            }
 
        }

        private int tickCount = 0;

        private void TimerSim_Tick(object sender, EventArgs e)
        {
            tickCount++;
            txtPopulation.Text = $"Tick #{tickCount}";
            lblPopulation.Text = AOPUDP.msgCount.ToString();
            //   OfTestDriver.Instance.UpdateRc(this);
        }

        private void TimerSim_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Run background updates here
            if (Properties.Settings.Default.setPlanterSimulator_Active == true)
            {
                OfTestDriver.Instance.UpdateRc(this);
            }
            // If you need to update UI controls (labels, progress bars, etc.)
            // use Invoke() to run code safely on the UI thread:
            //this.Invoke((System.Windows.Forms.MethodInvoker)delegate
            //{
            //    txtSkips.Text = DateTime.Now.ToString("HH:mm:ss.fff");
            //});
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        //    }

    }
}

