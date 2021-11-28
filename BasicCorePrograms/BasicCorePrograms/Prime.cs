using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
    public class Prime
    {
        int N,i;
        int CheckPrimee;
        public void CheckPrime()
        {
            Console.Write("*----------Print the prime factors of number N-------------*\n\n");
            Console.Write("Enter Number To Find Prime Factor:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPrime factor of " + N + " is\n");
            for (i=2;i<=N;i++)
            {
                if(N%i==0)
                {
                    CheckPrimee = 1;
                    for(int j=2;j<=i/2;j++)
                    {
                        if(i%j==0)
                        {
                            CheckPrimee = 0;
                        }
                    }
                    if(CheckPrimee==1)
                    {
                        Console.Write(i+ "\n");
                    }
                }

            }
            Console.Write("\n");
        }
        

    }
}
