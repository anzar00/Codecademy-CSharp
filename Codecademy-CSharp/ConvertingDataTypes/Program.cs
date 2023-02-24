using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");

            //int faveNumber = Console.ReadLine(); //Throws an error

            //int faveNumber = (int)Console.ReadLine(); // Not possible to explicitly convert a string into an int (or vice versa) in C#

            // Turn that answer into an int using built-in method

            int faveNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
