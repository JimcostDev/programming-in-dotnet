namespace curso_dotnet.linq
{
    public static class LinqExamples
    {
        private static void LinqDemo()
        {
            Console.WriteLine(":: Ejemplos de LINQ ::");

            // Fuente de datos
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1) Filtrar con Where (método de extensión)
            var evens = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Pares: " + string.Join(", ", evens));

            // 2) Proyección con Select
            var squares = numbers.Select(n => n * n);
            Console.WriteLine("Cuadrados: " + string.Join(", ", squares));

            // 3) Ordenación con OrderByDescending
            var desc = numbers.OrderByDescending(n => n);
            Console.WriteLine("Descendente: " + string.Join(", ", desc));

            // 4) Agrupación con GroupBy
            var groups = numbers.GroupBy(n => n % 2 == 0 ? "Pares" : "Impares");
            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Key}: {string.Join(", ", g)}");
            }

            // 5) Agregación con Aggregate
            var sum = numbers.Aggregate((acc, n) => acc + n);
            Console.WriteLine($"Suma total: {sum}");

            // 6) Sintaxis de consulta (query syntax)
            var query =
                from n in numbers
                where n > 5
                orderby n
                select n;
            Console.WriteLine("Mayores que 5: " + string.Join(", ", query));

            Console.WriteLine(new string('-', 30));
        }

        public static void Run()
        {
            LinqDemo();
        }
    }
}
