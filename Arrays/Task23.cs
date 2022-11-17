using System;
using System.Linq;

class Task23 : ISolution
{
    public void GetSolution()
    {
        string fn = Console.ReadLine();
        string sn = Console.ReadLine();

        Console.Write("Уникальные числа: ");
        for (int i = 0; i < fn.Length; ++i)
        {
            if (fn.Count(x => x == fn[i]) == 1 && !sn.Contains(fn[i])) Console.Write(fn[i] + ", ");
        }
    }
}