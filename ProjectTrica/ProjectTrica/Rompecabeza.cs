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
    class Rompecabeza
    {

        int[,] mat;
        string ruta = "";
        string opcion;
        public Rompecabeza(string opcion)
        {
            this.opcion = opcion;
            mat = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    mat[i, j] = -1;
            }
            ruta = Directory.GetCurrentDirectory() + "\\Imagenes\\Rompecabezas";
        }
        public void mezclar()
        {
            int a;
            Random aleatorio = new Random();
            for (int i = 0; i < 9; i++)
            {
                a = 0;
                while (a == 0)
                {
                    int celda = aleatorio.Next(9);
                    int fil, col;
                    fil = celda / 3;
                    col = celda % 3;
                    if (mat[fil, col] == -1)
                    {
                        mat[fil, col] = i;
                        a = 1;
                    }
                }
            }
        }
        public void cargarImagenes(Button btnX, int f, int c)
        {
            btnX.Image = Image.FromFile(ruta + opcion + "\\p" + mat[f, c].ToString() + ".jpg");
        }
        public void intercambiar(int a, int b)
        {
            int fil1, col1;
            fil1 = a / 3;
            col1 = a % 3;
            int fil2, col2;
            fil2 = b / 3;
            col2 = b % 3;
            int aux;
            aux = mat[fil1, col1];
            mat[fil1, col1] = mat[fil2, col2];
            mat[fil2, col2] = aux;
        }
        public bool fin()
        {
            int cont = 0;
            bool x = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mat[i, j] == cont)
                    {

                    }
                    else
                    {
                        x = false;
                    }
                    cont++;
                }
            }
            return x;
        }
    }
}
