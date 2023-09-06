using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDistructiveForFacebook.Forms;

namespace TheDistructiveForFacebook.Forms
{
    public partial class FetchIDs : UserControl
    {
        public FetchIDs()
        {
            InitializeComponent();
        }
        static ServerFB Server = new ServerFB();
        static bool state;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            Server.webFB1.ScrollBarsEnabled = true;
            state = true;
            if (state == true)
            {
                if (textIDsCount.Text == "" || textID.Text == "")
                {
                    MessageBox.Show("There Error In Register Data !", "The Distructive", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int MemberGroup = Convert.ToInt32(textIDsCount.Text);
                int GetMemberGroup = 0;

                int URLs;
                progressIDs.Minimum = 0; progressIDs.Maximum = MemberGroup;
                progressIDs.Value = 0;

                Server.webFB1.Navigate("https://www.facebook.com/groups/" + textID.Text + "/members/");
                    while (Server.webFB1.ReadyState == WebBrowserReadyState.Complete | Server.webFB1.IsBusy) Application.DoEvents();

                   

                    // Now We Can Work
                    while (GetMemberGroup < MemberGroup)
                    {
                        progressIDs.Value = GetMemberGroup;
                        ShowPro.Text = GetMemberGroup + " Of " + MemberGroup;

                        URLs = Server.webFB1.Document.GetElementsByTagName("a").Count - 1;
                        

                        // This For Loop Do And Fetch  New Account
                        for (int x = 0; x <= URLs; x = x + 2)
                        {
                            if (listIDs.Items.Count == MemberGroup || listIDs.Items.Count >= MemberGroup || state == false)
                            {
                                progressIDs.Value = GetMemberGroup;
                                ShowPro.Text = GetMemberGroup + " Of " + MemberGroup;
                                return;
                            }
                            else 
                            {
                                listIDs.Items.Clear();
                                string NoID = listIDs.Items.Count.ToString();
                                string URL = Server.webFB1.Document.GetElementsByTagName("a")[x].OuterHtml;
                                if (URL.IndexOf("hc_location=group") > -1)
                                {
                                    if (URL.IndexOf("user.php?id=") > -1)
                                    {
                                        // Preparing To Add 
                                        string NameURL = Server.webFB1.Document.GetElementsByTagName("a")[x].GetAttribute("title").ToString();
                                        URL = URL.Substring(URL.IndexOf("user.php?id") + 12);
                                        string IDsURL = URL.Substring(0, 15);

                                        // Ready To Add 
                                        if(IDsURL.IndexOf("&amp;") == -1)
                                        {
                                            listIDs.Items.Add(NoID + 1).SubItems.Add(IDsURL);
                                            listIDs.Items[Convert.ToInt32(NoID)].SubItems.Add(NameURL);
                                        }
                                        
                                    }
                                }
                            }

                                GetMemberGroup = listIDs.Items.Count;

                            }
                            // Refresh ListView
                            Application.DoEvents();
                            //  Get ScrollBar Down
                            Server.webFB1.Document.Window.ScrollTo(0, 300000);
                            System.Threading.Thread.Sleep(100);
                            //while (Server.webFB.ReadyState == WebBrowserReadyState.Complete | Server.webFB.IsBusy) Application.DoEvents();
                            URLs = Server.webFB1.Document.GetElementsByTagName("a").Count - 1;
                            // Refresh Application
                            Application.DoEvents();
                        }

                    }

            }
        

        private void StopBTN_Click(object sender, EventArgs e)
        {
            state = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listIDs.Items.Clear();
           // Server.Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            // Preparing File To Save
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text|.txt";
            sfd.FileName = "File";
        
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                // Check File
                string FilePath = sfd.FileName;
                if (FilePath.IndexOf(".txt") == -1) FilePath += ".txt";
                // Open Stream Writer
                System.IO.StreamWriter sw = new System.IO.StreamWriter(FilePath);

                // Write IDs
                for (int item = 0; item <= listIDs.Items.Count - 1; item++)
                {

                    sw.WriteLine(listIDs.Items[item].SubItems[1].Text);
                    Application.DoEvents();
                }
                // Close Stream Writer
                sw.Close();

            }

        }

        private void listIDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
