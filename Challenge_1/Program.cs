using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked to input a string and stored in a variable
            Console.Write("Enter a string: ");
            string userString = Console.ReadLine();

            // The length of the string is calculated and printed out to the user
            int stringLength = userString.Length;
            Console.WriteLine($"Total characters in the string: {stringLength}");
        }
    }
}
