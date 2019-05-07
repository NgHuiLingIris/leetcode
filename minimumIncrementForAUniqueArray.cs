using System;
using System.Linq;

namespace MinIncrementUniqueArray
{
    public class Solution
    {
        public static void Main()
        {
            int[] A = new int[] { 165, 489, 594, 646, 69, 455 };
            int increment = MinIncrementForUnique(A);
            Console.WriteLine(increment);
        }
        public static int MinIncrementForUnique(int[] A)
        {
            int increment = 0;
            do
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] == A[i + 1])
                    {
                        A[i + 1] = A[i + 1] + 1;
                        increment++;
                    }
                }
                Array.Sort(A);
            } while (checkUnique(A) == false);
            return increment;
        }
        public static bool checkUnique(int[] A)
        {
            if (A.Length != A.Distinct().Count())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
