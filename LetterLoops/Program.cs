using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a string of letters.");
            var userEntry = Console.ReadLine();
            var letterCount = userEntry.Length;
            for (int i=0; i < userEntry.Length; i++)
            {
                //Console.WriteLine(userEntry[i]);
                //index(is i) + 1 times, 
                for(var j = 0; j < i + 1; j++)
                {
                    Console.WriteLine(userEntry[i]);
                }
            }
            


            Console.ReadKey();
        }
    }
}
