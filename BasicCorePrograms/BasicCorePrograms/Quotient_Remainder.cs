﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckQR
{
    public class Quotient_Remainder
    {
        int Dividend, Divisor;
        public void QuotRem()
        {
            Console.Write("****--Compute Quotient and Remainder--****\n\n");
            Console.Write("Enter Dividend:");
            Dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Divisor:");
            Divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = Dividend / Divisor;
            int remainder = Dividend % Divisor;
            Console.Write("****--Quotient and Remainder--****\n\n");
            Console.Write("Quotient:"+quotient+"\n");
            Console.Write("Remainder:" + remainder + "\n");
        }

    }
}
