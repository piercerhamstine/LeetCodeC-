using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class EncodeDecode
    {
        static char delimiter = '!';
        public static string Encode(IList<string> strs){
            string encodedString = "";

            for(int i = 0; i < strs.Count; ++i){
                encodedString += strs[i].Length.ToString()+delimiter + strs[i];
            }

            return encodedString;
        }

        public static List<string> Decode(string s){
            List<string> decoded = new List<string>();
            string currWord = "";
            int currWordLength;
            for(int i = 0; i < s.Length; ++i){
                currWord += s[i];

                if(s[i] == delimiter){
                    string wordLength = currWord[currWord.Length-2].ToString();
                    currWordLength = int.Parse(wordLength);

                    currWord = s.Substring(i+1, currWordLength);
                    i += currWord.Length;                    

                    decoded.Add(currWord);

                    currWord = "";
                }
            }

            return decoded;
        }
    }
}