namespace curso_dotnet.flow_control
{
    public static class Iterators
    {
        // Ejemplos de ciclos
        private static void IteratorsExamples()
        {
            // for tradicional
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteración: {i}");
            }

            // while
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine($"While: valor de x = {x}");
                x++;
            }

            // bucle infinito (comentado)
            // while (true)
            // {
            //     Console.WriteLine(x);
            //     x++;
            // }

            // lista de frutas 
            var frutas = new List<string> { "piña", "mango", "mandarina" };
            for (int idx = 0; idx < frutas.Count; idx++)
            {
                Console.WriteLine($"Índice: {idx}, Valor: {frutas[idx]}");
            }

            // iterar sobre diccionario (colores)
            var colores = new Dictionary<string, string>
            {
                ["rojo"]  = "#FF0000",
                ["verde"] = "#00FF00",
                ["azul"]  = "#0000FF",
            };
            foreach (var kvp in colores)
            {
                Console.WriteLine($"Color: {kvp.Key}, Código: {kvp.Value}");
            }

            // continue: saltar números pares
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine($"Número impar: {i}");
            }

            // break: detener al llegar a 5
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("¡Llegamos a 5!");
                    break;
                }
                Console.WriteLine($"Iteración: {i}");
            }
        }

        public static void Run()
        {
            IteratorsExamples();
        }
    }
}
