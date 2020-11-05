namespace WinFormsApp
{
    partial class WordListController
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewWordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWordList)).BeginInit();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewWordList
            // 
            this.dataGridViewWordList.AllowUserToAddRows = false;
            this.dataGridViewWordList.AllowUserToDeleteRows = false;
            this.dataGridViewWordList.AllowUserToResizeRows = false;
            this.dataGridViewWordList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWordList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewWordList.Location = new System.Drawing.Point(60, 60);
            this.dataGridViewWordList.Name = "dataGridViewWordList";
            this.dataGridViewWordList.ReadOnly = true;
            this.dataGridViewWordList.RowHeadersVisible = false;
            this.dataGridViewWordList.Size = new System.Drawing.Size(627, 330);
            this.dataGridViewWordList.TabIndex = 0;
            // 
            // WordListController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewWordList);
            this.Name = "WordListController";
            this.Size = new System.Drawing.Size(799, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWordList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridViewWordList;
    }
}
