using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ProjectTrica
{// colores facil animales medio y verbos dificl 
    class Memoria
    {//Se declara una matriz y la ruta de las imagenes
        int[,] mat;
        const int FILAS = 4;
        const int COLUMNAS = 4;
        string ruta = Directory.GetCurrentDirectory() + "\\Imagenes\\BuscarPares\\";
        //Llena la matriz con -1
        public Memoria(string tematica)
        {
            ruta = ruta + tematica;
            mat = new int[FILAS, COLUMNAS];
            for (int f = 0; f < FILAS; f++)
            {
                for (int c = 0; c < COLUMNAS; c++)
                {
                    mat[f, c] = -1;
                }
            }
        }
        //Asigna valores aleatorios entre 0 y 15 
        public void inicializar()
        {
            int cantidad = (FILAS * COLUMNAS) / 2;
            Random semilla = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                int contador = 1;
                while (contador <= 2)
                {
                    int celda = semilla.Next(16);
                    int fil, col;
                    fil = celda / COLUMNAS;
                    col = celda % COLUMNAS;
                    if (mat[fil, col] == -1)
                    {
                        mat[fil, col] = i;
                        contador++;
                    }
                }
            }
        }
        //Usa el directorio y carga los botones con las imagenes
        public void cargarImagen(Button btnX, int nro)
        {
            int f = nro / 4;
            int c = nro % 4;
            btnX.Image = Image.FromFile(ruta + mat[f, c].ToString() + ".jpg");
            btnX.Text = mat[f, c].ToString();
        }
    }
}
