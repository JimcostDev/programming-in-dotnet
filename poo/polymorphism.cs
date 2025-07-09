namespace curso_dotnet.poo

// ¿Qué es un método virtual?
// En C#, un método marcado con la palabra clave virtual en la clase base 
// define un comportamiento por defecto que las clases derivadas 
// pueden sobrescribir usando override. 
// Esto habilita el polimorfismo en tiempo de ejecución, 
// permitiendo que la llamada a ese método ejecute la implementación de la subclase correspondiente.

{
    // Clase base que define un método virtual
    public class Animal
    {
        // Método virtual que puede ser sobreescrito por las subclases
        public virtual void Speak() => Console.WriteLine("El animal hace un sonido");
    }

    // Dog hereda de Animal y sobreescribe Speak()
    public class Dog : Animal
    {
        // override: modifica el comportamiento del método base
        public override void Speak() => Console.WriteLine("El perro dice: ¡Guau!");
    }

    // Cat hereda de Animal y también sobreescribe Speak()
    public class Cat : Animal
    {
        // Polimorfismo en acción: la misma llamada Speak() produce distintos resultados
        public override void Speak() => Console.WriteLine("El gato dice: ¡Miau!");
    }
}