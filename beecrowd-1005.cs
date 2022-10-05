using System;

class URI
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"MEDIA = {((a * 3.5 + 7.5 * b) / 11).ToString("F5")}");
    }
}
