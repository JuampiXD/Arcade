using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arcade_Master
{
    class Diccionario
    {
        string ruta = Directory.GetCurrentDirectory() + "\\";
        public string[] notepad = new string[100];
        int i = 0;
        string pal;
        public void Ruta(string n)
        {
            ruta = ruta+ n;
        }
        public void limbiarRuta()
        {
            ruta = "";
        }
        public void Inicializar()
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("Upss Algo Salio Mal");
            }
            else
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        notepad[i] = linea.Trim();
                        i++;
                        if (i > 9)
                        {
                            i = 0;
                        }
                    }
                }
            }
        }
        public string getPalabra()
        {
            Random aleatorio = new Random();
            int y = aleatorio.Next(10);
            int x = notepad[y].Length;
            pal = notepad[y];
            return pal;
        }
        public int longitud()
        {
            return pal.Length;
        }
    }
}
