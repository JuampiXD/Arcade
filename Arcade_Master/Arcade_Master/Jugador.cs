using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade_Master
{
    class Jugador
    {
        public string nombre;
        public int casilla;
        public int turnos;
        public Jugador(string nombre)
        {
            this.nombre = nombre;
            casilla = 1;
            turnos = 0;
        }
        public void setCasilla(int casilla)
        {
            this.casilla = casilla;
        }
        public void setTurno(int turno)
        {
            this.turnos = turno;
        }
        public string getNombre()
        {
            return nombre;
        }
        public int getCasilla()
        {
            return casilla;
        }
        public int getTurno()
        {
            return turnos;
        }
        public int mover(int tirada)
        {
            if (casilla + tirada > 63)
                casilla = 63 - (tirada - (63 - casilla));
            else
                casilla += tirada;
            return casilla;
        }
        public int tirarDados()
        {
            Random rand = new Random();
            int dado = rand.Next(1, 6);
            return dado;
        }
    }
}
