namespace TheDistructiveForFacebook.Forms.Controls
{
    partial class ReporterIDs
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
            this.listIDs = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textIDVctim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPro = new System.Windows.Forms.Label();
            this.progressIDs = new System.Windows.Forms.ProgressBar();
            this.StopBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textIDsCount = new System.Windows.Forms.TextBox();
            this.StartBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.textIDAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textIDPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listIDs
            // 
            this.listIDs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listIDs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listIDs.FullRowSelect = true;
            this.listIDs.GridLines = true;
            this.listIDs.Location = new System.Drawing.Point(0, 135);
            this.listIDs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listIDs.Name = "listIDs";
            this.listIDs.Size = new System.Drawing.Size(778, 384);
            this.listIDs.TabIndex = 14;
            this.listIDs.UseCompatibleStateImageBehavior = false;
            this.listIDs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Password";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Report State";
            this.columnHeader6.Width = 200;
            // 
            // textIDVctim
            // 
            this.textIDVctim.Location = new System.Drawing.Point(119, 3);
            this.textIDVctim.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textIDVctim.Name = "textIDVctim";
            this.textIDVctim.Size = new System.Drawing.Size(301, 28);
            this.textIDVctim.TabIndex = 13;
            this.textIDVctim.Text = "2447708308809466";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vctim ID :";
            // 
            // ShowPro
            // 
            this.ShowPro.AutoSize = true;
            this.ShowPro.Location = new System.Drawing.Point(383, 65);
            this.ShowPro.Name = "ShowPro";
            this.ShowPro.Size = new System.Drawing.Size(36, 20);
            this.ShowPro.TabIndex = 20;
            this.ShowPro.Text = "0 Of 0";
            // 
            // progressIDs
            // 
            this.progressIDs.Location = new System.Drawing.Point(119, 65);
            this.progressIDs.Name = "progressIDs";
            this.progressIDs.Size = new System.Drawing.Size(234, 20);
            this.progressIDs.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressIDs.TabIndex = 19;
            this.progressIDs.Click += new System.EventHandler(this.progressIDs_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopBTN.FlatAppearance.BorderSize = 0;
            this.StopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBTN.ForeColor = System.Drawing.Color.White;
            this.StopBTN.Location = new System.Drawing.Point(357, 97);
            this.StopBTN.Margin = new System.Windows.Forms.Padding(2);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(63, 35);
            this.StopBTN.TabIndex = 18;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "No. Procedure :";
            // 
            // textIDsCount
            // 
            this.textIDsCount.Location = new System.Drawing.Point(119, 33);
            this.textIDsCount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textIDsCount.Name = "textIDsCount";
            this.textIDsCount.Size = new System.Drawing.Size(301, 28);
            this.textIDsCount.TabIndex = 16;
            this.textIDsCount.Text = "50";
            // 
            // StartBTN
            // 
            this.StartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartBTN.FlatAppearance.BorderSize = 0;
            this.StartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBTN.ForeColor = System.Drawing.Color.White;
            this.StartBTN.Location = new System.Drawing.Point(290, 97);
            this.StartBTN.Margin = new System.Windows.Forms.Padding(2);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(63, 35);
            this.StartBTN.TabIndex = 15;
            this.StartBTN.Text = "Report";
            this.StartBTN.UseVisualStyleBackColor = false;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBTN);
            this.groupBox1.Controls.Add(this.textIDAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textIDPassword);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(425, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 135);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Accounts";
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddBTN.FlatAppearance.BorderSize = 0;
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBTN.ForeColor = System.Drawing.Color.White;
            this.AddBTN.Location = new System.Drawing.Point(270, 95);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(63, 35);
            this.AddBTN.TabIndex = 22;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // textIDAdd
            // 
            this.textIDAdd.Location = new System.Drawing.Point(115, 22);
            this.textIDAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textIDAdd.Name = "textIDAdd";
            this.textIDAdd.Size = new System.Drawing.Size(218, 28);
            this.textIDAdd.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // textIDPassword
            // 
            this.textIDPassword.Location = new System.Drawing.Point(115, 57);
            this.textIDPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textIDPassword.Name = "textIDPassword";
            this.textIDPassword.Size = new System.Drawing.Size(218, 28);
            this.textIDPassword.TabIndex = 20;
            // 
            // ReporterIDs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listIDs);
            this.Controls.Add(this.textIDVctim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPro);
            this.Controls.Add(this.progressIDs);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIDsCount);
            this.Controls.Add(this.StartBTN);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReporterIDs";
            this.Size = new System.Drawing.Size(778, 519);
            this.Load += new System.EventHandler(this.ReporterIDs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listIDs;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textIDVctim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShowPro;
        private System.Windows.Forms.ProgressBar progressIDs;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIDsCount;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.TextBox textIDAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIDPassword;
    }
}
