using lab04;
using System;
using System.IO;
using System.Linq;

// -LoadList. Possible fix better implementation of null management
// -Words <list name> <sortByLanguage>
// -count <list name>
// -practice <list name>
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

                        newList.Save();
                        AddWords(newList);
                        break;

                    case "-add":
                        if (args.Length < 1)
                        {
                            Console.WriteLine("You forgot to enter the name of the list");
                            break;
                        }
                        AddWords(WordList.LoadList(args[1]));
                        break;

                    case "-remove":
                        var removeList = LoadList(args[1]);
                        string[] languages = removeList.Languages;
                        int translation = Array.FindIndex(languages, l => l == args[2].ToLower());
                        if (translation == -1)
                        {
                            Console.WriteLine("Couldn't find expected language");
                            Environment.Exit(0);
                        }

                        Console.WriteLine(removeList.Remove(translation, args[3])
                            ? $"The word '{args[3]}' has been removed from {removeList.Name}."
                            : "The word was not found. Did you spell correctly?");
                        break;

                    case "-words":
                        if (args.Length < 3)
                        {
                            Console.WriteLine("You forgot to enter a language to sort by.. <listname> <sortbyLanguage>");
                            break;
                        }
                        var wordsList = LoadList(args[1]);
                        string[] languages2 = wordsList.Languages;

                        var translation2 = Array.FindIndex(languages2, l => l.ToLower() == args[2].ToLower());
                        if (translation2 == -1)
                        {
                            Console.WriteLine("Could not find entered language.. Check your spelling and try again!");
                            Environment.Exit(0);
                        }

                        foreach (var language in wordsList.Languages)
                        {
                            Console.Write(language.PadRight(20).ToUpper());
                        }

                        Console.WriteLine();

                        wordsList.List(translation2, wordInTranslation =>
                        {
                            foreach (var word in wordInTranslation)
                            {
                                Console.Write(word.PadRight(20));
                            }

                            Console.WriteLine();
                        });
                        break;

                    case "-count":
                        Console.WriteLine($"There are {LoadList(args[1]).Count()} words in {args[1]}");
                        break;

                    case "-practice":
                        var correctAnswers = 0;
                        var attempts = 0;
                        var guess = "";

                        do
                        {
                            var practiceList = LoadList(args[1]);
                            var word = practiceList.GetWordToPractice();

                            Console.WriteLine($"Translate the {practiceList.Languages[word.FromLanguage]} word {word.Translations[word.FromLanguage]} to {practiceList.Languages[word.ToLanguage]}");
                            guess = Console.ReadLine()?.ToLower();

                            if (guess == word.Translations[word.ToLanguage])
                            {
                                Console.WriteLine("Correct!");
                                correctAnswers++;
                                attempts++;
                            }
                            else if (guess != word.Translations[word.ToLanguage] && guess != "")
                            {
                                Console.WriteLine($"Wrong! The answer was {word.Translations[word.ToLanguage]}.     (Press any key to continue!)");
                                Console.ReadLine();
                                attempts++;
                            }

                        } while (guess != "");

                        Console.WriteLine($"You practiced {attempts} words.");
                        Console.WriteLine($"You got {correctAnswers * 100 / attempts}% of your answers correct!");
                        Console.ReadLine();
                        break;

                    default:
                        InvalidArgument();
                        break;
                }
            }
            else InvalidArgument();

        }

        public static void AddWords(WordList list)
        {
            bool exit = false;
            do
            {
                string[] words = new string[list.Languages.Length];
                for (int i = 0; i < list.Languages.Length; i++)
                {
                    Console.WriteLine($"Enter word in {list.Languages[i]}");
                    words[i] = Console.ReadLine()?.ToLower();
                    exit = (words[i] == "");
                    if (exit) break;
                }
                if (!exit) list.Add(words);
                list.Save();
            } while (exit == false);
        }

        public static WordList LoadList(string name)
        {
            if (WordList.LoadList(name) != null) return WordList.LoadList(name);
            Console.WriteLine("List was not found.");
            Environment.Exit(0);
            return null;
        }

        public static void InvalidArgument()
        {
            Console.WriteLine("Use any of the following parameters: ");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }
    }
}
