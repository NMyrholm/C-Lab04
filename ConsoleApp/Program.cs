using lab04;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Lab04");

            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "-lists":
                        string[] lists = WordList.GetLists();
                        foreach (string l in lists)
                        {
                            Console.WriteLine(l);
                        }
                        break;
                    case "-new":
                        if (args.Length < 4)
                        {
                            Console.WriteLine("You need at least a name and two languages!");
                            break;
                        }
                        var newList = new WordList(args[1], args.Skip(2).ToArray());
                        Console.WriteLine($"A new list named {args[1]} has been created!");
                        newList.Add(args[1]);
                        AddWords(args[1]);
                        break;

                    case "-add":
                        if (args.Length < 1)
                        {
                            Console.WriteLine("You forgot to enter the name of the list");
                            break;
                        }

                        //var list = WordList.LoadList(args[1]);
                        //string[] words = new string[list.Languages.Length];
                        //bool exit = false;
                        //do
                        //{
                        //    for (int i = 0; i < list.Languages.Length; i++)
                        //    {
                        //        Console.WriteLine($"Enter word in {list.Languages[i]}");
                        //        words[i] = Console.ReadLine();
                        //        exit = (words[i] == "");
                        //    }
                        //    list.Add(words);
                        //} while (exit == false);
                        AddWords(args[1]);
                        break;

                    default:
                        InvalidArgument();
                        break;
                }
            }
            else InvalidArgument();

        }

        public static void AddWords(string name)
        {
            var list = WordList.LoadList(name);
            bool exit = false;
            do
            {
                string[] words = new string[list.Languages.Length];
                for (int i = 0; i < list.Languages.Length; i++)
                {
                    Console.WriteLine($"Enter word in {list.Languages[i]}");
                    words[i] = Console.ReadLine();
                    exit = (words[i] == "");
                }
                list.Add(words);
            } while (exit == false);
        }

        public static void InvalidArgument()
        {
            Console.WriteLine("Use any of the following parameters: ");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <langauge n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }
    }
}
