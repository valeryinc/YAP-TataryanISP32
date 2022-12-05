using System;

class Money
{
    private int rub_ = 0;
    private int kop_ = 0;

    public int kop
    {
        get { return kop_; }
        set {
            rub += value / 100;
            kop_ = value % 100;
        }
    }

    public int rub { get; set; }

    public Money(string value, string type)
    {
        if (int.Parse(value) < 0)
        {
            Console.WriteLine("Не может быть отрицательным!");
            return;
        }
        switch (type)
        {
            case "р.":
                rub += int.Parse(value);
                break;
            case "коп.":
                kop += int.Parse(value);
                break;
            default: throw new ArgumentException("Ты чево");
        }
    }

    public Money(string value1, string type1, string value2, string type2)
    {
        if (int.Parse(value1) < 0 || int.Parse(value2) < 0)
        {
            Console.WriteLine("Не может быть отрицательным!");
            return;
        }

        if(type1 == "коп.")
        {
            Console.WriteLine("Рубли и копейки перепутаны местами!");
            return;
        }

        rub += int.Parse(value1);
        kop += int.Parse(value2);
    }

    public Money(int rub, int kop)
    {
        if(rub < 0 || kop < 0) throw new ArgumentException("Не может быть меньше нуля");

        this.rub = rub;
        this.kop = kop;
    }

    public static Money Sum(Money a, Money b)
    {
        return new Money(a.rub + b.rub, a.kop + b.kop);
    }

    public static Money Difference(Money a, Money b)
    {
        int n = (a.rub * 100 + a.kop) - (b.rub * 100 + b.kop);
        if (n < 0) throw new Exception("Результат разницы не может быть отрицательным");
        return new Money(n/100, n%100);
    }

    public void Print()
    {
        if (rub == 0) return;
        Console.WriteLine($"{rub} руб {kop} к.");
    }

    public void PrintTransferCost(float prc)
    {
        int n = (rub * 100 + kop);
        int res = (int) Math.Ceiling(n + n * prc);
        Console.WriteLine($"{res/100} руб {res%100} к.");
    }
}

class Task64: ISolution
{
    public void GetSolution()
    {
        Money n = new Money(17, 10);
        Money d = new Money(10, 40);

        Money b;
        b = Money.Difference(n, d);
        b.Print();
        b = Money.Sum(n, d);
        b.Print();
        n.PrintTransferCost(0.05f);
    }
}
