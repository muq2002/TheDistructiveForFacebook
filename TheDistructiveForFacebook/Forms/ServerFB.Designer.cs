namespace TheDistructiveForFacebook.Forms
{
    partial class ServerFB
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webFB1 = new System.Windows.Forms.WebBrowser();
            this.webFB2 = new System.Windows.Forms.WebBrowser();
            this.WebTwitter = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webFB1
            // 
            this.webFB1.Location = new System.Drawing.Point(0, 0);
            this.webFB1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFB1.Name = "webFB1";
            this.webFB1.Size = new System.Drawing.Size(368, 282);
            this.webFB1.TabIndex = 0;
            this.webFB1.Url = new System.Uri("", System.UriKind.Relative);
            this.webFB1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webFB_DocumentCompleted);
            // 
            // webFB2
            // 
            this.webFB2.Location = new System.Drawing.Point(374, 0);
            this.webFB2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFB2.Name = "webFB2";
            this.webFB2.Size = new System.Drawing.Size(368, 282);
            this.webFB2.TabIndex = 1;
            this.webFB2.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // WebTwitter
            // 
            this.WebTwitter.Location = new System.Drawing.Point(0, 288);
            this.WebTwitter.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebTwitter.Name = "WebTwitter";
            this.WebTwitter.Size = new System.Drawing.Size(368, 282);
            this.WebTwitter.TabIndex = 2;
            this.WebTwitter.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // ServerFB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 554);
            this.Controls.Add(this.WebTwitter);
            this.Controls.Add(this.webFB2);
            this.Controls.Add(this.webFB1);
            this.Name = "ServerFB";
            this.Text = "ServerFB";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webFB1;
        public System.Windows.Forms.WebBrowser webFB2;
        public System.Windows.Forms.WebBrowser WebTwitter;

    }
}