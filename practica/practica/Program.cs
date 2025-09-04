using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero entero");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es PAR.");

            }
            else
            {
                Console.WriteLine("El numero es IMPAR");

            }

        }
    }
}
