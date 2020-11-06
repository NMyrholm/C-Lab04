using System;
using System.IO;
using System.Windows.Forms;
using lab04;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public event EventHandler AddNewWord;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Lab04");

        }

        private WordList ListOfWords { get; set; }

        private void MyListForm_SelectClicked(object sender, EventArgs e)
        {
            var sender2 = (WordListForm)sender;
            ListOfWords = sender2.ListName;

            PrintDataGrid();

            buttonAddWord.Enabled = true;
            buttonPractice.Enabled = true;
            buttonRemoveWord.Enabled = true;
        }

        private void PrintDataGrid()
        {
            dataGridViewForm.Columns.Clear();

            int lastIndex = 0;

            for (int i = 0; i < ListOfWords.Languages.Length; i++)
            {
                dataGridViewForm.Columns.Add($"{ListOfWords.Languages[i]}", $"{ListOfWords.Languages[i].ToUpper()}");
                lastIndex = i;
            }
            dataGridViewForm.Columns[lastIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (ListOfWords.Count() <= 0) return;
            {
                dataGridViewForm.Rows.Add(ListOfWords.Count());
                var row = 0;

                ListOfWords.List(0, wordInTranslation =>
                {
                    for (int i = 0; i < wordInTranslation.Length; i++)
                    {

                        dataGridViewForm.Rows[row].Cells[i].Value = wordInTranslation[i];

                    }
                    row++;
                });
            }
        }

        private void OpenWordList()
        {
            using (var wordListForm = new WordListForm())
            {
                wordListForm.SelectClicked += MyListForm_SelectClicked;
                wordListForm.ShowDialog();

            }
        }

        private void wordListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWordList();
        }

        private void buttonRemoveWord_Click(object sender, EventArgs e)
        {
            if (dataGridViewForm.CurrentCell == null) return;
            ListOfWords.Remove(dataGridViewForm.CurrentCell.ColumnIndex, dataGridViewForm.CurrentCell.Value.ToString());
            PrintDataGrid();
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            AddWordWindow();
        }

        private void AddWordWindow()
        {
            using (var addWordForm = new AddWordForm(ListOfWords))
            {
                AddNewWord?.Invoke(this, null);
                addWordForm.AddWord += AddWordForm_AddWord;
                addWordForm.ShowDialog();
            }
        }

        private void AddWordForm_AddWord(object sender, EventArgs e)
        {
            var sender2 = (AddWordForm)sender;
            var list = sender2.NewWords.ToArray();
            ListOfWords.Add(list);
            ListOfWords.Save();
            PrintDataGrid();
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            if (ListOfWords.Count() <= 1) return;
            using (var practice = new PracticeForm(ListOfWords))
            {
                practice.ShowDialog();
            }
        }
    }
}
