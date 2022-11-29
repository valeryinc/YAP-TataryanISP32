using System;

struct Vector3
{
    public float x, y, z;

    public Vector3(float x = 0, float y = 0, float z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //гордо стырил из референсов юнити
    public static float Distance(Vector3 a, Vector3 b)
    {
        float diff_x = b.x - a.x;
        float diff_y = b.y - a.y;
        float diff_z = b.z - a.z;
        return (float)Math.Sqrt(diff_x * diff_x + diff_y * diff_y + diff_z * diff_z);
    }

    public static float Path(Vector3 startPos, Vector3 targetPos)
    {
        //сначала двигаемся горизонтально, чтоб выровняться по координатам x и y
        float p1 = Distance(startPos, new Vector3(targetPos.x, targetPos.y, startPos.z));
        //опускаемся
        float p2 = Distance(new Vector3(targetPos.x, targetPos.y, startPos.z), targetPos);
        return p1 + p2;
    }
}

class Task53 : ISolution
{
    public void GetSolution()
    {
        Vector3 spider = new(3, 3, 3);
        Vector3 fly = new(1, 2);
        Console.WriteLine($"{Vector3.Distance(spider, fly):F5}");
        Console.WriteLine($"{Vector3.Path(spider, fly):F5}");
    }
}

