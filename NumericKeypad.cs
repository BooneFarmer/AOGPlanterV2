using System.Globalization;

namespace AOGPlanterV2
{
    public partial class NumericKeypad : Form
    {
        private TextBox txtDisplay;
        private Button[] numButtons;
        private Button btnClear, btnOk, btnDot, btnBack, btnCancel;
        public decimal Result { get; private set; }

        public NumericKeypad(decimal initialValue = 0)
        {

            InitializeComponent();
            txtDisplay.Text = initialValue.ToString("0.##"); // Display the current value
        }

        private void InitializeComponent()
        {
            this.Text = "Numeric Keypad";
            this.ClientSize = new Size(360, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.BringToFront();    

            // Display box
            txtDisplay = new TextBox
            {
                Font = new Font("Segoe UI", 32, FontStyle.Bold),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                Location = new Point(20, 20),
                Size = new Size(320, 70),
                BackColor = Color.White
            };
            this.Controls.Add(txtDisplay);

            int btnWidth = 90, btnHeight = 70;
            int startX = 20, startY = 110;
            int padding = 10;

            // Numeric buttons 1–9
            numButtons = new Button[10];
            for (int i = 1; i <= 9; i++)
            {
                numButtons[i] = new Button
                {
                    Text = i.ToString(),
                    Font = new Font("Segoe UI", 22, FontStyle.Regular),
                    Size = new Size(btnWidth, btnHeight),
                    Location = new Point(startX + (i - 1) % 3 * (btnWidth + padding),
                                         startY + (i - 1) / 3 * (btnHeight + padding)),
                    BackColor = Color.WhiteSmoke
                };
                numButtons[i].Click += NumButton_Click;
                this.Controls.Add(numButtons[i]);
            }

            // Button 0
            numButtons[0] = new Button
            {
                Text = "0",
                Font = new Font("Segoe UI", 22),
                Size = new Size(btnWidth, btnHeight),
                Location = new Point(startX + btnWidth + padding, startY + 3 * (btnHeight + padding)),
                BackColor = Color.WhiteSmoke
            };
            numButtons[0].Click += NumButton_Click;
            this.Controls.Add(numButtons[0]);

            // Decimal point
            btnDot = new Button
            {
                Text = ".",
                Font = new Font("Segoe UI", 22),
                Size = new Size(btnWidth, btnHeight),
                Location = new Point(startX, startY + 3 * (btnHeight + padding)),
                BackColor = Color.WhiteSmoke
            };
            btnDot.Click += BtnDot_Click;
            this.Controls.Add(btnDot);

            // Backspace
            btnBack = new Button
            {
                Text = "←",
                Font = new Font("Segoe UI", 22),
                Size = new Size(btnWidth, btnHeight),
                Location = new Point(startX + 2 * (btnWidth + padding), startY + 3 * (btnHeight + padding)),
                BackColor = Color.WhiteSmoke
            };
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);

            // Clear
            btnClear = new Button
            {
                Text = "Clear",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Size = new Size(btnWidth, btnHeight),
                Location = new Point(startX, startY + 4 * (btnHeight + padding)),
                BackColor = Color.IndianRed,
                ForeColor = Color.White
            };
            btnClear.Click += BtnClear_Click;
            this.Controls.Add(btnClear);

            // OK
            btnOk = new Button
            {
                Text = "OK",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Size = new Size(btnWidth * 2 + padding, btnHeight),
                Location = new Point(startX + btnWidth + padding, startY + 4 * (btnHeight + padding)),
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White
            };
            btnOk.Click += BtnOk_Click;
            this.Controls.Add(btnOk);

            // Cancel (new button)
            btnCancel = new Button
            {
                Text = "Cancel",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Size = new Size(btnWidth * 3 + padding * 2, btnHeight),
                Location = new Point(startX, startY + 5 * (btnHeight + padding)),
                BackColor = Color.Gray,
                ForeColor = Color.White
            };
            btnCancel.Click += BtnCancel_Click;
            this.Controls.Add(btnCancel);
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string text = txtDisplay.Text;

            // Prevent more than 2 decimal digits
            if (text.Contains("."))
            {
                int index = text.IndexOf(".");
                if (text.Length - index > 2)
                    return;
            }

            if (text == "0" && btn.Text != ".")
                text = "";

            txtDisplay.Text = text + btn.Text;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                if (txtDisplay.Text.Length == 0)
                    txtDisplay.Text = "0.";
                else
                    txtDisplay.Text += ".";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal val))
            {
                Result = Math.Round(val, 2);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid number", "Error");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
