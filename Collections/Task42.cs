using System;
using System.Collections.Generic;
using System.Linq;

class Task42 : ISolution
{
    public void GetSolution()
    {
        List<int> numbers = "1 2 3 0 5 6 7 0 9".Split(' ').Select(x => int.Parse(x)).Reverse().ToList();
        for(int i = numbers.IndexOf(0) + 1; i < numbers.LastIndexOf(0); ++i)
            Console.Write(numbers[i] + " ");
        Console.WriteLine();
    }
}