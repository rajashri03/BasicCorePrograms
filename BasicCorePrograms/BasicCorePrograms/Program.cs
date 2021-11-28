using System;
using BasicCoreProgram;
using CheckVowelConsonant;
using LargeNum;
using CheckSwapNumber;
using CheckQR;
using Head_Tails;
using CheckLP;
using CheckHarmonic;
using PrimeNum;
class EvenOdd
{
    public static void Main()
    {
        //For Even_Odd
        CheckEvenOdd number = new CheckEvenOdd();
        //For Vowel Consonant
        VowelConsonant characterr = new VowelConsonant();
        //For LargeNumber
        LargeNumber bignum = new LargeNumber();
        //For Swap Two Numbers
        SwapNum swapping = new SwapNum();

        //For Quotient remainder
        Quotient_Remainder quotrem = new Quotient_Remainder();
        //For printing percentage of Heads and Tails
        HeadsTails headtail = new HeadsTails();
        //LeapYear
        LeapYear leap = new LeapYear();
        //Harmonic
        Harmonic harm = new Harmonic();
        //Harmonic
        Prime prime = new Prime();
        while (true)
        {
            Console.WriteLine("Select Number:\n" +
                "1.Check Whether a Number is Even or Odd\n" +
                "2.Check Whether an Alphabet is Vowel or Consonant\n" +
                "3.Find the Largest Among Three Numbers\n" +
                "4.Swap Two Numbers\n" +
                "5.Compute Quotient and Remainder\n" +
                "6.Find percentage of Heads and Tails\n"+
                "7.Find Leap Year\n"+
                 "8.Harmonic Number\n"+
                 "9.Find Prime Factor of Number\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    number.EvenOdd();
                    break;
                case 2:
                    characterr.CkeckVowelConso();
                    break;
                case 3:
                    bignum.Checkbig();
                    break;
                case 4:
                    swapping.CheckSwap();
                    break;
                case 5:
                    quotrem.QuotRem();
                    break;
                case 6:
                    headtail.CheckHeadTail();
                    break;
                case 7:
                    leap.CheckLeap();
                    break;
                case 8:
                    harm.CheckNum();
                    break;
                case 9:
                    prime.CheckPrime();
                    break;
                default:
                    Console.Write("Please Select Correct Number\n");
                    break;
            }
        }
    }
}