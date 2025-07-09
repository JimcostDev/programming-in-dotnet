namespace curso_dotnet.poo
{
    // Definición de una clase 'Person'
    public class Person
    {
        // Propiedades representan el estado
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor: inicializa un nuevo objeto
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Método para mostrar información
        public void Introduce()
        {
            Console.WriteLine($"Hola, soy {Name} y tengo {Age} años.");
        }
    }

    // Uso de la clase Person (creación de un objeto)
    public static class ObjectDemo
    {
        public static void Run()
        {
            // Creación de un objeto de tipo Person
            var person = new Person("Ronaldo", 26);

            // Acceso a propiedades
            Console.WriteLine(person.Name); 

            // Llamada a método
            person.Introduce(); 
        }
    }
}