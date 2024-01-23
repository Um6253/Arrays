using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 91, 62, 3, 7, 5, 1, 5, 3, 4, 2, 2, 4, 5, 1, 7, 4, 9 };

            Console.WriteLine($"Maximum: {arr.Max()}");
            Console.WriteLine($"Minimum: {arr.Min()}");

            Console.ReadLine();
        }
    }
}