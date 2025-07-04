namespace curso_dotnet.data_structure
{
    // En C#, los arrays tienen tamaño fijo, lo que significa que una vez que se crea un array, no se puede cambiar su tamaño.
    // Si necesitas un array dinámico, puedes usar una lista (List<T>).
            
    public static class Arrays
    {
        private static void ArrayExamples()
        {
            Console.WriteLine(":: Ejemplo de Arrays ::");
            // Declaración tradicional
            // string[] teams = new string[3];
            // teams[0] = "Cali";
            // teams[1] = "Liverpool";
            // teams[2] = "Milan";

            // Declaración e inicialización implícita
            string[] teams = { "Cali", "Liverpool", "Milan", "Barcelona" };
            Console.WriteLine("Contenido del array:");

            // Imprimir array completo (como cadena)
            Console.WriteLine(string.Join(", ", teams));

            // Recorrer array
            Console.WriteLine("Recorriendo el array:");
            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }

            // Mostrar tipo de dato
            Console.WriteLine($"El tipo de dato es: {teams.GetType()}");

            Console.WriteLine(new string('-', 30));
        }

        public static void Run()
        {
            ArrayExamples();
        }
    }
}
