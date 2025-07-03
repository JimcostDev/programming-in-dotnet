using System;

namespace curso_dotnet.fundamentals
{
    public static class Operators
    {
        // Operadores aritméticos
        private static void ArithmeticOperators()
        {
            Console.WriteLine(":: Operadores aritméticos ::");
            Console.WriteLine(10 + 5); // 15
            Console.WriteLine(10 - 5); // 5
            Console.WriteLine(10 * 5); // 50
            Console.WriteLine(10 / 5); // 2
            Console.WriteLine(10 % 5); // 0
            Console.WriteLine(new string('-', 20));
        }

        // Operadores de comparación
        private static void ComparisonOperators()
        {
            Console.WriteLine();
            Console.WriteLine(":: Operadores de comparación ::");
            Console.WriteLine(10 == 5);   // False
            Console.WriteLine(10 == 10);  // True
            Console.WriteLine(10 != 5);   // True
            Console.WriteLine(10 > 5);    // True
            Console.WriteLine(10 < 5);    // False
            Console.WriteLine(10 >= 5);   // True
            Console.WriteLine(10 <= 5);   // False
            Console.WriteLine(new string('-', 20));
        }

        // Operadores lógicos
        private static void LogicalOperators()
        {
            Console.WriteLine();
            Console.WriteLine(":: Operadores lógicos ::");
            Console.WriteLine("AND:");
            Console.WriteLine(true && true);    // True
            Console.WriteLine(true && false);   // False
            Console.WriteLine(false && true);   // False
            Console.WriteLine(false && false);  // False

            Console.WriteLine();
            Console.WriteLine("OR:");
            Console.WriteLine(true || true);    // True
            Console.WriteLine(true || false);   // True
            Console.WriteLine(false || true);   // True
            Console.WriteLine(false || false);  // False

            Console.WriteLine();
            Console.WriteLine("NOT:");
            Console.WriteLine(!true);  // False
            Console.WriteLine(!false); // True
            Console.WriteLine(new string('-', 20));
        }

        public static void Run()
        {
            ArithmeticOperators();
            ComparisonOperators();
            LogicalOperators();
        }
    }
}
