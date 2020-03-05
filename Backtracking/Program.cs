using System;

namespace Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Subsets sb = new Subsets();
            // sb.Subsets_Iterative(new int[] { 1,2,3});
            // sb.Subsets_Recursive(new int[] { 1, 2, 3 });
            sb.SubsetsWithDup(new int[] {1, 2, 2});
        }
    }
}
