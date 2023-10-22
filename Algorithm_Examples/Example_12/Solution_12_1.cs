using System;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    //
    internal class Solution_12_1
    {
        static List<int> alice = new List<int>() { 4, 2, 9, 12 };
        static List<int> bob = new List<int>() { 9, 3, 5, 1 };

        static void Main(string[] args)
        {
           List<int> sum = compareTriplets(alice, bob);
           Console.WriteLine($"Alice: {sum[0]} Bob: {sum[1]}");
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (b[i] > a[i])
                {
                    bob++;
                }
            }
            List<int> result = new List<int>();
            result.Add(alice);
            result.Add(bob);

            return result;
        }
    }
}
