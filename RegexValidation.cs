using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatching
{
    class RegexValidation
    {
        public void checkFirstName(string firstName)
        {
            string validateFirstName = "^[A-Z][A-Za-z]{2,}$";
            try{
                if (Regex.IsMatch(firstName,validateFirstName))
                    Console.WriteLine("First Name saved succufull ");
                else
                    Console.WriteLine("Invalid Name!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
