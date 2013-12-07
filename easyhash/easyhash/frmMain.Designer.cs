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
            this.SuspendLayout();
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(12, 12);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(388, 200);
            this.tbPlainText.TabIndex = 0;
            // 
            // tbHashOutput
            // 
            this.tbHashOutput.Location = new System.Drawing.Point(12, 248);
            this.tbHashOutput.Multiline = true;
            this.tbHashOutput.Name = "tbHashOutput";
            this.tbHashOutput.Size = new System.Drawing.Size(388, 200);
            this.tbHashOutput.TabIndex = 1;
            // 
            // cbAlgorithms
            // 
            this.cbAlgorithms.FormattingEnabled = true;
            this.cbAlgorithms.Location = new System.Drawing.Point(114, 218);
            this.cbAlgorithms.Name = "cbAlgorithms";
            this.cbAlgorithms.Size = new System.Drawing.Size(286, 21);
            this.cbAlgorithms.TabIndex = 2;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(9, 221);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(99, 15);
            this.lblHash.TabIndex = 3;
            this.lblHash.Text = "Select Algorithm:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(325, 454);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(82, 454);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(163, 454);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 481);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.cbAlgorithms);
            this.Controls.Add(this.tbHashOutput);
            this.Controls.Add(this.tbPlainText);
            this.Name = "frmMain";
            this.Text = "Easy Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

