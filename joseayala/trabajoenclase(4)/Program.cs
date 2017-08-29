using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoenclase_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            cosa cosauno = new cosa();
            DateTime fechauno=new DateTime();
            DateTime fechados = new DateTime();
            //ConsoleColor color = new ConsoleColor();

            cosauno.mostrar(ConsoleColor.DarkRed);

            cosauno.metodoestablecervalor(new DateTime(2017, 08, 29));
            Console.WriteLine(cosauno.mostrar());
            cosauno.mostrar(ConsoleColor.DarkRed);
            cosauno.metodoestablecervalor(22, "juan",fechauno);
            Console.WriteLine(cosauno.mostrar());

            cosauno.metodoestablecervalor("pedro", fechados, 55);
            Console.WriteLine(cosauno.mostrar());

            /*constructores sobrecargado*/
            /****************************/
            cosa constructor0parametro = new cosa();
            //Console.WriteLine(cosauno.mostrar());
            cosa constructor1parametro = new cosa(22);
            Console.WriteLine(cosauno.mostrar());
            cosa constructor2parametro = new cosa(44, "convalor");
            Console.WriteLine(cosauno.mostrar());
            cosa constructor3parametro = new cosa(new DateTime(2017, 08, 29), 55, "fulano");
        }
    }
}
