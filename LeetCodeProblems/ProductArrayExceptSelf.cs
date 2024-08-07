using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class ProductArrayExceptSelf
    {
        public static int[] Solution(int[] nums){
            int[] result = new int[nums.Length];
                
            int prefix = 1;
            for(int i = 0; i < nums.Length; ++i){
                result[i] = prefix;
                prefix *= nums[i];
                
            }

            int postfix = 1;
            for(int i = nums.Length-1; i >= 0; i--){
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }
    }
}