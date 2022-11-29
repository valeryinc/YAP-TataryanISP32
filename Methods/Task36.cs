using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

class Task36 : ISolution
{
    //работает только с однозначными числами
    //56 = 7 * 7 + 7
    //23 = 7 * 3 + 2
    public void GetSolution()
    {
        int number = int.Parse(Console.ReadLine());
        VasyaStyle(number);
    }

    public void VasyaStyle(int number)
    {
        int[] numbers = { 2, 3, 7 };
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                int b = number - (numbers[i] * numbers[j]);
                if (b > 0 && numbers.Contains(b) && !set.Contains(numbers[i] * numbers[j]))
                {
                    Console.WriteLine($"{numbers[i]} * {numbers[j]} + {b}");
                    set.Add(numbers[i] * numbers[j]);
                }
            }
        }

        if (set.Count == 0)
        {
            Console.WriteLine("Купите нормальный калькулятор пж");
        }
    }
}