using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPractice.Arrays
{
    public  class LargestNumber
    {
        public static void Run()
        {
            int[] number = [10, 15, 20, 25, 30, 55];

            int Maxnumber = number[0];

            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] > Maxnumber)
                {
                    Maxnumber = number[i];
                }
            }
            Console.WriteLine($"Largest number is {Maxnumber}");
        }
    }
}
