using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] secondArrayOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var length = Math.Max(firstArrayOfIntegers.Length, secondArrayOfIntegers.Length);
            var sum = new int[length];
            for (int i = 0; i < length; i++)
            {
                sum[i] = firstArrayOfIntegers[i % firstArrayOfIntegers.Length] + secondArrayOfIntegers[i % secondArrayOfIntegers.Length];

            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
