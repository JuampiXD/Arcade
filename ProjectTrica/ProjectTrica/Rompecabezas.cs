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

namespace ProjectTrica
{
    public partial class Rompecabezas : Form
    {
        Musica dj = new Musica();
        Rompecabeza rmp;
        string ruta = Directory.GetCurrentDirectory() + "\\Imagenes\\Rompecabezas";
        int click = 0, a, b, s = 0, m = 0;


        public Rompecabezas()
        {
            dj.direccion("Rompecabezas.wav");
            dj.Reproductor();
            InitializeComponent();
            pictureBox1.Size = new Size(1280,637);
        }
        public void Opcion(string opcion, string descripcion)
        {
            label1.Text = "00:00";
            s = 0;
            m = 0;
            inicio();
            timer1.Enabled = true;
            pnlRompecabezas.Location = new Point(48, 119);
            pnlRompecabezas.Size = new Size(1176, 475);
            pnlRompecabezas.Visible = true;
            rmp = new Rompecabeza(opcion);
            rmp.mezclar();
            cargarImagenes();
            btnPatron.Image = Image.FromFile(ruta + opcion + "\\patron.jpg");
            lbDescripcion.Text = descripcion;
        }
        //Este es el boton para el rompecabeza opcion 1
        private void BtnOpcion1RP_Click(object sender, EventArgs e)
        {
            Opcion("\\op1", "Modo Facil");

        }
        //Este es el boton para el rompecabeza opcion 2
        private void BtnOpcion2RP_Click(object sender, EventArgs e)
        {
            Opcion("\\op2", "Modo Normal");
            
        }
        //Este es el boton para el rompecabeza opcion 3
        private void BtnOpcion3RP_Click(object sender, EventArgs e)
        {
            Opcion("\\op3", "Modo Dificil");
            
        }
        //Este es el boton para el rompecabeza opcion 4
        private void BtnOpcion4RP_Click(object sender, EventArgs e)
        {
            Opcion("\\op4", "Modo Extremo");
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
                pnlMagistral.Location = new Point(248,104);
                pnlMagistral.Size = new Size(694, 245);
                pnlMagistral.Visible = true;
                fin();
                

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
        public void limpiar()
        {
            label1.Text = "00:00";
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            label1.Text = "00:00";
            pnlMagistral.Visible = false;
            pnlRompecabezas.Visible = false;
        }

        private void BtnVolverAlMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(true);
            menu.Show();
            Close();
        }

        //Este es Boton al acabar la partida
        private void BtnAtras_Click_1(object sender, EventArgs e)
        {
            pnlMagistral.Visible = false;
            label1.Text = "00:00";
            pnlRompecabezas.Visible = false;
            btnVolverAlMenu.Visible = true;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            intercambiar(7);
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            intercambiar(8);
        }
        private void BtnVolverAlMP_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(true);
            menu.Show();
            Close();
        }
    }
}
