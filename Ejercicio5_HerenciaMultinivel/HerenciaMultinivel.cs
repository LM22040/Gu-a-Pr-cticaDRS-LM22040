using System;

namespace Ejercicio5_HerenciaMultinivel
{
    /// <summary>
    /// Clase base Animal - Nivel 1 de la jerarquía
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Método virtual que puede ser sobrescrito
        /// </summary>
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    /// <summary>
    /// Clase intermedia Mamifero - Nivel 2 de la jerarquía
    /// Hereda de Animal
    /// </summary>
    public class Mamifero : Animal
    {
        /// <summary>
        /// Método específico de Mamifero
        /// </summary>
        public void Alimentar()
        {
            Console.WriteLine("El mamífero está siendo alimentado con leche materna.");
        }

        /// <summary>
        /// Sobrescritura del método HacerSonido
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El mamífero hace un sonido característico.");
        }
    }

    /// <summary>
    /// Clase derivada Perro - Nivel 3 de la jerarquía
    /// Hereda de Mamifero (que a su vez hereda de Animal)
    /// </summary>
    public class Perro : Mamifero
    {
        /// <summary>
        /// Sobrescritura del método HacerSonido específico para Perro
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El perro dice: ¡Guau guau!");
        }

        /// <summary>
        /// Método específico de Perro
        /// </summary>
        public void Jugar()
        {
            Console.WriteLine("El perro está jugando con una pelota.");
        }
    }

    // Clase Program para demostrar herencia multinivel
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 5: HERENCIA MULTINIVEL ===\n");

            // Crear instancia de Perro
            Perro miPerro = new Perro();

            Console.WriteLine("--- Demostrando herencia multinivel ---\n");

            // Método sobrescrito en Perro (nivel 3)
            Console.WriteLine("1. Método sobrescrito en Perro:");
            miPerro.HacerSonido();
            Console.WriteLine();

            // Método heredado de Mamifero (nivel 2)
            Console.WriteLine("2. Método heredado de Mamifero:");
            miPerro.Alimentar();
            Console.WriteLine();

            // Método específico de Perro
            Console.WriteLine("3. Método específico de Perro:");
            miPerro.Jugar();
            Console.WriteLine();

            Console.WriteLine("--- Demostrando polimorfismo en la jerarquía ---\n");

            // Referencias polimórficas
            Animal animalRef = new Perro();
            Mamifero mamiferoRef = new Perro();

            Console.WriteLine("Referencia de tipo Animal apuntando a Perro:");
            animalRef.HacerSonido();
            Console.WriteLine();

            Console.WriteLine("Referencia de tipo Mamifero apuntando a Perro:");
            mamiferoRef.HacerSonido();
            mamiferoRef.Alimentar();
            Console.WriteLine();

            Console.WriteLine("--- Comparando los tres niveles ---\n");

            Animal animal = new Animal();
            Mamifero mamifero = new Mamifero();
            Perro perro = new Perro();

            Console.Write("Animal: ");
            animal.HacerSonido();

            Console.Write("Mamífero: ");
            mamifero.HacerSonido();

            Console.Write("Perro: ");
            perro.HacerSonido();

            Console.ReadKey();
        }
    }
}
