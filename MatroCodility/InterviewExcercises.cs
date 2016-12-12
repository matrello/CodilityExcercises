using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatroCodility
{
    public class InterviewExercises
    {
        public static int StackMachine(string S)
        {
            var stack = new Stack<uint>();
            string c;
            uint n1, n2;

            try
            {
                for(int k = 0; k < S.Length; k++)
                {
                    c = S.Substring(k, 1);

                    switch (c)
                    {
                        case "+":
                            n1 = stack.Pop();
                            n2 = stack.Pop();
                            stack.Push(n1 + n2);
                            break;

                        case "*":
                            n1 = stack.Pop();
                            n2 = stack.Pop();
                            stack.Push(n1 * n2);
                            break;

                        default:
                            stack.Push(uint.Parse(c));
                            break;
                    }
                }

                return (int)stack.Pop();
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static int Deviation(int[] A)
        {
            if (A.Length == 0) return -1;

            int pMaxDev = 0;
            double M = A.Average();
            
            for (int P = 0; P < A.Length; P++)
                if (Math.Abs(A[P] - M) > Math.Abs(A[pMaxDev] - M)) pMaxDev = P;

            return pMaxDev;
        }

        // FM.2016.09.19 - http://peter-braun.org/2012/01/algorithms-to-find-complemantary-pairs-of-numbers-in-an-array/
        // FM.2016.09.19 - https://codebutchery.wordpress.com/2015/03/29/codility-and-the-k-complementary-pairs-in-array-challenge/

        public static int ComplementaryPair(int K, int[] A)
        {
            var complOccurrencies = new Dictionary<long, int>();
            int counter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                long compl = ((long)K) - A[i];

                if (complOccurrencies.ContainsKey(compl))
                    complOccurrencies[compl] += 1;
                else
                    complOccurrencies.Add(compl, 1);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (complOccurrencies.ContainsKey(A[i]))
                    counter += complOccurrencies[A[i]];
            }

            return counter;
        }
    }
}
