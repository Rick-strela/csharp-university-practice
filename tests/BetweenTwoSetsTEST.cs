using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTasks
{
    public class Task3Tests
    {
        public void RunTests()
        {
            var a1 = new List<int> { 2, 6 };
            var b1 = new List<int> { 24, 36 };
            int result1 = Task3.GetTotalX(a1, b1);
            Console.WriteLine(result1 == 2 ? "Test 1 Passed" : "Test 1 Failed");

            var a2 = new List<int> { 2, 4 };
            var b2 = new List<int> { 16, 32, 96 };
            int result2 = Task3.GetTotalX(a2, b2);
            Console.WriteLine(result2 == 3 ? "Test 2 Passed" : "Test 2 Failed");
        }
    }
}