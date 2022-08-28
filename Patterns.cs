﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatching
{
    class Patterns
    {
        public void CheckFirstName(string firstname)
        {
            string validateFirstName = "^[A-Z][a-z]{3,}$";
            try
            {
                if (Regex.IsMatch(firstname, validateFirstName))
                    Console.WriteLine("First Name saved succesfull");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CheckLastName(string lastname)
        {
            string validateFirstName = "^[A-Z][a-z]{3,}$";
            try
            {
                if (Regex.IsMatch(lastname, validateFirstName))
                    Console.WriteLine("First Name saved succesfull");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CheckEmail(string email)
        {
            string validateEmail = "^[a-zA-Z0-9]+([#$%^&*.+][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z0-9]{2})?$";
            try
            {
                if (Regex.IsMatch(email, validateEmail))
                    Console.WriteLine(" email validate succesfull");
                else
                    Console.WriteLine("Invalid email!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CheckMobileNo(string mobile)
        {
            string validateMobile = "^[0-9]{1,4}[ ][0-9]{10,12}$";
            try
            {
                if (Regex.IsMatch(mobile, validateMobile))
                    Console.WriteLine(" mobile no validate succesfull");
                else
                    Console.WriteLine("Invalid mobile no.!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CheckPassword(string password)
        {
            //string validatepassword = "^(?=.*[A-Z])(?=.*[a-zA-Z0-9]{8,}).*$"; 
            
            string validatepassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-zA-Z0-9]{8,}).*$";
            try
            {
                if (Regex.IsMatch(password, validatepassword))
                    Console.WriteLine("password validate succesfull");
                else
                    Console.WriteLine("Invalid password!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}


