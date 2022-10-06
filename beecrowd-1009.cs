using System;

class URI
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double sales = double.Parse(Console.ReadLine());
        Console.WriteLine($"TOTAL = R$ {(salary + sales * 0.15).ToString("f2")}");
    }
}
