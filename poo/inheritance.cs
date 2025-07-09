namespace curso_dotnet.poo
{
    public class Athlete
    {
        public required string Name { get; set; }
        public int Age { get; set; }
    }

    // Footballer hereda de Athlete
    public class Footballer : Athlete
    {
        public required string Position { get; set; }
        public decimal Salary { get; set; }
    }
}