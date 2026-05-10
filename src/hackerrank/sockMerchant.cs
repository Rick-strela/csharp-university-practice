using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int sockMerchant(int n, List<int> ar)
    {
        HashSet<int> lonelySocks = new HashSet<int>();
        int pairs = 0;

        foreach (int sock in ar)
        {
            if (lonelySocks.Contains(sock))
            {
                pairs++;
                lonelySocks.Remove(sock);
            }
            else
            {
                lonelySocks.Add(sock);
            }
        }

        return pairs;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();

        int result = sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}