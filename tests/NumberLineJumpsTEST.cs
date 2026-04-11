using Xunit;
using KangarooApp.Hackerrank;

namespace KangarooApp.Tests
{
    public class Task3Tests
    {
        [Fact]
        public void TestMeetingPointExists()
        {
            string result = Task3.Kangaroo(0, 3, 4, 2);

            Assert.Equal("YES", result);
        }

        [Fact]
        public void TestMeetingPointDoesNotExist()
        {
            string result = Task3.Kangaroo(0, 2, 5, 3);
            Assert.Equal("NO", result);
        }

        [Fact]
        public void TestSlowerKangarooBehind()
        {
            Assert.Equal("NO", Task3.Kangaroo(0, 2, 5, 2));
            Assert.Equal("NO", Task3.Kangaroo(0, 1, 5, 3));
        }
    }
}