using System;

namespace RegexPatternMatching
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            if (patterns.validateString("HBzhxbs90"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
        }
    }
}