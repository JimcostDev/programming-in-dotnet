namespace curso_dotnet.data_structure
{
    public static class Lists
    {
        private static void ListExamples()
        {
            Console.WriteLine(":: Ejemplo de List<T> (equivalente a slice en Go) ::");

            // Crear "slice" (List<string>) de equipos
            var equipos = new List<string> { "Barcelona", "Real Madrid", "Juventus", "PSG" };

            // Agregar elementos al final (similar a append)
            equipos.Add("Manchester City");
            equipos.Add("Bayern Munich");

            // Crear una sublista a partir de otro (GetRange crea un nuevo List con copia de los elementos)
            var favoritos = equipos.GetRange(0, 2);
            // Cambiar elementos en la lista original no afecta a la sublista,  
            // a diferencia de un slice en Go que comparte el array subyacente:
            equipos[0] = "Cali";

            // Imprimir los equipos
            for (int idx = 0; idx < equipos.Count; idx++)
            {
                Console.WriteLine($"{idx}: {equipos[idx]}");
            }

            Console.WriteLine("Favoritos:");
            foreach (var fav in favoritos)
            {
                Console.WriteLine(fav);
            }

            // Longitud y capacidad
            Console.WriteLine($"Longitud: {equipos.Count}, Capacidad: {equipos.Capacity}");
            // En List<T>, Capacity es el tamaño del arreglo interno, que crece automáticamente (normalmente duplica su tamaño)

            // Tipo de dato
            Console.WriteLine($"El tipo de dato es: {equipos.GetType()}");

            // Combinar dos listas (similar a append(...))
            var numeros1 = new List<int> { 1, 2, 3 };
            var numeros2 = new List<int> { 4, 5, 6 };
            var resultado = new List<int>(numeros1);
            resultado.AddRange(numeros2);
            Console.WriteLine(string.Join(", ", resultado)); // 1, 2, 3, 4, 5, 6

            Console.WriteLine(new string('-', 30));
        }

        // Diferencia entre array y lista:
        // - Un array (T[]) tiene tamaño fijo una vez creado.
        // - Una List<T> es dinámica: permite agregar, eliminar o insertar elementos,
        //   y ajusta su Capacity automáticamente según sea necesario.

        public static void Run()
        {
            ListExamples();
        }
    }
}
