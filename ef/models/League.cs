namespace curso_dotnet.ef.models
{
    // Entidad 'League' representa ligas de fútbol en la base de datos
    public class League
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
