using System;

namespace ProjectEuler.Solutions.Q014
{
    class Q014
    {
        static void Main(string[] args)
        {
            var item = 0;
            var sequence = 0;
            for (var a = 2; a <= 1000000; a++)
            {
                var chain = 1;
                long number = a; //attention!
                while (number != 1)
                {
                    if (number % 2 == 0) //even
                    {
                        number = number / 2;
                    }
                    else //odd
                    {
                        number = 3 * number + 1;

                    }
                    chain++;

                }

                if (chain > item)
                {
                    item = chain;
                    sequence = a;

                }

            }
            Console.WriteLine("{0} {1}", sequence, item);
            Console.ReadLine();

        }
    }
}
