using System;
using System.Numerics;

namespace ProjectEuler.Solutions.Q020
{
    class Q020
    {
        static void Main(string[] args)
        {
            BigInteger result = 0;
            int val = 100;
            Console.WriteLine(calculate(faktoriyel(val)));
            Console.ReadLine();


            BigInteger faktoriyel(int value)
            {
                BigInteger multiplication = 1;
                for (int i = 1; i <= value; i++)
                {
                    multiplication *= i;
                }
                return multiplication;

            }
            BigInteger calculate(BigInteger calc)
            {
                for (int i = 0; ; i++)
                {
                    if (calc > 0)
                    {
                        result += calc % 10;
                        calc = calc / 10;

                    }
                    else break;
                }
                              
                return result;
            }         
        }
    }
}
