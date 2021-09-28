using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade_Master
{
    class Casilla
    {
        int numero;
        int siguiente;
        int turno;
        public Casilla(int numero, int siguiente, int turno)
        {
            this.numero = numero;
            this.siguiente = siguiente;
            this.turno = turno;
        }
        void setNumero(int numero)
        {
            this.numero = numero;
        }
        void setSiguiente(int siguiente)
        {
            this.siguiente = siguiente;
        }
        void setTurnos(int turno)
        {
            this.turno = turno;
        }
        public int getSiguiente()
        {
            return siguiente;
        }
        public int getTurnos()
        {
            return turno;
        }
    }
}
