using System;
using System.Collections.Generic;

class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        if (scores == null || scores.Count == 0) return new List<int> { 0, 0 };

        int max = scores[0];
        int min = scores[0];

        int countMax = 0;
        int countMin = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > max)
            {
                max = scores[i];
                countMax++;
            }
            else if (scores[i] < min)
            {
                min = scores[i];
                countMin++;
            }
        }

        return new List<int> { countMax, countMin };
    }
}