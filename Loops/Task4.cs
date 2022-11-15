using System;

class Task4
{
    public static void Solution()
    {
        int n = int.Parse(Console.ReadLine());
        int ticks = 0;
        TimeSpan time = new TimeSpan(12, 30, 0);
        double angle, prevAngle = Angle(time);

        while (ticks != n)
        {
            time = time.Add(new TimeSpan(0, 1, 0));
            angle = Angle(time);
            if (prevAngle < 30 && angle >= 30) ++ticks;
            prevAngle = angle;
        }
        Console.WriteLine(time.ToString("hh':'mm"));
    }

    public static double Angle(TimeSpan time)
    {
        double hAngle = 0.5d * (time.Hours * 60 + time.Minutes);
        double mAngle = 6 * time.Minutes;
        double angle = Math.Abs(hAngle - mAngle);
        angle = Math.Min(angle, 360 - angle);
        return angle;
    }
}