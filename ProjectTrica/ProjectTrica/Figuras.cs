using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ProjectTrica
{
    class Figuras //Coleres, formas, animales
    {
        //vector donde se almacenara el orden de las figuraas mostradas
        string ubicacion;
        public  Figuras()
        {
            ubicacion = Directory.GetCurrentDirectory()+ "\\Imagenes\\Secuencias";
        }
        public string Cat()
        {
            return ubicacion;
        }
        public void Categoria(string cat)
        {
            ubicacion = ubicacion + "\\" + cat;
        }
        public void Secuencia(ListaDoble lista)
        {
            Random alertorio = new Random();
            int x;
            if (lista.Cantidad() == 0)
            {
                for(int i = 1;i <= 4; i++)
                {
                     x = alertorio.Next(1, 5);
                     lista.InsertarFin(x);
                }
            }
            else
            {
                x = alertorio.Next(1, 5);
                lista.InsertarFin(x);
            }
            
        }
    }
}
