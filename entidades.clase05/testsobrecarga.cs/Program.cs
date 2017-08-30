using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades.clase05;

namespace testsobrecarga.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            entidades.clase05.tinta tintauno = new tinta(ConsoleColor.Blue, eTipotinta.chino);
            tinta tintados=new tinta(ConsoleColor.DarkRed,eTipotinta.conbrillito);
            Console.WriteLine(tinta.mostrar(tintauno));
            Console.WriteLine(tinta.mostrar(tintados));

            tinta tinta1operadores = new tinta(ConsoleColor.Blue,eTipotinta.chino);
            tinta tinta2operadores = new tinta(ConsoleColor.Blue, eTipotinta.conbrillito);

            if (tinta1operadores == tinta2operadores)
            {
                Console.WriteLine("son iguales");
                Console.WriteLine(tinta.mostrar(tinta1operadores));
                Console.WriteLine(tinta.mostrar(tinta2operadores));
            }
            else 
            {
                Console.WriteLine("no son iguales");
                Console.WriteLine(tinta.mostrar(tinta1operadores));
                Console.WriteLine(tinta.mostrar(tinta2operadores));
            }

            Console.WriteLine(tinta1operadores);
            //1:36:00
           /*nose puede castear*/ //Console.Write((string)tinta1operadores);
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine((string)tinta1operadores);
            Console.WriteLine(tinta1operadores);
            Console.WriteLine(tinta1operadores);
            Console.WriteLine((string)tinta1operadores);


        }
    }
}
