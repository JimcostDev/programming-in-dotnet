using System;

namespace curso_dotnet.exceptions
{
    // 1) Definición de excepción personalizada
    public class MyCustomException : Exception
    {
        public MyCustomException() { }

        public MyCustomException(string message) 
            : base(message) { }

        public MyCustomException(string message, Exception inner) 
            : base(message, inner) { }
    }

    public static class Exceptions
    {
        private static void ExceptionHandlingExamples()
        {
            Console.WriteLine(":: Manejo de excepciones básico ::");
            int divisor = 0;

            try
            {
                // Esto arrojará DivideByZeroException
                int result = 10 / divisor;
                Console.WriteLine($"Resultado: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("¡Error! División por cero.");
                Console.WriteLine($"Detalles: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Captura cualquier otra excepción inesperada
                Console.WriteLine("Ocurrió un error inesperado.");
                Console.WriteLine($"Detalles: {ex.Message}");
            }
            finally
            {
                // Se ejecuta siempre, haya excepción o no
                Console.WriteLine("Bloque finally: limpieza o registro.");
            }

            Console.WriteLine(new string('-', 30));
        }

        private static void CustomExceptionExample(string input)
        {
            Console.WriteLine(":: Ejemplo de excepción personalizada ::");

            try
            {
                if (string.IsNullOrWhiteSpace(input))
                    throw new MyCustomException("La cadena de entrada no puede estar vacía.");

                Console.WriteLine($"La entrada es: {input}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("¡Se detectó un error de validación!");
                Console.WriteLine($"Mensaje: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fin de la validación de entrada.");
            }

            Console.WriteLine(new string('-', 30));
        }

        private static void RethrowExample()
        {
            Console.WriteLine(":: Ejemplo de rethrow ::");
            try
            {
                ProcessData(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Excepción capturada en Run(): " + ex.Message);
            }
        }

        private static void ProcessData(string? data)
        {
            try
            {
                if (data == null)
                    throw new ArgumentNullException(nameof(data), "El dato no puede ser nulo.");

                // Procesar data...
            }
            catch (ArgumentNullException)
            {
                // Hacer registro o limpieza si es necesario...
                Console.WriteLine("Logging: data era nulo en ProcessData.");
                // Re-lanzar la misma excepción para que el llamador la maneje
                throw;
            }
        }

        public static void Run()
        {
            ExceptionHandlingExamples();
            CustomExceptionExample("");
            RethrowExample();
        }
    }
}
