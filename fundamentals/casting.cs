namespace curso_dotnet.fundamentals
{
    public static class Casting
    {
        private static void CastingExamples()
        {
            Console.WriteLine(":: Ejemplos de casting (casteo) ::");

            // Casting implícito: de int a double (ampliación)
            int entero = 42;
            double numeroDecimal = entero; // No se necesita casting explícito
            Console.WriteLine($"Casting implícito (int a double): {numeroDecimal}");

            // Casting explícito: de double a int (reducción)
            double otroDecimal = 9.87;
            int enteroCasteado = (int)otroDecimal; // Se pierden los decimales
            Console.WriteLine($"Casting explícito (double a int): {enteroCasteado}");

            // Casting entre clases (herencia)
            Animal animal = new Perro(); // Upcasting implícito: 
            animal.Hablar(); // Upcasting (automático): de una subclase a su clase base.

            // Downcasting (explícito) - convertir de clase base a derivada
            if (animal is Perro perro)
            {
                perro.Ladrar(); // Downcasting (necesita comprobación): de clase base a subclase, con is o (Tipo).
            }

            Console.WriteLine(new string('-', 30));
        }

        // Clases de ejemplo para casting entre tipos de referencia
        class Animal
        {
            public virtual void Hablar()
            {
                Console.WriteLine("El animal hace un sonido.");
            }
        }

        class Perro : Animal
        {
            public override void Hablar()
            {
                Console.WriteLine("El perro dice: ¡Guau!");
            }

            public void Ladrar()
            {
                Console.WriteLine("Ladrando como perro...");
            }
        }

        public static void Run()
        {
            CastingExamples();
        }
    }
}
