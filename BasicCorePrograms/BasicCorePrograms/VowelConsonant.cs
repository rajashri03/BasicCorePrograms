﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVowelConsonant
{
    public class VowelConsonant
    {
        char ch;
        public void CkeckVowelConso()
        {
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.\n\n");

            }
            else
            {
                Console.WriteLine(ch + " is Consonant.\n\n");
            }

           
        }
    }
}
