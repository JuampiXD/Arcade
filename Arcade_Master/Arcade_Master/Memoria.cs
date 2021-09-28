using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Arcade_Master
{
    class Memoria
    {
        int[,] mat;
        const int FILAS = 4;
        const int COLUMNAS = 4;
        string ruta = Directory.GetCurrentDirectory() + "\\imagenes\\BuscarPares\\";
        public Memoria()
        {
            mat = new int[FILAS, COLUMNAS];
            for (int f = 0; f < FILAS; f++)
            {
                for (int c = 0; c < COLUMNAS; c++)
                {
                    mat[f, c] = -1;
                }
            }
        }
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
        public void cargarImagen(Button btnX, int nro)
        {
            int f = nro / 4;
            int c = nro % 4;
            btnX.Image = Image.FromFile(ruta + mat[f, c].ToString() + ".jpg");
            btnX.Text = mat[f, c].ToString();
        }
        public bool SonIguales(int nro1, int nro2)
        {
            if (mat[nro1 / COLUMNAS, nro1 % COLUMNAS] == mat[nro2 / COLUMNAS, nro2 % COLUMNAS])
                return true;
            else
                return false;
        }
    }
}
