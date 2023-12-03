using System.CodeDom.Compiler;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Diagonal Difference / HackerRank
    internal class Solution_14_1
    {
        static List<List<int>> arr = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };

        static void Main(string[] args)
        {
            Console.WriteLine(diagonalDifference(arr));
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumlr = 0;
            int sumrl = 0;
            int length = arr.Count;

            for (int i = 0; i < length; i++)
            {
                sumlr += arr[i][0 + i];
                sumrl += arr[i][length - i - 1];
            }

            return Math.Abs(sumlr - sumrl);
        }
    }
}
