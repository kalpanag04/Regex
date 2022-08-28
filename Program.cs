using System;

namespace RegexPatternMatching
{
    class Program
    {
        public static void Main(string[] args)
        {
            RegexValidation regex=new RegexValidation();
            Console.WriteLine("First Name  should be capital ");
            Console.WriteLine("Name should have minimum three characters ");
            Console.WriteLine("Enter name : ");
            string firstName = Console.ReadLine();
            regex.checkFirstName(firstName);
        }
    }
}