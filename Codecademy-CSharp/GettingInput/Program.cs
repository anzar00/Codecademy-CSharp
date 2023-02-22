using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("How old are you?");
                string input = Console.ReadLine();
                Console.WriteLine($"You are {input} years old!");
            }
        }
    }
}
