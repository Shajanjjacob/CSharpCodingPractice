using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPractice.Arrays
{
    public  class SecondLargestNumber
    {
        public static void Run()
        {
            int[] Number = [222, 33, 44, 555, 6666, 7, 8, 12, 34];
         
            //ALSO A METHOD USING LINQ
            //var secondlargest = Number.OrderByDescending(x => x).Distinct().Skip(1).First();
            //Console.WriteLine($"Second largest number is {secondlargest}");

            int first = int.MinValue;
            int second = int.MinValue;

            foreach (var num in Number)  //  for (int i = 0; i < Number.Length; i++)
            {
                if (num > first)        // if (Number[i] > MaxNumber)
                {
                    second = first;   //if find a new largest no old largest become second one 
                    first = num;
                   
                }
                else if(num > second && num < first) // else if (Number[i] > SecondLarge && Number[i] < MaxNumber)
                {
                    second = num;
                }


            }
            Console.WriteLine($"Second Largest Number is ={second}");

        }
    }
}
