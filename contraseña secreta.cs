using System;

public class ValidacionContrasena
{
    public static void Main(string[] args)
    {

        VerificarContrasena();
    }

    ///    <summary>

    ///    </summary>
    public static void VerificarContrasena()
    {

        const string contrasenaCorrecta = "secreto123";

 
        Console.WriteLine("Por favor, ingrese la contraseña:");
        string contrasenaUsuario = Console.ReadLine();


        if (contrasenaUsuario == contrasenaCorrecta)
        {
            Console.WriteLine("¡Contraseña correcta! Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta. Acceso denegado.");
        }
    }
}