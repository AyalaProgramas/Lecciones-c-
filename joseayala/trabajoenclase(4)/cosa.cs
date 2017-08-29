using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoenclase_4_
{
    public class cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public ConsoleColor color; 

        public cosa()
        {
            this.entero = 0;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        //public cosa(int enteroconstructor)
        //    : this(enteroconstructor_i: enteroconstructor, cadenaconstructor_s: "hola", fechaconstructor_f:DateTime.Now)
        //{
        //    this.entero = enteroconstructor;
        //    //this.cadena = "sin valor";
        //    //this.fecha = DateTime.Now;
        //}

        public cosa(int enteroconstructor):this()
        {
            this.entero = enteroconstructor;
            //this.cadena = "sin valor";
            //this.fecha = DateTime.Now;
        }

        public cosa(int enteroconstructor, string cadenaconstructor)
            : this(enteroconstructor)
        {
            //this.entero = enteroconstructor;
            this.cadena = cadenaconstructor;
            //this.fecha = DateTime.Now;
        }

        public cosa(DateTime fechaconstructor,int enteroconstructor,string cadenaconstructor):this( enteroconstructor,cadenaconstructor)
        {

        }

        //public cosa(DateTime fechaconstructor_f, int enteroconstructor_i, string cadenaconstructor_s)
            
        //{

        //}
        public void metodoestablecercolor(ConsoleColor color)
        {
            this.color=color;
        }



        /// <summary>
        /// 
        /// </summary>
        public void metodoestablecervalor(DateTime fechaprueba)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entero"></param>
        /// <param name="cadena"></param>
        /// <param name="fecha"></param>
        public void metodoestablecervalor(int entero, string cadena, DateTime fecha)
        {
            this.cadena=cadena;
            this.entero = entero;
            this.fecha = fecha;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="fecha"></param>
        /// <param name="entero"></param>
        public void metodoestablecervalor(string cadena, DateTime fecha, int entero)
        {
            this.cadena = cadena;
            this.entero = entero;
            this.fecha = fecha;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string mostrar()
        {

            return this.entero + this.cadena + this.fecha;
        }

        public string mostrar(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            return this.entero + this.cadena + this.fecha;
        }

    }
}
