using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPractice.Arrays
{
    public  class SmallestNumber
    {
       public  static void Run()
        {
            int[] number = [2, 4, 5, 13, 66, 77, 89, 45, 62, 1, 888];

            int minNumber = number[0];
            for(int i =0; i < number.Length; i++)
            {
                if (number[i] < minNumber)
                {
                    minNumber = number[i];
                }
            }
            Console.WriteLine($"smallest number is {minNumber}");
        }
    }
}
