using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheDistructiveForFacebook.Forms
{
    public partial class Compare_IDs : Form
    {
        public Compare_IDs()
        {
            InitializeComponent();
        }

        private void SelectOneBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string Line = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Check File

                string FilePath = ofd.FileName;
                if (FilePath.IndexOf(".txt") == -1) FilePath += ".txt";
                // Write Path

                StreamReader sr = new StreamReader(FilePath);
                listBoxOne.Items.Clear();

                while (Line != null)
                {
                    Line = sr.ReadLine();
                    if (Line == null)
                    {
                        lblCount1.Text = "Count : " + listBoxOne.Items.Count;
                        sr.Close();
                        return;
                    }
                    listBoxOne.Items.Add(Line);
                    Application.DoEvents();
                }
                sr.Close();
            }

        }

        private void SelectTwoBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string Line = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Check File

                string FilePath = ofd.FileName;
                if (FilePath.IndexOf(".txt") == -1) FilePath += ".txt";
                // Write Path

             
                StreamReader sr = new StreamReader(FilePath);
                listBoxTwo.Items.Clear();

                while (Line != null)
                {
                    Line = sr.ReadLine();
                    if (Line == null)
                    {
                        lblCount2.Text = "Count : " + listBoxTwo.Items.Count;
                        sr.Close();
                        return;
                    }
                    listBoxTwo.Items.Add(Line);
                    Application.DoEvents();
                }
                sr.Close();
            }

        }

        private void RunBTN_Click(object sender, EventArgs e)
        {
            for (int parent = 0; parent <= listBoxOne.Items.Count - 1; parent++ )
            {
                 bool Check= false;
                for (int child = 0; child <= listBoxTwo.Items.Count - 1;child++ )
                {
                  
                    if (listBoxOne.Items[parent].ToString() == listBoxTwo.Items[child].ToString())
                    {
                        Check = true;
                        break;
                    }

                }

                if (Check != true)
                {
                    NewlistBox.Items.Add(listBoxOne.Items[parent].ToString());
                }
                Application.DoEvents();
                
            }

            lblCount3.Text = "Count : " + NewlistBox.Items.Count.ToString();
        }

        private void PowerOFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            // Preparing File To Save
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "File.txt";
            sfd.Filter = "Text|.txt";


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Check File
                string FilePath = sfd.FileName;
                if (FilePath.IndexOf(".txt") == -1) FilePath += ".txt";
                // Open Stream Writer
                System.IO.StreamWriter sw = new System.IO.StreamWriter(FilePath);

                // Write IDs
                for (int item = 0; item <= NewlistBox.Items.Count - 1; item++)
                {

                    sw.WriteLine(NewlistBox.Items[item].ToString());
                    Application.DoEvents();
                }
                // Close Stream Writer
                sw.Close();

            }
        }
    }
}
