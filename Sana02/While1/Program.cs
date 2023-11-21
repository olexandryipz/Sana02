using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть натуральне число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double resultA = CalculateExpressionA(n);
        double resultB = CalculateExpressionB(n);
        int resultC = CalculateExpressionC(n);

        Console.WriteLine($"a = {resultA}");
        Console.WriteLine($"b = {resultB}");
        Console.WriteLine($"c = {resultC}");
    }

    static double CalculateExpressionA(int n)
    {
        double sumA = 0;

        for (int i = 0; i <= n; i++)
        {
            double termA = CalculateTermA(i);
            sumA += termA;
        }

        return sumA;
    }

    static double CalculateTermA(int i)
    {
        double termA = Math.Pow(-1, i) / (2 * i + 1);
        return termA;
    }

    static double CalculateExpressionB(int n)
    {
        double sumB = 0;

        for (int i = 1; i <= n; i++)
        {
            double termB = CalculateTermB(i);
            sumB += termB;
        }

        return sumB;
    }

    static double CalculateTermB(int i)
    {
        double termB = 1.0 + 1.0 / Math.Pow(i, 2);
        return termB;
    }

    static int CalculateExpressionC(int n)
    {
        int sumC = 0;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sumC += factorial;
        }

        return sumC;
    }
}