﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class CheckEvenOdd
    {
        int Num;
        public int EvenOdd()
        {
            Console.WriteLine("Enter Number:");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {

                Console.WriteLine("Number is Even\n");
            }
            else
            {
                Console.Write("Number is odd\n");
            }
            return Num;
        }
    }
}
