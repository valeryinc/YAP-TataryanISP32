using System;

class Task3
{
    public static void Solution()
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