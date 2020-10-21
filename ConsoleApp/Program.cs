using lab04;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Console.WriteLine(newList.Name);
                        Console.WriteLine(newList.Languages[0]);
                        break;
                    case "-add":
                        if (args.Length < 1)
                        {
                            Console.WriteLine("You forgot to enter the name of the list");
                            break;
                        }

                        var list = WordList.LoadList(args[1]);
                        WordList.Add(list);
                        break;

                    default:
                        InvalidArgument();
                        break;
                }
            }
            else InvalidArgument();

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
