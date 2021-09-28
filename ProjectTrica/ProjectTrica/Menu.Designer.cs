namespace ProjectTrica
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.btnPanelSalir = new System.Windows.Forms.PictureBox();
            this.btnCreditos = new System.Windows.Forms.PictureBox();
            this.pbCreditos = new System.Windows.Forms.PictureBox();
            this.pnlSalir = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.PictureBox();
            this.pnlJuegos = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSecuencia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdivinanzas = new System.Windows.Forms.Button();
            this.btnRompecabezas = new System.Windows.Forms.Button();
            this.btnBuscarPares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanelSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreditos)).BeginInit();
            this.pnlSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnJugar)).BeginInit();
            this.pnlJuegos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFondo
            // 
            this.pbFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbFondo.Image")));
            this.pbFondo.Location = new System.Drawing.Point(12, 12);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(14, 44);
            this.pbFondo.TabIndex = 1;
            this.pbFondo.TabStop = false;
            this.pbFondo.Click += new System.EventHandler(this.PbFondo_Click);
            // 
            // btnPanelSalir
            // 
            this.btnPanelSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPanelSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelSalir.Image")));
            this.btnPanelSalir.Location = new System.Drawing.Point(31, 361);
            this.btnPanelSalir.Name = "btnPanelSalir";
            this.btnPanelSalir.Size = new System.Drawing.Size(156, 66);
            this.btnPanelSalir.TabIndex = 2;
            this.btnPanelSalir.TabStop = false;
            this.btnPanelSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreditos.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditos.Image")));
            this.btnCreditos.Location = new System.Drawing.Point(32, 274);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(156, 66);
            this.btnCreditos.TabIndex = 3;
            this.btnCreditos.TabStop = false;
            this.btnCreditos.Click += new System.EventHandler(this.BtnCreditos_Click);
            // 
            // pbCreditos
            // 
            this.pbCreditos.Image = ((System.Drawing.Image)(resources.GetObject("pbCreditos.Image")));
            this.pbCreditos.Location = new System.Drawing.Point(43, 12);
            this.pbCreditos.Name = "pbCreditos";
            this.pbCreditos.Size = new System.Drawing.Size(19, 44);
            this.pbCreditos.TabIndex = 4;
            this.pbCreditos.TabStop = false;
            this.pbCreditos.Visible = false;
            this.pbCreditos.Click += new System.EventHandler(this.PbCreditos_Click);
            // 
            // pnlSalir
            // 
            this.pnlSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlSalir.Controls.Add(this.btnCancelar);
            this.pnlSalir.Controls.Add(this.btnSalir);
            this.pnlSalir.Controls.Add(this.label2);
            this.pnlSalir.Location = new System.Drawing.Point(68, 12);
            this.pnlSalir.Name = "pnlSalir";
            this.pnlSalir.Size = new System.Drawing.Size(20, 44);
            this.pnlSalir.TabIndex = 8;
            this.pnlSalir.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(57, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(193, 71);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estas seguro que quieres salir?";
            // 
            // btnJugar
            // 
            this.btnJugar.Image = ((System.Drawing.Image)(resources.GetObject("btnJugar.Image")));
            this.btnJugar.Location = new System.Drawing.Point(32, 192);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(156, 66);
            this.btnJugar.TabIndex = 10;
            this.btnJugar.TabStop = false;
            this.btnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // pnlJuegos
            // 
            this.pnlJuegos.BackColor = System.Drawing.Color.Transparent;
            this.pnlJuegos.Controls.Add(this.button5);
            this.pnlJuegos.Controls.Add(this.btnSecuencia);
            this.pnlJuegos.Controls.Add(this.button3);
            this.pnlJuegos.Controls.Add(this.btnAdivinanzas);
            this.pnlJuegos.Controls.Add(this.btnRompecabezas);
            this.pnlJuegos.Controls.Add(this.btnBuscarPares);
            this.pnlJuegos.Location = new System.Drawing.Point(261, 37);
            this.pnlJuegos.Name = "pnlJuegos";
            this.pnlJuegos.Size = new System.Drawing.Size(596, 400);
            this.pnlJuegos.TabIndex = 11;
            this.pnlJuegos.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(399, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 200);
            this.button5.TabIndex = 15;
            this.button5.Text = "PROXIMAMENTE";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnSecuencia
            // 
            this.btnSecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecuencia.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecuencia.ForeColor = System.Drawing.Color.Black;
            this.btnSecuencia.Image = ((System.Drawing.Image)(resources.GetObject("btnSecuencia.Image")));
            this.btnSecuencia.Location = new System.Drawing.Point(199, 199);
            this.btnSecuencia.Name = "btnSecuencia";
            this.btnSecuencia.Size = new System.Drawing.Size(200, 200);
            this.btnSecuencia.TabIndex = 14;
            this.btnSecuencia.Text = "JUEGO DE SECUENCIAS";
            this.btnSecuencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSecuencia.UseVisualStyleBackColor = true;
            this.btnSecuencia.Click += new System.EventHandler(this.BtnSecuencia_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(399, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 200);
            this.button3.TabIndex = 13;
            this.button3.Text = "PROXIMAMENTE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnAdivinanzas
            // 
            this.btnAdivinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinanzas.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinanzas.ForeColor = System.Drawing.Color.Black;
            this.btnAdivinanzas.Image = ((System.Drawing.Image)(resources.GetObject("btnAdivinanzas.Image")));
            this.btnAdivinanzas.Location = new System.Drawing.Point(0, 199);
            this.btnAdivinanzas.Name = "btnAdivinanzas";
            this.btnAdivinanzas.Size = new System.Drawing.Size(200, 200);
            this.btnAdivinanzas.TabIndex = 12;
            this.btnAdivinanzas.Text = "ADIVINA LA PALABRA";
            this.btnAdivinanzas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdivinanzas.UseVisualStyleBackColor = true;
            this.btnAdivinanzas.Click += new System.EventHandler(this.BtnAdivinanzas_Click);
            // 
            // btnRompecabezas
            // 
            this.btnRompecabezas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRompecabezas.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRompecabezas.ForeColor = System.Drawing.Color.Black;
            this.btnRompecabezas.Image = ((System.Drawing.Image)(resources.GetObject("btnRompecabezas.Image")));
            this.btnRompecabezas.Location = new System.Drawing.Point(199, 0);
            this.btnRompecabezas.Name = "btnRompecabezas";
            this.btnRompecabezas.Size = new System.Drawing.Size(200, 200);
            this.btnRompecabezas.TabIndex = 11;
            this.btnRompecabezas.Text = "ROMPECABEZAS";
            this.btnRompecabezas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRompecabezas.UseVisualStyleBackColor = true;
            this.btnRompecabezas.Click += new System.EventHandler(this.BtnRompecabezas_Click);
            // 
            // btnBuscarPares
            // 
            this.btnBuscarPares.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarPares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPares.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPares.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarPares.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPares.Image")));
            this.btnBuscarPares.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarPares.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarPares.Name = "btnBuscarPares";
            this.btnBuscarPares.Size = new System.Drawing.Size(200, 200);
            this.btnBuscarPares.TabIndex = 10;
            this.btnBuscarPares.Text = "BUSCAR PARES";
            this.btnBuscarPares.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarPares.UseVisualStyleBackColor = false;
            this.btnBuscarPares.Click += new System.EventHandler(this.BtnBuscarPares_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 485);
            this.Controls.Add(this.pnlJuegos);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pbCreditos);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnPanelSalir);
            this.Controls.Add(this.pnlSalir);
            this.Controls.Add(this.pbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanelSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreditos)).EndInit();
            this.pnlSalir.ResumeLayout(false);
            this.pnlSalir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnJugar)).EndInit();
            this.pnlJuegos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.PictureBox btnPanelSalir;
        private System.Windows.Forms.PictureBox btnCreditos;
        private System.Windows.Forms.PictureBox pbCreditos;
        private System.Windows.Forms.Panel pnlSalir;
        private System.Windows.Forms.PictureBox btnJugar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlJuegos;
        private System.Windows.Forms.Button btnBuscarPares;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSecuencia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdivinanzas;
        private System.Windows.Forms.Button btnRompecabezas;
    }
}