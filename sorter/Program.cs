using System;

namespace fileSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sorting {string.Join(',',args)}");
            if (args.Any(a => a == "--photos"))
            {
                Console.WriteLine("would you like to proceed Y/N");
                var uinput = Console.ReadLine();
                if (uinput == "Y")
                {
                    Console.WriteLine("Sorting your files");
                }
                else
                {
                    Console.WriteLine("See you again!");
                }
                
            }
        }
    }
}

