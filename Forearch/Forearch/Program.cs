using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 28, 72, 8, 36 };
            foreach (int myNumber in numbers)
            {
                Console.WriteLine(myNumber);
            }

        }
    }
}
