namespace curso_dotnet.flow_control
{
    public static class Selection
    {
        // Bloques condicionales
        private static void Conditionals()
        {
            var rand = new Random();
            int valor = rand.Next(0, 10); // genera un número entre 0 y 9

            if (valor == 0)
            {
                Console.WriteLine($"El número {valor} es cero");
            }
            else if (valor % 2 == 0)
            {
                Console.WriteLine($"El número {valor} es par");
            }
            else
            {
                Console.WriteLine($"El número {valor} es impar");
            }

            Console.WriteLine("Fin del programa");
        }

        // Casos o switch
        private static void SwitchCases()
        {
            string dia = "domingo";

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Hoy es lunes, el primer día de la semana");
                    break;
                case "martes":
                case "miércoles":
                case "jueves":
                    Console.WriteLine("Mitad de la semana");
                    break;
                case "viernes":
                    Console.WriteLine("Viernes, fin de la semana laboral");
                    break;
                case "sábado":
                case "domingo":
                    Console.WriteLine("Fin de semana");
                    break;
                default:
                    Console.WriteLine("Día no válido");
                    break;
            }

            string letra = "a";

            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine("Es una vocal");
                    break;
                default:
                    Console.WriteLine("Es cualquier otro carácter menos una vocal");
                    break;
            }
        }

        public static void Run()
        {
            Conditionals();
            SwitchCases();
        }
    }
}
