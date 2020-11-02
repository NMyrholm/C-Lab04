using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace lab04
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }
        public static string AppData = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Lab04";
        private readonly List<Word> _listOfWords = new List<Word>();


        public WordList(string name, params string[] languages)
        {
            Name = name.ToLower();
            Languages = languages;
        }

        public static string[] GetLists()
        {
            DirectoryInfo d = new DirectoryInfo(AppData);
            FileInfo[] files = d.GetFiles("*.dat");
            string[] fileList = new string[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                fileList[i] = Path.GetFileNameWithoutExtension(files[i].Name);
            }
            return fileList;
        }

        public static WordList LoadList(string name)
        {
            var filePath = $@"{AppData}\{name.ToLower()}.dat";
            bool fileExist = File.Exists(filePath);

            if (fileExist)
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    var firstLine = sr.ReadLine();

                    var langs = firstLine?.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var list = new WordList(name, langs);

                    for (int i = 1; i < File.ReadLines(filePath).Count(); i++)
                    {
                        var words = File.ReadLines(filePath).Skip(i).Take(1).First().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                        list.Add(words);
                    }

                    sr.Close();
                    return list;
                }

            }

            return null;
        }

        public void Save()
        {
            var file = $@"{AppData}\{Name.ToLower()}.dat";
            using (File.AppendText($@"{AppData}\{Name.ToLower()}.dat"))
            {

            }

            int NumberOfRetries = 3;
            int DelayOnRetry = 1000;

            for (int i = 0; i < NumberOfRetries; i++)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(file, false))
                    {
                        foreach (var lang in Languages)
                        {
                            sw.Write(lang.ToLower() + ";");
                        }
                        sw.WriteLine();

                        foreach (var w in _listOfWords)
                        {
                            foreach (var t in w.Translations)
                            {
                                sw.Write(t.ToLower() + ";");
                            }

                            sw.WriteLine();
                        }

                        sw.Close();
                    }
                    break;
                }
                catch (IOException e) when (i <= NumberOfRetries)
                {
                    Thread.Sleep(DelayOnRetry);
                }
            }
        }

        public void Add(params string[] translations)
        {
            try
            {
                _listOfWords.Add(new Word(translations));
            }
            catch (ArgumentException e) when (translations.Length != Languages.Length)
            {
                Console.WriteLine($"An error has occured:\n{e}");
            }

        }

        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < _listOfWords.Count; i++)
            {
                if (!_listOfWords[i].Translations[translation].Contains(word)) continue;
                _listOfWords.RemoveAt(i);
                Save();
                return true;
            }
            return false;
        }

        public int Count()
        {
            return _listOfWords.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            if (_listOfWords == null) return;
            var list = _listOfWords.OrderBy(x => x.Translations[sortByTranslation]);
            foreach (var b in list)
            {
                showTranslations(b.Translations);
            }

        }

        public Word GetWordToPractice()
        {
            Random rnd = new Random();
            var word = rnd.Next(1, _listOfWords.Count);
            return _listOfWords[word];
        }
    }
}
