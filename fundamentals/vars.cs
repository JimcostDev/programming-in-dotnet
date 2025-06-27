namespace curso_dotnet.fundamentals;

public static class DataTypes
{
    public static void Run()
    {
        // Variables y Tipos de Datos en C#
        // En C#, las variables son espacios en memoria que almacenan datos
        // Tipos de datos primitivos:
        // - int: enteros
        // - double: números decimales
        // - bool: booleanos (true/false)
        // - string: cadenas de texto
        // - char: caracteres individuales
        // - var: tipo dinámico (se infiere el tipo de dato)
        // - const: constantes (no cambian su valor)

        // variables
        string name = "Ronaldo";
        bool isDeveloper = true;
        int age = 25;
        double height = 1.84;
        string lang = "C#";

        // tipado dinámico, se infiere el tipo de dato
        var city = "Cali";

        // constantes
        const string country = "Colombia";

        Console.WriteLine("Hola Mundo, desde " + lang + "!");
        Console.WriteLine($"Hola, soy {name}! Tengo {age} años y mido {height} metros. ¿Dev? {isDeveloper}. Soy de {city}, {country}.");
    }
}
