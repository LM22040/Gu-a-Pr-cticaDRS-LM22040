using System;

namespace Ejercicio2_Encapsulacion
{
    /// <summary>
    /// Clase que representa un empleado implementando encapsulación
    /// para proteger los datos y controlar el acceso.
    /// </summary>
    public class Empleado
    {
        // Atributos privados
        private string nombre;
        private int edad;

        /// <summary>
        /// Propiedad pública para acceder al nombre del empleado
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: El nombre no puede estar vacío.");
                    return;
                }
                nombre = value; 
            }
        }

        /// <summary>
        /// Propiedad pública para acceder a la edad del empleado con validación
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: La edad debe ser mayor que 0.");
                    return;
                }
                if (value >= 100)
                {
                    Console.WriteLine("Error: La edad debe ser menor que 100.");
                    return;
                }
                edad = value;
            }
        }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public Empleado()
        {
            nombre = "";
            edad = 0;
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Empleado(string nombre, int edad)
        {
            Nombre = nombre; // Usa la propiedad para validar
            Edad = edad;     // Usa la propiedad para validar
        }

        /// <summary>
        /// Método para mostrar la información del empleado
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años");
        }
    }

    // Clase Program para demostrar el uso de Empleado
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 2: ENCAPSULACIÓN Y CONTROL DE ACCESO ===\n");

            // Crear empleado usando constructor con parámetros
            Empleado empleado1 = new Empleado("Juan Pérez", 30);
            Console.WriteLine("Empleado 1:");
            empleado1.MostrarInformacion();
            Console.WriteLine();

            // Crear empleado usando constructor sin parámetros
            Empleado empleado2 = new Empleado();
            empleado2.Nombre = "María García";
            empleado2.Edad = 25;
            Console.WriteLine("Empleado 2:");
            empleado2.MostrarInformacion();
            Console.WriteLine();

            // Intentar asignar edad inválida (menor que 0)
            Console.WriteLine("Intentando asignar edad negativa:");
            empleado2.Edad = -5;
            empleado2.MostrarInformacion();
            Console.WriteLine();

            // Intentar asignar edad inválida (mayor o igual que 100)
            Console.WriteLine("Intentando asignar edad >= 100:");
            empleado2.Edad = 105;
            empleado2.MostrarInformacion();
            Console.WriteLine();

            // Asignar edad válida
            Console.WriteLine("Asignando edad válida:");
            empleado2.Edad = 35;
            empleado2.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
