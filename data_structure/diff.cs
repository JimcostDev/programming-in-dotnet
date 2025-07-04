namespace curso_dotnet.data_structure
{
    public static class Diff
    {
        private static void DiffExamples()
        {
            Console.WriteLine(":: Diferencia en comportamiento de copia entre array y List<T> ::");

            // Declaración de un array
            string[] arrayOriginal = { "Original 1", "Original 2", "Original 3" };
            // Creamos una copia del array usando Clone (copia superficial)
            string[] arrayCopia = (string[])arrayOriginal.Clone();

            // Modificamos la copia
            ModifyArray(arrayCopia);
            Console.WriteLine($"Array original después de modificar la copia: {string.Join(", ", arrayOriginal)}");
            // El array original NO cambia, porque Clone creó un nuevo array independiente

            Console.WriteLine(new string('-', 20));

            // Declaración de una List<T>
            var listaOriginal = new List<string> { "Original 1", "Original 2", "Original 3" };
            // Asignación directa: apunta al mismo objeto
            var listaReferencia = listaOriginal;
            ModifyList(listaReferencia);
            Console.WriteLine($"Lista original después de modificar la referencia: {string.Join(", ", listaOriginal)}");
            // La lista original SÍ cambia, porque listaReferencia y listaOriginal son el mismo objeto

            Console.WriteLine(new string('-', 20));

            // Para copiar una List<T> y desvincularla del original:
            var listaCopia = new List<string>(listaOriginal);
            ModifyList(listaCopia);
            Console.WriteLine($"Lista original después de modificar la copia: {string.Join(", ", listaOriginal)}");
            // La lista original NO cambia, porque listaCopia es un nuevo objeto

            Console.WriteLine(new string('-', 30));
        }

        private static void ModifyArray(string[] arr)
        {
            arr[0] = "Modificado en función";
            Console.WriteLine($"Array dentro de la función: {string.Join(", ", arr)}");
        }

        private static void ModifyList(List<string> lst)
        {
            lst[0] = "Modificado en función";
            Console.WriteLine($"Lista dentro de la función: {string.Join(", ", lst)}");
        }

        // Nota sobre diferencias:
        // - array.Clone() crea un nuevo array (tratado por valor en términos de la referencia),
        //   de modo que modificar la copia no afecta al original.
        // - Asignar un array sin Clone solo copia la referencia: modificar el array en otro lado
        //   SÍ afectaría al original.
        // - new List<T>(otraList) crea una nueva lista con copia superficial de los elementos.
        // - Asignar List<T> directamente copia la referencia: ambas variables apuntan al mismo objeto.

        public static void Run()
        {
            DiffExamples();
        }
    }
}
