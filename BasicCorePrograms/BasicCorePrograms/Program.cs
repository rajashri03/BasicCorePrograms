using System;
using BasicCoreProgram;
using CheckVowelConsonant;
using LargeNum;
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

        Console.WriteLine("Select Number:\n1.Check Whether a Number is Even or Odd\n2.Check Whether an Alphabet is Vowel or Consonant\n3.Find the Largest Among Three Numbers");
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
            default:
                Console.Write("Please Select Correct Number");
                break;
        }
    }
}