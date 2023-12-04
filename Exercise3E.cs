using System;

class Exercise3E
{
    public static void Cala3()
    {
        Console.WriteLine("Ingrese un número entero para obtener los primeros m números de Fibonacci:");
        int m = Convert.ToInt32(Console.ReadLine());
        MostrarFibonacci(m);
    }

    static void MostrarFibonacci(int m)
    {
        long a = 0;
        long b = 1;

        Console.WriteLine($"Los primeros {m} números de Fibonacci son:");

        for (int i = 0; i < m; i++)
        {
            Console.Write($"{a} ");

            long temp = a + b;
            a = b;
            b = temp;
        }
    }
}
