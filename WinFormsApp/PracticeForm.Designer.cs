namespace WinFormsApp
{
    partial class PracticeForm
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
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonEndPractice = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelTranslate = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRestart.Location = new System.Drawing.Point(299, 331);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(106, 28);
            this.buttonRestart.TabIndex = 0;
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonEndPractice
            // 
            this.buttonEndPractice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEndPractice.Location = new System.Drawing.Point(432, 331);
            this.buttonEndPractice.Name = "buttonEndPractice";
            this.buttonEndPractice.Size = new System.Drawing.Size(106, 28);
            this.buttonEndPractice.TabIndex = 1;
            this.buttonEndPractice.Text = "END PRACTICE";
            this.buttonEndPractice.UseVisualStyleBackColor = true;
            this.buttonEndPractice.Click += new System.EventHandler(this.buttonEndPractice_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxInput.Location = new System.Drawing.Point(299, 170);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(239, 20);
            this.textBoxInput.TabIndex = 2;
            // 
            // labelTranslate
            // 
            this.labelTranslate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTranslate.AutoSize = true;
            this.labelTranslate.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTranslate.Location = new System.Drawing.Point(219, 105);
            this.labelTranslate.Name = "labelTranslate";
            this.labelTranslate.Size = new System.Drawing.Size(96, 26);
            this.labelTranslate.TabIndex = 3;
            this.labelTranslate.Text = "Translate";
            this.labelTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(294, 238);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(246, 26);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "0 of 0 words were correct";
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 472);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTranslate);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonEndPractice);
            this.Controls.Add(this.buttonRestart);
            this.MinimizeBox = false;
            this.Name = "PracticeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonEndPractice;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelTranslate;
        private System.Windows.Forms.Label labelScore;
    }
}