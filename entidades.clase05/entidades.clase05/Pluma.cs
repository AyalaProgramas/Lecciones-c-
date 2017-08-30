using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.clase05
{
    public class Pluma
    {
        private string _marca;
        private tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._cantidad = 0;
            this._marca = "sin marca";
            this._tinta = null;
        }
        public Pluma(string marcaparametro):this()
        {
            this._marca = marcaparametro;
        }
        public Pluma(string marcaparametro,int cantidadparametro):this(marcaparametro)
        {
            this._cantidad = cantidadparametro;
        }
        public Pluma(string marcaparametro,int cantidadparametro,tinta tintaparametro):this(marcaparametro,cantidadparametro) 
        {
            this._tinta = tintaparametro;
        }

        public static bool operator ==(Pluma plumaoperador,tinta tintaoperador)
        {
            return (plumaoperador._tinta == tintaoperador);
        }

        public static bool operator !=(Pluma plumaoperador, tinta tintaoperador)
        {
            return !(plumaoperador == tintaoperador);
        }
        public static Pluma operator +(Pluma plumaoperador, tinta tintaoperador)
        {
            if (plumaoperador == tintaoperador&&plumaoperador._cantidad<100)
            {
                plumaoperador._cantidad++;
            }
            
            return plumaoperador;
        }

        public static Pluma operator -(Pluma plumaoperador, tinta tintaoperador)
        {
            if (plumaoperador != tintaoperador && plumaoperador._cantidad < 5)
            {
                plumaoperador._cantidad--;
            }

            return plumaoperador;
        }

    }
}
