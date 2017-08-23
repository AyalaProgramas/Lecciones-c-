using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasecsharpnum3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            Auto a2 = new Auto();

            a1.marca = "fiat";
            a1.patente = "A001";
            a1.precio = 130000;

            a2.marca = "ford";
            a2.patente = "B00Z";
            a2.precio = 80000;

            //Console.Write(a1.mostrar());
            //Console.Write(a2.mostrar());

            a1 = a2;

            Console.WriteLine(Auto.mostrarmetodoprivate(a1));
            Console.WriteLine(Auto.mostrarmetodoprivate(a2));

            //Auto.f_final = DateTime.Now;

        }
    }
}
