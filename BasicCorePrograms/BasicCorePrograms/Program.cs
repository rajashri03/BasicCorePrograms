using System;
using BasicCoreProgram;
using CheckVowelConsonant;
using LargeNum;
using CheckSwapNumber;
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
        

        Console.WriteLine("Select Number:\n" +
            "1.Check Whether a Number is Even or Odd\n" +
            "2.Check Whether an Alphabet is Vowel or Consonant\n" +
            "3.Find the Largest Among Three Numbers\n"+
            "4.Swap Two Numbers");
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
            default:
                Console.Write("Please Select Correct Number");
                break;
        }
    }
}