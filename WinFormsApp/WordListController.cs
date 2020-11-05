using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab04;

namespace WinFormsApp
{
    public partial class WordListController : UserControl
    {

        public WordListController()
        {
            InitializeComponent();
            this.Controls.Add(dataGridViewWordList);
        }

        public void AddDataGrid(WordList list)
        {
            dataGridViewWordList.DataSource = list.Languages.ToList();

            //dataGridViewWordList.ColumnCount = list.Languages.Length;
            for (int i = 0; i < list.Languages.Length; i++)
            {
                //dataGridViewWordList.Columns[i].HeaderCell.Value = $"{list.Languages[i]}";
            }
            //dataGridViewWordList.Update();
            //dataGridViewWordList.Columns.Add("Hej", "Hallo");
            //foreach (var lang in list.Languages)
            //{
            //    dataGridViewWordList.Columns.Add($"{lang}", "hej");
            //}
            //var columnList = list.Languages.ToList();

            
            //dataGridViewWordList.Rows.Add(list.Languages);


            //dataGridViewWordList.DataSource = list.Languages.Select(x => new {Property1 = x}).ToList();
            //dataGridViewWordList.DataSource(list.Languages);
            //dataGridViewWordList.Update();

        }
    }
}
