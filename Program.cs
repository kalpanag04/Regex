using System;

namespace RegexPatternMatching
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns regex = new Patterns();
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string fname = Console.ReadLine();
            regex.CheckFirstName(fname);
            Console.WriteLine("Enter Last name :");
            string lname = Console.ReadLine();
            regex.CheckLastName(lname);
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            regex.CheckEmail(email);
        }
    }
}