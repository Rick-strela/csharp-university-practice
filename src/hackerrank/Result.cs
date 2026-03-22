using Xunit;
using System.Collections.Generic;
using HackerRankTasks;

public class GradingTests
{
    [Fact]
    public void TestGradingLogic()
    {
        var input = new List<int> { 73, 67, 38, 33 };
        var expected = new List<int> { 75, 67, 40, 33 };

        var result = Result.gradingStudents(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(29, 29)]
    [InlineData(57, 57)]
    [InlineData(84, 85)]
    public void TestIndividualGrades(int inputGrade, int expectedGrade)
    {
        var result = Result.gradingStudents(new List<int> { inputGrade });
        Assert.Equal(expectedGrade, result[0]);
    }
}