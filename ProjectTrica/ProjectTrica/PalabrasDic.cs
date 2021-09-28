using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTrica
{ 
    class PalabrasDic
    {
        string ruta = null;
        public string[] Listado = new string[100];
        string palabra;
        int i = 0, aux = 0;
        int x;
        public ListaDoble LD = new ListaDoble();
        public void Ruta(string Categoria)
        {
            //object lista = Properties.Resources.Animales; 
            i = 0;
            ruta = "Imagenes\\Adivinanzas\\Listado\\" + Categoria + ".txt";
        }
        public void inicializar()
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo no se encontro");
            }
            else
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        LD.InsertarFin(linea);
                        i++;
                    }                
                }
            }
        }
        public string getPalabra()
        {            
            Random aleatorio = new Random();
            int y = aleatorio.Next(1, LD.Cantidad()+1);
            aux = y;
            palabra = Convert.ToString(LD.Elemento(y));
            x = i;
            return palabra;
        }
        public void Acabar()
        {
            LD.EliminarPos(aux);
        }
        public int Tamaño()
        {
            i = 0;
            return x;
        }
    }
}
