using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1
            //Crear un programa a nivel de consola que permita ingresar nombre, cantidad y precio
            //de 10 productos, al final el programa imprimira cuanto es el total a pagar aplicandole
            // el incremento respectivo del 13% de IVA.

            //Declaramos variables
            int cantidad = 2;
            int cantidadProducto;
            String nombreProducto;
            double precioProducto, totalPagar, totalAcumulado = 0;

            //Ciclo for
            for(int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Nombre del producto " + i);
                nombreProducto = Console.ReadLine();
                Console.WriteLine("Precio del producto " + i);
                precioProducto = double.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de productos " + i);
                cantidadProducto = int.Parse(Console.ReadLine());

                totalPagar = (cantidadProducto * precioProducto) * 1.13;
                totalAcumulado = totalAcumulado + totalPagar;
            }

            //Se imprime el total a pagar.
            Console.WriteLine("El total a pagar es: " + totalAcumulado + " IVA incluido");
            Console.ReadKey();
        }
    }
}
