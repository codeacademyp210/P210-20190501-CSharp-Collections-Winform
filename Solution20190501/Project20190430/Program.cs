using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20190430
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ededler daxil edin: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(',');

            int[] numberArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                numberArray[i] = Convert.ToInt32(inputArray[i]);
            }

            //Array.Sort<int>(numberArray, new Comparison<int>((i1,i2) => i2.CompareTo(i1) ) );

            Array.Sort(numberArray);
            int[] sorted = new int[numberArray.Length];
            numberArray.CopyTo(sorted,0);

            Console.WriteLine("Sort");
            foreach (var item in numberArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Reverse");
            Array.Reverse(numberArray);
            foreach (var item in numberArray)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("Average: " + GetAverate(numberArray));


            Console.ReadLine();

        }

        public static int GetAverate(int[] arr)
        {
            int output = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                output += arr[i];
            }

            return output / arr.Length;

        }


    }
}
