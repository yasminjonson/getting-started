﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueDigits
{
    class UniqueDigits
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();

            for (int i = 1; i <= 54; i++)
                Numbers.Add(i);

            IEnumberable<int> AcceptedNumbers = Numbers.Where(N => N.ToString().Distinct().Count() == N.ToString().Length);
            
            foreach (int AcceptedNumber in AcceptedNumbers)
                Console.WriteLine(AcceptedNumber);

        }
    }
}
