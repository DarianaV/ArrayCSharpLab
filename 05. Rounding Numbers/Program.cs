using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfRealNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < arrayOfRealNumbers.Length; i++)
            {
                if (arrayOfRealNumbers[i] > 0)
                {
                    Console.WriteLine("{0} => {1}", arrayOfRealNumbers[i], Math.Round(arrayOfRealNumbers[i], 0, MidpointRounding.AwayFromZero));
                }
                else
                {
                    Console.WriteLine("{0} => {1}", arrayOfRealNumbers[i], Math.Round(arrayOfRealNumbers[i], 0, MidpointRounding.AwayFromZero));
                }
            }
        }
    }
}
