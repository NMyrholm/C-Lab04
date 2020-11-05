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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var myListForm = new WordListForm();
            //var myListController = new WordListController();
            //wordListControl.Dock = DockStyle.Fill;
            //Controls.Add(wordListControl);
            //splitContainer1.Panel1.Controls.Add(myListController);
            //myListController.Dock = DockStyle.Fill;
            myListForm.SelectClicked += MyListForm_SelectClicked;

        }

        private void MyListForm_SelectClicked(object sender, EventArgs e)
        {
            var myListController = new WordListController();
            //wordListControl.Dock = DockStyle.Fill;
            //Controls.Add(myListController);
            myListController.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void OpenWordList()
        {
            using (WordListForm wordListForm = new WordListForm())
            {
                if (wordListForm.ShowDialog() == DialogResult.OK)
                { 
                    //WordList.LoadList()
                }
            }
        }

        private void wordListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWordList();
        }
    }
}
