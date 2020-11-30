using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instancio las listas de entradas y estacionamientos
            List<Entrada> entradas = new List<Entrada>();
            List<Estacionamiento> estacionamientos= new List<Estacionamiento>();

            //Creo
            Entrada entrada1 = new Entrada(250, "2012", Entrada.EGenero.Drama);
            Entrada entrada2 = new Entrada(400, "Climax", Entrada.EGenero.Drama);

            Estacionamiento est1 = new Estacionamiento(250, "A1");
            Estacionamiento est2 = new Estacionamiento(80, "E3");

            //Muestro la informacion de algunos
            Console.WriteLine(entrada1.ToString());
            Console.WriteLine();
            Console.WriteLine(est1.ToString());
            Console.WriteLine();

            //Instancio la lista de ventas
            Venta<Producto> ventas = new Venta<Producto>();

            //Agrego a la lista de ventas
            ventas += entrada2;
            ventas += est2;

            //Imprimo el ticket de compra
            Console.WriteLine(ventas.MostrarCompra(ventas));

            Console.ReadLine();
        }
    }
}
