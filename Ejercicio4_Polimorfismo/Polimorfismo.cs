using System;

namespace Ejercicio4_Polimorfismo
{
    /// <summary>
    /// Clase base Animal con método virtual para polimorfismo
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Método virtual que puede ser sobrescrito por clases derivadas
        /// </summary>
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido genérico.");
        }
    }

    /// <summary>
    /// Clase Perro que hereda de Animal y sobrescribe HacerSonido
    /// </summary>
    public class Perro : Animal
    {
        /// <summary>
        /// Sobrescritura del método HacerSonido para Perro
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El perro dice: ¡Guau guau!");
        }
    }

    /// <summary>
    /// Clase Gato que hereda de Animal y sobrescribe HacerSonido
    /// </summary>
    public class Gato : Animal
    {
        /// <summary>
        /// Sobrescritura del método HacerSonido para Gato
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El gato dice: ¡Miau miau!");
        }
    }

    // Clase Program para demostrar polimorfismo
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 4: POLIMORFISMO ===\n");

            // Crear instancias de las clases derivadas
            Perro miPerro = new Perro();
            Gato miGato = new Gato();

            Console.WriteLine("Llamadas directas:");
            miPerro.HacerSonido();
            miGato.HacerSonido();

            Console.WriteLine("\n--- DEMOSTRANDO POLIMORFISMO ---");
            Console.WriteLine("Usando referencias de tipo Animal:\n");

            // Demostrar polimorfismo usando referencias de tipo Animal
            Animal animal1 = new Perro();
            Animal animal2 = new Gato();
            Animal animal3 = new Animal();

            Console.Write("animal1 (tipo Perro): ");
            animal1.HacerSonido();

            Console.Write("animal2 (tipo Gato): ");
            animal2.HacerSonido();

            Console.Write("animal3 (tipo Animal): ");
            animal3.HacerSonido();

            Console.WriteLine("\n--- USO DE ARREGLO POLIMÓRFICO ---");
            Animal[] animales = { new Perro(), new Gato(), new Perro(), new Animal() };

            for (int i = 0; i < animales.Length; i++)
            {
                Console.Write($"Animal {i + 1}: ");
                animales[i].HacerSonido();
            }

            Console.ReadKey();
        }
    }
}
