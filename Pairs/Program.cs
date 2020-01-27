using System;

namespace Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = { 1 ,3, 5, 8, 6, 4, 2 };
            
            int x = 2;
            var result= pairs( x, a);
            
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int pairs(int k, int[] arr)
        {

            //Sort the array first 
            Array.Sort(arr);
            //this varible will hold the count to the number of success results
            int count = 0;
            //we will use the pointer technique to solve this challange;
            //have two pointers
            //the first pointer represents the first elment in the array
            int i = 0;
            //the second pointer represents the second element in the array
            int j = 1;
            int n = arr.Length;

            while (j < n)
            {
                //if we find a pair, increment the count
                if (arr[j] - arr[i] == k)
                {
                    count++;
                    i++;
                    j++;
                }

                else if (arr[j] - arr[i] < k)
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }


            return count;


        }
        
    }
}
