using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la aplicacion a nuestro programa");
        Console.Write("Por favor, ingrese su nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Sientate bienvenido, {nombre}!");
        
        // Leer la edad como una cadena y luego convertirla a entero
        Console.Write("Digite tu edad: ");
        string edadInput = Console.ReadLine();
        int edad;
        
        // Intentar convertir la entrada a un número entero
        if (!int.TryParse(edadInput, out edad))
        {
            Console.WriteLine("Edad no regristada.");
            return;
        }
        
        if (edad >= 20)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }
        
        // Leer la puntuación como una cadena y luego convertirla a entero
        Console.Write("Digite una puntuacion del 1 al 10: ");
        string calidadInput = Console.ReadLine();
        int calidad;
        
        // Intentar convertir la entrada a un número entero
        if (!int.TryParse(calidadInput, out calidad))
        {
            Console.WriteLine("Puntuación no válida.");
            return;
        }

        if (calidad < 1 || calidad > 10)
        {
            Console.WriteLine("Variable no válida, digite nuevamente.");
        }
        else
        {
            if (calidad < 5)
            {
                Console.WriteLine("Necesitas mejorar más");
            }
            else if (calidad <= 7)
            {
                Console.WriteLine("Buen trabajo, pero hay margen para mejorar");
            }
            else
            {
                Console.WriteLine("¡exelente trabajo!");
            }
        }
        
        Console.WriteLine("Presione una tecla para salir");
        Console.ReadKey();
    }
}

