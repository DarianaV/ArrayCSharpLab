using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else if (nums.Length % 2 == 0)
            {
                var middleElements = new int[nums.Length];
                middleElements[0] = nums[nums.Length / 2 - 1];
                middleElements[1] = nums[nums.Length / 2];
                Console.Write("{");
                Console.Write(middleElements[0] + " , ");
                Console.Write(middleElements[1]);
                Console.WriteLine("}");
            }
            else if (nums.Length % 2 != 0)
            {
                var middleElements = new int[nums.Length];
                middleElements[0] = nums[nums.Length / 2 - 1];
                middleElements[1] = nums[nums.Length / 2];
                middleElements[2] = nums[nums.Length / 2 + 1];
                Console.Write("{");
                Console.Write(middleElements[0] + " , ");
                Console.Write(middleElements[1] + " , ");
                Console.Write(middleElements[2]);
                Console.WriteLine("}");
            }
        }
    }
}
