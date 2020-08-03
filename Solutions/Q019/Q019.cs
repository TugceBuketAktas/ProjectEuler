using System;

namespace ProjectEuler.Solutions.Q019
{
    class Q019
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            int day = 0;
            int sum = 1;
         
            for (int year = 1901; year <= 2000; year++)
            {
                for(int i = 1; i <= 12; i++)
                {
                    if (i == 4 || i == 6 || i == 9 || i == 11)
                    {
                        day = 30 ;
                    }
                    else if(i == 2)
                    {
                        if (year % 4 == 0)
                        {
                            day = 29 ;
                        }
                        else
                        {
                            day = 28 ;
                        }
                    }
                    else
                    {
                        day = 31 ;
                    }
                    sum += day;
                    
                    calculate(sum);

                }
                       
            }
           
            Console.WriteLine(counter);
            Console.ReadLine();

        }
        static int calculate(int d)
        {
            int key = (d % 7) + 1;

            switch (key)
            {
                case 1:
                    break;

                case 2:
                    break;
                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    counter++;
                    break;
            }
            return counter;
        }
    }
}
