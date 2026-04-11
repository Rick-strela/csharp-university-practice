using System;

namespace KangarooApp.Hackerrank
{
    public static class Task3
    {
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 <= v2)
            {
                return "NO";
            }

            bool willMeet = (x2 - x1) % (v1 - v2) == 0;

            return willMeet ? "YES" : "NO";
        }
    }
}