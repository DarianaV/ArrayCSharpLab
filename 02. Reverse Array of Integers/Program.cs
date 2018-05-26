using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElement = int.Parse(Console.ReadLine());
            int[] arr = new int[numberOfElement];
            for (int i = 0; i < numberOfElement; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numberOfElement - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
