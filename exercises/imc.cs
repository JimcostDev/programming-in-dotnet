using System.Globalization;
namespace curso_dotnet.exercises
{
    public static class ImcCalculator
    {
        // Calcula el IMC = peso / estatura^2
        public static double CalcularIMC(double peso, double estatura)
        {
            return peso / (estatura * estatura);
        }

        // Clasifica el IMC según la OMS
        public static string ClasificarIMC(double imc)
        {
            return imc switch
            {
                < 18.5 => "Bajo peso",
                < 25.0 => "Normal",
                < 30.0 => "Sobrepeso",
                < 35.0 => "Obesidad tipo I",
                < 40.0 => "Obesidad tipo II",
                _ => "Obesidad tipo III"
            };
        }

        public static double CalcularPesoMinimo(double estatura)
        {
            return 18.5 * estatura * estatura;
        }

        public static double CalcularPesoMaximo(double estatura)
        {
            return 24.9 * estatura * estatura;
        }

        public static void MostrarPesoNormal(double estatura)
        {
            double min = CalcularPesoMinimo(estatura);
            double max = CalcularPesoMaximo(estatura);
            Console.WriteLine($"Peso normal: {min:F2} - {max:F2} kg");
        }

        public static void MostrarIMC(double imc, string clasificacion)
        {
            Console.WriteLine($"Tu IMC es: {imc:F2}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }

        public static void Run()
        {
            Console.Write("Introduce tu peso en kg (ej. 66.3): ");
            string? pesoInput = Console.ReadLine();

            double peso;
            // Intentamos parsear con la cultura invariante (punto)
            if (!double.TryParse(pesoInput, NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
            {
                Console.WriteLine("Error: Debes introducir un peso válido.");
                return;
            }

            Console.Write("Introduce tu altura en metros (ej. 1.84: ");
            string? estaturaInput = Console.ReadLine();

            double estatura;
            // Hacemos lo mismo para la altura
            if (!double.TryParse(estaturaInput, NumberStyles.Any, CultureInfo.InvariantCulture, out estatura))
            {
                Console.WriteLine("Error: Debes introducir una altura válida.");
                return;
            }

            double imc = CalcularIMC(peso, estatura);
            string clasificacion = ClasificarIMC(imc);

            MostrarIMC(imc, clasificacion);
            MostrarPesoNormal(estatura);
        }
    }
}
