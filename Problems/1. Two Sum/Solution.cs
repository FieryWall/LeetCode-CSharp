using System;
using System.Collections.Generic;

namespace csharp.Problems._1._Two_Sum
{
    public class TwoSumSolution {
        public int[] TwoSum(int[] nums, int target) {
            var r = new int[2];
            var d = new Dictionary<int, int>();
            r[0] = nums.Length;
            while(!d.TryGetValue(target - nums[--r[0]], out r[1]))
            {
                if((d[nums[r[0]]] = r[0]) < 0) throw new Exception();
            }
            return r;
        }
    }
}