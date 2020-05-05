using System;
using System.Collections.Generic;


namespace MyMath
{
    /// <summary> Class where different operations take place </summary>
    public class Operations
    {
        /// <summary> Finds the maximum integer in a list </summary>
        /// <returns> Maximum integer </returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
        {
            return (0);
        }

        int len = nums.Count;
        int max = nums[0];
        for (int i = 0; i < len; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
            else
            {
                continue;
            }
        }
        return (max);
        }
    }
}
