using System;
using System.Collections.Generic;

class Task34 : ISolution
{
    public void GetSolution()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        PrintEven(GetMultiple(startValue, endValue));
    }

    public void PrintEven(List<int> toPrint)
    {
        foreach(int l in toPrint)
        {
            Console.WriteLine(l + " ");
        }
    }

    public List<int> GetMultiple(int startValue, int endValue)
    {
        List<int> res = new List<int>();
        for(int i = startValue; i <= endValue; ++i)
        {
            if(i % 7 == 0 && i != 0)
            {
                res.Add(i);
            }
        }
        return res;
    }
}