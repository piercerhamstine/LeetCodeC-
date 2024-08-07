using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class ValidSudoku
    {
        public static bool Solution(char[][] board){
            HashSet<(int, int)> rowDigits = new HashSet<(int, int)>();
            HashSet<(int, int)> colDigits = new HashSet<(int, int)>();
            HashSet<(int, int, int)> squares = new HashSet<(int, int, int)>();

            int subGridSize = 3;
            for(int y = 0; y < board.Length; y++){
                for(int x = 0; x < board.GetLength(0); x++){
                    if(board[y][x] == '.')
                        continue;

                    int currSubCol = y / subGridSize;
                    int currSubRow = x / subGridSize;

                    if(!rowDigits.Add((y, board[y][x])) || !colDigits.Add((x, board[y][x])) || !squares.Add((currSubCol, currSubRow, board[y][x]))){
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

