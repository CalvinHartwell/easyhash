namespace easyhash
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
            this.tbPlainText = new System.Windows.Forms.TextBox();
            this.tbHashOutput = new System.Windows.Forms.TextBox();
            this.cbAlgorithms = new System.Windows.Forms.ComboBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grpPlainText = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpPlainText.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(14, 19);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(370, 200);
            this.tbPlainText.TabIndex = 0;
            // 
            // tbHashOutput
            // 
            this.tbHashOutput.Location = new System.Drawing.Point(14, 22);
            this.tbHashOutput.Multiline = true;
            this.tbHashOutput.Name = "tbHashOutput";
            this.tbHashOutput.Size = new System.Drawing.Size(370, 200);
            this.tbHashOutput.TabIndex = 1;
            // 
            // cbAlgorithms
            // 
            this.cbAlgorithms.FormattingEnabled = true;
            this.cbAlgorithms.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "Base 64"});
            this.cbAlgorithms.Location = new System.Drawing.Point(116, 225);
            this.cbAlgorithms.Name = "cbAlgorithms";
            this.cbAlgorithms.Size = new System.Drawing.Size(268, 21);
            this.cbAlgorithms.TabIndex = 2;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(11, 227);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(99, 15);
            this.lblHash.TabIndex = 3;
            this.lblHash.Text = "Select Algorithm:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(337, 514);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(256, 514);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(94, 514);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(175, 514);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // grpPlainText
            // 
            this.grpPlainText.Controls.Add(this.tbPlainText);
            this.grpPlainText.Controls.Add(this.cbAlgorithms);
            this.grpPlainText.Controls.Add(this.lblHash);
            this.grpPlainText.Location = new System.Drawing.Point(12, 12);
            this.grpPlainText.Name = "grpPlainText";
            this.grpPlainText.Size = new System.Drawing.Size(400, 256);
            this.grpPlainText.TabIndex = 8;
            this.grpPlainText.TabStop = false;
            this.grpPlainText.Text = "Plain Text";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.tbHashOutput);
            this.grpOutput.Location = new System.Drawing.Point(12, 274);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(400, 234);
            this.grpOutput.TabIndex = 9;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 548);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpPlainText);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmMain";
            this.Text = "EasyHash - Calvin Hartwell";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPlainText.ResumeLayout(false);
            this.grpPlainText.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlainText;
        private System.Windows.Forms.TextBox tbHashOutput;
        private System.Windows.Forms.ComboBox cbAlgorithms;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox grpPlainText;
        private System.Windows.Forms.GroupBox grpOutput;
    }
}

