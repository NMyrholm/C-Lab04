using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab04;

namespace WinFormsApp
{
    public partial class NewListForm : Form
    {
        public NewListForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string[] languages = textBoxLanguages.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (textBoxTitle.Text == "") MessageBox.Show("You are missing a title!", "Error!", MessageBoxButtons.OK);
            
            else if (languages.Length <=1) MessageBox.Show("Enter at least two languages!", "Error!", MessageBoxButtons.OK);

            else
            {
                languages = textBoxLanguages.Text.Split(new []{ '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var newList = new WordList(textBoxTitle.Text, languages);
                newList.Save();
                Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
