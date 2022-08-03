using System;

namespace RegexPatternMatching
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            if (patterns.validateString("abc.xyl@bl.co.in"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
        }
    }
}