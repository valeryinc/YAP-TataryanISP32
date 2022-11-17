using System;

class Task13 : ISolution
{
    public void GetSolution()
    {
        int height = int.Parse(Console.ReadLine());
        int space = height;

        for (int i = 0, j = 1; i < height; ++i, j += 2)
        {
            Console.Write(new string(' ', --space));
            Console.Write(new string('*', j));
            Console.WriteLine();
        }
    }
}