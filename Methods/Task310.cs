using System;
using System.Linq;

class Task310 : ISolution
{
    public void GetSolution()
    {
        int[] a = { 3, 2, 1, 5, 3 };
        int[] b = { 6, 2, 21, 24, };

        Console.WriteLine(ArraySum(a, b));
    }

    public int ArraySum(int[] a, int[] b)
    {
        return a.Sum() + b.Sum();
    }
}