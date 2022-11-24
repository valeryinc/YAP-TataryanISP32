using System;

class Task31 : ISolution
{
    public void GetSolution()
    {
        string text = Console.ReadLine();
        if (text.Contains("e") || text.Contains("E"))
            Console.WriteLine("Есть буква е, только латинская))))");
        else
            Console.WriteLine("Все норм");
    }
}