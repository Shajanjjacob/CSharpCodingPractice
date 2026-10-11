using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPractice.Arrays
{
    public  class ThirdLargestNumber
    {
        public static void Run()
        {
            int[] number = [33, 444, 4444, 666, 778, 6, 66, 77, 1];

            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;

            foreach(int num in number)
            {
                if(num > first)
                {
                    third = second;  //if new no is largest 
                    second = first;
                    first = num;
                }
                else if(num < first && num > second)
                {
                    third = second;
                    second = num;
                }
                else if(num < second && num > third)
                {
                    third = num;
                }
            }

            Console.WriteLine($"3rd no is ={third}");
        }
    }
}
