using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrica
{
    class NodoDoble
    {
        public object Dato { get; set; }
        public NodoDoble Siguiente { get; set; }
        public NodoDoble Anterior { get; set; }

        public NodoDoble()
        {
            Dato = null;
            Siguiente = null;
            Anterior = null;
        }
    }
}
