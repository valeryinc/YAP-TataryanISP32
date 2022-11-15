using System;

class Task2
{
    public static void Solution()
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        while (number > 1)
        {
            if (number % 2 == 0) number /= 2;
            else number = number * 3 + 1;
            count++;
        }
        Console.WriteLine($"Количество необходимых действий над числом - {count}");
    }
}

