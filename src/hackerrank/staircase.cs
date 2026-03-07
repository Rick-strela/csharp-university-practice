using System;
using System.Text;
using NUnit.Framework;

namespace PracticalWork.HackerRank
{
    public class StaircaseTask
    {
        public static string BuildStaircase(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                string line = new string(' ', n - i) + new string('#', i);
                sb.Append(line);
                if (i < n)
                {
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }
        public static void PrintStaircase(int n)
        {
            Console.WriteLine(BuildStaircase(n));
        }
    }
    [TestFixture]
    public class StaircaseTests
    {
        [Test]
        public void TestStaircase_Size6()
        {
            int n = 6;
            string expected =

                "     #\n" +
                "    ##\n" +
                "   ###\n" +
                "  ####\n" +
                " #####\n" +
                "######";


            string result = StaircaseTask.BuildStaircase(n).Replace("\r\n", "\n");
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestStaircase_Size1()
        {
            Assert.That(StaircaseTask.BuildStaircase(1), Is.EqualTo("#"));
        }
    }
}