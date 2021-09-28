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
    //638; 617
    public partial class BuscarPares : Form
    {
        Memoria objMemoria;
        int clic;
        Button boton1, boton2;
        int parejas;
        Musica dj = new Musica();
        int s = 0, m = 0;
        public BuscarPares()
        {
            InitializeComponent();
            dj.direccion("BuscarPares.wav");
            dj.Reproductor();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void BtnVolverAlMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu(true);
            menu.Show();
            Close();
        }

        private void BtnIniciar_Click_1(object sender, EventArgs e)
        {
            //DJ.Reproductor(2);
            panel1.Visible = true;
            tmr2.Enabled = true;
            objMemoria = new Memoria();
            objMemoria.inicializar();
            panel1.Enabled = true;
            clic = 0;
            parejas = 0;
            btnCancelar.Enabled = true;
            btnIniciar.Enabled = false;
            lbTitulo1.Visible = false;
            lbTitulo2.Visible = false;
            btnVolverAlMenu.Visible = false;
            btnIniciar.Location = new Point(756,80);
            btnCancelar.Location = new Point(756, 115);
        }
        void analizar(Button btnX, int nroCelda)
        {
            if (btnX.Image == null && timer1.Enabled == false)
            {
                objMemoria.cargarImagen(btnX, nroCelda);
                clic++;
                if (clic == 1)
                    boton1 = btnX;
                else
                {
                    if (clic == 2)
                    {
                        boton2 = btnX;
                        timer1.Enabled = true;
                    }

                }
            }
        }
        private void BtnJugar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = false;
            anularImagenes();
            btnIniciar.Enabled = true;
            s = 0;
            m = 0;
            label1.Text = "0" + m.ToString() + ":0" + s.ToString();
            lbTitulo1.Visible = true;
            lbTitulo2.Visible = true;
            btnVolverAlMenu.Visible = true;
            btnIniciar.Location = new Point(133,215);
            btnCancelar.Location = new Point(133,277);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            tmr2.Enabled = false;
            s = 0;
            m = 0;
            label1.Text = "0" + m.ToString() + ":0" + s.ToString();
            btnIniciar.Enabled = true;
            btnCancelar.Enabled = false;
            anularImagenes();
        }
        void anularImagenes()
        {
            btn0.Image = null;
            btn1.Image = null;
            btn2.Image = null;
            btn3.Image = null;
            btn4.Image = null;
            btn5.Image = null;
            btn6.Image = null;
            btn7.Image = null;
            btn8.Image = null;
            btn9.Image = null;
            btn10.Image = null;
            btn11.Image = null;
            btn12.Image = null;
            btn13.Image = null;
            btn14.Image = null;
            btn15.Image = null;

            btn0.Text = "";
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (boton1.Text == boton2.Text)
            {
                boton1.Enabled = false;
                boton2.Enabled = false;
                parejas++;
                if (parejas == 7)
                {
                    //DJ.Reproductor(3);
                    tmr2.Enabled = false;
                    label4.Text = label1.Text;
                    //DJ.Reproductor(1);
                    panel1.Enabled = false;
                    panel2.Visible = true;
                    btnIniciar.Enabled = false;
                    btnCancelar.Enabled = false;
                    

                }
            }
            else
            {
                boton1.Image = null;
                boton2.Image = null;
                boton1.Text = "";
                boton2.Text = "";

            }
            timer1.Enabled = false;
            clic = 0;
        }
        private void Tmr2_Tick(object sender, EventArgs e)
        {
            s++;
            if (s > 60)
            {
                s = 0;
                m++;
            }
            if (s >= 0 && s <= 9 && m >= 0 && m <= 9)
                label1.Text = "0" + m.ToString() + ":0" + s.ToString();
            if (s > 9 && m >= 0 && m <= 9)
                label1.Text = "0" + m.ToString() + ":" + s.ToString();
            if (s >= 0 && s <= 9 && m >= 9)
                label1.Text = m.ToString() + ":0" + s.ToString();
            if (s > 9 && m >= 9)
                label1.Text = m.ToString() + s.ToString();

        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            analizar(btn0, 0);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            analizar(btn1,1);
        }

        private void Btn2_Click_1(object sender, EventArgs e)
        {
            analizar(btn2,2);
        }

        private void Btn3_Click_1(object sender, EventArgs e)
        {
            analizar(btn3,3);
        }

        private void Btn4_Click_1(object sender, EventArgs e)
        {
            analizar(btn4,4);
        }

        private void Btn5_Click_1(object sender, EventArgs e)
        {
            analizar(btn5,5);
        }

        private void Btn6_Click_1(object sender, EventArgs e)
        {
            analizar(btn6,6);
        }

        private void Btn7_Click_1(object sender, EventArgs e)
        {
            analizar(btn7,7);
        }

        private void Btn8_Click_1(object sender, EventArgs e)
        {
            analizar(btn8,8);
        }

        private void Btn9_Click_1(object sender, EventArgs e)
        {
            analizar(btn9,9);
        }

        private void Btn10_Click_1(object sender, EventArgs e)
        {
            analizar(btn10,10);
        }

        private void Btn11_Click_1(object sender, EventArgs e)
        {
            analizar(btn11,11);
        }

        private void Btn12_Click_1(object sender, EventArgs e)
        {
            analizar(btn12,12);
        }

        private void Btn13_Click_1(object sender, EventArgs e)
        {
            analizar(btn13,13);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = false;
            anularImagenes();
            btnIniciar.Enabled = true;
            s = 0;
            m = 0;
            label1.Text = "0" + m.ToString() + ":0" + s.ToString();
            lbTitulo1.Visible = true;
            lbTitulo2.Visible = true;
            btnVolverAlMenu.Visible = true;
            btnIniciar.Location = new Point(133, 215);
            btnCancelar.Location = new Point(133, 277);
            panel1.Enabled = false;
            tmr2.Enabled = false;
            s = 0;
            m = 0;
            label1.Text = "0" + m.ToString() + ":0" + s.ToString();
            btnIniciar.Enabled = true;
            btnCancelar.Enabled = false;
            anularImagenes();
        }

        private void Btn14_Click_1(object sender, EventArgs e)
        {
            analizar(btn14,14);
        }

        private void Btn15_Click_1(object sender, EventArgs e)
        {
            analizar(btn15,15);
        }
        
    }
}
