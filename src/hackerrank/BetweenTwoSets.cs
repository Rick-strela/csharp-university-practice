using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTasks
{
    public class Task3
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int count = 0;

            int start = a.Max();
            int end = b.Min();
            for (int i = start; i <= end; i++)
            {
                bool condition1 = true;
                foreach (int x in a)
                {
                    if (i % x != 0)
                    {
                        condition1 = false;
                        break;
                    }
                }

                if (condition1)
                {
                    bool condition2 = true;
                    foreach (int x in b)
                    {
                        if (x % i != 0)
                        {
                            condition2 = false;
                            break;
                        }
                    }

                    if (condition2)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}