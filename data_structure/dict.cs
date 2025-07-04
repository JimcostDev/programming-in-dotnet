namespace curso_dotnet.data_structure
{
    public static class Dicts
    {
        private static void DictExamples()
        {
            Console.WriteLine(":: Ejemplo de Dictionary<TKey, TValue> (equivalente a map en Go) ::");

            // Con constructor vacío (equivale a make)
            var goleadores = new Dictionary<string, int>();
            goleadores["Ronaldo"] = 30;
            Console.WriteLine("Goleadores: " + string.Join(", ", goleadores));

            // Inicialización literal (equivale a map[string]int{})
            var asistentes = new Dictionary<string, int>
            {
                ["James"] = 16
            };
            Console.WriteLine("Asistentes: " + string.Join(", ", asistentes));

            // Inicialización con varios pares clave-valor
            var equipos = new Dictionary<string, string>
            {
                ["Barcelona"]     = "azulgrana",
                ["Real Madrid"]   = "blanco",
                ["Bayern Munich"] = "rojo"
            };

            // Acceder a un valor
            Console.WriteLine($"Color de Barcelona: {equipos["Barcelona"]}");

            // Agregar un nuevo equipo
            equipos["Liverpool"] = "rojo";

            // Verificar si existe una clave
            if (equipos.TryGetValue("Liverpool", out string? color))
            {
                Console.WriteLine($"Color de Liverpool: {color}");
            }
            else
            {
                Console.WriteLine("Liverpool no existe en el diccionario");
            }

            // Recorrer el diccionario
            Console.WriteLine("Equipos y sus colores:");
            foreach (var kvp in equipos)
            {
                Console.WriteLine($"El equipo {kvp.Key} tiene el color {kvp.Value}");
            }

            // Eliminar un valor
            equipos.Remove("Liverpool");
            Console.WriteLine("Diccionario actualizado: " +
                string.Join(", ", equipos));

            Console.WriteLine(new string('-', 30));
        }

        // Nota:
        // - En Go: make(map[K]V) y literal map[K]V{} inicializan un map.
        // - En C#: new Dictionary<K,V>() o la sintaxis literal con {} cumplen la misma función.

        public static void Run()
        {
            DictExamples();
        }
    }
}
