using System;

class Task26 : ISolution
{
    public void GetSolution()
    {
        int[] n = { 5, 32, 234, 432, 1, 21, 7, 4, 324 };

        for (int i = 0; i < n.Length; i++)
            for (int j = 0; j < n.Length - i - 1; j++)
            {
                if (n[j] > n[j + 1])
                {
                    int temp = n[j];
                    n[j] = n[j + 1];
                    n[j + 1] = temp;
                }
            }

        foreach (int x in n)
            Console.Write(x + " ");
        Console.WriteLine();
    }
}