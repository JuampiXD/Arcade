using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTrica
{
    public partial class Menu : Form
    {
        //Declara dj del tipo musica
        Musica dj = new Musica();
        bool x = false;
        public Menu(bool bandera)
        {
            InitializeComponent();
            if (bandera)
            {
                dj.direccion("Menu.wav");
                dj.Reproductor();
                //Dimensiona el picture box del fondo
                pbFondo.Location = new Point(0, 0);
                pbFondo.Size = new Size(960, 485);
                pnlJuegos.Visible = true;
                 
            }
            else
            {
                //Dimensiona el picture box del fondo
                pbFondo.Location = new Point(0, 0);
                pbFondo.Size = new Size(960, 485);
            }
            
        }
        //Esconde el panel de los creditos
        private void PbFondo_Click(object sender, EventArgs e)
        {
            if (x)
            {
                dj.direccion("Menu.wav");
                dj.Reproductor();
                x = false;
            }
            
            pbCreditos.Visible = false;
            pnlJuegos.Visible = false;
        }
        private void PbCreditos_Click(object sender, EventArgs e)
        {
            pbCreditos.Visible = false;
        }
        //Muestra los creditos de la aplicacion
        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            pnlJuegos.Visible = false;
            pbCreditos.Location = new Point(239,107);
            pbCreditos.Size = new Size(500,316);
            pbCreditos.Visible = true;
            pnlSalir.Visible = false;
        }
        //Muestra el panel de salida
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            pnlJuegos.Visible = false;
            pbCreditos.Visible = false;
            pnlSalir.Location = new Point(305,196);
            pnlSalir.Size = new Size(367,133);
            pnlSalir.Visible = true;
        }
        //Esconde el panel de salida
        private void BtnCancelarSalir_Click(object sender, EventArgs e)
        {
            pnlSalir.Visible = false;
        }
        //Inicializa el juego Buscar Pares y esconde el Menu 
        private void BtnBuscarPares_Click_1(object sender, EventArgs e)
        {
            BuscarPares Pares = new BuscarPares();
            Pares.Show();
            Close();
        }
        //Esconde el panel de salida
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnlSalir.Visible = false;
        }
        //Finaliza el programa
        private void BtnSalir_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Muestra el panel de juegos
        private void BtnJugar_Click(object sender, EventArgs e)
        {
            pnlJuegos.Visible = true;
            pbCreditos.Visible = false;
            pnlSalir.Visible = false;
        }

        private void BtnRompecabezas_Click(object sender, EventArgs e)
        {
            Rompecabezas Rompecabeza = new Rompecabezas();
            Rompecabeza.Show();
            Hide();
        }
        private void BtnSecuencia_Click(object sender, EventArgs e)
        {
            Secuencias Secuencia = new Secuencias();
            Secuencia.Show();
            Hide();
        }

        private void BtnAdivinanzas_Click(object sender, EventArgs e)
        {
            AdivinaLaImagen Adivina = new AdivinaLaImagen();
            Adivina.Show();
            Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            x = true;
            dj.direccion("1.wav");
            dj.Reproductor();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            x = true;
            dj.direccion("2.wav");
            dj.Reproductor();
        }
    }
}
