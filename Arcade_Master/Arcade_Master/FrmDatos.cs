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
    public partial class FrmDatos : Form
    {
        public string[] jugadores = new string[4];
        public int numj;
        Musica dj = new Musica();
        public FrmDatos()
        {
            InitializeComponent();
            dj.direccion("LaOca.wav");
            dj.Reproductor();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (comboNumj.Text != "")
            {
                numj = Convert.ToInt32(comboNumj.Text);
                btnIniciar.Enabled = false;
                textBNom1.Enabled = false;
                textBNom2.Enabled = false;
                textBNom3.Enabled = false;
                textBNom4.Enabled = false;
                textBNom1.Text = "";
                textBNom2.Text = "";
                textBNom3.Text = "";
                textBNom4.Text = "";
                if (numj > 1 && numj < 5)
                {
                    if (numj >= 2)
                    {
                        btnIniciar.Enabled = true;
                        textBNom1.Text = "Jugador 1";
                        textBNom1.Enabled = true;
                        textBNom2.Text = "Jugador 2";
                        textBNom2.Enabled = true;
                        if (numj >= 3)
                        {
                            textBNom3.Text = "Jugador 3";
                            textBNom3.Enabled = true;
                            if (numj == 4)
                            {
                                textBNom4.Text = "Jugador 4";
                                textBNom4.Enabled = true;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El numero de Jugadores tiene q ser entre 2 a 4.");
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            jugadores = new string[numj];
            if (numj >= 2)
            {
                jugadores[0] = textBNom1.Text;
                jugadores[1] = textBNom2.Text;
                if (numj >= 3)
                {
                    jugadores[2] = textBNom3.Text;
                    if (numj == 4)
                    {
                        jugadores[3] = textBNom4.Text;
                    }
                }
            }

             LaOcaLoca LaOca = new LaOcaLoca(jugadores);

            LaOca.Show();
        }

        private void ComboNumj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnVolveralmenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu(true);
            menu.Show();
            Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
