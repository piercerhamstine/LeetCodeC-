using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class ContainsDupe
    {
        public static bool Solution(int[] nums){
            HashSet<int> set = new HashSet<int>();

            for(int i = 0; i < nums.Length; ++i){
                if(set.Contains(nums[i])){
                    return true;
                }

                set.Add(nums[i]);
            }

            return false;
        }
    }
}