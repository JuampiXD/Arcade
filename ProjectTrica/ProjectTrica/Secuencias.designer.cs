namespace ProjectTrica
{
    partial class Secuencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secuencias));
            this.Juego = new System.Windows.Forms.Timer(this.components);
            this.Juego2 = new System.Windows.Forms.Timer(this.components);
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Mal = new System.Windows.Forms.Timer(this.components);
            this.pnCategoria = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnFiguras = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.picCategoria = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.picMal = new System.Windows.Forms.PictureBox();
            this.picBien = new System.Windows.Forms.PictureBox();
            this.picExcelente = new System.Windows.Forms.PictureBox();
            this.MostrarSeleccion = new System.Windows.Forms.Timer(this.components);
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.PictureBox();
            this.btnVolverAlMenu = new System.Windows.Forms.Button();
            this.pnCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcelente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button4)).BeginInit();
            this.SuspendLayout();
            // 
            // Juego
            // 
            this.Juego.Interval = 2000;
            this.Juego.Tick += new System.EventHandler(this.Juego_Tick);
            // 
            // Juego2
            // 
            this.Juego2.Interval = 1700;
            this.Juego2.Tick += new System.EventHandler(this.Juego2_Tick);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Black;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(925, 472);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(223, 84);
            this.btnReiniciar.TabIndex = 31;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click_1);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Black;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(925, 472);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(223, 84);
            this.btnIniciar.TabIndex = 26;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(988, 42);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 60);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Mal
            // 
            this.Mal.Interval = 5000;
            this.Mal.Tick += new System.EventHandler(this.Mal_Tick);
            // 
            // pnCategoria
            // 
            this.pnCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCategoria.BackgroundImage")));
            this.pnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCategoria.Controls.Add(this.btnVolverAlMenu);
            this.pnCategoria.Controls.Add(this.label1);
            this.pnCategoria.Controls.Add(this.btnColores);
            this.pnCategoria.Controls.Add(this.btnFiguras);
            this.pnCategoria.Controls.Add(this.btnAnimales);
            this.pnCategoria.Controls.Add(this.picCategoria);
            this.pnCategoria.Location = new System.Drawing.Point(12, 124);
            this.pnCategoria.Name = "pnCategoria";
            this.pnCategoria.Size = new System.Drawing.Size(1126, 91);
            this.pnCategoria.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(202, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 155);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATEGORIA";
            // 
            // btnColores
            // 
            this.btnColores.BackColor = System.Drawing.Color.Black;
            this.btnColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColores.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnColores.Location = new System.Drawing.Point(695, 388);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(241, 93);
            this.btnColores.TabIndex = 2;
            this.btnColores.Text = "COLORES";
            this.btnColores.UseVisualStyleBackColor = false;
            this.btnColores.Click += new System.EventHandler(this.BtnColores_Click_1);
            // 
            // btnFiguras
            // 
            this.btnFiguras.BackColor = System.Drawing.Color.Black;
            this.btnFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiguras.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnFiguras.Location = new System.Drawing.Point(448, 388);
            this.btnFiguras.Name = "btnFiguras";
            this.btnFiguras.Size = new System.Drawing.Size(241, 93);
            this.btnFiguras.TabIndex = 1;
            this.btnFiguras.Text = "FIGURAS";
            this.btnFiguras.UseVisualStyleBackColor = false;
            this.btnFiguras.Click += new System.EventHandler(this.BtnFiguras_Click_1);
            // 
            // btnAnimales
            // 
            this.btnAnimales.BackColor = System.Drawing.Color.Black;
            this.btnAnimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimales.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAnimales.Location = new System.Drawing.Point(201, 388);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(241, 93);
            this.btnAnimales.TabIndex = 0;
            this.btnAnimales.Text = "ANIMALES";
            this.btnAnimales.UseVisualStyleBackColor = false;
            this.btnAnimales.Click += new System.EventHandler(this.BtnAnimales_Click_1);
            // 
            // picCategoria
            // 
            this.picCategoria.Image = ((System.Drawing.Image)(resources.GetObject("picCategoria.Image")));
            this.picCategoria.Location = new System.Drawing.Point(19, 3);
            this.picCategoria.Name = "picCategoria";
            this.picCategoria.Size = new System.Drawing.Size(14, 12);
            this.picCategoria.TabIndex = 5;
            this.picCategoria.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox.Location = new System.Drawing.Point(634, 91);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(300, 256);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 25;
            this.picBox.TabStop = false;
            // 
            // picMal
            // 
            this.picMal.BackColor = System.Drawing.Color.Transparent;
            this.picMal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMal.Image = ((System.Drawing.Image)(resources.GetObject("picMal.Image")));
            this.picMal.Location = new System.Drawing.Point(661, 353);
            this.picMal.Name = "picMal";
            this.picMal.Size = new System.Drawing.Size(230, 221);
            this.picMal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMal.TabIndex = 34;
            this.picMal.TabStop = false;
            this.picMal.Visible = false;
            // 
            // picBien
            // 
            this.picBien.BackColor = System.Drawing.Color.Transparent;
            this.picBien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBien.Image = ((System.Drawing.Image)(resources.GetObject("picBien.Image")));
            this.picBien.Location = new System.Drawing.Point(243, 262);
            this.picBien.Name = "picBien";
            this.picBien.Size = new System.Drawing.Size(150, 150);
            this.picBien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBien.TabIndex = 33;
            this.picBien.TabStop = false;
            this.picBien.Visible = false;
            // 
            // picExcelente
            // 
            this.picExcelente.BackColor = System.Drawing.Color.Transparent;
            this.picExcelente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExcelente.Image = ((System.Drawing.Image)(resources.GetObject("picExcelente.Image")));
            this.picExcelente.Location = new System.Drawing.Point(661, 353);
            this.picExcelente.Name = "picExcelente";
            this.picExcelente.Size = new System.Drawing.Size(230, 221);
            this.picExcelente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExcelente.TabIndex = 37;
            this.picExcelente.TabStop = false;
            this.picExcelente.Visible = false;
            // 
            // MostrarSeleccion
            // 
            this.MostrarSeleccion.Interval = 800;
            this.MostrarSeleccion.Tick += new System.EventHandler(this.MostrarSeleccion_Tick);
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(37, 401);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(51, 76);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFondo.TabIndex = 38;
            this.picFondo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(832, 103);
            this.label3.TabIndex = 40;
            this.label3.Text = "REPITE LA SECUENCIA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button1.Location = new System.Drawing.Point(244, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button1.TabIndex = 41;
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button2.Location = new System.Drawing.Point(94, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button2.TabIndex = 42;
            this.button2.TabStop = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button3.Location = new System.Drawing.Point(392, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button3.TabIndex = 43;
            this.button3.TabStop = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button4.Location = new System.Drawing.Point(243, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 150);
            this.button4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button4.TabIndex = 44;
            this.button4.TabStop = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnVolverAlMenu
            // 
            this.btnVolverAlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverAlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolverAlMenu.BackgroundImage")));
            this.btnVolverAlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolverAlMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverAlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverAlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAlMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverAlMenu.Location = new System.Drawing.Point(1048, 34);
            this.btnVolverAlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverAlMenu.Name = "btnVolverAlMenu";
            this.btnVolverAlMenu.Size = new System.Drawing.Size(55, 55);
            this.btnVolverAlMenu.TabIndex = 63;
            this.btnVolverAlMenu.UseVisualStyleBackColor = false;
            this.btnVolverAlMenu.Click += new System.EventHandler(this.BtnVolverAlMenu_Click);
            // 
            // Secuencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1150, 610);
            this.Controls.Add(this.pnCategoria);
            this.Controls.Add(this.picMal);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.picExcelente);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.picBien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Secuencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secuencias";
            this.pnCategoria.ResumeLayout(false);
            this.pnCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcelente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnFiguras;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Timer Juego;
        private System.Windows.Forms.Timer Juego2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Timer Mal;
        private System.Windows.Forms.PictureBox picBien;
        private System.Windows.Forms.PictureBox picMal;
        private System.Windows.Forms.PictureBox picCategoria;
        private System.Windows.Forms.PictureBox picExcelente;
        private System.Windows.Forms.Timer MostrarSeleccion;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox button1;
        private System.Windows.Forms.PictureBox button2;
        private System.Windows.Forms.PictureBox button3;
        private System.Windows.Forms.PictureBox button4;
        private System.Windows.Forms.Button btnVolverAlMenu;
    }
}