namespace curso_dotnet.poo
{
    // Interfaz que define el comportamiento genérico de un luchador
    public interface IFighter
    {
        string Name { get; }
        string WeightClass { get; }
        int Health { get; }
        
        void Attack();
        void Defend();
        void ShowStats();
    }

    // Clase que implementa un luchador de MMA
    public class MMAFighter : IFighter
    {
        public string Name { get; private set; }
        public string WeightClass { get; private set; }
        public int Health { get; private set; }

        public int StrikesLanded { get; private set; }
        public int Takedowns { get; private set; }

        public MMAFighter(string name, string weightClass)
        {
            Name = name;
            WeightClass = weightClass;
            Health = 100;
            StrikesLanded = 0;
            Takedowns = 0;
        }

        public void Attack()
        {
            var rnd = new Random();
            bool strike = rnd.Next(2) == 0;
            if (strike)
            {
                StrikesLanded++;
                Console.WriteLine($"{Name} lanza un golpe limpio!");
            }
            else
            {
                Takedowns++;
                Console.WriteLine($"{Name} consigue un derribo!");
            }
        }

        public void Defend()
        {
            var rnd = new Random();
            int damage = rnd.Next(5, 16);
            Health -= damage;
            Console.WriteLine($"{Name} recibe {damage} de daño. Salud actual: {Health}.");
        }

        public void ShowStats()
        {
            Console.WriteLine($"\n-- Estadísticas de {Name} --");
            Console.WriteLine($"Categoría: {WeightClass}");
            Console.WriteLine($"Salud: {Health}");
            Console.WriteLine($"Golpes conectados: {StrikesLanded}");
            Console.WriteLine($"Derribos: {Takedowns}\n");
        }
    }

    // Demo de uso
    public static class FighterDemo
    {
        public static void Run()
        {
            IFighter fighter = new MMAFighter("Ilia Topuria", "Ligero");

            Console.WriteLine("Combate iniciado!\n");
            Console.WriteLine($"Luchador: {fighter.Name}");
            Console.WriteLine($"Categoría: {fighter.WeightClass}\n");
            
            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine($"--- Round {round} ---");
                fighter.Attack();
                fighter.Defend();
            }

            fighter.ShowStats();
        }
    }
}
