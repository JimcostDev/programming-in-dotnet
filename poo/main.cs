namespace curso_dotnet.poo
{
    public static class ExamplesPoo
    {
        public static void Run()
        {
            // Abstracción
            var circle = new Circle(5);
            Console.WriteLine($"Área: {circle.Area()}, Perímetro: {circle.Perimeter()}");

            // Encapsulamiento
            var account = new BankAccount(100);
            account.Deposit(50);
            Console.WriteLine($"Balance: {account.Balance}");

            // Herencia
            var emp = new Footballer { Name = "Ronaldo", Age = 40, Position = "Delantero", Salary = 50000 };
            Console.WriteLine($"Futbolista: {emp.Name}, {emp.Position}");

            // Polimorfismo
            Animal[] animals = { new Dog(), new Cat() };
            foreach (var a in animals) a.Speak();
        }
    }
}