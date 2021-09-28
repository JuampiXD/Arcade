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
    public partial class Ahorcado : Form
    {
        Musica dj = new Musica();
        string pale;
        string Prueba, ad;
        int pos, po, p, contador = 0, duck = 0;
        Diccionario dic = new Diccionario();
        Comparar comp = new Comparar();
        public Ahorcado()
        {
            dj.direccion("Ahorcado.wav");
            dj.Reproductor();
            InitializeComponent();
            pictureBox1.Size = new Size(1200, 700);
            panelMenu.Size = new Size(1428, 718);
        }
        //Categoria del Ahorcado
        private void BtnSistema_Click(object sender, EventArgs e)
        {
            guionesLi();
            Activar();
            contador = 0;
            pbxAhorcado.Image = null;
            Prueba = "PalabraS.txt";
            dic.Ruta(Prueba);
            dic.Inicializar();
            pale = dic.getPalabra();
            panelMenu.Visible = false;
            panelAhorcado.Visible = true;
            guiones(dic.longitud());
            ad = pale;
            label25.Text = "CATEGORIA: SISTEMAS";
            //pbxfondo.Image = Image.FromFile("imagenes\\Ahorcado\\fondo.gif");
        }
        private void BtnMecatronica_Click(object sender, EventArgs e)
        {
            guionesLi();
            Activar();
            contador = 0;
            pbxAhorcado.Image = null;
            Prueba = "PalabraM.txt";
            dic.Ruta(Prueba);
            dic.Inicializar();
            pale = dic.getPalabra();
            panelMenu.Visible = false;
            panelAhorcado.Visible = true;
            guiones(dic.longitud());
            for (int i = 0; i < pale.Length; i++)
            {
                ad = ad + pale[i];
            }
            label25.Text = "CATEGORIA: MECATRONICA";
        }

        private void BtnElectronica_Click(object sender, EventArgs e)
        {
            guionesLi();
            Activar();
            contador = 0;
            pbxAhorcado.Image = null;
            Prueba = "PalabraE.txt";
            dic.Ruta(Prueba);
            dic.Inicializar();
            pale = dic.getPalabra();
            panelMenu.Visible = false;
            panelAhorcado.Visible = true;
            guiones(dic.longitud());
            for (int i = 0; i < pale.Length; i++)
            {
                ad = ad + pale[i];
            }
            label25.Text = "CATEGORIA: ELECTRONICA";
        }
        private void BtnIndustrial_Click(object sender, EventArgs e)
        {
            guionesLi();
            Activar();
            contador = 0;
            pbxAhorcado.Image = null;
            Prueba = "PalabraI.txt";
            dic.Ruta(Prueba);
            dic.Inicializar();
            pale = dic.getPalabra();
            panelMenu.Visible = false;
            panelAhorcado.Visible = true;
            guiones(dic.longitud());
            for (int i = 0; i < pale.Length; i++)
            {
                ad = ad + pale[i];
            }
            label25.Text = "CATEGORIA: INDUSTRIAL";
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelAhorcado.Visible = false;
            txtPalabraFinal.Clear(); //ESTOOOOOOOO
            dic.limbiarRuta();
        }

        private void BtnVerificacion_Click(object sender, EventArgs e)
        {
            string ver = txtPalabraFinal.Text.ToUpper();
            if (ver == ad)
            {
                MessageBox.Show("Felicitaciones Ganaste El Juego Del Ahorcado Quieres Volver a Jugar? UwU");
                btnVerificacion.Enabled = false;
                panel2.Enabled = false;
            }
            else
            {
                Oportunidades(7);
            }
            txtPalabraFinal.Clear();
        }
        public void guionesLi()
        {
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label7.Text = "_";
            label8.Text = "_";
            label9.Text = "_";
            label10.Text = "_";
            label11.Text = "_";
            label12.Text = "_";
            label13.Text = "_";
            label14.Text = "_";
            label15.Text = "_";
            label16.Text = "_";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }
        private void BtnJugar_Click(object sender, EventArgs e)
        {
            pale = null; ;
            Prueba=null;
            pos = 0;
            po = 0;
            p = 0;
            ad = "";
            txtPalabraFinal.Clear();
            dic.Inicializar();
            pale = dic.getPalabra();
            guionesLi();
            guiones(dic.longitud());
            pbxAhorcado.Image = null;
            contador = 0;
            duck = 0;
            for (int i = 0; i < pale.Length; i++)
            {
                ad = ad + pale[i];
            }
            btnVerificacion.Enabled = true;
            panel2.Enabled = true;
            Activar();
        }
        public void Activar()
        {
            btnQ.Enabled = true;
            btnW.Enabled = true;
            btnE.Enabled = true;
            btnR.Enabled = true;
            btnT.Enabled = true;
            btnY.Enabled = true;
            btnU.Enabled = true;
            btnI.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnA.Enabled = true;
            btnS.Enabled = true;
            btnD.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnÑ.Enabled = true;
            btnZ.Enabled = true;
            btnX.Enabled = true;
            btnC.Enabled = true;
            btnV.Enabled = true;
            btnB.Enabled = true;
            btnN.Enabled = true;
            btnM.Enabled = true;
        }
        public void letrasVisibles(string let)
        {
            switch (pos)
            {
                case 0:
                    label1.Text = let;
                    duck++;
                    break;
                case 1:
                    label2.Text = let;
                    duck++;
                    break;
                case 2:
                    label3.Text = let;
                    duck++;
                    break;
                case 3:
                    label4.Text = let;
                    duck++;
                    break;
                case 4:
                    label5.Text = let;
                    duck++;
                    break;
                case 5:
                    label6.Text = let;
                    duck++;
                    break;
                case 6:
                    label7.Text = let;
                    duck++;
                    break;
                case 7:
                    label8.Text = let;
                    duck++;
                    break;
                case 8:
                    label9.Text = let;
                    duck++;
                    break;
                case 9:
                    label10.Text = let;
                    duck++;
                    break;
                case 10:
                    label11.Text = let;
                    duck++;
                    break;
                case 11:
                    label12.Text = let;
                    duck++;
                    break;
                case 12:
                    label13.Text = let;
                    duck++;
                    break;
                case 13:
                    label14.Text = let;
                    duck++;
                    break;
                case 14:
                    label15.Text = let;
                    duck++;
                    break;
                default:
                    Oportunidades(1);
                    break;
            }
            switch (po)
            {
                case 0:
                    label1.Text = let;
                    duck++;
                    break;
                case 1:
                    label2.Text = let;
                    duck++;
                    break;
                case 2:
                    label3.Text = let;
                    duck++;
                    break;
                case 3:
                    label4.Text = let;
                    duck++;
                    break;
                case 4:
                    label5.Text = let;
                    duck++;
                    break;
                case 5:
                    label6.Text = let;
                    duck++;
                    break;
                case 6:
                    label7.Text = let;
                    duck++;
                    break;
                case 7:
                    label8.Text = let;
                    duck++;
                    break;
                case 8:
                    label9.Text = let;
                    duck++;
                    break;
                case 9:
                    label10.Text = let;
                    duck++;
                    break;
                case 10:
                    label11.Text = let;
                    duck++;
                    break;
                case 11:
                    label12.Text = let;
                    duck++;
                    break;
                case 12:
                    label13.Text = let;
                    duck++;
                    break;
                case 13:
                    label14.Text = let;
                    duck++;
                    break;
                case 14:
                    label15.Text = let;
                    duck++;
                    break;
                default:
                    break;
            }
            switch (p)
            {
                case 0:
                    label1.Text = let;
                    duck++;
                    break;
                case 1:
                    label2.Text = let;
                    duck++;
                    break;
                case 2:
                    label3.Text = let;
                    duck++;
                    break;
                case 3:
                    label4.Text = let;
                    duck++;
                    break;
                case 4:
                    label5.Text = let;
                    duck++;
                    break;
                case 5:
                    label6.Text = let;
                    duck++;
                    break;
                case 6:
                    label7.Text = let;
                    duck++;
                    break;
                case 7:
                    label8.Text = let;
                    duck++;
                    break;
                case 8:
                    label9.Text = let;
                    duck++;
                    break;
                case 9:
                    label10.Text = let;
                    duck++;
                    break;
                case 10:
                    label11.Text = let;
                    duck++;
                    break;
                case 11:
                    label12.Text = let;
                    duck++;
                    break;
                case 12:
                    label13.Text = let;
                    duck++;
                    break;
                case 13:
                    label14.Text = let;
                    duck++;
                    break;
                case 14:
                    label15.Text = let;
                    duck++;
                    break;
                default:
                    break;
            }
            pos = 99;
            po = 99;
            p = 99;
            Final(duck);
        }
        public void Oportunidades(int cont)
        {
            contador = contador + cont;
            switch (contador)
            {
                case 1:
                    pbxAhorcado.Image = Image.FromFile("imagenes\\Ahorcado\\0.png");
                    break;
                case 2:
                    pbxAhorcado.Image = Image.FromFile("imagenes\\Ahorcado\\1.png");
                    break;
                case 3:
                    pbxAhorcado.Image = Image.FromFile("imagenes\\Ahorcado\\2.png");
                    break;
                case 4:
                    pbxAhorcado.Image = Image.FromFile("imagenes\\Ahorcado\\3.png");
                    break;
                case 5:
                    pbxAhorcado.Image = Image.FromFile("imagenes\\Ahorcado\\4.png");
                    break;
                case 6:
                    pbxAhorcado.Image = Image.FromFile("imagenes\\Ahorcado\\5.png");
                    break;
                //Controla que el Juego Termine y Bloquea Los paneles y Botones
                case 7:
                    pbxAhorcado.Image = Image.FromFile("imagenes\\Ahorcado\\6.png");
                    MessageBox.Show("Juego Terminado //PERDISTE\\");
                    btnVerificacion.Enabled = false;
                    panel2.Enabled = false;
                    Mostrar();
                    break;
            }
        }
        public void Mostrar()
        {
            MessageBox.Show("La palabra buscada era: " + ad);
        }
        public void guiones(int x)
        {
            if (x >= 3)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                if (x >= 4)
                {
                    label4.Visible = true;
                    if (x >= 5)
                    {
                        label5.Visible = true;
                        if (x >= 6)
                        {
                            label6.Visible = true;
                            if (x >= 7)
                            {
                                label7.Visible = true;
                                if (x >= 8)
                                {
                                    label8.Visible = true;
                                    if (x >= 9)
                                    {
                                        label9.Visible = true;
                                        if (x >= 10)
                                        {
                                            label10.Visible = true;
                                            if (x >= 11)
                                            {
                                                label11.Visible = true;
                                                if (x >= 12)
                                                {

                                                    label12.Visible = true;
                                                    if (x >= 13)
                                                    {
                                                        label13.Visible = true;
                                                        if (x >= 14)
                                                        {
                                                            label14.Visible = true;
                                                            if (x >= 15)
                                                            {
                                                                label15.Visible = true;
                                                                if (x >= 16)
                                                                {
                                                                    label16.Visible = true;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Final(int c)
        {
            int k = pale.Length;
            if (c == k)
            {
                MessageBox.Show("Felicitaciones Ganaste El Juego Del Ahorcado Quieres Volver a Jugar? UwU");
                btnVerificacion.Enabled = false;
                panel2.Enabled = false;
                pale = null; ;
                Prueba = null;
                pos = 0;
                po = 0;
                p = 0;
                ad = "";
                txtPalabraFinal.Clear();
                dic.Inicializar();
                pale = dic.getPalabra();
                guionesLi();
                guiones(dic.longitud());
                pbxAhorcado.Image = null;
                contador = 0;
                duck = 0;
                for (int i = 0; i < pale.Length; i++)
                {
                    ad = ad + pale[i];
                }
                btnVerificacion.Enabled = true;
                panel2.Enabled = true;
                Activar();
            }

        }
        private void BtnQ_Click(object sender, EventArgs e)
        {
            comp.Letra("Q");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("Q");
            btnQ.Enabled = false;
        }
        private void BtnW_Click(object sender, EventArgs e)
        {
            comp.Letra("W");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("W");
            btnW.Enabled = false;
        }
        private void BtnE_Click(object sender, EventArgs e)
        {
            comp.Letra("E");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("E");
            btnE.Enabled = false;
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            comp.Letra("R");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("R");
            btnR.Enabled = false;
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            comp.Letra("T");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("T");
            btnT.Enabled = false;
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            comp.Letra("Y");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("Y");
            btnY.Enabled = false;
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            comp.Letra("U");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("U");
            btnU.Enabled = false;
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            comp.Letra("I");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("I");
            btnI.Enabled = false;
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            comp.Letra("O");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("O");
            btnO.Enabled = false;
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            comp.Letra("P");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("P");
            btnP.Enabled = false;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            comp.Letra("A");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("A");
            btnA.Enabled = false;
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            comp.Letra("S");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("S");
            btnS.Enabled = false;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            comp.Letra("D");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("D");
            btnD.Enabled = false;
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            comp.Letra("F");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("F");
            btnF.Enabled = false;
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            comp.Letra("G");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("G");
            btnG.Enabled = false;
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            comp.Letra("H");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("H");
            btnH.Enabled = false;
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            comp.Letra("J");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("J");
            btnJ.Enabled = false;
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            comp.Letra("K");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("K");
            btnK.Enabled = false;
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            comp.Letra("L");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("L");
            btnL.Enabled = false;
        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {
            comp.Letra("Ñ");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("Ñ");
            btnÑ.Enabled = false;
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            comp.Letra("Z");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("Z");
            btnZ.Enabled = false;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            comp.Letra("X");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("X");
            btnX.Enabled = false;
        }

        private void BtnVMP_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu(true);
            menu.Show();
            Close();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            comp.Letra("C");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("C");
            btnC.Enabled = false;
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            comp.Letra("V");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("V");
            btnV.Enabled = false;
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            comp.Letra("B");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("B");
            btnB.Enabled = false;
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            comp.Letra("N");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("N");
            btnN.Enabled = false;
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            comp.Letra("M");
            comp.Existe(ad);
            pos = comp.getPosicion1();
            po = comp.getPosicion2();
            p = comp.getPosicion3();

            letrasVisibles("M");
            btnM.Enabled = false;
        }

       
    }
}
