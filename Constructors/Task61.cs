using System;

class Task61 : ISolution
{
    public void GetSolution()
    {
        var myWatch = new Watch("Casio", "electronic", 15.99M);
        myWatch.Print();
    }
}

class Watch
{
    public Watch(string name, string type, decimal price) { }
    public void Print() { }
}
