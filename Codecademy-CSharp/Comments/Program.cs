using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Ask the user to enter age
                Console.WriteLine("How old are you?");
                string input = Console.ReadLine();
                Console.WriteLine($"You are {input} years old!");
            }
        }
    }
}
