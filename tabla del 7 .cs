using System;

public class TablaMultiplicar
{
    public static void Main(string[] args)
    {
        ImprimirTablaDelSiete();
    }

     ///   <summary>
    
     ///   </summary>
    public static void ImprimirTablaDelSiete()
    {
        int numero = 7;
        
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        Console.WriteLine("----------------------------------");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }

}
