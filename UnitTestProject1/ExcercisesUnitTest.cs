using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using MatroCodility;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class ExcercisesUnitTest
    {
        [TestMethod]
        public void BinaryGap()
        {
            var input = new int[] { 9, 529, 20, 15, 1041 };

            Array.ForEach(input, t => Debug.WriteLine("Input: {0} Output: {1}", t, Excercises.BinaryGap(t)));
        }

        [TestMethod]
        public void OddOccurencesInArray()
        {
            var input = new List<int[]>() {
                new int[] { 1, 2, 3, 4, 2, 3, 4, 5, 1 } ,
                new int[] { 1, 2, 5, 4, 2, 3, 4, 5, 1 } ,
                new int[] { 1, 2, 3, 4, 2, 3, 4, 5, 5 } ,
                new int[] { 1, 2, 3, 4, 2, 3, 5, 5, 1 } };

            for (int seq = 0; seq < input.Count; seq++)
                Debug.WriteLine("Sequence {0} Output: {1}", seq,  Excercises.OddOccurencesInArray2(input[seq]));
        }

        [TestMethod]
        public void Rotate()
        {
            var input = new List<int[]>() {
                new int[] {  3, 5, 1, 1, 2 } ,
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8 } ,
                new int[] { 1, 2, 3, 4, 5 } ,
                new int[] { 1, 2, 3, 4, 5, 6 } };

            var rot = new int[] { 4, 4, 7, 7 };

            for (int seq = 0; seq < input.Count; seq++)
            {
                var output = Excercises.Rotate(input[seq], rot[seq]);

                Debug.Write("Output: ", seq.ToString());
                Array.ForEach(output, x => Debug.Write($"{x}, "));
                Debug.WriteLine("");
            }
        }

        [TestMethod]
        public void FloodDepth()
        {
            var input = new List<int[]>() {
                new int[] { 3, 1, 2 } ,
                new int[] { 1, 2, 3 } ,
                new int[] { 2, 1, 3 } ,
                new int[] { 3, 2, 1 } ,
                new int[] { 2, 3, 1 } ,
                new int[] { 1, 3, 2 } ,
                new int[] { 5, 8 } ,
                new int[] { 2, 6, 5, 6, 12, 9, 13, 2, 5, 3 } ,
                new int[] { 2, 6, 1, 6, 12, 9, 13, 2, 5, 3 } ,
                new int[] { 2, 3, 3, 3, 2, 5, 3, 2, 5, 3 }
            };

            Random rnd = new Random();

            var input2 = new int[100000];

            for (int k = 0; k < 100000; k++)
                input2[k] = rnd.Next(100000000);

            for (int seq = 0; seq < input.Count; seq++)
                Debug.WriteLine("Sequence {0} Output: {1}", seq, Excercises.FloodDepth(input[seq]));
        }

        [TestMethod]
        public void FloodDepthLarge()
        {
            Random rnd = new Random();

            var input = new int[100000];

            for (int k = 0; k < 100000; k++)
                input[k] = rnd.Next(100000000);

            Debug.WriteLine("Large Sequence Output: {0}", Excercises.FloodDepth(input));
        }

    }
}
