using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TheDistructiveForFacebook.Forms;
using TheDistructiveForFacebook.Forms.Controls;

namespace TheDistructiveForFacebook
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        static ServerFB Server = new ServerFB();


        // SHOW USER CONTROLS
        BruterIDs  Bruter = new  BruterIDs();
        FetchIDs Fetch =new  FetchIDs();
        ReporterIDs Reporter = new ReporterIDs();

        private void ShowFetchIDsBTN_Click(object sender, EventArgs e)
        {
            Bruter.Visible = false;
            Reporter.Visible = false;

            panel2.Controls.Add(Fetch);
            Fetch.Dock = DockStyle.Fill;
            Fetch.Visible = true;
            Fetch.Invalidate();
        }
        private void ShowBruterIDsBTN_Click(object sender, EventArgs e)
        {
            Fetch.Visible = false;
            Reporter.Visible = false;

            panel2.Controls.Add(Bruter);
            Bruter.Dock = DockStyle.Fill;
            Bruter.Visible = true;
            Bruter.Invalidate();
        }

        private void ShowReporterIDsBTN_Click(object sender, EventArgs e)
        {
            Bruter.Visible = false;
            Fetch.Visible = false;

            panel2.Controls.Add(Reporter);
            Reporter.Dock = DockStyle.Fill;
            Reporter.Visible = true;
            Reporter.Invalidate();
        }

        // TITLE BAR ICONS WORKER
        private void AddAccountBTN_Click(object sender, EventArgs e)
        {
            AddAccount Frm = new AddAccount();
            Frm.Show();
        }

        private void PowerOFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        }
    }

