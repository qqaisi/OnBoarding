using System;

namespace Something
{
    class Program
    {
        public static string GiveMeSomething(string word)
        {
            return "Somthing "+ word;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(GiveMeSomething("is better than nothing"));
        }
    }
}
