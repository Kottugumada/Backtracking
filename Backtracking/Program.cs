using System;

namespace Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ExpressionsAddOperators exp = new ExpressionsAddOperators();
            exp.AddOperators("123", 6);
            Subsets sb = new Subsets();
            // sb.Subsets_Iterative(new int[] { 1,2,3});
           // sb.Subsets_Recursive(new int[] { 1, 2, 3 });
            // sb.SubsetsWithDup(new int[] {1, 2, 2});
            Permutations pr = new Permutations();
            // pr.Permute(new int[] { 1,2,3});
            PalindromePartitioning pp = new PalindromePartitioning();
            // pp.Partition("aabccd");
            NQueens nq = new NQueens();
            NQueens_Attempt2 nq2 = new NQueens_Attempt2();
            // nq2.SolveNQueens(4);
            LetterCombinationsPhoneNumbers lq = new LetterCombinationsPhoneNumbers();
            lq.LetterCombinations("23");
        }
        
    }
}
