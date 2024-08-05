using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> Solution(string[] strs){
            // SORTING SOLUTION
            // Dictionary<string, IList<string>> anagrams = new Dictionary<string, IList<string>>();
            // foreach(var str in strs){
            //     var strToArray = str.ToArray();
            //     Array.Sort(strToArray);

            //     if(!anagrams.TryAdd(new string(strToArray), new List<string>())){
            //         anagrams[new string(strToArray)].Add(str);
            //     }
            //     else{
            //         anagrams[new string(strToArray)].Add(str);
            //     }
            // }
            // return anagrams.Values.ToList();
            
            // 'Hashing' Solution
            Dictionary<string, IList<string>> anagrams = new Dictionary<string, IList<string>>();
            foreach(var s in strs){
                char[] count = new char[26];

                foreach(var c in s){
                    count[c-'a']++;
                }
                string key = new string(count);

                if(!anagrams.TryGetValue(key, out var value)){
                    anagrams.Add(key, new List<string>());
                }

                anagrams[key].Add(s);
            }

            return anagrams.Values.ToList();
        }
    }
}