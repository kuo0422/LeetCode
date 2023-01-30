using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Code
{
    internal class D1_2_Find_Pivot_Index_No724
    {
        public int PivotIndex(int[] nums)
        {
            int leftSum = 0, rightSum = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }

            return -1;
        }

        internal void PrintResult(int[] data, int result)
        {
            var printValue = String.Join(',', data);
            var printResultValue = String.Join(',', result);

            Console.WriteLine($"Input: nums = [{printValue}]");
            Console.WriteLine($"Output: {result}");
        }

        internal int[] GetInitialData()
        {
            return new int[] { 1, 7, 3, 6, 5, 6 };
        }
    }
}