using System;

namespace ProjectEuler.Solutions.Q018
{
    class Q018
    {
        static void Main(string[] args)
        {
           
            string line;
            int sum = 0;            
            int t = 0;
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"triangleFile.txt");
            while ((line = file.ReadLine()) != null)
            {

                int[] ia = tointarray(line, ' ');
                
                if( ia.Length == 1)
                sum += ia[t];
                else if ( ia[t] > ia[t + 1])
                {
                    sum += ia[t];
                }
                else 
                {
                    sum += ia[t + 1];
                    t++;
                }
            
            }

            int[] tointarray(string value, char sep)
            {
                string[] sa = value.Split(sep);
                int[] ia = new int[sa.Length]; 
                for (int i = 0; i < ia.Length; ++i)
                {
                    int j;
                    string s = sa[i];
                    if (int.TryParse(s, out j))
                    {
                        ia[i] = j;
                    }
                    
                }

     
                return ia;
                
            }

            file.Close(); 
            Console.WriteLine(sum);
            System.Console.ReadLine();
        }
      
    }
}
