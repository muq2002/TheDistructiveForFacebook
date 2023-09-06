namespace TheDistructiveForFacebook.Forms.Tiwtter.UserControls
{
    partial class TiwtterFetchIDs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiwtterFetchIDs));
            this.listIDs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.ShowPro = new System.Windows.Forms.Label();
            this.progressIDs = new System.Windows.Forms.ProgressBar();
            this.StopBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textIDsCount = new System.Windows.Forms.TextBox();
            this.StartBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listIDs
            // 
            this.listIDs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listIDs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listIDs.FullRowSelect = true;
            this.listIDs.GridLines = true;
            this.listIDs.Location = new System.Drawing.Point(0, 111);
            this.listIDs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listIDs.Name = "listIDs";
            this.listIDs.Size = new System.Drawing.Size(778, 408);
            this.listIDs.TabIndex = 14;
            this.listIDs.UseCompatibleStateImageBehavior = false;
            this.listIDs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "*";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 200;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(119, 3);
            this.textID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(301, 28);
            this.textID.TabIndex = 13;
            this.textID.Text = "169165043789655";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username : ";
            // 
            // ClearBTN
            // 
            this.ClearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClearBTN.FlatAppearance.BorderSize = 0;
            this.ClearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBTN.ForeColor = System.Drawing.Color.White;
            this.ClearBTN.Image = ((System.Drawing.Image)(resources.GetObject("ClearBTN.Image")));
            this.ClearBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ClearBTN.Location = new System.Drawing.Point(671, 4);
            this.ClearBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(45, 52);
            this.ClearBTN.TabIndex = 22;
            this.ClearBTN.UseVisualStyleBackColor = false;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveBTN.FlatAppearance.BorderSize = 0;
            this.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBTN.ForeColor = System.Drawing.Color.White;
            this.SaveBTN.Image = ((System.Drawing.Image)(resources.GetObject("SaveBTN.Image")));
            this.SaveBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveBTN.Location = new System.Drawing.Point(720, 4);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(45, 52);
            this.SaveBTN.TabIndex = 21;
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // ShowPro
            // 
            this.ShowPro.AutoSize = true;
            this.ShowPro.Location = new System.Drawing.Point(510, 35);
            this.ShowPro.Name = "ShowPro";
            this.ShowPro.Size = new System.Drawing.Size(36, 20);
            this.ShowPro.TabIndex = 20;
            this.ShowPro.Text = "0 Of 0";
            // 
            // progressIDs
            // 
            this.progressIDs.Location = new System.Drawing.Point(425, 3);
            this.progressIDs.Name = "progressIDs";
            this.progressIDs.Size = new System.Drawing.Size(210, 28);
            this.progressIDs.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressIDs.TabIndex = 19;
            // 
            // StopBTN
            // 
            this.StopBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopBTN.FlatAppearance.BorderSize = 0;
            this.StopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBTN.ForeColor = System.Drawing.Color.White;
            this.StopBTN.Location = new System.Drawing.Point(357, 73);
            this.StopBTN.Margin = new System.Windows.Forms.Padding(2);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(63, 35);
            this.StopBTN.TabIndex = 18;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = false;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number Username";
            // 
            // textIDsCount
            // 
            this.textIDsCount.Location = new System.Drawing.Point(165, 41);
            this.textIDsCount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textIDsCount.Name = "textIDsCount";
            this.textIDsCount.Size = new System.Drawing.Size(255, 28);
            this.textIDsCount.TabIndex = 16;
            this.textIDsCount.Text = "50";
            // 
            // StartBTN
            // 
            this.StartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartBTN.FlatAppearance.BorderSize = 0;
            this.StartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBTN.ForeColor = System.Drawing.Color.White;
            this.StartBTN.Location = new System.Drawing.Point(290, 73);
            this.StartBTN.Margin = new System.Windows.Forms.Padding(2);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(63, 35);
            this.StartBTN.TabIndex = 15;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = false;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // TiwtterFetchIDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listIDs);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.ShowPro);
            this.Controls.Add(this.progressIDs);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIDsCount);
            this.Controls.Add(this.StartBTN);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "TiwtterFetchIDs";
            this.Size = new System.Drawing.Size(778, 519);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listIDs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label ShowPro;
        private System.Windows.Forms.ProgressBar progressIDs;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIDsCount;
        private System.Windows.Forms.Button StartBTN;
    }
}
