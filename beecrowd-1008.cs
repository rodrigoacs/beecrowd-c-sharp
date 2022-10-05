using System;

class URI
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int hrs = int.Parse(Console.ReadLine());
        float salary = float.Parse(Console.ReadLine());
        Console.WriteLine($"NUMBER = {num}");
        Console.WriteLine($"SALARY = U$ {(hrs * salary).ToString("F2")}");
    }
}
