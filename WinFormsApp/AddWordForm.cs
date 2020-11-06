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
    public partial class AddWordForm : Form
    {
        public event EventHandler AddWord;

        private WordList List { get; }
        public List<string>NewWords = new List<string>();

        public AddWordForm(WordList list)
        {
            InitializeComponent();
            List = list;
            AddTranslations();
        }

        private void buttonAddAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewAdd.Rows.Count; i++)
            {
                if (!String.IsNullOrWhiteSpace(dataGridViewAdd.Rows[i].Cells[1].Value.ToString()))
                {
                    NewWords.Add(dataGridViewAdd.Rows[i].Cells[1].Value.ToString());
                }
                else
                {
                    NewWords.Clear();
                    MessageBox.Show("All languages needs a translation", "Missing translation");
                    break;
                }
            }

            if (NewWords.Count == 0) return;
            AddWord?.Invoke(this, null);
            Close();

        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTranslations()
        {
            dataGridViewAdd.Columns.Add("Language", "Language");
            dataGridViewAdd.Columns.Add("Word", "Word");
            dataGridViewAdd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (var t in List.Languages)
            {
                dataGridViewAdd.Rows.Add($"{t.ToUpper()}", "");
            }

            dataGridViewAdd.Columns[0].ReadOnly = true;

        }
    }
}
