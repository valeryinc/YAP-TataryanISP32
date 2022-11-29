using System;
using System.Linq;
using System.Globalization;

class MyString
{
    private string str;

    public MyString(string str) => this.str = str;

    public string Reverse() => new (str.Reverse().ToArray());

    public string UcFirst() => str.Substring(0, 1).ToUpper() + str.Substring(1);

    public string UcWords() => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
}

class Task52 : ISolution
{
    public void GetSolution()
    {
        MyString myString = new("simple text");

        Console.WriteLine(myString.Reverse());
        Console.WriteLine(myString.UcFirst());
        Console.WriteLine(myString.UcWords());
    }
}