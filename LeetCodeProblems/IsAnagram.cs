using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class IsAnagram
    {
        public static bool Solution(string s, string t){
            if(s.Length != t.Length){
                return false;
            }

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; ++i){
                if(!chars.TryAdd(s[i], 1)){
                    chars[s[i]] += 1;
                }
            }

            for(int i = 0; i < t.Length; ++i){
                if(!chars.TryAdd(t[i], 1)){
                    chars[t[i]] -= 1;

                    if(chars[t[i]] == 0){
                        chars.Remove(t[i]);
                    }
                }
                else{
                    return false;
                }
            }

            if(chars.Count == 0){
                return true;
            }

            return false;
        }
    }
}