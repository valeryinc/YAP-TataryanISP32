using System;

class MainClass
{
    public static void Main()
    {
        //ISolution n = new Task26();
        //n.GetSolution();
        VasyaStyle(56);
    }

    static void VasyaStyle(int value)
    {
        string numbers = "237";
        string temp = "222";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int s = 0; s < 3; s++)
                {
                    if (int.Parse(numbers[i].ToString()) *
                    int.Parse(numbers[j].ToString()) + int.Parse(numbers[s].ToString()) == value)
                    {
                        if (temp[0] == numbers[j] && temp[1] == numbers[i] && temp[2] == numbers[s])
                        {
                            continue;
                        }
                        else
                        {
                            temp = (numbers[i] + numbers[j] + numbers[s]).ToString();
                            Console.WriteLine($"{numbers[i]} * {numbers[j]} + {numbers[s]}");
                        }
                    }
                }
            }
        }
    }
}