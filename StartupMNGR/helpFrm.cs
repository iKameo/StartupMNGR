using System;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace StartupMNGR
{
    public partial class helpFrm : Form
    {
        public helpFrm()
        {
            InitializeComponent();
        }

        private void helpFrm_Load(object sender, EventArgs e)
        {
            lbl_version.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lbl_built.Text = "Built on Friday, 08.11.2019 at 16:00 PM";
        }

        private void lbl_homepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ikameo.xyz");
        }
    }
}
