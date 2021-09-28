using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade_Master
{
    public partial class frmMenu : Form
    {
        Musica dj = new Musica();
        //798; 586  TAMAÑO DEL PICTURE BOX INTRO
        //798; 585 TAMALO DEL FORMS INTRO


        public frmMenu(bool flag)
        {
            dj.direccion("musica1.wav");
            dj.Reproductor();
            InitializeComponent();
            pbFondo.Size = new Size(801, 598);
            Size = new Size(798, 586);
            if (flag)
            {
                pnlJuegos.Visible = true;
                Size = new Size(960, 481);
                pbFondo.Size = new Size(965, 485);
                pbTitulo.Visible = false;
            }
        }
        //Boton de Jugar
        private void PbJugar_Click(object sender, EventArgs e)
        {
            pnlJuegos.Visible = true;
        }
        //Boton De Rompecabezas
        private void BtnRompecabezas_Click(object sender, EventArgs e)
        {
            Rompecabezas J1 = new Rompecabezas();
            J1.Show();
            this.Hide();
        }
        private void BtnOca_Click(object sender, EventArgs e)
        {
            FrmDatos J2 = new FrmDatos();
            J2.Show();
            this.Hide();
        }

        private void BtnBuscarPares_Click(object sender, EventArgs e)
        {
            BuscarPares J3 = new BuscarPares();
            J3.Show();
            this.Hide();
        }

        private void BtnAhorcado_Click(object sender, EventArgs e)
        {
            Ahorcado j4 = new Ahorcado();
            j4.Show();
            this.Hide();
        }

        private void BtnSerpientesEscaleras_Click(object sender, EventArgs e)
        {

        }

        private void BtnTresEnRaya_Click(object sender, EventArgs e)
        {

        }
        private void TmrLogo_Tick(object sender, EventArgs e)
        {
            Size=new Size(960,481);
            pbFondo.Size = new Size(965, 485);
            pbTitulo.Visible = false;
            tmrLogo.Enabled = false;
        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            pnlSalir.Visible = true;
            pnlJuegos.Enabled = false;
            pbFondo.Enabled = false;
            pbCreditos.Enabled = false;
            pbJugar.Enabled = false;
            pbSalir.Enabled = false;
            
        }

        private void PbCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fernando Belaunde Tercero - Uwil Cuellar Rojas - Juan Pablo Nuñez Molina");
        }

        private void PbFondo_Click(object sender, EventArgs e)
        {
            pnlJuegos.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnlSalir.Visible = false;
            pnlJuegos.Enabled = true;
            pbFondo.Enabled = true;
            pbCreditos.Enabled = true;
            pbJugar.Enabled = true;
            pbSalir.Enabled = true;
        }

        private void PbTitulo_Click(object sender, EventArgs e)
        {
            Size = new Size(960, 481);
            pbFondo.Size = new Size(965, 485);
            pbTitulo.Visible = false;
            tmrLogo.Enabled = false;
        }
    }
}
