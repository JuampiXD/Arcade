using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade_Master
{
    class Comparar
    {
        string let;
        int cantletra = 0, posicion = 99, posicio = 99, posici = 99;
        string vec;
        public void Letra(string l)
        {
            this.let = l;
        }
        public void Existe(string x)
        {
            posicion = 99;
            posicio = 99;
            posici = 99;
            int n = x.Length;
            for (int i = 0; i < n; i++)
            {
                vec = x;
                if (vec[i] == let[0])
                {
                    cantletra++;
                    switch (cantletra)
                    {
                        case 1:
                            posicion = i;
                            break;
                        case 2:
                            posicio = i;
                            break;
                        case 3:
                            posici = i;
                            break;
                        default:
                            break;
                    }

                }

            }
            cantletra = 0;
        }
        public int getPosicion1()
        {
            return posicion;
        }
        public int getPosicion2()
        {
            return posicio;
        }
        public int getPosicion3()
        {
            return posici;
        }
    }
}
