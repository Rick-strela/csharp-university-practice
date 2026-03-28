using Xunit;
using System.Collections.Generic;
using AppleAndOrange;

namespace AppleAndOrange.Tests
{
    public class AppleAndOrangeTests
    {
        [Fact]
        public void TestSampleInput()
        {
            int s = 7, t = 11;
            int a = 5, b = 15;
            var apples = new List<int> { -2, 2, 1 };
            var oranges = new List<int> { 5, -6 };

            var (appleResult, orangeResult) = Result.GetCounts(s, t, a, b, apples, oranges);

            Assert.Equal(1, appleResult);
            Assert.Equal(1, orangeResult);
        }
    }
}