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
            string boy = "I am very exhausted";
            string[] w = boy.Split(' ');

            for (int i = 0; i < w.Length; i++)
            {
                char[] cp = w[i].ToCharArray();
                Array.Reverse(cp);
                w[i] = new string(cp);
            }

            string rstring = string.Join(" ", w);

            Console.WriteLine(rstring);
            Console.ReadLine();
        }
    }
}