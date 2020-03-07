using System;
using System.Collections.Generic;
using System.Text;

namespace Backtracking
{
    public class WordSearch
    {
        /// <summary>
        /// https://leetcode.com/problems/word-search
        /// </summary>
        /// <param name="board"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0] && Backtracking_WordSearch(board, word, i, j, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Backtracking_WordSearch(char[][] board, string word, int i, int j, int count)
        {
            // count here is my backtracking iterator
            if (count == word.Length)
            {
                return true;
            }
            if (i<0 || i>=board.Length || j<0 || j>= board[i].Length || board[i][j] != word[count])
            {
                return false;
            }
            char temp = board[i][j]; // not to lose the currrent value
            board[i][j] = ' '; // mark the cell
            bool found = Backtracking_WordSearch(board, word, i + 1, j, count + 1) ||
                Backtracking_WordSearch(board, word, i - 1, j, count + 1) ||
                Backtracking_WordSearch(board, word, i, j + 1, count + 1) ||
                Backtracking_WordSearch(board, word, i, j - 1, count + 1);
            board[i][j] = temp; // retrieve the value
            return found;
        }
    }
}
