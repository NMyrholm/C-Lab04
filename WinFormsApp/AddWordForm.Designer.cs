namespace WinFormsApp
{
    partial class AddWordForm
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
            this.dataGridViewAdd = new System.Windows.Forms.DataGridView();
            this.buttonAddCancel = new System.Windows.Forms.Button();
            this.buttonAddAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdd
            // 
            this.dataGridViewAdd.AllowUserToAddRows = false;
            this.dataGridViewAdd.AllowUserToDeleteRows = false;
            this.dataGridViewAdd.AllowUserToResizeColumns = false;
            this.dataGridViewAdd.AllowUserToResizeRows = false;
            this.dataGridViewAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdd.ColumnHeadersVisible = false;
            this.dataGridViewAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAdd.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdd.Name = "dataGridViewAdd";
            this.dataGridViewAdd.RowHeadersVisible = false;
            this.dataGridViewAdd.Size = new System.Drawing.Size(302, 152);
            this.dataGridViewAdd.TabIndex = 0;
            // 
            // buttonAddCancel
            // 
            this.buttonAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddCancel.Location = new System.Drawing.Point(56, 173);
            this.buttonAddCancel.Name = "buttonAddCancel";
            this.buttonAddCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCancel.TabIndex = 1;
            this.buttonAddCancel.Text = "Cancel";
            this.buttonAddCancel.UseVisualStyleBackColor = true;
            this.buttonAddCancel.Click += new System.EventHandler(this.buttonAddCancel_Click);
            // 
            // buttonAddAdd
            // 
            this.buttonAddAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAdd.Location = new System.Drawing.Point(173, 173);
            this.buttonAddAdd.Name = "buttonAddAdd";
            this.buttonAddAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAdd.TabIndex = 2;
            this.buttonAddAdd.Text = "Add";
            this.buttonAddAdd.UseVisualStyleBackColor = true;
            this.buttonAddAdd.Click += new System.EventHandler(this.buttonAddAdd_Click);
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 210);
            this.Controls.Add(this.buttonAddAdd);
            this.Controls.Add(this.buttonAddCancel);
            this.Controls.Add(this.dataGridViewAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddWordForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdd;
        private System.Windows.Forms.Button buttonAddCancel;
        private System.Windows.Forms.Button buttonAddAdd;
    }
}