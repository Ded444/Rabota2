using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];

        Console.WriteLine("Введите свои числа:");
        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        int ravno = 0;
        int nolik = 0;
        int chet = 0;
        int five = 0;

        for (int i = 1; i < n; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                ravno++;
            }

            if (sequence[i] == 0 && sequence[i - 1] == 0)
            {
                nolik++;
            }

            if (sequence[i] % 2 == 0 && sequence[i - 1] % 2 == 0)
            {
                chet++;
            }

            if (sequence[i] % 10 == 5 && sequence[i - 1] % 10 == 5)
            {
                five++;
            }
        }

        Console.WriteLine("kol-vo par sosednih chisel ai, равных между собой: " + ravno);
        Console.WriteLine("kol-vo par sosednih chisel ai, равных нулю: " + nolik);
        Console.WriteLine("kol-vo par sosednih chisel ai, являющихся четными числами: " + chet);
        Console.WriteLine("kol-vo par sosednih chisel ai, оканчивающихся на цифру 5: " + five);
    }
}