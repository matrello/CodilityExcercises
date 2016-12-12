using MatroCodility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class InterviewUnitTest
    {
        [TestMethod]
        public void StackMachine()
        {
            Assert.AreEqual(76, InterviewExercises.StackMachine("13+62*7+*"));
            Assert.AreEqual(-1, InterviewExercises.StackMachine("11++"));

            Assert.AreEqual(-1, InterviewExercises.StackMachine(""));

            StringBuilder s = new StringBuilder();
            for (int i = 0; i < 200000; i++)
            {
                s.Append('1');
            }
            Assert.AreEqual(1, InterviewExercises.StackMachine(s.ToString()));
            Assert.AreEqual(-1, InterviewExercises.StackMachine($"+{s.ToString().Substring(0, s.Length - 1) }"));

            s = new StringBuilder();
            s.Append("2");
            for (int i = 0; i < 100000; i++)
            {
                s.Append("2+");
            }
            Assert.AreEqual(200002, InterviewExercises.StackMachine(s.ToString()));

            s = new StringBuilder();
            s.Append("9");
            for (int i = 0; i < 100000; i++)
            {
                s.Append("9*");
            }
            Assert.AreEqual(1944332553, InterviewExercises.StackMachine(s.ToString()));

        }

        [TestMethod]
        public void Deviation()
        {
            Assert.AreEqual(-1, InterviewExercises.Deviation(new int[] { }));
            Assert.AreEqual(3, InterviewExercises.Deviation(new int[] { 9, 4, -3, -10 }));
            Assert.AreEqual(3, InterviewExercises.Deviation(new int[] { 2, 7, -12, -16, 3, 5, -12 }));
            Assert.AreEqual(0, InterviewExercises.Deviation(new int[] { -16, 7, -12, 2, 3, 5, -12 }));
            Assert.AreEqual(6, InterviewExercises.Deviation(new int[] { -12, 7, -12, 2, 3, 5, -16 }));
            Assert.AreEqual(0, InterviewExercises.Deviation(new int[] { 1000 }));
            Assert.AreEqual(0, InterviewExercises.Deviation(new int[] { 0 }));
            Assert.AreEqual(0, InterviewExercises.Deviation(new int[] { -2147483648 }));
            Assert.AreEqual(0, InterviewExercises.Deviation(new int[] { -2147483648, 2147483647 }));
            Assert.AreEqual(0, InterviewExercises.Deviation(new int[] { 2147483647 }));
        }

        [TestMethod]
        public void ComplementaryPair()
        {
            Assert.AreEqual(5, InterviewExercises.ComplementaryPair(4, new int[] { 2, 5, -1, 6, 10, -2 }));
            Assert.AreEqual(3, InterviewExercises.ComplementaryPair(10, new int[] { 1, 5, 9 }));
            Assert.AreEqual(7, InterviewExercises.ComplementaryPair(6, new int[] { 1, 8, -3, 0, 1, 3, -2, 4, 5 }));
            Assert.AreEqual(0, InterviewExercises.ComplementaryPair(0, new int[] { -2147483648, 2147483647 }));
            Assert.AreEqual(2, InterviewExercises.ComplementaryPair(0, new int[] { -2147483648, 2147483647, -2147483647 }));

        }
    }
}
