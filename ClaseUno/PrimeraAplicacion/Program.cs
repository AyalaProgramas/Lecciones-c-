using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
            {
            //Console.WriteLine("hola mundo");
            //Console.ReadKey();

            int numeroUno;
            int numeroDos;
            int Resultado;
            string dato;
            bool esnumero;
            int cont = 0;
            bool flaps;

            //dato = Console.ReadLine();
            //esnumero = int.TryParse(Console.ReadLine(), out numeroUno);

            while (!int.TryParse(Console.ReadLine(), out numeroUno))
            {
                Console.WriteLine("error ingrese, el numero uno");
                cont++;
                if(cont>5)
                {

                }
            }

            //dato = Console.ReadLine();
            //numeroUno = int.Parse(dato);
            //dato = Console.ReadLine();
            //numeroDos = int.Parse(dato);



            //numeroDos = 10;
            //numeroUno = 12;

           // Resultado = numeroDos + numeroUno;

           //Console.Write("el resultado es:"+Resultado);
            Console.ReadKey();


        }
    }
}
