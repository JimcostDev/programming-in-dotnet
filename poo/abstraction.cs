namespace curso_dotnet.poo
{
    // Clase abstracta representa un contrato que las subclases deben implementar
    public abstract class Shape
    {
        // Método abstracto: definido por la forma, implementado en cada subclase
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;
        public override double Area() => Math.PI * Radius * Radius;
        public override double Perimeter() => 2 * Math.PI * Radius;
    }
}