using curso_dotnet.ef.data;
using curso_dotnet.ef.models;
namespace curso_dotnet.ef
{
    public static class ExamplesEF
    {
        public static void Run()
        {
            using var db = new AppDbContext();
            // Crear la base de datos si no existe
            db.Database.EnsureCreated();

            // Crear un nueva liga
            var league = new League
            {
                Name = "Bundesliga"
            };
            db.Leagues.Add(league);
            db.SaveChanges();

            // Leer ligas
            var leagues = db.Leagues.ToList();
            Console.WriteLine("Ligas en la base de datos:");
            leagues.ForEach(t =>
                Console.WriteLine($"{t.Id}: {t.Name}")
            );

            // Actualizar un equipo
            league.Name = "Bundesliga 2";
            db.SaveChanges();
            Console.WriteLine($"Liga actualizada: {league.Name}");

            // Eliminar un equipo
            db.Leagues.Remove(league);
            db.SaveChanges();
            Console.WriteLine($"Liga '{league.Name}' eliminada.");

        }
    }
}