using System;

class Task24 : ISolution
{
    public void GetSolution()
    {
        string n = Console.ReadLine();

        if (n.Contains("2")) Console.WriteLine("Ну что, студент, пора долг Родине отдать");
        else if (n.Contains("3")) Console.WriteLine("Прощай стипендия!");
        else if (n.Contains("4")) Console.WriteLine("Живи пока, через полгода увидимся");
        else Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
    }
}