using System;

namespace ExplicacionAli;

class Program
{
    private static void Main(string[] args)
    {
        // Solicita al usuario que ingrese un texto
        Console.Write("Ingrese un texto: ");
        string? entrada = Console.ReadLine();

        // Imprime el texto ingresado por el usuario
        Console.WriteLine("Usted ingresó: " + entrada);
    }
}