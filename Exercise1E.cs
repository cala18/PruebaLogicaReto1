using System;

class Exercise1E 
{
      public static void Cala1()
    {
        Console.WriteLine("Ingrese un número entero n para calcular el n-ésimo número de Fibonacci:");
        int n = Convert.ToInt32(Console.ReadLine());
        long resultado = Fibonacci(n);
        Console.WriteLine($"El {n}-ésimo número de Fibonacci es: {resultado}");
    }

    static long Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            long a = 0;
            long b = 1;
            long temp;

            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
