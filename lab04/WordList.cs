using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab04
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }
        public static string AppData = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Lab04";

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
            if (File.Exists($@"{AppData}\{name.ToLower()}.dat"))
            {
                using (StreamReader sr = new StreamReader($@"{AppData}\{name.ToLower()}.dat"))
                {
                    string firstLine = sr.ReadLine();

                    string[] langs = firstLine?.Split( new [] {';'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    sr.Close();
                    return new WordList(name, langs);
                }
            }

            Console.WriteLine("File not found!"); // MOVE TO CONSOLE APP

            return null;
        }

        public void Save()
        {

        }

        public void Add(params string[] translations)
        {
            //Skriv ut translations som är orden, till .dat filen
            if (File.Exists($@"{AppData}\{Name.ToLower()}.dat"))
            {
                using (StreamWriter sw = new StreamWriter($@"{AppData}\{Name.ToLower()}.dat"))
                {
                    foreach (string word in translations)
                    {
                        sw.Write($"{word}");
                    }

                    sw.Close();
                }

                Save();
            }
        }

        public bool Remove(int translation, string word)
        {
            return true;
        }

        public int Count()
        {
            return 0;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {

        }

        public Word GetWordToPractice()
        {
            return null;
        }
    }
}
