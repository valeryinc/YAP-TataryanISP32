using System;
using System.Globalization;

class Task73: ISolution
{
    public void GetSolution()
    {
        Date m = new Date(32, 13, 2000);
        m.Next().Print();
    }
}

class Date
{
    private int Day { get; set; }
    private int Month { get; set; }
    private int Year { get; set; }

    public Date(int day, int month, int year)
    {
        if(day == -1 && month == -1 && year == -1)
        {
            Year = 1;
            Month = 1;
            Day = 1;
            return;
        }

        DateTime n = new DateTime(1, 1, 1);
        n = n.AddYears(year - 1);
        n = n.AddMonths(month - 1);
        n = n.AddDays(day - 1);

        Year = n.Year;
        Month = n.Month;
        Day = n.Day;
    }

    public Date Next()
    {
        DateTime n = new DateTime(Year, Month, Day).AddDays(1);
        return new Date(n.Day, n.Month, n.Year);
    }

    public Date Previous()
    {
        DateTime n = new DateTime(Year, Month, Day).AddDays(-1);
        return new Date(n.Day, n.Month, n.Year);
    }

    public void Print()
    {
        DateTime n = new DateTime(Year, Month, Day);
        Console.WriteLine($"The {n.Day} of {n.ToString("MMMM", CultureInfo.GetCultureInfo("en-us"))} {n.Year}");
    }

    public void PrintForward(int n)
    {
        DateTime k = new DateTime(Year, Month, Day);
        k = k.AddDays(1);
        for (int i = 0; i < n; ++i)
        {
            Console.WriteLine($"The {k.Day} of {k.ToString("MMMM", CultureInfo.GetCultureInfo("en-us"))} {k.Year}");
            k = k.AddDays(1);
        }
    }

    public void PrintBackward(int n)
    {
        DateTime k = new DateTime(Year, Month, Day);
        k = k.AddDays(-1);
        for (int i = 0; i < n; ++i)
        {
            Console.WriteLine($"The {k.Day} of {k.ToString("MMMM", CultureInfo.GetCultureInfo("en-us"))} {k.Year}");
            k = k.AddDays(-1);
        }
    }
}

