namespace WinFormsApp
{
    partial class WordListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxWordLists = new System.Windows.Forms.ListBox();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.wordCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word lists:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxWordLists
            // 
            this.listBoxWordLists.FormattingEnabled = true;
            this.listBoxWordLists.Location = new System.Drawing.Point(12, 45);
            this.listBoxWordLists.Name = "listBoxWordLists";
            this.listBoxWordLists.Size = new System.Drawing.Size(144, 108);
            this.listBoxWordLists.TabIndex = 1;
            this.listBoxWordLists.Click += new System.EventHandler(this.listBoxWordLists_Click);
            this.listBoxWordLists.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.Location = new System.Drawing.Point(181, 45);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(152, 108);
            this.listBoxLanguages.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Languages:";
            // 
            // buttonNewList
            // 
            this.buttonNewList.Location = new System.Drawing.Point(12, 181);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(75, 23);
            this.buttonNewList.TabIndex = 4;
            this.buttonNewList.Text = "New list";
            this.buttonNewList.UseVisualStyleBackColor = true;
            this.buttonNewList.Click += new System.EventHandler(this.buttonNewList_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(207, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(60, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(273, 181);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(60, 23);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.button3_Click);
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(82, 26);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(75, 13);
            this.wordCount.TabIndex = 7;
            this.wordCount.Text = "Word count: 2";
            this.wordCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 216);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNewList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.listBoxWordLists);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select word list";
            this.Load += new System.EventHandler(this.WordListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxWordLists;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label wordCount;
    }
}