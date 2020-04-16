using System;

namespace ProjectEuler.Solutions.Q015
{
    class Q015
    {
        static void Main(string[] args)
        {
            long[,] sequence = new long[21, 21];
            long item=0;

            for (long i = 0; i <= 19; i++)
            {
                sequence[i+1, 0] = 1;
                for (long j = 0; j <= 20; j++)
                {
                    if (j < 20)
                    {
                        sequence[0, j+1] = 1;                  
                        item = sequence[i, j+1] + sequence[i+1, j];
                        sequence[i+1, j+1] = item;
                    }
                }
               
            }
            Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}






