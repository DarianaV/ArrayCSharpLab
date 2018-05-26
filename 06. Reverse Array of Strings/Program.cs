using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfLetters = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < arrayOfLetters.Length / 2; i++)
            {
                var old = arrayOfLetters[i];
                arrayOfLetters[i] = arrayOfLetters[arrayOfLetters.Length - i - 1];
                arrayOfLetters[arrayOfLetters.Length - i - 1] = old;
            }
            Console.WriteLine(string.Join(" ", arrayOfLetters));
        }
    }
}
