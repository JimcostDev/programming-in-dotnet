namespace curso_dotnet.functions
{
    public static class Functions
    {
        // 1. Función normal (void, sin retorno)
        private static void Greet(string name)
        {
            Console.WriteLine($"¡Hola, {name}!");
        }

        // 2. Función con retorno simple
        private static int Square(int x)
        {
            return x * x;
        }

        // 3. Función con retorno múltiple usando tuplas
        private static (int quotient, int remainder) Divide(int dividend, int divisor)
        {
            int q = dividend / divisor;
            int r = dividend % divisor;
            return (q, r);
        }

        // 4. Función variádica (params)
        private static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (var n in numbers)
                total += n;
            return total;
        }

        // 5. Función con parámetros opcionales y llamada con argumentos nombrados
        private static void DisplayInfo(string name, int age = 0, string country = "Desconocido")
        {
            Console.WriteLine($"Nombre: {name}, Edad: {age}, País: {country}");
        }

        public static void Run()
        {
            Console.WriteLine(":: Función normal ::");
            Greet("Paula");

            Console.WriteLine("\n:: Retorno simple ::");
            int val = 5;
            Console.WriteLine($"El cuadrado de {val} es {Square(val)}");

            Console.WriteLine("\n:: Retorno múltiple (tuplas) ::");
            var (q, r) = Divide(17, 4);
            Console.WriteLine($"17 ÷ 4 = {q} con resto {r}");

            Console.WriteLine("\n:: Función variádica ::");
            Console.WriteLine($"Suma de 1,2,3,4,5 = {Sum(1, 2, 3, 4, 5)}");

            Console.WriteLine("\n:: Argumentos nombrados y opcionales ::");
            // Llamada usando argumentos nombrados (en cualquier orden)
            DisplayInfo(age: 30, name: "Oswaldo", country: "España");
            // Aprovechando valores por defecto
            DisplayInfo(name: "Fernanda");
        }
    }
}
