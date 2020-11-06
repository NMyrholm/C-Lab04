using lab04;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{

    public partial class WordListForm : Form
    {
        public event EventHandler SelectClicked;

        public WordListForm()
        {
            InitializeComponent();
        }
        public WordList ListName { get; set; }

        private void WordListForm_Load(object sender, EventArgs e)
        {
            UpdateListOfLists();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectClicked?.Invoke(this, null);
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxWordLists_Click(object sender, EventArgs e)
        {
            if (listBoxWordLists.SelectedItem == null) return;
            listBoxLanguages.Items.Clear();
            ListName = WordList.LoadList(listBoxWordLists.SelectedItem.ToString());
            foreach (var language in ListName.Languages)
            {
                listBoxLanguages.Items.Add(language);
            }

            wordCount.Text = $"Word count: {ListName.Count()}";
            buttonSelect.Enabled = true;

        }

        private void UpdateListOfLists()
        {
            listBoxWordLists.Items.Clear();
            string[] lists = WordList.GetLists();

            foreach (var l in lists)
            {
                listBoxWordLists.Items.Add(l);
            }
        }

        private void buttonNewList_Click(object sender, EventArgs e)
        {
            using (NewListForm newListForm = new NewListForm())
            {
                newListForm.ShowDialog();
            }
            UpdateListOfLists();
        }
    }
}
