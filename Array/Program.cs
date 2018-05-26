using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDay = int.Parse(Console.ReadLine());
            string[] array = {            
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            };
            if (numberOfDay > 0 && numberOfDay <= 7)            
            Console.WriteLine(array[numberOfDay - 1]);            
            else           
            Console.WriteLine("Invalid Day!");
           
        }
    }
}
