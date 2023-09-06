using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDistructiveForFacebook.Forms.Controls
{
    public partial class ReporterIDs : UserControl
    {
        public ReporterIDs()
        {
            InitializeComponent();
        }
        static TheDistructiveForFacebook.Forms.ServerFB Server = new TheDistructiveForFacebook.Forms.ServerFB();
        private void progressIDs_Click(object sender, EventArgs e)
        {

        }

        private void ReporterIDs_Load(object sender, EventArgs e)
        {

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if(textIDAdd.Text.Trim() != "" && textIDPassword.Text.Trim() !="")
            {
                listIDs.Items.Add(textIDAdd.Text).SubItems.Add(textIDPassword.Text);
                textIDAdd.Text = "";
                textIDPassword.Text = "";
            }
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            Server.webFB2.Navigate("m.facebook.com");
            while (Server.webFB2.ReadyState == WebBrowserReadyState.Complete | Server.webFB2.IsBusy) Application.DoEvents();

            // Find Support or Report Profile
            for(int x = 0 ; x <= Server.webFB2.Document.GetElementsByTagName("a").Count -1 ;x++)
            {
                string href = Server.webFB2.Document.GetElementsByTagName("a")[x].InnerText;
                if ( href == "Find Support or Report Profile")
                {
                    Server.webFB2.Document.GetElementsByTagName("a")[x].InvokeMember("click");
                }
            }
            while (Server.webFB2.ReadyState == WebBrowserReadyState.Complete | Server.webFB2.IsBusy) Application.DoEvents();


            // Fake Account
            for (int x = 0; x <= Server.webFB2.Document.GetElementsByTagName("input").Count - 1; x++)
            {
                string href = Server.webFB2.Document.GetElementsByTagName("input")[x].GetAttribute("value").ToString();
                if (href == "profile_fake_account")
                {
                    Server.webFB2.Document.GetElementsByTagName("input")[x].InvokeMember("click");
                }
            }

            // Submit
            for (int x = 0; x <= Server.webFB2.Document.GetElementsByTagName("input").Count - 1; x++)
            {
                string href = Server.webFB2.Document.GetElementsByTagName("input")[x].GetAttribute("value").ToString();
                if (href == "Submit")
                {
                    Server.webFB2.Document.GetElementsByTagName("input")[x].InvokeMember("click");
                }
            }
            while (Server.webFB2.ReadyState == WebBrowserReadyState.Complete | Server.webFB2.IsBusy) Application.DoEvents();


            // Report profile
            for (int x = 0; x <= Server.webFB2.Document.GetElementsByTagName("input").Count - 1; x++)
            {
                string href = Server.webFB2.Document.GetElementsByTagName("input")[x].GetAttribute("value").ToString();
                if (href == "FRX_PROFILE_REPORT_CONFIRMATION")
                {
                    Server.webFB2.Document.GetElementsByTagName("input")[x].InvokeMember("click");
                }
            }
            // Submit
            for (int x = 0; x <= Server.webFB2.Document.GetElementsByTagName("input").Count - 1; x++)
            {
                string href = Server.webFB2.Document.GetElementsByTagName("input")[x].GetAttribute("value").ToString();
                if (href == "Submit")
                {
                    Server.webFB2.Document.GetElementsByTagName("input")[x].InvokeMember("click");
                }
            }
            while (Server.webFB2.ReadyState == WebBrowserReadyState.Complete | Server.webFB2.IsBusy) Application.DoEvents();


            // I believe that this goes against Facebook's Community Standards
            for (int x = 0; x <= Server.webFB2.Document.GetElementsByTagName("input").Count - 1; x++)
            {
                string href = Server.webFB2.Document.GetElementsByTagName("input")[x].GetAttribute("value").ToString();
                if (href == "yes")
                {
                    Server.webFB2.Document.GetElementsByTagName("input")[x].InvokeMember("click");
                }
            }
            // Report
            for (int x = 0; x <= Server.webFB2.Document.GetElementsByTagName("input").Count - 1; x++)
            {
                string href = Server.webFB2.Document.GetElementsByTagName("input")[x].GetAttribute("value").ToString();
                if (href == "Report")
                {
                    Server.webFB2.Document.GetElementsByTagName("input")[x].InvokeMember("click");
                }
            }
            while (Server.webFB2.ReadyState == WebBrowserReadyState.Complete | Server.webFB2.IsBusy) Application.DoEvents();

            // Now Logout 

        }
    }
}
