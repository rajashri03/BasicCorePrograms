﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSwapNumber
{
    public class SwapNum
    {
        int Num1, Num2, Temp = 0;

        public void CheckSwap()
        {
            Console.Write("Enter First Number:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Temp = Num1;
            Num1 = Num2;
            Num2 = Temp;
            Console.Write("*****----Numbers After Swaping----*****\n");
            Console.Write("Number 1:" + Num1+ "\n");
            Console.Write("Number 2:" + Num2 + "\n");
        }
    }
}
