using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDistructiveForFacebook.Forms
{
    public partial class OpenMain : Form
    {
        public OpenMain()
        {
            InitializeComponent();
        }

        private void OpenMain_Load(object sender, EventArgs e)
        {

        }

        private void ShowFetchIDsBTN_Click(object sender, EventArgs e)
        {
            Main Frm = new Main();
            Frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Compare_IDs Frm = new Compare_IDs();
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstagramMain Frm = new InstagramMain();
            Frm.Show();
        }
    }
}
