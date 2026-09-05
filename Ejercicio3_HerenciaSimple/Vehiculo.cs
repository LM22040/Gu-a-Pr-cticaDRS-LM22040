using System;

namespace Ejercicio3_HerenciaSimple
{
    /// <summary>
    /// Clase base Vehiculo con métodos básicos
    /// </summary>
    public class Vehiculo
    {
        /// <summary>
        /// Método para arrancar el vehículo
        /// </summary>
        public void Arrancar()
        {
            Console.WriteLine("El vehículo está arrancando...");
        }

        /// <summary>
        /// Método para detener el vehículo
        /// </summary>
        public void Detener()
        {
            Console.WriteLine("El vehículo se está deteniendo...");
        }
    }

    /// <summary>
    /// Clase derivada Coche que hereda de Vehiculo
    /// </summary>
    public class Coche : Vehiculo
    {
        /// <summary>
        /// Método específico de la clase Coche
        /// </summary>
        public void Conducir()
        {
            Console.WriteLine("El coche está siendo conducido en la carretera.");
        }
    }

    // Clase Program para demostrar la herencia simple
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 3: HERENCIA SIMPLE ===\n");

            // Crear una instancia de Coche
            Coche miCoche = new Coche();

            // Usar métodos heredados de Vehiculo
            miCoche.Arrancar();
            
            // Usar método propio de Coche
            miCoche.Conducir();
            
            // Usar método heredado de Vehiculo
            miCoche.Detener();

            Console.WriteLine("\n¡El coche ha utilizado todos sus métodos exitosamente!");

            Console.ReadKey();
        }
    }
}
