using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The forename name and surname is asked of the user
            Console.Write("Enter your forename: ");
            string userForename = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string userSurname = Console.ReadLine();

            // First character is extracted and stored in variable initial
            char initial = userForename[0];

            // The first character and surname are concatenated,space added to seperate and converted to uppercase
            string fullname = (initial + " " + userSurname).ToUpper();

            // The variable 'fullname' is printed out the user
            Console.Write($"Fullname: {fullname}");

        }
    }
}
