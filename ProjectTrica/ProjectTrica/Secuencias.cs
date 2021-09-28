using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectTrica
{
    public partial class Secuencias : Form
    {
        Musica dj = new Musica();
        Figuras f;
        int a,b;
        ListaDoble lista = new ListaDoble();
        public Secuencias()
        {
            f = new Figuras();
            InitializeComponent();
            dj.direccion("Secuencias.wav");
            dj.Reproductor();
            pnCategoria.Size = new Size(1150, 610);
            pnCategoria.Location = new Point(0, 0);
            picCategoria.Size = new Size(1150, 610);
            picCategoria.Location = new Point(0, 0);
            picFondo.Size = new Size(1150, 610);
            picFondo.Location = new Point(0, 0);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btnReiniciar.Enabled = false;
        }
        //Inicio
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            a = 1;
            b = 1;
            f.Secuencia(lista);
            Juego.Enabled = true;
        }
        //Timers
        private void MostrarSeleccion_Tick(object sender, EventArgs e)
        {
            picBox.Image = null;
            //button1.Enabled = true;
            //button2.Enabled = true;
            //button3.Enabled = true;
            //button4.Enabled = true;
            picBien.Visible = false;
            MostrarSeleccion.Enabled = false;
        }
        private void Mal_Tick(object sender, EventArgs e)
        {
            Mal.Enabled = false;
            picMal.Visible = false;
        }
        private void Juego_Tick(object sender, EventArgs e)
        {
            Juego2.Enabled = true;
            if (lista.Cantidad() < a)
            {
                Juego.Enabled = false;
                btnReiniciar.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                picMal.Visible = false;
                picExcelente.Visible = false;
                a = 1;
            }
            else
            {
                picBox.Image = Image.FromFile(f.Cat() + "\\" + lista.Elemento(a).ToString() + ".png");
            }
            a++;
        }
        private void Juego2_Tick(object sender, EventArgs e)
        {
            picBox.Image = null;
            Juego2.Enabled = false;
        }
        //Botones de adivinar
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lista.Elemento(b)) == 1)
            {
                if (Convert.ToInt32(lista.Cantidad()) == b)
                {
                    btnReiniciar.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    f.Secuencia(lista);
                    a = 1;
                    b = 1;
                    picExcelente.Visible = true;
                    Juego.Enabled = true;
                }
                else
                {
                    picBox.Image = null;
                    picBox.Image = Image.FromFile(f.Cat() + "\\1.png");
                    //button1.Enabled = false;
                    //button2.Enabled = false;
                    //button3.Enabled = false;
                    //button4.Enabled = false;
                    if(MostrarSeleccion.Enabled == true)
                    {
                        MostrarSeleccion.Enabled = false;
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    else
                    {
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    b++;
                }
               
            }
            else
            {
                a = 1;
                b = 1;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                picMal.Visible = true;
                Juego.Enabled = true;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lista.Elemento(b)) == 2)
            {
                if (Convert.ToInt32(lista.Cantidad()) == b)
                {
                    btnReiniciar.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    f.Secuencia(lista);
                    a = 1;
                    b = 1;
                    picExcelente.Visible = true;
                    Juego.Enabled = true;
                }
                else
                {
                    picBox.Image = null;
                    picBox.Image = Image.FromFile(f.Cat() + "\\2.png");
                    //button1.Enabled = false;
                    //button2.Enabled = false;
                    //button3.Enabled = false;
                    //button4.Enabled = false;
                    if (MostrarSeleccion.Enabled == true)
                    {
                        MostrarSeleccion.Enabled = false;
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    else
                    {
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    b++;
                }
               
            }
            else
            {
                a = 1;
                b = 1;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                picMal.Visible = true;
                Juego.Enabled = true;
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lista.Elemento(b)) == 3)
            {
                if (Convert.ToInt32(lista.Cantidad()) == b)
                {
                    btnReiniciar.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    f.Secuencia(lista);
                    a = 1;
                    b = 1;
                    picExcelente.Visible = true;
                    Juego.Enabled = true;
                }
                else
                {

                    picBox.Image = null;
                    picBox.Image = Image.FromFile(f.Cat() + "\\3.png");
                    //button1.Enabled = false;
                    //button2.Enabled = false;
                    //button3.Enabled = false;
                    //button4.Enabled = false;
                    if (MostrarSeleccion.Enabled == true)
                    {
                        MostrarSeleccion.Enabled = false;
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    else
                    {
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    b++;
                }
            }
            else
            {
                a = 1;
                b = 1;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                picMal.Visible = true;
                Juego.Enabled = true;
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lista.Elemento(b)) == 4)
            {
                if (Convert.ToInt32(lista.Cantidad()) == b)
                {
                    btnReiniciar.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    f.Secuencia(lista);
                    a = 1;
                    b = 1;
                    picExcelente.Visible = true;
                    Juego.Enabled = true;
                }
                else
                {

                    picBox.Image = null;
                    picBox.Image = Image.FromFile(f.Cat() + "\\4.png");
                    //button1.Enabled = false;
                    //button2.Enabled = false;
                    //button3.Enabled = false;
                    //button4.Enabled = false;
                    if (MostrarSeleccion.Enabled == true)
                    {
                        MostrarSeleccion.Enabled = false;
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    else
                    {
                        picBien.Visible = true;
                        MostrarSeleccion.Enabled = true;
                    }
                    b++;
                }
                
            }
            else
            {
                a = 1;
                b = 1;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                picMal.Visible = true;
                Juego.Enabled = true;
            }
        }
        //Categorias
        private void BtnAnimales_Click_1(object sender, EventArgs e)
        {
            f.Categoria("Animales");
            button1.Image = Image.FromFile(f.Cat() + "\\1.png");
            button2.Image = Image.FromFile(f.Cat() + "\\2.png");
            button3.Image = Image.FromFile(f.Cat() + "\\3.png");
            button4.Image = Image.FromFile(f.Cat() + "\\4.png");
            pnCategoria.Visible = false;
        }
        private void BtnFiguras_Click_1(object sender, EventArgs e)
        {
            f.Categoria("Figuras");
            button1.Image = Image.FromFile(f.Cat() + "\\1.png");
            button2.Image = Image.FromFile(f.Cat() + "\\2.png");
            button3.Image = Image.FromFile(f.Cat() + "\\3.png");
            button4.Image = Image.FromFile(f.Cat() + "\\4.png");
            pnCategoria.Visible = false;
        }
        private void BtnColores_Click_1(object sender, EventArgs e)
        {
            f.Categoria("Colores");
            button1.Image = Image.FromFile(f.Cat() + "\\1.png");
            button2.Image = Image.FromFile(f.Cat() + "\\2.png");
            button3.Image = Image.FromFile(f.Cat() + "\\3.png");
            button4.Image = Image.FromFile(f.Cat() + "\\4.png");
            pnCategoria.Visible = false;
        }
        //Boton Volver
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Juego.Enabled = false;
            picBox.Image = null;
            pnCategoria.Visible = true;
            f = new Figuras();
            btnReiniciar.Enabled = false;
            picBien.Visible = false;
            picMal.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btnIniciar.Visible = true;
            lista.Anula();
            a = 1;
            b = 1;
        }
        private void BtnVolverAlMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(true);
            menu.Show();
            Close();
        }

        //Boton reiniciar
        private void BtnReiniciar_Click_1(object sender, EventArgs e)
        {
            btnReiniciar.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            lista.Anula();
            a = 1;
            b = 1;
            f.Secuencia(lista);
            Juego.Enabled = true;
        }
    }
}
