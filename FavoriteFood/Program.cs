using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user
            Console.WriteLine("What is your favorite food?");

            // create variable
            var Answer = Console.ReadLine();

            if (Answer == "pineapple bread")
            { Console.WriteLine("Most exellent and correct! Pineapple bread is indeed one of the best foods ever put on this screaming wet clod of dirt."); }

            else
            { Console.WriteLine("no. try something tropical pendejo");}

        }
    }
}
