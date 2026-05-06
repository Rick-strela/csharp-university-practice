using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int migratoryBirds(List<int> arr)
    {
        int[] counts = new int[6];

        foreach (int type in arr)
        {
            counts[type]++;
        }

        int maxFrequency = 0;
        int resultId = 0;
        for (int i = 1; i <= 5; i++)
        {
            if (counts[i] > maxFrequency)
            {
                maxFrequency = counts[i];
                resultId = i;
            }
        }

        return resultId;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string input = Console.ReadLine();

        List<int> arr = input.TrimEnd().Split(' ').Select(int.Parse).ToList();

        int result = migratoryBirds(arr);

        Console.WriteLine(result);
    }
}