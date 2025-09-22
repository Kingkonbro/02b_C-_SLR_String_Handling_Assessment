using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is prompted to enter their full name on one line
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            // The index on the space is found in the string
            int nameSeperation = fullName.IndexOf(" ");

            // The string is manipulated and the first and last name is printed seperate to the user
            string firstName = fullName.Substring(0, nameSeperation);
            Console.WriteLine($"Forename: {firstName}");

            string lastName = fullName.Substring(nameSeperation + 1, ((fullName.Length)-nameSeperation - 1 ) );
            Console.WriteLine($"Surname: {lastName}");
        }
    }
}
