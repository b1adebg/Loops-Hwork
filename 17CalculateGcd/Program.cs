using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int bigger = Math.Max(a, b);
        int smaller = Math.Min(a, b);
        int rem = 0;
        while (bigger != 0 && smaller != 0)
        {
            rem = bigger % smaller;
            bigger = smaller;
            smaller = rem;
        }
        Console.WriteLine(bigger);
    }
}

