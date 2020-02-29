using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a string of letters.");
            var userEntry = Console.ReadLine();
            int count = 0;
            foreach (char letter in userEntry)
            {
            count++;
            }
            Console.WriteLine(count);
            count = 0;


                Console.ReadKey();
        }
    }
}
