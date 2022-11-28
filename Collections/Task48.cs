using System;
using System.Collections.Generic;
using System.Linq;

class Task48 : ISolution
{
    public void GetSolution()
    {
        string source = "даабввв";
        string result = "";

        for(int i = 'а'; i < 'я'; ++i)
        {
            if (!source.Contains((char)i)) continue;
            int index = source.IndexOf((char) i, 0);
            result += (char)i + " ";

            while (index > -1)
            {
                result += index + " ";
                index = source.IndexOf((char)i, index + 1);
            }
        }

        Console.WriteLine(result);
    }
}