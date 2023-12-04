using System;

class Exercise2E
{
    static void Cala2()
    {
        Console.WriteLine("Ingrese un número entero para verificar si es un número de Fibonacci:");
        int numero = Convert.ToInt32(Console.ReadLine());
        Exercise2E ejercicio = new Exercise2E();
        if (ejercicio.EsNumeroDeFibonacci(numero))
        {
            Console.WriteLine($"{numero} es un número de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número de Fibonacci.");
        }
    }

    public bool EsNumeroDeFibonacci(int numero)
    {
        return EsCuadradoPerfecto(5 * numero * numero + 4) || EsCuadradoPerfecto(5 * numero * numero - 4);
    }

    private bool EsCuadradoPerfecto(int numero)
    {
        int raizCuadrada = (int)Math.Sqrt(numero);
        return raizCuadrada * raizCuadrada == numero;
    }
}
