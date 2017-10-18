using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class MinMax
    {
        static void Main(string[] args)
        {

            int min = 1;
            int max = 50;

            int[] numbers = new int[50];

            Random r = new Random();
            for( int i = 0; i < numbers.Length; i++ )
            { numbers[i] = r.Next (min, max ); }

            for (int y = 0; y < 5; y++)
            {
                String row = "";
                for (int x = 0; x < 10; x++)
                {
                    String c = numbers[ y * 10 + x ] + ", ";
                    row += c.PadRight(5,' ');
                }
                Console.WriteLine( row + "\n" );  
            }

            int maxx = numbers.Max();
            Console.WriteLine("The largest number in the array is: " + maxx);

            int minn = numbers.Min();
            Console.WriteLine("The smallest number in the array is: " + minn);


        }
    }
}
