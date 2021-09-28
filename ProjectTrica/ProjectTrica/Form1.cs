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
    public partial class Form1 : Form
    {
        //Declara dj del tipo musica
        Musica dj = new Musica();

        public Form1()
        {
            //Manda el nombre de la cancion que va a reproducir y da la orden de reproducir
            dj.direccion("Menu.wav");
            dj.Reproductor();
            InitializeComponent();
           //Dimensiona el picture box del logo inicial 
            pbLogo.Location = new Point(0, 0);
            pbLogo.Size = new Size(800, 600);
        }
        private void PbLogo_Click(object sender, EventArgs e)
        {
            //Abre automaticamente el menu caundo se da un click al picture box
            Menu menu = new Menu(false);
            menu.Show();
            this.Hide();
            tmrLogo.Enabled = false;
        }
        private void TmrLogo_Tick(object sender, EventArgs e)
        {
            //Abre automaticamente el menu si no se da un click al picture box
            Menu menu = new Menu(false);
            menu.Show();
            this.Hide();
            tmrLogo.Enabled = false;
        }
    }
}
