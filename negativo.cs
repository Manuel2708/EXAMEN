using System;

public class VerificadorNumero
{
    public static void Main(string[] args)
    {

        VerificarPositividadNumero();
    }

    ///   <summary>

    ///   </summary>
    public static void VerificarPositividadNumero()
    {
        Console.WriteLine("Por favor, ingrese un número entero:");


        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero > 0)
            {
                Console.WriteLine($"El número {numero} es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"El número {numero} es negativo.");
            }
            else
            {

                Console.WriteLine($"El número es 0.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese solo números enteros.");
        }
    }
}