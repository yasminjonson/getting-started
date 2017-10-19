using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedupe
{
    class Dedupe
    {
        static void Main(string[] args)
        {
            // does the first part (array of 5000)
            int min = 0;
            int max = 50;

            int[] numbers = new int[5000];

            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            { numbers[i] = r.Next(min, max); }

            // sort from least to greatest
            Array.Sort(numbers);

            Console.WriteLine(numbers);
            

        }
    }
}
