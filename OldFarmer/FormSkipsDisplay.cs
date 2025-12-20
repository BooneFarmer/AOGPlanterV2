//using System.Windows.Forms;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace AOGPlanterV2
{
    public class FormSkipsDisplay : Form
    {
        private readonly FormAOP mf;
       // private readonly System.Windows.Forms.Timer repaintTimer;
        private readonly int numOfSections;
        private const int HistoryRows = 10; // 1 live + 6 below
        private Color[,] colorBuffer;
        private int numSections;
        private DateTime lastUpdate = DateTime.MinValue;
        private readonly TimeSpan updateInterval = TimeSpan.FromSeconds(3);
        int gap = 6;   // pixels between rectangles

        public FormSkipsDisplay(FormAOP mainForm)
//        public FormSkipsDisplay(Form callingForm)
        {
                mf = mainForm;
            // mf = callingForm as FormAOP;

            // Subscribe to SkipsChart timer
            mf.skp.TickSync += OnChartTick;
            numOfSections = (int)Properties.Settings.Default.setPlanterNumRows;//(int)mf.tool.numOfSections;
            colorBuffer = new Color[HistoryRows, numOfSections];

            // Initialize everything green
            for (int r = 0; r < HistoryRows; r++)
                for (int c = 0; c < numOfSections; c++)
                    colorBuffer[r, c] = Color.Green;
            
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.Lime;          // pick a color that you don't use elsewhere
            TransparencyKey = Color.Lime;    // everything that color becomes transparent
            BackColor = Color.Black;
//            Opacity = 0.9;
            TopMost = true;

            Bounds = Screen.PrimaryScreen.Bounds;
            var screen = Screen.PrimaryScreen.WorkingArea;
            int rectHeight = screen.Height / 48;   // same value used in OnPaint
            int totalRowsHeight = HistoryRows * rectHeight;
            Height = totalRowsHeight + 10; // small padding
            Width = (int)(screen.Width /1.45f);
            int y = screen.Bottom - Height - (screen.Height / 12);
            Location = new Point(screen.Width/7, y);
            Size = new Size(Width, Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (mf?.rc == null) return;

            Graphics g = e.Graphics;

            int screenW = (int)(ClientSize.Width * 1.0f); // was /2
            int screenH = ClientSize.Height;
            int xOffset = (ClientSize.Width - screenW) / 2;

            int baseY = screenH - (screenH); // was / 4
            int rectHeight = screenH / 10;
//            int rectWidth = screenW / numOfSections;
            int totalGapWidth = gap * (numSections - 1);
            int rectWidth = (screenW - totalGapWidth) / numOfSections;

            for (int r = 0; r < HistoryRows; r++)
            {
                int y = baseY + (r * rectHeight);

                for (int c = 0; c < numOfSections; c++)
                {
                    using var brush = new SolidBrush(colorBuffer[r, c]);

                    Rectangle rect = new Rectangle(
                       xOffset + (c * rectWidth + gap),
                        y,
                        rectWidth - 2 - gap,
                        rectHeight - 4);

                    g.FillRectangle(brush, rect);

                    // Only number the top row
                    if (r == 0)
                    {
                        using var font = new Font("Segoe UI", 9, FontStyle.Bold);
                        using var textBrush = new SolidBrush(Color.Black);

                        string text = (c + 1).ToString();
                        SizeF size = g.MeasureString(text, font);

                        g.DrawString(
                            text,
                            font,
                            textBrush,
                            rect.X + (rect.Width - size.Width) / 2,
                            rect.Y + (rect.Height - size.Height) / 2);
                    }
                }
            }
        }


        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FormSkipsDisplay
            // 
            ClientSize = new Size(1449, 690);
            Name = "FormSkipsDisplay";
            Load += FormSkipsDisplay_Load;
            ResumeLayout(false);

        }

        private void FormSkipsDisplay_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private void OnChartTick(object sender, EventArgs e)
        {
            if (DateTime.UtcNow - lastUpdate < updateInterval)
                return;

            lastUpdate = DateTime.UtcNow;

            ShiftRowsDown();
            UpdateTopRowFromLiveData();
            Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mf.skp.TickSync -= OnChartTick;
            base.OnFormClosing(e);
        }
        private void ShiftRowsDown()
        {
            for (int r = HistoryRows - 1; r > 0; r--)
            {
                for (int c = 0; c < numOfSections; c++)
                {
                    colorBuffer[r, c] = colorBuffer[r - 1, c];
                }
            }
        }
        private void UpdateTopRowFromLiveData()
        {
            for (int i = 0; i < numOfSections; i++)
            {
                Color color = Color.Green;

                if (mf.rc.rcDoubles[i] > 0)
                    color = Color.Purple;

                if (mf.rc.rcSkips[i] > 0)
                    color = Color.Yellow; // overlays purple

                colorBuffer[0, i] = color;
            }
        }

    }
}
