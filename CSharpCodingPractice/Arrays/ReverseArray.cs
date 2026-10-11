using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPractice.Arrays
{
    public class ReverseArray
    {
        public static void Run()
        {
            int[] input = [10, 20, 30, 40, 50 ];

            int[] output = new int[input.Length]; 

            int j =0;

            for(int i = input.Length-1; i >= 0; i--)
            {
                output[j] = input[i];
                j++;
            }

            Console.WriteLine("Reversed Array:");
            Console.WriteLine(string.Join(",", output));
            
        }
    }
}
