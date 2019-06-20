using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usernameInput = Console.ReadLine();
            char[] correctPasswordChars = new char[usernameInput.Length];

            for (int i = 0; i < usernameInput.Length; i++)
            {
                correctPasswordChars[i] = usernameInput[(usernameInput.Length - 1) - i]; //reverse username characters
            }
            string correctPassword = new string(correctPasswordChars); //generate correct password

            for (int i = 0; i < 4; i++)
            {
                string passwordInput = Console.ReadLine();
                if (passwordInput == correctPassword)
                {
                    Console.WriteLine($"User {usernameInput} logged in.");
                    break;
                }
                else if (i >= 3)
                {
                    Console.WriteLine($"User {usernameInput} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
} 