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
            string[] lists = WordList.GetLists();

            foreach (var l in lists)
            {
                listBoxWordLists.Items.Add(l);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //WordListController wlc = new WordListController();
            //wlc.Dock = DockStyle.Fill;
            //wlc.AddDataGrid(ListName);
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


        }

        private void buttonNewList_Click(object sender, EventArgs e)
        {
            using (NewListForm newListForm = new NewListForm())
            {
                if (newListForm.ShowDialog() == DialogResult.OK)
                {
                    //WordList.LoadList()
                }
            }
        }
    }
}
