using System;

class Program
{
    static void Main()
    {
        double x = 0.5;  // x
        int n = 8;       // Количество рядов

        double sum = 0.0;

        // сумма ряда
        for (int i = 1; i <= n; i=i+1)
        {
            sum += Math.Pow(x, i) / i;
        }

        // результат
        Console.WriteLine($"Сумма ряда для x = {x} и n = {n}: S = {sum:F6}");
    }
}
