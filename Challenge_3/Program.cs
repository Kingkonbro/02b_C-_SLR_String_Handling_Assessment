using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is prompted to enter the name of two citys
            Console.WriteLine("Please input two city names, one after the other:");
            string cityOne = Console.ReadLine();
            string cityTwo = Console.ReadLine();
            
            // The strings are manipulated for the output, and concatenated
            string result = (cityOne.Substring(0,4) + "-" + cityTwo.Substring(0,4)).ToUpper();
            Console.WriteLine($"Result: {result}");
        }
    }
}
