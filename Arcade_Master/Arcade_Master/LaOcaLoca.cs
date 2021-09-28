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

namespace Arcade_Master
{
    public partial class LaOcaLoca : Form
    {
        string ruta = Directory.GetCurrentDirectory() + "\\casillas.txt";
        string rutadado = Directory.GetCurrentDirectory() + "\\imagenes\\Dados\\";
        int turno = 0, dados, casilla = 1, cTurnos, jTurnos;
        bool fin = false;
        int n, s, t, i = 0;
        string nom = "";
        Jugador[] j = new Jugador[4];
        int numJ;
        Casilla[] c = new Casilla[63];
        int numJugadores;
        int turnoJugador = -1;

        private void TiempoDado_Tick(object sender, EventArgs e)
        {
            Dadopic.Visible = false;
            jugar();
            ImagenDado();
            Icono();
            TiempoDado.Enabled = false;
            btnDado.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ImagenDado()
        {
            pictureDadi.Image = Image.FromFile(rutadado + Convert.ToString(dados) + ".png");
            pictureDadi.Visible = true;

        }
        private void BtnDado_Click_1(object sender, EventArgs e)
        {
            btnDado.Enabled = false;
            pictureDadi.Visible = false;
            Dadopic.Visible = true;
            TiempoDado.Enabled = true;
            if (casilla == 63)
            {
                MessageBox.Show("FELICIDADES " + j[turno].getNombre().ToUpper() + " HAS GANADO!!", "VICTORIA MAGISTRAL");
                fin = true;
            }
            turno = siguienteJugador();
            listBox1.Items.Clear();
            listBox1.Items.Add("Turno de: " + j[turno].getNombre());

        }

        

        public LaOcaLoca(string[] nombres)
        {
            numJ = nombres.Length;
            for (int i = 0; i < numJ; i++)
            {
                j[i] = new Jugador(nombres[i]);
            }
            numJugadores = nombres.Length;

            inicializarCasillas();
            InitializeComponent();
            if (numJ >= 2)
            {
                jugador1.Visible = true;
                jugador2.Visible = true;
                if (numJ >= 3)
                {
                    jugador3.Visible = true;
                    if (numJ == 4)
                    {
                        jugador4.Visible = true;
                    }
                }
            }
        }
        public void inicializarCasillas()
        {
            

            if (!File.Exists(ruta))
            {
                MessageBox.Show("Error Fatal!");
                Application.Exit();
            }
            else
            {
                using (StreamReader z = new StreamReader(ruta))
                {
                    string linea;

                    while ((linea = z.ReadLine()) != null)
                    {
                        string[] dato = new string[3];
                        dato = linea.Split(';');
                        n = Convert.ToInt32(dato[0]);
                        s = Convert.ToInt32(dato[1]);
                        t = Convert.ToInt32(dato[2]);
                        c[i] = new Casilla(n, s, t);
                        i++;
                    }
                    z.Close();
                }
            }

        }
        public void jugar()
        {
            jTurnos = j[turno].getTurno();
            if (!fin)
            {
                //if (jTurnos == 0)
                //{
                nom = j[turno].getNombre();
                dados = j[turno].tirarDados();
                casilla = j[turno].mover(dados);

                if (c[casilla - 1].getSiguiente() != casilla + 1)
                {
                    if (c[casilla - 1].getSiguiente() == 5 || c[casilla - 1].getSiguiente() == 9 || c[casilla - 1].getSiguiente() == 14 || c[casilla - 1].getSiguiente() == 18 || c[casilla - 1].getSiguiente() == 23 || c[casilla - 1].getSiguiente() == 27 || c[casilla - 1].getSiguiente() == 32 || c[casilla - 1].getSiguiente() == 36 || c[casilla - 1].getSiguiente() == 41 || c[casilla - 1].getSiguiente() == 45 || c[casilla - 1].getSiguiente() == 50 || c[casilla - 1].getSiguiente() == 54 || c[casilla - 1].getSiguiente() == 59)
                    {
                        MessageBox.Show("DE OCA A OCA Y TIRO PORQUE ME TOCA");
                    }
                    if (c[casilla - 1].getSiguiente() == 42)
                    {
                        MessageBox.Show("UPS TE PERDISTE EN EL LABERINTO!!");
                        j[turno].setCasilla(c[casilla - 1].getSiguiente());
                    }

                    if (c[casilla - 1].getSiguiente() == 6 || c[casilla - 1].getSiguiente() == 12)
                    {
                        MessageBox.Show("DE PUENTE A PUENTE Y TIRO PORQUE ME LLEVA LA CORRIENTE!");
                        j[turno].setCasilla(c[casilla - 1].getSiguiente());
                    }

                    if (c[casilla - 1].getSiguiente() == 26)
                    {
                        MessageBox.Show("DE DADOS A DADOS Y TIRO PORQUE ME HA TOCADO!");
                        j[turno].setCasilla(c[casilla - 1].getSiguiente());
                    }

                    if (c[casilla - 1].getSiguiente() == 58)
                    {
                        MessageBox.Show("UPS MAL ATERIZAJE");
                        j[turno].setCasilla(c[casilla - 1].getSiguiente());
                    }
                    else
                        j[turno].setCasilla(c[casilla - 1].getSiguiente());

                }

                listBox1.Items.Clear();
                listBox1.Items.Add("Turno de : " + nom + " - Dado: " + dados);
                //j[turno].setCasilla(casilla);
                casilla = j[turno].getCasilla();
                cTurnos = c[casilla - 1].getTurnos();
                j[turno].setTurno(cTurnos);
                if (cTurnos == 1)
                {
                    jTurnos = j[turno].getTurno();
                    j[turno].setTurno(jTurnos);
                }
                //}
                //else
                //{
                //    jTurnos = j[turno].getTurno();
                //    if (jTurnos > 1)
                //    {
                //        MessageBox.Show("Turno de " + nom + " debe esperar " + jTurnos + " turnos para tirar.");

                //    }
                //    j[turno].setTurno(jTurnos - 1);

                //}
            }
            else
            {
                MessageBox.Show("Fin del Juego!");
            }
        }
       
        public int siguienteJugador()
        {
            turnoJugador++;
            return turnoJugador % numJugadores;
        }
        public void Icono()
        {
            //Jugador1
            if (turno == 0)
            {
                if (j[turno].casilla == 1)
                    this.jugador1.Location = new Point(50, 750);
                if (j[turno].casilla == 2)
                    this.jugador1.Location = new Point(325, 745);
                if (j[turno].casilla == 3)
                    this.jugador1.Location = new Point(394, 746);
                if (j[turno].casilla == 4)
                    this.jugador1.Location = new Point(467, 746);
                if (j[turno].casilla == 5)
                    this.jugador1.Location = new Point(537, 748);
                if (j[turno].casilla == 6)
                    this.jugador1.Location = new Point(607, 746);
                if (j[turno].casilla == 7)
                    this.jugador1.Location = new Point(670, 747);
                if (j[turno].casilla == 8)
                    this.jugador1.Location = new Point(727, 754);
                if (j[turno].casilla == 9)
                    this.jugador1.Location = new Point(751, 722);
                if (j[turno].casilla == 10)
                    this.jugador1.Location = new Point(747, 668);
                if (j[turno].casilla == 11)
                    this.jugador1.Location = new Point(747, 600);
                if (j[turno].casilla == 12)
                    this.jugador1.Location = new Point(747, 529);
                if (j[turno].casilla == 13)
                    this.jugador1.Location = new Point(743, 461);
                if (j[turno].casilla == 14)
                    this.jugador1.Location = new Point(748, 390);
                if (j[turno].casilla == 15)
                    this.jugador1.Location = new Point(746, 318);
                if (j[turno].casilla == 16)
                    this.jugador1.Location = new Point(747, 257);
                if (j[turno].casilla == 17)
                    this.jugador1.Location = new Point(752, 193);
                if (j[turno].casilla == 18)
                    this.jugador1.Location = new Point(752, 154);
                if (j[turno].casilla == 19)
                    this.jugador1.Location = new Point(728, 113);
                if (j[turno].casilla == 20)
                    this.jugador1.Location = new Point(668, 128);
                if (j[turno].casilla == 21)
                    this.jugador1.Location = new Point(600, 130);
                if (j[turno].casilla == 22)
                    this.jugador1.Location = new Point(531, 129);
                if (j[turno].casilla == 23)
                    this.jugador1.Location = new Point(456, 129);
                if (j[turno].casilla == 24)
                    this.jugador1.Location = new Point(390, 130);
                if (j[turno].casilla == 25)
                    this.jugador1.Location = new Point(319, 130);
                if (j[turno].casilla == 26)
                    this.jugador1.Location = new Point(253, 131);
                if (j[turno].casilla == 27)
                    this.jugador1.Location = new Point(190, 134);
                if (j[turno].casilla == 28)
                    this.jugador1.Location = new Point(152, 121);
                if (j[turno].casilla == 29)
                    this.jugador1.Location = new Point(115, 155);
                if (j[turno].casilla == 30)
                    this.jugador1.Location = new Point(128, 214);
                if (j[turno].casilla == 31)
                    this.jugador1.Location = new Point(128, 280);
                if (j[turno].casilla == 32)
                    this.jugador1.Location = new Point(128, 349);
                if (j[turno].casilla == 33)
                    this.jugador1.Location = new Point(127, 420);
                if (j[turno].casilla == 34)
                    this.jugador1.Location = new Point(129, 484);
                if (j[turno].casilla == 35)
                    this.jugador1.Location = new Point(131, 542);
                if (j[turno].casilla == 36)
                    this.jugador1.Location = new Point(120, 588);
                if (j[turno].casilla == 37)
                    this.jugador1.Location = new Point(152, 622);
                if (j[turno].casilla == 38)
                    this.jugador1.Location = new Point(194, 611);
                if (j[turno].casilla == 39)
                    this.jugador1.Location = new Point(261, 612);
                if (j[turno].casilla == 40)
                    this.jugador1.Location = new Point(331, 611);
                if (j[turno].casilla == 41)
                    this.jugador1.Location = new Point(403, 611);
                if (j[turno].casilla == 42)
                    this.jugador1.Location = new Point(472, 611);
                if (j[turno].casilla == 43)
                    this.jugador1.Location = new Point(526, 610);
                if (j[turno].casilla == 44)
                    this.jugador1.Location = new Point(587, 622);
                if (j[turno].casilla == 45)
                    this.jugador1.Location = new Point(621, 587);
                if (j[turno].casilla == 46)
                    this.jugador1.Location = new Point(608, 544);
                if (j[turno].casilla == 47)
                    this.jugador1.Location = new Point(609, 476);
                if (j[turno].casilla == 48)
                    this.jugador1.Location = new Point(609, 413);
                if (j[turno].casilla == 49)
                    this.jugador1.Location = new Point(607, 352);
                if (j[turno].casilla == 50)
                    this.jugador1.Location = new Point(613, 293);
                if (j[turno].casilla == 51)
                    this.jugador1.Location = new Point(587, 254);
                if (j[turno].casilla == 52)
                    this.jugador1.Location = new Point(525, 268);
                if (j[turno].casilla == 53)
                    this.jugador1.Location = new Point(492, 184);
                if (j[turno].casilla == 54)
                    this.jugador1.Location = new Point(394, 266);
                if (j[turno].casilla == 55)
                    this.jugador1.Location = new Point(335, 269);
                if (j[turno].casilla == 56)
                    this.jugador1.Location = new Point(297, 265);
                if (j[turno].casilla == 57)
                    this.jugador1.Location = new Point(250, 286);
                if (j[turno].casilla == 58)
                    this.jugador1.Location = new Point(267, 349);
                if (j[turno].casilla == 59)
                    this.jugador1.Location = new Point(267, 412);
                if (j[turno].casilla == 60)
                    this.jugador1.Location = new Point(251, 455);
                if (j[turno].casilla == 61)
                    this.jugador1.Location = new Point(288, 485);
                if (j[turno].casilla == 62)
                    this.jugador1.Location = new Point(348, 475);
                if (j[turno].casilla == 63)
                    this.jugador1.Location = new Point(515, 411);
            }
            //jugador2
            if (turno == 1)
            {
                if (j[turno].casilla == 1)
                    this.jugador2.Location = new Point(120, 800);
                if (j[turno].casilla == 2)
                    this.jugador2.Location = new Point(349, 777);
                if (j[turno].casilla == 3)
                    this.jugador2.Location = new Point(416, 777);
                if (j[turno].casilla == 4)
                    this.jugador2.Location = new Point(483, 776);
                if (j[turno].casilla == 5)
                    this.jugador2.Location = new Point(556, 775);
                if (j[turno].casilla == 6)
                    this.jugador2.Location = new Point(626, 776);
                if (j[turno].casilla == 7)
                    this.jugador2.Location = new Point(690, 777);
                if (j[turno].casilla == 8)
                    this.jugador2.Location = new Point(741, 787);
                if (j[turno].casilla == 9)
                    this.jugador2.Location = new Point(787, 750);
                if (j[turno].casilla == 10)
                    this.jugador2.Location = new Point(783, 695);
                if (j[turno].casilla == 11)
                    this.jugador2.Location = new Point(783, 627);
                if (j[turno].casilla == 12)
                    this.jugador2.Location = new Point(783, 556);
                if (j[turno].casilla == 13)
                    this.jugador2.Location = new Point(779, 488);
                if (j[turno].casilla == 14)
                    this.jugador2.Location = new Point(784, 416);
                if (j[turno].casilla == 15)
                    this.jugador2.Location = new Point(782, 344);
                if (j[turno].casilla == 16)
                    this.jugador2.Location = new Point(786, 276);
                if (j[turno].casilla == 17)
                    this.jugador2.Location = new Point(788, 209);
                if (j[turno].casilla == 18)
                    this.jugador2.Location = new Point(785, 130);
                if (j[turno].casilla == 19)
                    this.jugador2.Location = new Point(760, 83);
                if (j[turno].casilla == 20)
                    this.jugador2.Location = new Point(694, 95);
                if (j[turno].casilla == 21)
                    this.jugador2.Location = new Point(626, 97);
                if (j[turno].casilla == 22)
                    this.jugador2.Location = new Point(557, 96);
                if (j[turno].casilla == 23)
                    this.jugador2.Location = new Point(456, 129);
                if (j[turno].casilla == 24)
                    this.jugador2.Location = new Point(413, 97);
                if (j[turno].casilla == 25)
                    this.jugador2.Location = new Point(342, 97);
                if (j[turno].casilla == 26)
                    this.jugador2.Location = new Point(276, 100);
                if (j[turno].casilla == 27)
                    this.jugador2.Location = new Point(213, 103);
                if (j[turno].casilla == 28)
                    this.jugador2.Location = new Point(117, 91);
                if (j[turno].casilla == 29)
                    this.jugador2.Location = new Point(86, 121);
                if (j[turno].casilla == 30)
                    this.jugador2.Location = new Point(95, 189);
                if (j[turno].casilla == 31)
                    this.jugador2.Location = new Point(95, 255);
                if (j[turno].casilla == 32)
                    this.jugador2.Location = new Point(95, 324);
                if (j[turno].casilla == 33)
                    this.jugador2.Location = new Point(96, 393);
                if (j[turno].casilla == 34)
                    this.jugador2.Location = new Point(97, 463);
                if (j[turno].casilla == 35)
                    this.jugador2.Location = new Point(99, 529);
                if (j[turno].casilla == 36)
                    this.jugador2.Location = new Point(88, 616);
                if (j[turno].casilla == 37)
                    this.jugador2.Location = new Point(126, 657);
                if (j[turno].casilla == 38)
                    this.jugador2.Location = new Point(211, 644);
                if (j[turno].casilla == 39)
                    this.jugador2.Location = new Point(278, 645);
                if (j[turno].casilla == 40)
                    this.jugador2.Location = new Point(348, 644);
                if (j[turno].casilla == 41)
                    this.jugador2.Location = new Point(420, 644);
                if (j[turno].casilla == 42)
                    this.jugador2.Location = new Point(489, 644);
                if (j[turno].casilla == 43)
                    this.jugador2.Location = new Point(551, 640);
                if (j[turno].casilla == 44)
                    this.jugador2.Location = new Point(618, 653);
                if (j[turno].casilla == 45)
                    this.jugador2.Location = new Point(647, 620);
                if (j[turno].casilla == 46)
                    this.jugador2.Location = new Point(640, 526);
                if (j[turno].casilla == 47)
                    this.jugador2.Location = new Point(641, 458);
                if (j[turno].casilla == 48)
                    this.jugador2.Location = new Point(641, 390);
                if (j[turno].casilla == 49)
                    this.jugador2.Location = new Point(639, 328);
                if (j[turno].casilla == 50)
                    this.jugador2.Location = new Point(648, 266);
                if (j[turno].casilla == 51)
                    this.jugador2.Location = new Point(615, 223);
                if (j[turno].casilla == 52)
                    this.jugador2.Location = new Point(551, 236);
                if (j[turno].casilla == 53)
                    this.jugador2.Location = new Point(461, 206);
                if (j[turno].casilla == 54)
                    this.jugador2.Location = new Point(420, 234);
                if (j[turno].casilla == 55)
                    this.jugador2.Location = new Point(355, 237);
                if (j[turno].casilla == 56)
                    this.jugador2.Location = new Point(276, 229);
                if (j[turno].casilla == 57)
                    this.jugador2.Location = new Point(217, 280);
                if (j[turno].casilla == 58)
                    this.jugador2.Location = new Point(233, 323);
                if (j[turno].casilla == 59)
                    this.jugador2.Location = new Point(267, 412);
                if (j[turno].casilla == 60)
                    this.jugador2.Location = new Point(219, 481);
                if (j[turno].casilla == 61)
                    this.jugador2.Location = new Point(265, 520);
                if (j[turno].casilla == 62)
                    this.jugador2.Location = new Point(324, 509);
                if (j[turno].casilla == 63)
                    this.jugador2.Location = new Point(436, 411);
            }
            //jugador 3
            if (turno == 2)
            {
                if (j[turno].casilla == 1)
                    this.jugador3.Location = new Point(190, 760);
                if (j[turno].casilla == 2)
                    this.jugador3.Location = new Point(324, 807);
                if (j[turno].casilla == 3)
                    this.jugador3.Location = new Point(394, 807);
                if (j[turno].casilla == 4)
                    this.jugador3.Location = new Point(463, 808);
                if (j[turno].casilla == 5)
                    this.jugador3.Location = new Point(538, 806);
                if (j[turno].casilla == 6)
                    this.jugador3.Location = new Point(608, 807);
                if (j[turno].casilla == 7)
                    this.jugador3.Location = new Point(670, 807);
                if (j[turno].casilla == 8)
                    this.jugador3.Location = new Point(759, 820);
                if (j[turno].casilla == 9)
                    this.jugador3.Location = new Point(823, 750);
                if (j[turno].casilla == 10)
                    this.jugador3.Location = new Point(819, 670);
                if (j[turno].casilla == 11)
                    this.jugador3.Location = new Point(819, 602);
                if (j[turno].casilla == 12)
                    this.jugador3.Location = new Point(819, 531);
                if (j[turno].casilla == 13)
                    this.jugador3.Location = new Point(815, 463);
                if (j[turno].casilla == 14)
                    this.jugador3.Location = new Point(820, 390);
                if (j[turno].casilla == 15)
                    this.jugador3.Location = new Point(818, 318);
                if (j[turno].casilla == 16)
                    this.jugador3.Location = new Point(818, 250);
                if (j[turno].casilla == 17)
                    this.jugador3.Location = new Point(820, 183);
                if (j[turno].casilla == 18)
                    this.jugador3.Location = new Point(812, 94);
                if (j[turno].casilla == 19)
                    this.jugador3.Location = new Point(746, 51);
                if (j[turno].casilla == 20)
                    this.jugador3.Location = new Point(670, 65);
                if (j[turno].casilla == 21)
                    this.jugador3.Location = new Point(602, 67);
                if (j[turno].casilla == 22)
                    this.jugador3.Location = new Point(533, 66);
                if (j[turno].casilla == 23)
                    this.jugador3.Location = new Point(458, 66);
                if (j[turno].casilla == 24)
                    this.jugador3.Location = new Point(389, 67);
                if (j[turno].casilla == 25)
                    this.jugador3.Location = new Point(318, 67);
                if (j[turno].casilla == 26)
                    this.jugador3.Location = new Point(246, 70);
                if (j[turno].casilla == 27)
                    this.jugador3.Location = new Point(182, 74);
                if (j[turno].casilla == 28)
                    this.jugador3.Location = new Point(137, 55);
                if (j[turno].casilla == 29)
                    this.jugador3.Location = new Point(47, 140);
                if (j[turno].casilla == 30)
                    this.jugador3.Location = new Point(63, 214);
                if (j[turno].casilla == 31)
                    this.jugador3.Location = new Point(63, 280);
                if (j[turno].casilla == 32)
                    this.jugador3.Location = new Point(64, 350);
                if (j[turno].casilla == 33)
                    this.jugador3.Location = new Point(66, 426);
                if (j[turno].casilla == 34)
                    this.jugador3.Location = new Point(69, 494);
                if (j[turno].casilla == 35)
                    this.jugador3.Location = new Point(70, 557);
                if (j[turno].casilla == 36)
                    this.jugador3.Location = new Point(52, 600);
                if (j[turno].casilla == 37)
                    this.jugador3.Location = new Point(94, 685);
                if (j[turno].casilla == 38)
                    this.jugador3.Location = new Point(181, 666);
                if (j[turno].casilla == 39)
                    this.jugador3.Location = new Point(248, 667);
                if (j[turno].casilla == 40)
                    this.jugador3.Location = new Point(318, 666);
                if (j[turno].casilla == 41)
                    this.jugador3.Location = new Point(390, 666);
                if (j[turno].casilla == 42)
                    this.jugador3.Location = new Point(459, 666);
                if (j[turno].casilla == 43)
                    this.jugador3.Location = new Point(529, 671);
                if (j[turno].casilla == 44)
                    this.jugador3.Location = new Point(606, 688);
                if (j[turno].casilla == 45)
                    this.jugador3.Location = new Point(685, 605);
                if (j[turno].casilla == 46)
                    this.jugador3.Location = new Point(663, 559);
                if (j[turno].casilla == 47)
                    this.jugador3.Location = new Point(664, 491);
                if (j[turno].casilla == 48)
                    this.jugador3.Location = new Point(664, 423);
                if (j[turno].casilla == 49)
                    this.jugador3.Location = new Point(668, 354);
                if (j[turno].casilla == 50)
                    this.jugador3.Location = new Point(689, 272);
                if (j[turno].casilla == 51)
                    this.jugador3.Location = new Point(609, 188);
                if (j[turno].casilla == 52)
                    this.jugador3.Location = new Point(527, 206);
                if (j[turno].casilla == 53)
                    this.jugador3.Location = new Point(485, 236);
                if (j[turno].casilla == 54)
                    this.jugador3.Location = new Point(388, 210);
                if (j[turno].casilla == 55)
                    this.jugador3.Location = new Point(325, 220);
                if (j[turno].casilla == 56)
                    this.jugador3.Location = new Point(242, 205);
                if (j[turno].casilla == 57)
                    this.jugador3.Location = new Point(181, 269);
                if (j[turno].casilla == 58)
                    this.jugador3.Location = new Point(204, 353);
                if (j[turno].casilla == 59)
                    this.jugador3.Location = new Point(206, 423);
                if (j[turno].casilla == 60)
                    this.jugador3.Location = new Point(190, 517);
                if (j[turno].casilla == 61)
                    this.jugador3.Location = new Point(223, 551);
                if (j[turno].casilla == 62)
                    this.jugador3.Location = new Point(347, 539);
                if (j[turno].casilla == 63)
                    this.jugador3.Location = new Point(515, 499);
            }
            //jugador4
            if (turno == 3)
            {
                if (j[turno].casilla == 1)
                    this.jugador4.Location = new Point(260, 800);
                if (j[turno].casilla == 2)
                    this.jugador4.Location = new Point(346, 836);
                if (j[turno].casilla == 3)
                    this.jugador4.Location = new Point(416, 835);
                if (j[turno].casilla == 4)
                    this.jugador4.Location = new Point(485, 837);
                if (j[turno].casilla == 5)
                    this.jugador4.Location = new Point(554, 837);
                if (j[turno].casilla == 6)
                    this.jugador4.Location = new Point(627, 837);
                if (j[turno].casilla == 7)
                    this.jugador4.Location = new Point(690, 837);
                if (j[turno].casilla == 8)
                    this.jugador4.Location = new Point(795, 836);
                if (j[turno].casilla == 9)
                    this.jugador4.Location = new Point(823, 786);
                if (j[turno].casilla == 10)
                    this.jugador4.Location = new Point(838, 705);
                if (j[turno].casilla == 11)
                    this.jugador4.Location = new Point(836, 636);
                if (j[turno].casilla == 12)
                    this.jugador4.Location = new Point(836, 565);
                if (j[turno].casilla == 13)
                    this.jugador4.Location = new Point(5832, 497);
                if (j[turno].casilla == 14)
                    this.jugador4.Location = new Point(837, 425);
                if (j[turno].casilla == 15)
                    this.jugador4.Location = new Point(835, 353);
                if (j[turno].casilla == 16)
                    this.jugador4.Location = new Point(836, 282);
                if (j[turno].casilla == 17)
                    this.jugador4.Location = new Point(838, 215);
                if (j[turno].casilla == 18)
                    this.jugador4.Location = new Point(836, 130);
                if (j[turno].casilla == 19)
                    this.jugador4.Location = new Point(788, 51);
                if (j[turno].casilla == 20)
                    this.jugador4.Location = new Point(702, 46);
                if (j[turno].casilla == 21)
                    this.jugador4.Location = new Point(634, 48);
                if (j[turno].casilla == 22)
                    this.jugador4.Location = new Point(565, 47);
                if (j[turno].casilla == 23)
                    this.jugador4.Location = new Point(490, 47);
                if (j[turno].casilla == 24)
                    this.jugador4.Location = new Point(419, 48);
                if (j[turno].casilla == 25)
                    this.jugador4.Location = new Point(348, 48);
                if (j[turno].casilla == 26)
                    this.jugador4.Location = new Point(278, 49);
                if (j[turno].casilla == 27)
                    this.jugador4.Location = new Point(213, 52);
                if (j[turno].casilla == 28)
                    this.jugador4.Location = new Point(91, 54);
                if (j[turno].casilla == 29)
                    this.jugador4.Location = new Point(46, 92);
                if (j[turno].casilla == 30)
                    this.jugador4.Location = new Point(41, 183);
                if (j[turno].casilla == 31)
                    this.jugador4.Location = new Point(41, 249);
                if (j[turno].casilla == 32)
                    this.jugador4.Location = new Point(41, 318);
                if (j[turno].casilla == 33)
                    this.jugador4.Location = new Point(43, 393);
                if (j[turno].casilla == 34)
                    this.jugador4.Location = new Point(43, 465);
                if (j[turno].casilla == 35)
                    this.jugador4.Location = new Point(41, 535);
                if (j[turno].casilla == 36)
                    this.jugador4.Location = new Point(47, 645);
                if (j[turno].casilla == 37)
                    this.jugador4.Location = new Point(130, 697);
                if (j[turno].casilla == 38)
                    this.jugador4.Location = new Point(204, 696);
                if (j[turno].casilla == 39)
                    this.jugador4.Location = new Point(271, 697);
                if (j[turno].casilla == 40)
                    this.jugador4.Location = new Point(341, 696);
                if (j[turno].casilla == 41)
                    this.jugador4.Location = new Point(413, 696);
                if (j[turno].casilla == 42)
                    this.jugador4.Location = new Point(482, 696);
                if (j[turno].casilla == 43)
                    this.jugador4.Location = new Point(559, 698);
                if (j[turno].casilla == 44)
                    this.jugador4.Location = new Point(642, 694);
                if (j[turno].casilla == 45)
                    this.jugador4.Location = new Point(685, 650);
                if (j[turno].casilla == 46)
                    this.jugador4.Location = new Point(691, 531);
                if (j[turno].casilla == 47)
                    this.jugador4.Location = new Point(692, 463);
                if (j[turno].casilla == 48)
                    this.jugador4.Location = new Point(692, 395);
                if (j[turno].casilla == 49)
                    this.jugador4.Location = new Point(692, 322);
                if (j[turno].casilla == 50)
                    this.jugador4.Location = new Point(687, 230);
                if (j[turno].casilla == 51)
                    this.jugador4.Location = new Point(650, 188);
                if (j[turno].casilla == 52)
                    this.jugador4.Location = new Point(558, 184);
                if (j[turno].casilla == 53)
                    this.jugador4.Location = new Point(459, 268);
                if (j[turno].casilla == 54)
                    this.jugador4.Location = new Point(418, 185);
                if (j[turno].casilla == 55)
                    this.jugador4.Location = new Point(346, 188);
                if (j[turno].casilla == 56)
                    this.jugador4.Location = new Point(275, 189);
                if (j[turno].casilla == 57)
                    this.jugador4.Location = new Point(190, 224);
                if (j[turno].casilla == 58)
                    this.jugador4.Location = new Point(183, 321);
                if (j[turno].casilla == 59)
                    this.jugador4.Location = new Point(181, 393);
                if (j[turno].casilla == 60)
                    this.jugador4.Location = new Point(182, 470);
                if (j[turno].casilla == 61)
                    this.jugador4.Location = new Point(260, 558);
                if (j[turno].casilla == 62)
                    this.jugador4.Location = new Point(315, 557);
                if (j[turno].casilla == 63)
                    this.jugador4.Location = new Point(436, 508);
            }
        }
    }
}
