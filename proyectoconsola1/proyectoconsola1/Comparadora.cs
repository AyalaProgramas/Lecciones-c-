using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoconsola1
{
    class Comparadora
    {
        public static int retornamayor(int numerouno, int numerodos)
        {
            int retorno = 0;

            if (numerouno > numerodos)
            {
                retorno = numerouno;
            }
            else
            {
                retorno = numerodos;
            }

            return retorno;
        }

        public static int mostrareldelmedio(int numerouno, int numerodos, int numerotres)
        {
            int retorno = numerodos;

            return retorno;
        }
    }
}
