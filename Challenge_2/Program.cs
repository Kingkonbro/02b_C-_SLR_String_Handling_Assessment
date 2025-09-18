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

            char initial = userForename[0];
            string fullname = (initial + " " + userSurname).ToUpper();

            // The variable 'fullname' is printed out the user
            Console.Write($"Fullname: {fullname}");

        }
    }
}
