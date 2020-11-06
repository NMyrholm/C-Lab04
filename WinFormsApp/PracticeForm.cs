using lab04;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class PracticeForm : Form
    {
        private WordList List { get; }
        private string _wordTo;
        private int _score;
        private int _tries;
        bool _newWord;
        public PracticeForm(WordList list)
        {
            InitializeComponent();
            List = list;
            InitPractice();
        }

        private void InitPractice()
        {
            _newWord = false;
            var word = List.GetWordToPractice();
            _wordTo = word.Translations[word.ToLanguage];
            labelTranslate.Text =
                $"Translate the {List.Languages[word.FromLanguage]} word {word.Translations[word.FromLanguage]} to {List.Languages[word.ToLanguage]}";

            labelScore.Text = $"{_score} of {_tries} words were correct";
            textBoxInput.KeyDown += CheckForAnswer;
        }

        private void CheckForAnswer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (textBoxInput.Text.ToLower() == _wordTo)
                {
                    _score += 1;
                    _newWord = true;
                }
                else
                {
                    var dialog = MessageBox.Show($"The correct translation is '{_wordTo}'.", "Incorrect answer!", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                        _newWord = true;
                }

                textBoxInput.Text = "";
                _tries += 1;
            }

            if (_newWord)
            {
                textBoxInput.KeyDown -= CheckForAnswer;
                InitPractice();
            }
        }

        private void buttonEndPractice_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            _score = 0;
            _tries = 0;
            InitPractice();
        }
    }
}
