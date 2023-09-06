using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDistructiveForFacebook;

namespace TheDistructiveForFacebook.Forms
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textIDsCount_TextChanged(object sender, EventArgs e)
        {

        }

        //static ServerFB Frm = new ServerFB();
        //static Main Frm2 = new Main();
        private void StartBTN_Click(object sender, EventArgs e)
        {
            //if(textID.Text.Trim() != "" && textPassword.Text.Trim() !="")
            //{
            //    Frm.webFB2.Navigate("www.facebook.com");
            //    while (Frm.webFB2.ReadyState == WebBrowserReadyState.Complete | Frm.webFB2.IsBusy) Application.DoEvents();
            //    Frm.Show();
            //    // Add e-mail
            //    Frm.webFB2.Document.GetElementsByTagName("input")[6].InnerText = textID.Text;
            //    // Add Password
            //    Frm.webFB2.Document.GetElementsByTagName("input")[7].InnerText = textID.Text;
            //    // Login Button Cilck
            //    Frm.webFB2.Document.GetElementsByTagName("input")[8].InvokeMember("click");
            //    while (Frm.webFB2.ReadyState == WebBrowserReadyState.Complete | Frm.webFB2.IsBusy) Application.DoEvents();
            //    Frm2.lblLoginState.Text = "Login State: On";
            //}
        }

        private void StopBTN_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
