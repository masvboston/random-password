namespace PasswordGenerator
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnClose = new System.Windows.Forms.Button();
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rtbPassword = new System.Windows.Forms.RichTextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 2;
            this.btnClose.ImageList = this.imgMain;
            this.btnClose.Location = new System.Drawing.Point(266, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.ttMain.SetToolTip(this.btnClose, "Close the application.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMain.Images.SetKeyName(0, "startwithoutdebugging_6556.png");
            this.imgMain.Images.SetKeyName(1, "Copy_6524.png");
            this.imgMain.Images.SetKeyName(2, "Clearallrequests_8816.png");
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.ImageIndex = 0;
            this.btnGenerate.ImageList = this.imgMain;
            this.btnGenerate.Location = new System.Drawing.Point(12, 115);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 34);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "&Generate";
            this.ttMain.SetToolTip(this.btnGenerate, "Generate a new random password \r\nand copy it to the clipboard.");
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(9, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(309, 26);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Click on the Generate button to create a new random password.\r\nThe new password i" +
    "s automatically copied to the clipboard.";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 51);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password is:";
            // 
            // rtbPassword
            // 
            this.rtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPassword.Location = new System.Drawing.Point(12, 67);
            this.rtbPassword.Name = "rtbPassword";
            this.rtbPassword.ReadOnly = true;
            this.rtbPassword.Size = new System.Drawing.Size(360, 34);
            this.rtbPassword.TabIndex = 4;
            this.rtbPassword.TabStop = false;
            this.rtbPassword.Text = "";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyToClipboard.ImageIndex = 1;
            this.btnCopyToClipboard.ImageList = this.imgMain;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(124, 115);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(106, 34);
            this.btnCopyToClipboard.TabIndex = 2;
            this.btnCopyToClipboard.Text = "&Copy";
            this.ttMain.SetToolTip(this.btnCopyToClipboard, "Copies the password to the clipboard.\r\nNote: the password is automatically copied" +
        "\r\nto the clipboard.  This button is just for\r\nnew users who are unsure.");
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(384, 152);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.rtbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 190);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Password Generator";
            this.Shown += new System.EventHandler(this.btnGenerate_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RichTextBox rtbPassword;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.ToolTip ttMain;
    }
}

