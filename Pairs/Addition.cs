using System;
using System.Collections.Generic;
using System.Text;

namespace Pairs
{
    class Addition
    {
        static bool isPairSum(int[] A, int N, int X)
        {
            // represents first pointer 
            int i = 0;

            // represents second pointer 
            int j = N - 1;

            while (i < j)
            {

                // If we find a pair 
                if (A[i] + A[j] == X)
                    return true;

                // If sum of elements at current 
                // pointers is less, we move towards 
                // higher values by doing i++ 
                else if (A[i] + A[j] < X)
                    i++;

                // If sum of elements at current 
                // pointers is more, we move towards 
                // lower values by doing j-- 
                else
                    j--;
            }
            return false;
        }
    }
}
