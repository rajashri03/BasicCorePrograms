﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeNum
{
    public class LargeNumber
    {
        int num1, num2, num3;
        public void Checkbig()
        {

            Console.Write("****---Find the largest of three numbers:---****\n");
            Console.Write("\n\n");

            Console.Write("Enter the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.Write("First Number is the greatest anomg three. \n\n");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.Write("Second Number is the greatest among three. \n\n");
            }
            else
            {
                Console.Write("Third Number is the greatest among three\n\n");
            }

        }
    }
}
