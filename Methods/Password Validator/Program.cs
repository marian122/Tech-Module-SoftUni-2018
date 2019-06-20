using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isBetween6And10Symbols = CheckLengthOfPassword(password);
            if (isBetween6And10Symbols == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            bool digitsAndLetters = ContainsOnlyDigitsAndLetters(password);
            if (digitsAndLetters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            bool min2Digits = CheckIfThereAreMin2Digits(password);
            if (min2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(isBetween6And10Symbols && digitsAndLetters && min2Digits)
            {
                Console.WriteLine("Password is valid");
            }


        }
        static bool CheckLengthOfPassword(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ContainsOnlyDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckIfThereAreMin2Digits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        } 

    }
}
