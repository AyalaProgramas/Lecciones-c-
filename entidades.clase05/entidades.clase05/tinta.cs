using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace entidades.clase05
{
    public class tinta
    {
        private ConsoleColor _color;
        private eTipotinta _tipo;

        public tinta()
        { 
           this._color=ConsoleColor.Black;
            this._tipo=eTipotinta.comun;
        }

        public tinta(ConsoleColor colorparametro):this()
        {
            this._color = colorparametro;
        }

        public tinta(ConsoleColor colorparametro,eTipotinta tipoparametro):this(colorparametro)
        {
            this._tipo = tipoparametro;
        }

        private string mostrar()
        {
            string datos;
            datos= "el color es:"+ this._color + " el tipo:" + this._tipo;
            return datos;
        }

        public static string mostrar(tinta tinta)
        {

            return tinta.mostrar();
        }

        

        public static bool operator ==(tinta tintauno,tinta tintados)
        {
            return ((tintauno._tipo == tintados._tipo) && (tintauno._color==tintados._color));
        }

        public static bool operator !=(tinta tintauno, tinta tintados)
        {
            //return !((tintauno._tipo == tintados._tipo) && (tintauno._color == tintados._color));
            return !(tintauno==tintados);
        }

        //public static explicit operator string (tinta tintastring)
        //{
        //   return  tintastring.mostrar();
        //}

        //public static implicit operator string(tinta tintastring)
        //{
        //    return tintastring.mostrar();
        //}

        public static implicit operator string(tinta tintastring)
        {
            return tintastring._tipo.ToString();
        }
        

    }
}
