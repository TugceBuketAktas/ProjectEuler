using System;
using System.Collections;

namespace ProjectEuler.Solutions.Q000
{
    #region detail about the question
    //Have the function ArrayChallenge(strArr) read the array of strings stored in strArr which will contain only two elements, both of which will represent an array of positive integers.For example: if strArr is ["[1, 2, 5, 6]", "[5, 2, 8, 11]"], then both elements in the input represent two integer arrays, and your goal for this challenge is to add the elements in corresponding locations from both arrays.For the example input, your program should do the following additions: [(1 + 5), (2 + 2), (5 + 8), (6 + 11)] which then equals[6, 4, 13, 17]. Your program should finally return this resulting array in a string format with each element separated by a hyphen: 6-4-13-17. 
    //If the two arrays do not have the same amount of elements, then simply append the remaining elements onto the new array(example shown below). Both arrays will be in the format: [e1, e2, e3, ...] where at least one element will exist in each array.
    //Examples
    //Input: new string[] {"[5, 2, 3]", "[2, 2, 3, 10, 6]"}
    //Output: 7 - 4 - 6 - 10 - 6 
    //Input: new string[] { "[1, 2, 1]", "[2, 1, 5, 2]" }
    //Output: 3 - 3 - 6 - 2

    #endregion

    class ArrayChallenge
    {
        static void Main(string[] args)
        {
            //string[] strArr = new string[] { "[5,2,3]", "[2,2,3,10,6]" };
            string[] strArr = new string[] { "[1,2,1]", "[2,1,5,2]" };
            ArrayChllenge(strArr);

        }

        static string data;
        static ArrayList data2 = new ArrayList();
        static int[,] array = new int[5, 5];
        static int[] nums = new int[5];
        private static void ArrayChllenge(string[] prm)
        {
         
            for ( int i = 0; i < prm.Length; i++)
            {

                data = string.Concat(prm[i].Replace("[","").Replace("]",""));                
                nums = Array.ConvertAll(data.Split(','),int.Parse);
                data2.Add(nums);

                Sum(nums,data2);
                
            }

            Console.ReadLine();

        }

        private static void Sum(int[] nums,ArrayList data2)
        {

            string STR = " ";
            for (int i = 0; i < nums.Length;i++)
            {
                array[i, 0] += nums[i];
                if(data2.Count > 1)
                {
                    string value = Convert.ToString(array[i, 0]);
                    string character = "-";
                    STR += String.Concat(value, character);
                    
                }
               
            }
            string output = STR.Substring(0, STR.Length - 1);

            Console.Write(output);

        }
        
    }
}
