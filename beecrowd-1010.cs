using System;

class URI
{
    static void Main(string[] args)
    {
        string[] line_1 = Console.ReadLine().Split(' ');
        string[] line_2 = Console.ReadLine().Split(' ');
        double value_1 = int.Parse(line_1[1]) * double.Parse(line_1[2]);
        double value_2 = int.Parse(line_2[1]) * double.Parse(line_2[2]);
        Console.WriteLine($"VALOR A PAGAR: R$ {(value_1 + value_2).ToString("F2")}");
    }
}
