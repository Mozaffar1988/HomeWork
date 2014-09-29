using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_console
{
    class Program
    {
        static void Main(string[] args)
        {
           /* sort and serch
            int[] numbers = new int[5] { 15, 6, 2, 84, 9 };
            Array.Sort(numbers);
            int serch = Array.IndexOf(numbers,9);
            Console.WriteLine(serch);
             */

            /* sort and array address
             int mynumber;
             int[] numbers = new int[5];
             numbers[0] = 12; 
             numbers[1] = 250;
             numbers[2] = 45;
             numbers[3] = 22;
             numbers[4] = 45236;
             Array.Sort(numbers); 
            mynumber = numbers[3];
            Console.WriteLine(mynumber);
            Console.ReadKey(); */


           /* Sum off array 
            double [] numbers = new double[5];
            double sum = 0;
            int i;
            Console.WriteLine("Enter five value");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Input value" + (i+1).ToString());
              
                numbers[i] =Convert.ToDouble (Console.ReadLine());
               
                sum = sum + numbers[i];
               
            }
            Console.WriteLine("The sum of numbers :" +sum);
            */


            // sorting of array
            int[] numbers = new int[5] { 3, 6, 4, 3, 100 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
