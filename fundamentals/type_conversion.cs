namespace curso_dotnet.fundamentals
{
    public static class TypeConversion
    {
        private static void ConvertStringToInt()
        {
            Console.WriteLine(":: Conversión de string a int ::");

            string numeroComoTexto = "123";
            int numeroConvertido;

            // Usando int.Parse (lanza excepción si falla)
            numeroConvertido = int.Parse(numeroComoTexto);
            Console.WriteLine($"Número convertido con Parse: {numeroConvertido}");

            // Usando int.TryParse (seguro, no lanza excepción)
            string otroTexto = "456";
            if (int.TryParse(otroTexto, out int resultado))
            {
                Console.WriteLine($"Número convertido con TryParse: {resultado}");
            }
            else
            {
                Console.WriteLine("La conversión falló.");
            }

            // Si el texto no es válido:
            string textoInvalido = "abc";
            if (int.TryParse(textoInvalido, out int invalido))
            {
                Console.WriteLine($"Conversión exitosa: {invalido}");
            }
            else
            {
                Console.WriteLine($"Error al convertir '{textoInvalido}' a entero.");
            }

            Console.WriteLine(new string('-', 30));
        }

        public static void Run()
        {
            ConvertStringToInt();
        }
    }
}
