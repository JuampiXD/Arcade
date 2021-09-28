using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTrica
{
    public partial class AdivinaLaImagen : Form
    {
        Musica dj = new Musica();
        public AdivinaLaImagen()
        {
            InitializeComponent();

            dj.direccion("Adivinanzas.wav");
            dj.Reproductor();
            PCategoria.Location = new Point(0,0);
            PCategoria.Size = new Size(830, 650);
            PAdivina.Location = new Point(0, 0);
            PAdivina.Size = new Size(830, 650);
            pbxfondoCat.Location = new Point(0, 0);
            pbxfondoCat.Size = new Size(830,650);
            pbxfondoCat.Image = Image.FromFile("Imagenes\\Adivinanzas//gif//FondoCat.gif");
        }
        PalabrasDic PD = new PalabrasDic();
        string Categoria, Palabra;
        string[] palabraU;
        int aux = 0, i = 0, oportunidades = 5;
        int n, x = 1;
        int TamañoL = 0;
        #region Botones
        //Teclado Virtual
        private void BtnQ_Click(object sender, EventArgs e)
        {
            Comparar("Q");
        }
        private void BtnW_Click(object sender, EventArgs e)
        {
            Comparar("W");
        }
        private void BtnE_Click(object sender, EventArgs e)
        {
            Comparar("E");
        }
        private void BtnR_Click(object sender, EventArgs e)
        {
            Comparar("R");
        }
        private void BtnT_Click(object sender, EventArgs e)
        {
            Comparar("T");
        }
        private void BtnY_Click(object sender, EventArgs e)
        {
            Comparar("Y");
        }
        private void BtnU_Click(object sender, EventArgs e)
        {
            Comparar("U");
        }
        private void BtnI_Click(object sender, EventArgs e)
        {
            Comparar("I");
        }
        private void BtnO_Click(object sender, EventArgs e)
        {
            Comparar("O");
        }
        private void BtnP_Click(object sender, EventArgs e)
        {
            Comparar("P");
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            Comparar("A");
        }
        private void BtnS_Click(object sender, EventArgs e)
        {
            Comparar("S");
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            Comparar("D");
        }
        private void BtnF_Click(object sender, EventArgs e)
        {
            Comparar("F");
        }
        private void BtnG_Click(object sender, EventArgs e)
        {
            Comparar("G");
        }
        private void BtnH_Click(object sender, EventArgs e)
        {
            Comparar("H");
        }
        private void BtnJ_Click(object sender, EventArgs e)
        {
            Comparar("J");
        }
        private void BtnK_Click(object sender, EventArgs e)
        {
            Comparar("K");
        }
        private void BtnL_Click(object sender, EventArgs e)
        {
            Comparar("L");
        }
        private void BtnÑ_Click(object sender, EventArgs e)
        {
            Comparar("Ñ");
        }
        private void BtnZ_Click(object sender, EventArgs e)
        {
            Comparar("Z");
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            Comparar("X");
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            Comparar("C");
        }
        private void BtnV_Click(object sender, EventArgs e)
        {
            Comparar("V");
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            Comparar("B");
        }
        private void BtnN_Click(object sender, EventArgs e)
        {
            Comparar("N");
        }
        private void BtnM_Click(object sender, EventArgs e)
        {
            Comparar("M");
        }
        #endregion 
        //Comparar
        public void Comparar(string letra)
        {
            Ltitulo.Focus();
            try
            {
                if (i == 0)
                {
                    n = Palabra.Length;
                    palabraU = new string[n];
                }
                palabraU[i] = letra;
                i++;
                Mostrar(letra);
                if (i == n)
                {
                    string Pfinal = "";
                    for (int i = 0; i < palabraU.Length; i++)
                    {
                        Pfinal = Pfinal + palabraU[i];
                    }
                    if (Pfinal == Palabra)
                    {
                        if (x < TamañoL - 1)
                        {
                            PFelicidades.Visible = true;
                            panelTeclado.Enabled = false;
                            btnPalabraN.Enabled = false;
                            btnEliminar.Enabled = false;
                            panelLabel.Enabled = false;
                            Lpanel.Visible = true;
                            Lpanel.Text = "CORRECTO SIGUE ASI";
                            PD.Acabar();
                            Siguiente();
                            reiniciar();
                            x++;
                        }
                        else
                        {
                            PFelicidades.Visible = true;
                            panelTeclado.Enabled = false;
                            btnPalabraN.Enabled = false;
                            btnEliminar.Enabled = false;
                            panelLabel.Enabled = false;
                            Lpanel.Visible = true;
                            Lpanel.Text = "FELICIDADES ENCONTRASTE";
                            L2panel.Visible = true;
                            L2panel.Text = "TODAS LAS PALABRAS";
                            btnVolver.Location = new Point(340, 590);
                            btnRetry.Visible = true;
                            Termina();
                        }                                             
                    }
                    else
                    {
                        oportunidades = oportunidades -1;
                        PFelicidades.Visible = true;
                        panelTeclado.Enabled = false;
                        btnPalabraN.Enabled = false;
                        btnEliminar.Enabled = false;
                        panelLabel.Enabled = false;
                        Lpanel.Visible = true;
                        Lpanel.Text = "VUELVE A INTENTARLO";
                        L2panel.Visible = true;
                        L2panel.Text = "TE QUEDAN "+ oportunidades + " OPORTUNIDADES";
                        if(oportunidades == 0)
                        {
                            MessageBox.Show("El " + Categoria + " es: " + Palabra);
                            btnVolver.Location = new Point(340, 590);
                            btnRetry.Visible = true;
                            Termina();
                            LCat.Visible = false;
                        }
                        reiniciar();
                    }
                }
            }
            catch
            {
                i = 0;
            }
        }
        //Panel de Felicidades
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            panelTeclado.Enabled = true;
            btnPalabraN.Enabled = true;
            btnEliminar.Enabled = true;
            panelLabel.Enabled = true;
            PFelicidades.Visible = false;
            Lpanel.Visible = false;
            L2panel.Visible = false;
        }
        //Comenzar de nuevo
        public void IniciarAgain()
        {
            n = 0; aux = 0; x = 0; n = 0; oportunidades = 5;
            PD.LD.Anula();
            panelTeclado.Enabled = true;
            btnPalabraN.Enabled = true;
            btnEliminar.Enabled = true;
            panelLabel.Enabled = true;
        }
        //Boton para volver a jugar
        private void BtnRetry_Click(object sender, EventArgs e)
        {
            n = 0; aux = 0; x = 0; n = 0; oportunidades = 5;
            panelTeclado.Enabled = true;
            btnPalabraN.Enabled = true;
            btnEliminar.Enabled = true;
            panelLabel.Enabled = true;
            PD.inicializar();
            Siguiente();
            reiniciar();
            TamañoL = PD.Tamaño();
        }
        //Terminar el Juego
        public void Termina()
        {
            oportunidades = 0;
            panelTeclado.Enabled = false;
            btnPalabraN.Enabled = false;
            btnEliminar.Enabled = false;
            panelLabel.Enabled = false;
        }
        //Borrar una letra
        public void BorrarLetra()
        {
            if (i > 0 && aux > 0) 
            {
                aux -= 1;
                i -= 1;
                Mostrar("___");
                aux -= 1;
            }
            else
            {
                aux = 0;
                i = 0;
            }       
        }
        //Mostrar
        public void Mostrar(string letra)
        {
            switch (aux)
            {
                case 0:
                    L1.Text = letra;
                    break;
                case 1:
                    L2.Text = letra;
                    break;
                case 2:
                    L3.Text = letra;
                    break;
                case 3:
                    L4.Text = letra;
                    break;
                case 4:
                    L5.Text = letra;
                    break;
                case 5:
                    L6.Text = letra;
                    break;
                case 6:
                    L7.Text = letra;
                    break;
                case 7:
                    L8.Text = letra;
                    break;
                case 8:
                    L9.Text = letra;
                    break;
                case 9:
                    L10.Text = letra;
                    break;
                case 10:
                    L11.Text = letra;
                    break;
                case 11:
                    L12.Text = letra;
                    break;
                case 12:
                    L13.Text = letra;
                    break;
                case 13:
                    L14.Text = letra;
                    break;
                case 15:
                    L16.Text = letra;
                    break;
                case 16:
                    L17.Text = letra;
                    break;
                case 17:
                    L18.Text = letra;
                    break;
                case 18:
                    L19.Text = letra;
                    break;
                case 19:
                    L20.Text = letra;
                    break;
                case 20:
                    L21.Text = letra;
                    break;
            }
            aux += 1;
        }
        //Reiniciar Juego
        public void reiniciar()
        {           
            palabraU = null;
            i = 0;
            aux = 0;
            Imagen();
            guionesLi();
            guiones(Palabra.Length);
        }
        //Siguiente
        public void Siguiente()
        {
            Palabra = PD.getPalabra();
        }
        //Categorias
        private void BtnColores_Click(object sender, EventArgs e)
        {
            IniciarAgain();
            Categoria = "Color";
            BotonesCategoria(Categoria);
        }
        private void BtnAnimales_Click(object sender, EventArgs e)
        {
            IniciarAgain();
            Categoria = "Animal";
            BotonesCategoria(Categoria);
        }
        private void BtnVerbos_Click(object sender, EventArgs e)
        {
            IniciarAgain();
            Categoria = "Vehiculo";
            BotonesCategoria(Categoria);
        }
        //Auxiliar de Las Categorias
        public void BotonesCategoria(string Categoria)
        {
            PCategoria.Visible = false;
            btnRetry.Visible = false;
            PAdivina.Visible = true;
            LCat.Visible = true;
            btnVolver.Location = new Point(560, 10);
            Ltitulo.Text = "Adivina el " + Categoria;           
            LCat.Text = "El " + Categoria + " es:";
            PD.Ruta(Categoria);
            PD.inicializar();
            Palabra = PD.getPalabra();  //Palabra Almacena Lo que se tiene que adivinar
            guionesLi();
            guiones(Palabra.Length);
            TamañoL = PD.Tamaño();
            Imagen();
            pbxfondo.Location = new Point(0, 0);
            pbxfondo.Size = new Size(830,650);
            pbxfondo.Image = Image.FromFile("Imagenes\\Adivinanzas//gif//fondo.gif");
        }
        //Volver
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Ltitulo.Focus();
            IniciarAgain();
            reiniciar();
            PCategoria.Visible = true;
            PAdivina.Visible = false;
            PFelicidades.Visible = false;
        }
        //Palabra Nueva
        private void BtnPalabraN_Click(object sender, EventArgs e)
        {
            Ltitulo.Focus();
            Siguiente();
            reiniciar();
        }
        //Cargar Imagenes
        public void Imagen()
        {
            if (Categoria.Equals("Color"))
            {
                pbx1.Visible = true;
                pbx2.Visible = true;
                pbx3.Visible = false;
                pbx1.Image = Image.FromFile("Imagenes\\Adivinanzas//Imagenes//Color//" + Palabra + ".png");
                pbx2.Image = Image.FromFile("Imagenes\\Adivinanzas//Imagenes//Color//" + Palabra + "1.png");
            }
            if (Categoria.Equals("Animal"))
            {
                pbx1.Visible = false;
                pbx2.Visible = false;
                pbx3.Visible = true;
                pbx3.Image = Image.FromFile("Imagenes\\Adivinanzas//Imagenes//Animal//" + Palabra + ".png");
            }
            if (Categoria.Equals("Vehiculo"))
            {
                pbx1.Visible = true;
                pbx2.Visible = true;
                pbx3.Visible = false;
                pbx1.Image = Image.FromFile("Imagenes\\Adivinanzas//Imagenes//Vehiculo//" + Palabra + ".png");
                pbx2.Image = Image.FromFile("Imagenes\\Adivinanzas//Imagenes//Vehiculo//" + Palabra + "1.png");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(true);
            menu.Show();
            Close();
        }
        //Guiones
        public void guionesLi()
        {
            L1.Text = "___";
            L2.Text = "___";
            L3.Text = "___";
            L4.Text = "___";
            L5.Text = "___";
            L6.Text = "___";
            L7.Text = "___";
            L8.Text = "___";
            L9.Text = "___";
            L10.Text = "___";
            L11.Text = "___";
            L12.Text = "___";
            L13.Text = "___";
            L14.Text = "___";
            L15.Text = "___";
            L16.Text = "___";
            L17.Text = "___";
            L18.Text = "___";
            L19.Text = "___";
            L20.Text = "___";
            L21.Text = "___";
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;
            L11.Visible = false;
            L12.Visible = false;
            L13.Visible = false;
            L14.Visible = false;
            L15.Visible = false;
            L16.Visible = false;
            L17.Visible = false;
            L18.Visible = false;
            L19.Visible = false;
            L20.Visible = false;
            L21.Visible = false;
        }
        //Borra Letra
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Ltitulo.Focus();
            BorrarLetra();
        }
        //Tamaño de la palabra mostrada en los labels
        public void guiones(int x)
        {
            if (x >= 3)
            {
                L1.Visible = true;
                L2.Visible = true;
                L3.Visible = true;
                if (x >= 4)
                {
                    L4.Visible = true;
                    if (x >= 5)
                    {
                        L5.Visible = true;
                        if (x >= 6)
                        {
                            L6.Visible = true;
                            if (x >= 7)
                            {
                                L7.Visible = true;
                                if (x >= 8)
                                {
                                    L8.Visible = true;
                                    if (x >= 9)
                                    {
                                        L9.Visible = true;
                                        if (x >= 10)
                                        {
                                            L10.Visible = true;
                                            if (x >= 11)
                                            {
                                                L11.Visible = true;
                                                if (x >= 12)
                                                {
                                                    L12.Visible = true;
                                                    if (x >= 13)
                                                    {
                                                        L13.Visible = true;
                                                        if (x >= 14)
                                                        {
                                                            L14.Visible = true;
                                                            if (x >= 15)
                                                            {
                                                                L15.Visible = true;
                                                                if (x >= 16)
                                                                {
                                                                    L16.Visible = true;
                                                                    if (x >= 17)
                                                                    {
                                                                        L17.Visible = true;
                                                                        if (x >= 18)
                                                                        {
                                                                            L18.Visible = true;
                                                                            if (x >= 19)
                                                                            {
                                                                                L19.Visible = true;
                                                                                if (x >= 20)
                                                                                {
                                                                                    L20.Visible = true;
                                                                                    if (x >= 21)
                                                                                    {
                                                                                        L21.Visible = true;
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
                        }
                    }
                }
            }
        }
        //Teclado Acceso
        private void AdivinaLaImagen_KeyDown(object sender, KeyEventArgs e)
        {
            if (PFelicidades.Visible.Equals(false))
            {
                if (oportunidades != 0)
                {
                    if (PAdivina.Visible.Equals(true))
                    {
                        if (e.KeyData == Keys.A)
                        {
                            Comparar("A");
                            return;
                        }
                        if (e.KeyData == Keys.B)
                        {
                            Comparar("B");
                            return;
                        }
                        if (e.KeyData == Keys.C)
                        {
                            Comparar("C");
                            return;
                        }
                        if (e.KeyData == Keys.D)
                        {
                            Comparar("D");
                            return;
                        }
                        if (e.KeyData == Keys.E)
                        {
                            Comparar("E");
                            return;
                        }
                        if (e.KeyData == Keys.F)
                        {
                            Comparar("F");
                            return;
                        }
                        if (e.KeyData == Keys.G)
                        {
                            Comparar("G");
                            return;
                        }
                        if (e.KeyData == Keys.H)
                        {
                            Comparar("H");
                            return;
                        }
                        if (e.KeyData == Keys.I)
                        {
                            Comparar("I");
                            return;
                        }
                        if (e.KeyData == Keys.J)
                        {
                            Comparar("J");
                            return;
                        }
                        if (e.KeyData == Keys.K)
                        {
                            Comparar("K");
                            return;
                        }
                        if (e.KeyData == Keys.L)
                        {
                            Comparar("L");
                            return;
                        }
                        if (e.KeyData == Keys.M)
                        {
                            Comparar("M");
                            return;
                        }
                        if (e.KeyData == Keys.N)
                        {
                            Comparar("N");
                            return;
                        }
                        if (e.KeyData == Keys.F1)
                        {
                            Comparar("Ñ");
                            return;
                        }
                        if (e.KeyData == Keys.O)
                        {
                            Comparar("O");
                            return;
                        }
                        if (e.KeyData == Keys.P)
                        {
                            Comparar("P");
                            return;
                        }
                        if (e.KeyData == Keys.Q)
                        {
                            Comparar("Q");
                            return;
                        }
                        if (e.KeyData == Keys.R)
                        {
                            Comparar("R");
                            return;
                        }
                        if (e.KeyData == Keys.S)
                        {
                            Comparar("S");
                            return;
                        }
                        if (e.KeyData == Keys.T)
                        {
                            Comparar("T");
                            return;
                        }
                        if (e.KeyData == Keys.U)
                        {
                            Comparar("U");
                            return;
                        }
                        if (e.KeyData == Keys.V)
                        {
                            Comparar("V");
                            return;
                        }
                        if (e.KeyData == Keys.W)
                        {
                            Comparar("W");
                            return;
                        }
                        if (e.KeyData == Keys.X)
                        {
                            Comparar("X");
                            return;
                        }
                        if (e.KeyData == Keys.Y)
                        {
                            Comparar("Y");
                            return;
                        }
                        if (e.KeyData == Keys.Z)
                        {
                            Comparar("Z");
                            return;
                        }
                        if (e.KeyData == Keys.Back)
                        {
                            BorrarLetra();
                            return;
                        }
                    }
                }
            }      
        }
    }
}
