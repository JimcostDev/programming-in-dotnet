namespace curso_dotnet.exercises
{
    public static class Interface
    {
        // Interfaz que define un saludo genérico
        public interface IGreeting
        {
            void Greeting();
        }

        // Implementaciones concretas de la interfaz IGreeting
        public class Web : IGreeting
        {
            public void Greeting()
            {
                string? name = Environment.GetEnvironmentVariable("USERNAME");
                Console.WriteLine($"Hola {name ?? "invitado"} bienvenido al sitio web!");
            }
        }

        public class Mobile : IGreeting
        {
            public void Greeting()
            {
                int hora = DateTime.Now.Hour;
                if (hora < 12)
                    Console.WriteLine("¡Buenos días desde el móvil!");
                else if (hora < 18)
                    Console.WriteLine("¡Buenas tardes desde el móvil!");
                else
                    Console.WriteLine("¡Buenas noches desde el móvil!");
                Console.WriteLine("¡Disfruta de la app!");
            }
        }

        public static void Run()
        {
            IGreeting webGreeting = new Web();
            IGreeting mobileGreeting = new Mobile();

            webGreeting.Greeting();
            mobileGreeting.Greeting();
        }
        
    }
}