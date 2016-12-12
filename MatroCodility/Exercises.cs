using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatroCodility
{
    public class Exercises
    {
        public static int BinaryGap(int N)
        {
            if (N < 5) return 0;

            var bin = Convert.ToString(N, 2);
            var isGap = false;
            var gapLen = 0;
            var gapMax = 0;

            for (int k = 0; k < bin.Length; k++)
            {
                if (bin.Substring(k, 1) == "0")
                {
                    if (isGap) gapLen++;
                }
                else
                {
                    if (isGap)
                    {
                        if (gapLen > gapMax) gapMax = gapLen;
                        gapLen = 0;
                    }

                    isGap = true;
                }

                if (gapLen + (bin.Length - k) <= gapMax) break;
            }

            return gapMax;
        }

        public static int OddOccurencesInArray(int[] A)
        {
            return A.FirstOrDefault(x => A.Count(y => y == x) == 1);
        }

        public static int OddOccurencesInArray2(int[] A)
        {
            var B = A.OrderBy(x => x).ToArray();

            int p = 0;

            while (p < A.Length - 1)
            {
                if (B[p] != B[p + 1])
                    return B[p];

                p+=2;
            }

            return B[p];
        }

        public static int[] Rotate(int[] A, int K)
        {
            if (K == 0) return A;
            if (A.Length == 0) return A;

            var shift = K > A.Length ? K % A.Length : K;

            var right = A.Skip(A.Length - shift);
            var left = A.Take(A.Length - shift);

            return right.Concat(left).ToArray();
        }

        public static int FloodDepth(int[] A)
        {
            var D = new int[A.Length];

            for (int K = 1; K < A.Length - 1; K++)
            {
                D[K] = MinBorder(K, A);

                if (K % 10000 == 0)
                    Debug.WriteLine("Cycle: {0}", K);
            }

            return D.Max();
        }

        private static int MinBorder(int P, int[] A)
        {
            if (P == 0) return 0;
            if (P == A.Length - 1) return 0;

            int maxLeft = 0;
            int maxRight = 0;
            
            for (int K = P - 1; K >= 0; K--)
                if (A[K] > A[P] && (A[K] - A[P]) > maxLeft) maxLeft = A[K] - A[P];

            if (maxLeft == 0) return 0;

            for (int K = P + 1; K <= A.Length - 1; K++)
                if (A[K] > A[P] && (A[K] - A[P]) > maxRight) maxRight = A[K] - A[P];

            if (maxRight == 0) return 0;

            return (Math.Min(maxLeft, maxRight));
        }
    }
}
