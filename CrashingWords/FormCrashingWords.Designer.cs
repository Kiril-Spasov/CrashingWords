namespace CrashingWords
{
    partial class FormCrashingWords
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
            this.BtnCrashingWords = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCrashingWords
            // 
            this.BtnCrashingWords.Location = new System.Drawing.Point(47, 36);
            this.BtnCrashingWords.Name = "BtnCrashingWords";
            this.BtnCrashingWords.Size = new System.Drawing.Size(186, 61);
            this.BtnCrashingWords.TabIndex = 0;
            this.BtnCrashingWords.Text = "Crashing Words";
            this.BtnCrashingWords.UseVisualStyleBackColor = true;
            this.BtnCrashingWords.Click += new System.EventHandler(this.BtnCrashingWords_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(341, 36);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(403, 330);
            this.TxtResult.TabIndex = 1;
            // 
            // FormCrashingWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnCrashingWords);
            this.Name = "FormCrashingWords";
            this.Text = "Crashing Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrashingWords;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

