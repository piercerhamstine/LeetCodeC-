using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target){
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int[] res = new int[2];

            for(int i = 0; i < nums.Length; ++i){
                if(!numbers.ContainsKey(target-nums[i])){
                    numbers[nums[i]] = i;
                }
                else{
                    res[0] = numbers[target-nums[i]];
                    res[1] = i;
                }
            }

            return res;
        }
    }
}