using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTrica
{
    class ListaDoble
    {
        public NodoDoble Ini { get; set; }
        public NodoDoble Fin { get; set; }
        private int n;

        public ListaDoble()
        {
            Anula();
        }

        public void Anula()
        {
            Ini = null;
            Fin = null;
            n = 0;
        }
        public int Cantidad()
        {
            return n;
        }

        public bool Vacia()
        {
            if (Ini == null) return true;
            else return false;
        }

        public void Insertar(object elemento, int pos)
        {
            if (pos >= 1 && pos <= n + 1)
            {
                NodoDoble nuevo = new NodoDoble();
                nuevo.Dato = elemento;
                if (n == 0)
                {
                    Ini = nuevo;
                    Fin = nuevo;
                }
                else if (pos == 1)
                {
                    nuevo.Siguiente = Ini;
                    Ini.Anterior = nuevo;
                    Ini = nuevo;
                }
                else if (pos == n + 1)
                {
                    nuevo.Anterior = Fin;
                    Fin.Siguiente = nuevo;
                    Fin = nuevo;
                }
                else
                {
                    if (pos <= (n / 2))
                        InsertarPorIzq(nuevo, pos);
                    else
                        InsertarPorDer(nuevo, pos);
                }
                n++;
            }
            else
                MessageBox.Show("Posición fuera de rango");
        }

        private void InsertarPorIzq(NodoDoble nuevo, int pos)
        {
            NodoDoble Act = Ini;
            int c = 1;
            while (c < (pos - 1))
            {
                Act = Act.Siguiente;
                c++;
            }
            Act.Siguiente.Anterior = nuevo;
            nuevo.Siguiente = Act.Siguiente;
            nuevo.Anterior = Act;
            Act.Siguiente = nuevo;
        }

        private void InsertarPorDer(NodoDoble nuevo, int pos)
        {
            NodoDoble Act = Fin;
            int c = n;
            while (c > (pos))
            {
                Act = Act.Anterior;
                c--;
            }
            nuevo.Siguiente = Act;
            nuevo.Anterior = Act.Anterior;
            Act.Anterior = nuevo;
            nuevo.Anterior.Siguiente = nuevo;
        }

        public void InsertarIni(object elemento)
        {
            Insertar(elemento, 1);
        }

        public void InsertarFin(object elemento)
        {
            Insertar(elemento, n + 1);
        }

        public void EliminarPos(int pos)
        {
            if (pos >= 1 && pos <= n)
            {
                if (n == 1)
                {
                    Ini = null;
                    Fin = null;
                }
                else if (pos == 1)
                {
                    Ini.Siguiente.Anterior = null;
                    Ini = Ini.Siguiente;
                }
                else if (pos == n)
                {
                    Fin.Anterior.Siguiente = null;
                    Fin = Fin.Anterior;
                }
                else
                {
                    if (pos <= (n / 2))
                        EliminarPorIzq(pos);
                    else
                        EliminarPorDer(pos);
                }
                n--;
            }
            else MessageBox.Show("Error: Posición fuera de rango!");
        }

        private void EliminarPorIzq(int pos)
        {
            NodoDoble Act = Ini;
            int c = 1;
            while (c < pos)
            {
                Act = Act.Siguiente;
                c++;
            }
            Act.Anterior.Siguiente = Act.Siguiente;
            Act.Siguiente.Anterior = Act.Anterior;
        }

        private void EliminarPorDer(int pos)
        {
            NodoDoble Act = Fin;
            int c = n;
            while (c > (pos))
            {
                Act = Act.Anterior;
                c--;
            }
            Act.Anterior.Siguiente = Act.Siguiente;
            Act.Siguiente.Anterior = Act.Anterior;
        }

        public void EliminarEle(object elemento)
        {
            int pos = Localiza(elemento);
            if (pos != -1)
                EliminarPos(pos);
        }

        public int Localiza(object elemento)
        {
            int pos = 1;
            NodoDoble Act = Ini;
            while (Act != null)
            {
                if (Act.Dato.Equals(elemento))
                    return pos;
                Act = Act.Siguiente;
                pos++;
            }
            return -1;
        }

        public void Visualiza(ListBox ltbMostrar)
        {
            ltbMostrar.Items.Clear();
            NodoDoble Act = Ini;
            ltbMostrar.Items.Add("Elementos de la Lista:");
            int i = 1;
            while (Act != null)
            {
                ltbMostrar.Items.Add(i + ". " + Act.Dato);
                Act = Act.Siguiente;
                i++;
            }
        }

        public object Elemento(int pos)
        {
            if (pos >= 1 && pos <= n)
            {
                if (pos <= (n / 2))
                    return BuscarPorIzquierda(pos);
                else
                    return BuscarPorDerecha(pos);
            }
            else
            {
                MessageBox.Show("Error: Posición fuera de rango!");
                return null;
            }
        }

        private object BuscarPorIzquierda(int pos)
        {
            NodoDoble Act = Ini;
            int c = 1;
            while (c < pos)
            {
                Act = Act.Siguiente;
                c++;
            }
            return Act.Dato;
        }

        private object BuscarPorDerecha(int pos)
        {
            NodoDoble Act = Fin;
            int c = n;
            while (c > (pos))
            {
                Act = Act.Anterior;
                c--;
            }
            return Act.Dato;
        }
        public void Suma(int x)
        {
            int a = 1;
            NodoDoble q = Ini;
            while (a <= n)
            {
                q.Dato = Convert.ToInt32(q.Dato) + x;
                q = q.Siguiente;
                a++;
            }
        }
    }
}
