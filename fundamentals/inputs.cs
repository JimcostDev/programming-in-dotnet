namespace curso_dotnet.fundamentals;

public static class Inputs
{
    public static void Run()
    {
        // Entrada de datos en C#
        // En C#, se puede leer la entrada del usuario utilizando Console.ReadLine()
        // Esto permite capturar texto ingresado por el usuario desde la consola

        Console.Write("Ingrese su nombre: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese su edad: ");
        string? ageInput = Console.ReadLine();
        int age = int.Parse(ageInput ?? "0"); // Convertir el texto a un entero

        Console.WriteLine($"Hola {name}, bienvenido al curso de C#! Tienes {age} años, y estás aprendiendo a programar.");
    }
}