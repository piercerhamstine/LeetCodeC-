using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class TopK
    {
        public static int[] Solution(int[] nums, int k){
            List<int> res = new List<int>();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; ++i){
                if(!dict.TryAdd(nums[i], 1)){
                    dict[nums[i]] += 1;
                }
            }
        
            var sorted = dict.OrderByDescending(item => item.Value);

            for(int i = 0; i < k; ++i){
                res.Add(sorted.ElementAt(i).Key);
            }

            return res.ToArray();
        }
    }
}