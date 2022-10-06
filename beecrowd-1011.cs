using System;

class URI
{
    static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());
        double volume = (4.0 / 3.0) * 3.14159 * Math.Pow(num, 3);
        Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
    }
}
