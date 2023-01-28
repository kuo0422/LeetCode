using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Code
{
    internal class Running_Sum_of_1d_Array_1480
    {
        public int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            Array.Copy(nums, 0, result, 0, nums.Length);

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] += result[i - 1];
            }

            return result;
        }

        internal void PrintResult(int[] data, int[] result)
        {
            var printValue = String.Join(',', data);
            var printResultValue = String.Join(',', result);

            Console.WriteLine($"Input: nums = [{printValue}]");
            Console.WriteLine($"Output: [{printResultValue}]");
        }

        internal int[] GetInitialData()
        {
            return new int[] { 1, 2, 3, 4 };
        }
    }
}