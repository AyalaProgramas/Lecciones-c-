using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoconsola1
{
    public class Sello
    {
        public static ConsoleColor color;
        public static string mensaje;

        public static void borrar()
        {
            Sello.mensaje="";
        }
        
        public static string imprimir()
        {
            return "algo";
        }

        public static void imprimirColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.mensaje);
        }
    }
}
