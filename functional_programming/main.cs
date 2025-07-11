namespace curso_dotnet.functional_programming
{
    public static class FunctionalDemo
    {
        private static void Demo()
        {
            Console.WriteLine(":: Programación Funcional en C# ::");

            // 1) Función pura: no tiene efectos secundarios y su salida depende sólo de sus argumentos
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"add(2, 3) = {add(2, 3)}"); // 5

            // 2) Inmutabilidad: no modificamos la lista original, creamos una nueva
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var doubled = numbers.Select(n => n * 2).ToList(); 
            Console.WriteLine("Original: " + string.Join(", ", numbers));
            Console.WriteLine("Doblados: " + string.Join(", ", doubled));

            // 3) Función de orden superior: recibe o devuelve funciones
            Func<Func<int, bool>, IEnumerable<int>, IEnumerable<int>> filter =
                (predicate, seq) => seq.Where(predicate);
            // Usamos filter para quedarnos con pares
            var evens = filter(n => n % 2 == 0, numbers);
            Console.WriteLine("Pares: " + string.Join(", ", evens));

            // 4) Composición de funciones: combinamos dos funciones en una nueva
            Func<int, int> square = x => x * x;
            Func<int, int> inc = x => x + 1;
            Func<int, int> incThenSquare = x => square(inc(x));
            Console.WriteLine($"incThenSquare(3) = {incThenSquare(3)}"); // (3+1)^2 = 16

            // 5) Uso de tuplas y desestructuración para evitar estado mutable
            Func<int, int, (int sum, int product)> sumAndProduct = (x, y) => (x + y, x * y);
            var result = sumAndProduct(4, 5);
            Console.WriteLine($"Suma: {result.sum}, Producto: {result.product}");

            Console.WriteLine(new string('-', 30));
        }

        public static void Run()
        {
            Demo();
        }
    }
}
