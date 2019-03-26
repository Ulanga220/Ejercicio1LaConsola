using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1LaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            string mensaje;
            Console.WriteLine("¿Cuál es el club más grande del mundo?");
            mensaje = Console.ReadLine();
            Console.WriteLine($"El club elejido fue {mensaje}");
            Console.ReadKey();



        }
    }
}
