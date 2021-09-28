namespace Arcade_Master
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.pnlJuegos = new System.Windows.Forms.Panel();
            this.btnSerpientesEscaleras = new System.Windows.Forms.Button();
            this.btnBuscarPares = new System.Windows.Forms.Button();
            this.btnOca = new System.Windows.Forms.Button();
            this.btnTresEnRaya = new System.Windows.Forms.Button();
            this.btnAhorcado = new System.Windows.Forms.Button();
            this.btnRompecabezas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrLogo = new System.Windows.Forms.Timer(this.components);
            this.pbJugar = new System.Windows.Forms.PictureBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.pbCreditos = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pnlSalir = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.pnlJuegos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.pnlSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTitulo
            // 
            this.pbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pbTitulo.Image")));
            this.pbTitulo.Location = new System.Drawing.Point(0, -1);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(801, 598);
            this.pbTitulo.TabIndex = 14;
            this.pbTitulo.TabStop = false;
            this.pbTitulo.Click += new System.EventHandler(this.PbTitulo_Click);
            // 
            // pnlJuegos
            // 
            this.pnlJuegos.BackColor = System.Drawing.Color.Transparent;
            this.pnlJuegos.Controls.Add(this.btnSerpientesEscaleras);
            this.pnlJuegos.Controls.Add(this.btnBuscarPares);
            this.pnlJuegos.Controls.Add(this.btnOca);
            this.pnlJuegos.Controls.Add(this.btnTresEnRaya);
            this.pnlJuegos.Controls.Add(this.btnAhorcado);
            this.pnlJuegos.Controls.Add(this.btnRompecabezas);
            this.pnlJuegos.Controls.Add(this.label1);
            this.pnlJuegos.Location = new System.Drawing.Point(250, 61);
            this.pnlJuegos.Name = "pnlJuegos";
            this.pnlJuegos.Size = new System.Drawing.Size(664, 386);
            this.pnlJuegos.TabIndex = 13;
            this.pnlJuegos.Visible = false;
            // 
            // btnSerpientesEscaleras
            // 
            this.btnSerpientesEscaleras.BackColor = System.Drawing.Color.Black;
            this.btnSerpientesEscaleras.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerpientesEscaleras.ForeColor = System.Drawing.Color.White;
            this.btnSerpientesEscaleras.Location = new System.Drawing.Point(413, 82);
            this.btnSerpientesEscaleras.Name = "btnSerpientesEscaleras";
            this.btnSerpientesEscaleras.Size = new System.Drawing.Size(150, 150);
            this.btnSerpientesEscaleras.TabIndex = 9;
            this.btnSerpientesEscaleras.Text = "PROXIMAMENTE";
            this.btnSerpientesEscaleras.UseVisualStyleBackColor = false;
            this.btnSerpientesEscaleras.Click += new System.EventHandler(this.BtnSerpientesEscaleras_Click);
            // 
            // btnBuscarPares
            // 
            this.btnBuscarPares.BackColor = System.Drawing.Color.Black;
            this.btnBuscarPares.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPares.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPares.Location = new System.Drawing.Point(116, 82);
            this.btnBuscarPares.Name = "btnBuscarPares";
            this.btnBuscarPares.Size = new System.Drawing.Size(150, 150);
            this.btnBuscarPares.TabIndex = 8;
            this.btnBuscarPares.Text = "BUSCAR PARES";
            this.btnBuscarPares.UseVisualStyleBackColor = false;
            this.btnBuscarPares.Click += new System.EventHandler(this.BtnBuscarPares_Click);
            // 
            // btnOca
            // 
            this.btnOca.BackColor = System.Drawing.Color.Black;
            this.btnOca.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOca.ForeColor = System.Drawing.Color.White;
            this.btnOca.Location = new System.Drawing.Point(264, 82);
            this.btnOca.Name = "btnOca";
            this.btnOca.Size = new System.Drawing.Size(150, 150);
            this.btnOca.TabIndex = 6;
            this.btnOca.Text = "LA OCA LOCA";
            this.btnOca.UseVisualStyleBackColor = false;
            this.btnOca.Click += new System.EventHandler(this.BtnOca_Click);
            // 
            // btnTresEnRaya
            // 
            this.btnTresEnRaya.BackColor = System.Drawing.Color.Black;
            this.btnTresEnRaya.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTresEnRaya.ForeColor = System.Drawing.Color.White;
            this.btnTresEnRaya.Location = new System.Drawing.Point(413, 227);
            this.btnTresEnRaya.Name = "btnTresEnRaya";
            this.btnTresEnRaya.Size = new System.Drawing.Size(150, 150);
            this.btnTresEnRaya.TabIndex = 5;
            this.btnTresEnRaya.Text = "PROXIMAMENTE";
            this.btnTresEnRaya.UseVisualStyleBackColor = false;
            this.btnTresEnRaya.Click += new System.EventHandler(this.BtnTresEnRaya_Click);
            // 
            // btnAhorcado
            // 
            this.btnAhorcado.BackColor = System.Drawing.Color.Black;
            this.btnAhorcado.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAhorcado.ForeColor = System.Drawing.Color.White;
            this.btnAhorcado.Location = new System.Drawing.Point(264, 228);
            this.btnAhorcado.Name = "btnAhorcado";
            this.btnAhorcado.Size = new System.Drawing.Size(150, 150);
            this.btnAhorcado.TabIndex = 3;
            this.btnAhorcado.Text = "AHORCADO";
            this.btnAhorcado.UseVisualStyleBackColor = false;
            this.btnAhorcado.Click += new System.EventHandler(this.BtnAhorcado_Click);
            // 
            // btnRompecabezas
            // 
            this.btnRompecabezas.BackColor = System.Drawing.Color.Black;
            this.btnRompecabezas.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRompecabezas.ForeColor = System.Drawing.Color.White;
            this.btnRompecabezas.Location = new System.Drawing.Point(116, 227);
            this.btnRompecabezas.Name = "btnRompecabezas";
            this.btnRompecabezas.Size = new System.Drawing.Size(150, 150);
            this.btnRompecabezas.TabIndex = 2;
            this.btnRompecabezas.Text = "ROMPECABEZAS";
            this.btnRompecabezas.UseVisualStyleBackColor = false;
            this.btnRompecabezas.Click += new System.EventHandler(this.BtnRompecabezas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOJA UNO DE LOS SIGUIENTES JUEGOS";
            // 
            // tmrLogo
            // 
            this.tmrLogo.Enabled = true;
            this.tmrLogo.Interval = 15000;
            this.tmrLogo.Tick += new System.EventHandler(this.TmrLogo_Tick);
            // 
            // pbJugar
            // 
            this.pbJugar.BackColor = System.Drawing.Color.Transparent;
            this.pbJugar.Image = ((System.Drawing.Image)(resources.GetObject("pbJugar.Image")));
            this.pbJugar.Location = new System.Drawing.Point(30, 180);
            this.pbJugar.Name = "pbJugar";
            this.pbJugar.Size = new System.Drawing.Size(156, 66);
            this.pbJugar.TabIndex = 14;
            this.pbJugar.TabStop = false;
            this.pbJugar.Click += new System.EventHandler(this.PbJugar_Click);
            // 
            // pbFondo
            // 
            this.pbFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbFondo.Image")));
            this.pbFondo.Location = new System.Drawing.Point(0, -1);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(952, 504);
            this.pbFondo.TabIndex = 17;
            this.pbFondo.TabStop = false;
            this.pbFondo.Click += new System.EventHandler(this.PbFondo_Click);
            // 
            // pbCreditos
            // 
            this.pbCreditos.BackColor = System.Drawing.Color.Transparent;
            this.pbCreditos.Image = ((System.Drawing.Image)(resources.GetObject("pbCreditos.Image")));
            this.pbCreditos.Location = new System.Drawing.Point(30, 275);
            this.pbCreditos.Name = "pbCreditos";
            this.pbCreditos.Size = new System.Drawing.Size(156, 66);
            this.pbCreditos.TabIndex = 18;
            this.pbCreditos.TabStop = false;
            this.pbCreditos.Click += new System.EventHandler(this.PbCreditos_Click);
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(30, 372);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(156, 66);
            this.pbSalir.TabIndex = 19;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.PbSalir_Click);
            // 
            // pnlSalir
            // 
            this.pnlSalir.BackColor = System.Drawing.Color.Black;
            this.pnlSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSalir.Controls.Add(this.btnCancelar);
            this.pnlSalir.Controls.Add(this.btnSalir);
            this.pnlSalir.Controls.Add(this.label2);
            this.pnlSalir.Location = new System.Drawing.Point(211, 180);
            this.pnlSalir.Name = "pnlSalir";
            this.pnlSalir.Size = new System.Drawing.Size(335, 100);
            this.pnlSalir.TabIndex = 20;
            this.pnlSalir.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(186, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(40, 61);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estas seguro que quieres salir?";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 586);
            this.Controls.Add(this.pbTitulo);
            this.Controls.Add(this.pnlSalir);
            this.Controls.Add(this.pbJugar);
            this.Controls.Add(this.pbCreditos);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.pnlJuegos);
            this.Controls.Add(this.pbFondo);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcade Master";
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.pnlJuegos.ResumeLayout(false);
            this.pnlJuegos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.pnlSalir.ResumeLayout(false);
            this.pnlSalir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlJuegos;
        private System.Windows.Forms.Button btnTresEnRaya;
        private System.Windows.Forms.Button btnAhorcado;
        private System.Windows.Forms.Button btnRompecabezas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOca;
        private System.Windows.Forms.Button btnSerpientesEscaleras;
        private System.Windows.Forms.Button btnBuscarPares;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.Timer tmrLogo;
        private System.Windows.Forms.PictureBox pbJugar;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.PictureBox pbCreditos;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.Panel pnlSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
    }
}

