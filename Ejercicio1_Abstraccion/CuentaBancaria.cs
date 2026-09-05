using System;

namespace Ejercicio1_Abstraccion
{
    /// <summary>
    /// Clase que representa una cuenta bancaria implementando abstracción de datos.
    /// El saldo está oculto y solo se puede acceder mediante métodos públicos.
    /// </summary>
    public class CuentaBancaria
    {
        // Atributo privado - implementa la abstracción de datos
        private decimal saldo;

        /// <summary>
        /// Constructor que inicializa la cuenta con un saldo inicial
        /// </summary>
        public CuentaBancaria(decimal saldoInicial = 0)
        {
            if (saldoInicial < 0)
            {
                throw new ArgumentException("El saldo inicial no puede ser negativo");
            }
            this.saldo = saldoInicial;
        }

        /// <summary>
        /// Permite depositar dinero en la cuenta
        /// </summary>
        /// <param name="monto">Cantidad a depositar</param>
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a depositar debe ser positivo.");
                return;
            }

            saldo += monto;
            Console.WriteLine($"Depósito exitoso. Monto depositado: ${monto:F2}");
        }

        /// <summary>
        /// Permite retirar dinero de la cuenta
        /// </summary>
        /// <param name="monto">Cantidad a retirar</param>
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a retirar debe ser positivo.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine($"Error: Fondos insuficientes. Saldo disponible: ${saldo:F2}");
                return;
            }

            saldo -= monto;
            Console.WriteLine($"Retiro exitoso. Monto retirado: ${monto:F2}");
        }

        /// <summary>
        /// Devuelve el saldo actual de la cuenta
        /// </summary>
        /// <returns>Saldo actual</returns>
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }

    // Clase Program para demostrar el uso de CuentaBancaria
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 1: ABSTRACCIÓN DE DATOS ===\n");

            // Crear una cuenta bancaria con saldo inicial
            CuentaBancaria cuenta = new CuentaBancaria(1000);
            
            Console.WriteLine($"Saldo inicial: ${cuenta.ObtenerSaldo():F2}\n");

            // Realizar operaciones
            cuenta.Depositar(500);
            Console.WriteLine($"Saldo actual: ${cuenta.ObtenerSaldo():F2}\n");

            cuenta.Retirar(300);
            Console.WriteLine($"Saldo actual: ${cuenta.ObtenerSaldo():F2}\n");

            // Intentar retirar más de lo disponible
            cuenta.Retirar(2000);
            Console.WriteLine($"Saldo actual: ${cuenta.ObtenerSaldo():F2}\n");

            // Intentar depositar un monto negativo
            cuenta.Depositar(-100);
            Console.WriteLine($"Saldo final: ${cuenta.ObtenerSaldo():F2}");

            Console.ReadKey();
        }
    }
}
