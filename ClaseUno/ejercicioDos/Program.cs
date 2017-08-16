using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            //int numeroDos;
            //int Resultado;
            int numeromayor=0;
            int numeromenor=0;
            string dato;
            bool esnumero;
            int contador = 0;
            
            while(contador<5)
            {
                
                while(!int.TryParse(Console.ReadLine(), out numeroUno))
                {
                    Console.WriteLine("error ingrese, el numero uno");
                }


                if(contador==0)
                {
                    numeromayor=numeroUno;
                    numeromenor=numeroUno;
                }
                else
                {
                    if(numeromayor<numeromenor)
                    {

                    }
                }

                contador++;
            }
             
               
            //while (!int.TryParse(Console.ReadLine(), out numeroUno))
            //{
            //    
                //cont++;
                //if(cont>5)
                //{
                //    flaps=true;
                //}
            }
            //Console.WriteLine("error ingrese, el numero uno");
            //cont++;
            //if (cont > 5)
            //{
            //    flaps = true;
            //}
        }
    }
}
