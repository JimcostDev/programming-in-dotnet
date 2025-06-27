namespace curso_dotnet.fundamentals;

public static class Outputs
{
    public static void Run()
    {
        // Salida de datos en C#
        // En C#, se puede mostrar información al usuario utilizando Console.WriteLine()
        // Esto permite imprimir texto en la consola

        Console.WriteLine("Bienvenido al curso de C#");
        Console.WriteLine("¡Disfruta aprendiendo a programar!");

        // También se pueden usar interpolaciones de cadenas para incluir variables
        string name = "JimcostDev";
        Console.WriteLine($"Hola {name}, ¿cómo estás hoy?");

        // Para imprimir múltiples líneas, se pueden usar saltos de línea
        Console.WriteLine("Línea 1\nLínea 2\nLínea 3");

        // Se puede concatenar texto usando el operador +
        string greeting = "Hola";
        string subject = "mundo";
        Console.WriteLine(greeting + " " + subject + "!");
    }
}