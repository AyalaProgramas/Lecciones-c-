using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasecsharpnum3
{
    class Auto
    {
        public string marca;//si no escribo public por defecto es private y por la tanto no lo veo
        public string patente;
        public float precio;
        public static int cantinstancia=0;//si pongo cantinstancia=0 siempre va tener ese valor q es 0
        public static DateTime f_inicio;
        public static DateTime f_final;
        public static DateTime cantdetiempo;

        public Auto()
        {
            //if (cantinstancia == 0)
            //{
            //    Auto.f_inicio = DateTime.Now;
            //}
            Auto.cantinstancia++;//es un atributo de clase
            this.marca = "sin marca";
        }

        static Auto()
        {
            Auto.f_inicio = DateTime.Now;
        }


        /*public*/private string mostrar()
        {
            return this.marca+this.patente+this.precio;


            //Console.WriteLine(marca);
            //Console.WriteLine(patente);
            //Console.WriteLine(precio);
        }

        public static string mostrarmetodoprivate(Auto autouno)//llama al metodo private mostrar
        {
            //return autouno.marca + autouno.patente + autouno.precio;
            return autouno.mostrar();//reutiliso el metodode arriba

            //Console.WriteLine(marca);
            //Console.WriteLine(patente);
            //Console.WriteLine(precio);
        }
    }
}
