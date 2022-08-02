using System;

namespace RegexPatternMatching
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            if (patterns.validateString("Kalpana Gonal"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
        }
    }
}