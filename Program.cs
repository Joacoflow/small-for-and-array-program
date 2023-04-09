using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Semana_14_Clientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listado de clientes
            string[] nombres = new string[5];
            string[] compra = new string[5];
            Console.WriteLine("=====================================");
            Console.WriteLine("=BIENVENIDO A LA PASTELERIA PIERO'S==");
            Console.WriteLine("Ingrese los nombres de los 5 clientes: ");
            Console.WriteLine("=====================================");

            for (int i = 0; i < 5; i++)
            {
                nombres[i] = Console.ReadLine();
            }
            //Compras de clientes
            Console.WriteLine("=====================================");
            Console.WriteLine("Ingrese las 5 compras que desean: ");
            Console.WriteLine("=====================================");
            for (int i = 0; i < 5; i++)
            {
                compra[i] = Console.ReadLine();
            }
            //Limpiamos consola para que no sea tan extenso
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine("Despacho de productos => ");
            Console.WriteLine("=====================================");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i] + "-" + compra[i]);
            }

            Console.ReadKey();

        }
    }
}
