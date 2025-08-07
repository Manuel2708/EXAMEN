using System;

public class VerificadorParImpar
{
    public static void Main(string[] args)
    {

        VerificarNumeroIngresado();
    }

    ///    <summary>
    /// 
    ///    </summary>
    public static void VerificarNumeroIngresado()
    {
        Console.WriteLine("Por favor, ingrese un número entero:");


        if (int.TryParse(Console.ReadLine(), out int numero))
        {

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese solo números enteros.");
        }
    }
}