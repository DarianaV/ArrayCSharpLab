﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            while (numbers.Length >= 2)
            {
                var sumAdjacentNumbers = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    sumAdjacentNumbers[i] = numbers[i] + numbers[i + 1];
                }
                numbers = sumAdjacentNumbers;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
