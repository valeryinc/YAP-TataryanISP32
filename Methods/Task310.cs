using System;
using System.Linq;

class Task310 : ISolution
{
    public void GetSolution()
    {
        int[] a = { 3, 2, 1, 5, 3 };
        int[] b = { 6, 2, 21, 24 };

        ArraySum(a, b);
    }

    public int[] ArraySum(int[] a, int[] b)
    {
        int[] n = new int[a.Length > b.Length ? a.Length : b.Length];

        for (int i = 0; i < a.Length; ++i)
            n[i] += a[i];

        for (int i = 0; i < b.Length; ++i)
            n[i] += b[i];

        return n;
    }
}
