using System;

class Interval
{
    static void Main()
    {
        Console.Write("Enter a real number: ");
        double x = Convert.ToDouble(Console.ReadLine());

        if ((x >= 2 && x < 3) || (x > 0 && x <= 1) || (x >= -10 && x <= -2))
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}