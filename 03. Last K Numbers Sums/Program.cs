using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine()); ;
            decimal[] array = new decimal[n];
            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                array[i] = SumNums(i - k, i - 1, array);
            }
            Console.WriteLine(string.Join(" ", array));
        }

        static decimal SumNums(int starstIndex, int endIndex, decimal[] arr)
        {
            decimal sum = 0;
            for (int i = starstIndex; i <= endIndex; i++)
            {
                if (i >= 0)
                {
                    sum = sum + arr[i];
                }
            }
            return sum;
        }
    }
}

