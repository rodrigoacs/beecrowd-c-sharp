using System;

class URI
{
    static void Main(string[] args)
    {
        string[] num_S = Console.ReadLine().Split(' ');
        double[] num = new double[num_S.Length];
        for (int i = 0; i < num_S.Length; i++)
        {
            num[i] = double.Parse(num_S[i]);
        }
        Console.WriteLine($"TRIANGULO: {((num[0] * num[2]) / 2).ToString("F3")}");
        Console.WriteLine($"CIRCULO: {(3.14159 * Math.Pow(num[2], 2)).ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {(((num[0] + num[1]) * num[2]) / 2).ToString("F3")}");
        Console.WriteLine($"QUADRADO: {(Math.Pow(num[1], 2)).ToString("F3")}");
        Console.WriteLine($"RETANGULO: {(num[0] * num[1]).ToString("F3")}");
    }
}
