using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade_Master
{
    public partial class Rompecabezas : Form
    {
        Musica dj = new Musica();
        Rompecabeza rmp;
        string opcion;
        string ruta = Directory.GetCurrentDirectory() + "\\imagenes";
        int click = 0, a, b, Flecha = 0, s = 0, m = 0;


        public Rompecabezas()
        {
            dj.direccion("Rompecabezas.wav");
            dj.Reproductor();
            InitializeComponent();
        }


        //Este es el boton para el rompecabeza opcion 1
        private void BtnOpcion1RP_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00";
            btnVolverAlMP.Visible = false;
            label1.Text = "00:00";
            instrucciones();
            s = 0;
            m = 0;
            inicio();
            timer1.Enabled = true;
            pnlRompecabezas.Visible = true;
            opcion = "\\op1";
            rmp = new Rompecabeza(opcion);
            rmp.mezclar();
            cargarImagenes();
            btnPatron.Image = Image.FromFile(ruta + opcion + "\\patron.jpg");
            lbDescripcion.Text = "Dia Soleado EMI";
        }
        //Este es el boton para el rompecabeza opcion 2
        private void BtnOpcion2RP_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00";
            btnVolverAlMP.Visible = false;
            label1.Text = "00:00";
            instrucciones();
            s = 0;
            m = 0;
            inicio();
            timer1.Enabled = true;
            pnlRompecabezas.Visible = true;
            opcion = "\\op2";
            rmp = new Rompecabeza(opcion);
            rmp.mezclar();
            cargarImagenes();
            btnPatron.Image = Image.FromFile(ruta + opcion + "\\patron.jpg");
            lbDescripcion.Text = "BCP al Ataque";
        }
        //Este es el boton para el rompecabeza opcion 3
        private void BtnOpcion3RP_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00";
            btnVolverAlMP.Visible = false;
            label1.Text = "00:00";
            instrucciones();
            s = 0;
            m = 0;
            inicio();
            timer1.Enabled = true;
            pnlRompecabezas.Visible = true;
            opcion = "\\op3";
            rmp = new Rompecabeza(opcion);
            rmp.mezclar();
            cargarImagenes();
            btnPatron.Image = Image.FromFile(ruta + opcion + "\\patron.jpg");
            lbDescripcion.Text = "Victoria's Secret mi Teniente";
        }
        //Este es el boton para el rompecabeza opcion 4
        private void BtnOpcion4RP_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00";
            btnVolverAlMP.Visible = false;
            label1.Text = "00:00";
            instrucciones();
            s = 0;
            m = 0;
            inicio();
            timer1.Enabled = true;
            pnlRompecabezas.Visible = true;
            opcion = "\\op4";
            rmp = new Rompecabeza(opcion);
            rmp.mezclar();
            cargarImagenes();
            btnPatron.Image = Image.FromFile(ruta + opcion + "\\patron.jpg");
            lbDescripcion.Text = "Dia Neblado EMI";
        }
        //Aqui se cargar los botones
        public void cargarImagenes()
        {
            rmp.cargarImagenes(btn0, 0, 0);
            rmp.cargarImagenes(btn1, 0, 1);
            rmp.cargarImagenes(btn2, 0, 2);
            rmp.cargarImagenes(btn3, 1, 0);
            rmp.cargarImagenes(btn4, 1, 1);
            rmp.cargarImagenes(btn5, 1, 2);
            rmp.cargarImagenes(btn6, 2, 0);
            rmp.cargarImagenes(btn7, 2, 1);
            rmp.cargarImagenes(btn8, 2, 2);
        }
        //Funcion para intercmbiar en la matrizas y en las imagenes
        public void intercambiar(int casilla)
        {
            click++;
            if (click == 1)
            {
                a = casilla;
            }
            else
            {
                if (click == 2)
                {
                    b = casilla;
                    rmp.intercambiar(a, b);
                    cargarImagenes();
                }
                click = 0;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "00:00";
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
            bool x = rmp.fin();
            if (x)
            {
                if (s > 60)
                {
                    s = 0;
                    m++;
                }
                if (s >= 0 && s <= 9 && m >= 0 && m <= 9)
                    lbTiempo.Text = "0" + m.ToString() + ":0" + s.ToString();
                if (s > 9 && m >= 0 && m <= 9)
                    lbTiempo.Text = "0" + m.ToString() + ":" + s.ToString();
                if (s >= 0 && s <= 9 && m >= 9)
                    lbTiempo.Text = m.ToString() + ":0" + s.ToString();
                if (s > 9 && m >= 9)
                    lbTiempo.Text = m.ToString() + s.ToString();
                timer1.Enabled = false;
                fin();
                pnlVictoria.Visible = true;
                tmrFlecha.Enabled = true;
            }
        }
        private void TmrFlecha_Tick_1(object sender, EventArgs e)
        {
            label1.Text = "00:00";
            if (Flecha == 0)
            {
                panel1.Visible = true;
                Flecha = 1;
            }
            else
            {
                panel1.Visible = false;
                Flecha = 0;
            }
        }
        public void inicio()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
        }
        public void fin()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            intercambiar(0);
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            intercambiar(1);
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            intercambiar(2);
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            intercambiar(3);
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            intercambiar(4);
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            intercambiar(5);
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            intercambiar(6);
        }

        private void PnlRompecabezas_Paint(object sender, PaintEventArgs e)
        {

        }
        public void limpiar()
        {
            label1.Text = "00:00";
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            label1.Text = "00:00";
            btnVolverAlMP.Visible = true;
            pnlVictoria.Visible = false;
            pnlRompecabezas.Visible = false;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            intercambiar(7);
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            intercambiar(8);
        }
        public void instrucciones()
        {
            MessageBox.Show(
                "* EL JUEGO TERMINA CUANDO LA IMAGEN ESTE IGUAL AL PATRON DE LA DERECHA" + '\n' +
                "* UN CONTADOR DE TIEMPO MEDIRA EL PUNTAJE" + '\n' +
                "* DEBE ESCOGER UNA CASILLA Y DESPUES ESCOGER CON CUAL DESEA INTERCAMBIARLA" + '\n' +
                "* TRATE DE ARMAR LA IMAGEN QUE SE MUESTRA EN EL EJEMPLO DE LA DERECHA" + '\n' +
                "* DISFRUTE", "INSTRUCCIONES");
        }
        //Este es Boton al acabar la partida
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            pnlVictoria.Visible = false;
            label1.Text = "00:00";
            pnlRompecabezas.Visible = false;
            tmrFlecha.Enabled = false;
            //se llama txtjugador
        }
        private void BtnVolverAlMP_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu(true);
            menu.Show();
            Close();
        }
    }
}
