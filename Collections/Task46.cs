using System;
using System.Collections.Generic;
using System.Linq;

class Task46 : ISolution
{
    public void GetSolution()
    {
        HashSet<int> n = "1 3 4 5 7 8 9 10".Split(' ').Select(x => int.Parse(x)).ToHashSet();
        for (int i = n.First(); i < n.Last(); ++i)
            if (!n.Contains(i))
                Console.Write(i + " ");
        Console.WriteLine();
    }
}