using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBWebExplorer
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        public AboutBox(WebBrowserTabPage webBrowserTabPage)
            : this()
        {
            _webBrowserTabPage = webBrowserTabPage;
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            productVersionLabel.Text = String.Format(productVersionLabel.Text, Application.ProductVersion);
            ieVersionLabel.Text = String.Format(ieVersionLabel.Text, _webBrowserTabPage.Browser.Version.Major.ToString());

            nbPictureBox.Image = nbImageList.Images[nbImageIndex];
        }

        private void nbPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            nbTimer.Enabled = !nbTimer.Enabled;
        }

        private void nbPictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nbImageCount = (nbImageCount == 3) ? 4 : 3;

            nbImageIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nbTimer_Tick(object sender, EventArgs e)
        {
            nbImageIndex = (nbImageIndex != nbImageCount) ? nbImageIndex + 1 : 0;

            nbPictureBox.Image = nbImageList.Images[nbImageIndex];
        }

        private WebBrowserTabPage _webBrowserTabPage;

        private Int32 nbImageIndex = 0;
        private Int32 nbImageCount = 3;
    }
}