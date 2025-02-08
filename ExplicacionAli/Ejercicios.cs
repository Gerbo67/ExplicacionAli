namespace ExplicacionAli;

public class Ejercicios
{
    // Visibilidad, tipo de uso <estatico>, tipo retorno, nombre 
    public static void Ejercicio1()
    {
        /*
         * Escribe un programa que imprima "Hola Mundo"
         */
        Console.WriteLine("Hola Mundo");
    }

    public static void Ejercicio2()
    {
        /*
         * Solicita al usuario dos numeros y muestra su suma.
         */

        try
        {
            // Obtener el primer numero
            Console.WriteLine("Dame el primer numero: ");
            var x = int.Parse(Console.ReadLine() ?? "0");

            // Obtener el segundo numero
            Console.WriteLine("Dame el segundo numero: ");
            var y = int.Parse(Console.ReadLine() ?? "0");

            // Imprimimos respuesta
            Console.WriteLine($"La suma es: {x + y}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un error al sumar los numeros");
        }
    }

    public static void Ejercicio3()
    {
        /*
         * Pide al usuario su peso en kg y su altura en mts, luego
         * calcula su IMC
         */
        try
        {
            // Obtener el primer numero
            Console.WriteLine("Dame tu peso (KG): ");
            var peso = double.Parse(Console.ReadLine() ?? "0");

            // Obtener el segundo numero
            Console.WriteLine("Dame tu estatura (MTS): ");
            var altura = double.Parse(Console.ReadLine() ?? "0");

            // Calcular IMC
            var imc = peso / Math.Pow(altura, 2);

            // Imprimimos respuesta
            Console.WriteLine($"La suma es: {Math.Round(imc, 2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un error");
        }
    }

    public static void Ejercicio4()
    {
        try
        {
            /*
             * Convierte una temperatura dada por
             * el usuario en Celsius a Fahrenheit y viceversa
             */
            Console.WriteLine("Selecciona una opcion:");
            Console.WriteLine("1 - C a F \n2 - F a C");
            var opcion = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Dame la temperatura: ");
            var temperatura = double.Parse(Console.ReadLine() ?? "0");


            switch (opcion)
            {
                case 1: 
                    var fahrenheit = (temperatura * 9 / 5) + 32;
                    Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit}");
                    break;
                case 2:
                    var celsius = (temperatura - 32) * 5 / 9;
                    Console.WriteLine($"La temperatura en Celsius es: {celsius}");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un error");
        }
    }

    public static void Ejercicio5()
    {
        try
        {
            /*
             * Dada una cadena, mostrar solo los primeros dos y los últimos dos caracteres.
             * Si la longitud de la cadena es menor que 2, retornar una cadena vacía.
             */
            
            Console.WriteLine("Dame una cadena: ");
            var cadena = Console.ReadLine() ?? "";
            
            // Longitud mala
            if (cadena.Length < 2)
            {
                Console.WriteLine("La cadena es muy corta");
                return;
            }

            // ["H", "o", "l", "a", "s"]
            // ["H", "o"]
            var cadenaPrimeros2 = cadena.Substring(0, 2);
            
            // ["a", "s"]
            var cadenaUltimos2 = cadena.Substring(cadena.Length - 2);
            
            Console.WriteLine($"La cadena es: {cadenaPrimeros2}...{cadenaUltimos2}");
            
        }
        catch (Exception e)
        {
            Console.WriteLine("Hubo un error");
        }
    }
}