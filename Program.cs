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
            HashSet<int> Values = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }


                if (count > 1 && !Values.Contains(arr[i]))
                {
                    Console.WriteLine($"{arr[i]} ={count} ");
                    Values.Add(arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
