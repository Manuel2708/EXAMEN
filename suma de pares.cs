using System;

public class SumaPares
{
    public static void Main(string[] args)
    {
        CalcularSumaPares();
    }

     ///   <summary>

     ///   </summary>
    public static void CalcularSumaPares()
    {
        int suma = 0; 

        for (int i = 2; i <= 100; i += 2)
        {
            suma = suma + i; 
        }

        Console.WriteLine($"La suma de todos los números pares del 1 al 100 es: {suma}");
    }

}
