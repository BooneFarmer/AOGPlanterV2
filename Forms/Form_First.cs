using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AOGPlanterV2
{
    public partial class Form_First : Form
    {

        private readonly FormAOP mf = null;

        public Form_First(Form callingForm)
        {
            mf = callingForm as FormAOP;
            InitializeComponent();
        }

        private FormAOP formAOP;


        private void Form_About_Load(object sender, EventArgs e)
        {
            //lblVersion.Text = "Version " + Application.ProductVersion.ToString(CultureInfo.InvariantCulture);

            //// Add a link to the LinkLabel.
            //LinkLabel.Link link = new LinkLabel.Link { LinkData = "https://github.com/farmerbriantee/AgOpenPlanterV2" };
            //linkLabelGit.Links.Add(link);

            //// Add a link to the LinkLabel.
            //LinkLabel.Link linkCf = new LinkLabel.Link
            //{
            //    LinkData = "https://discourse.agopengps.com/"
            //};
            //linkLabelCombineForum.Links.Add(linkCf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsAccepted = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsAccepted = false;
            Properties.Settings.Default.Save();
            //Close();
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Disagree_click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsAccepted = false;
            Properties.Settings.Default.Save();
            //Close();
            Environment.Exit(0);

        }

        private void Agree_click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsAccepted = true;
            Properties.Settings.Default.Save();
//            Environment.Exit(0);
            this.Hide(); // Close the current form
            Form formG = new FormAOP();
            formG.ShowDialog();
 //           Application.Run(new FormAOP());

            //Form fst = Application.OpenForms["FormAOP"];
            //if (fst != null)
            //{
            //    fst.Focus();
            //    return;
            //}
//            Form fst = this;
 //           Form formF = new FormAOP();
 //           Application.Run(new FormAOP());
 //           formF.ShowDialog();
 //           fst.Close();
//            Environment.Exit(0);



        }
    }
}