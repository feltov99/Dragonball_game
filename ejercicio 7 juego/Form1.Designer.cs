namespace ejercicio_7_juego
{
    partial class juego
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
            this.Animaciontimer = new System.Windows.Forms.Timer(this.components);
            this.AnimacionKrillin = new System.Windows.Forms.Timer(this.components);
            this.TiempoPoder = new System.Windows.Forms.Timer(this.components);
            this.poderGoku = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vidaFreezer = new System.Windows.Forms.ProgressBar();
            this.vidaKrillin = new System.Windows.Forms.ProgressBar();
            this.vidaGoku = new System.Windows.Forms.ProgressBar();
            this.energiaGoku = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.relojEnergia = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cargaBarra = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ImagenKrillin = new System.Windows.Forms.PictureBox();
            this.ImagenFreezer = new System.Windows.Forms.PictureBox();
            this.imagenGoku = new System.Windows.Forms.PictureBox();
            this.imagenEscenario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenKrillin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFreezer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEscenario)).BeginInit();
            this.SuspendLayout();
            // 
            // Animaciontimer
            // 
            this.Animaciontimer.Tick += new System.EventHandler(this.Animaciontimer_Tick);
            // 
            // AnimacionKrillin
            // 
            this.AnimacionKrillin.Interval = 3000;
            this.AnimacionKrillin.Tick += new System.EventHandler(this.AnimacionKrillin_Tick);
            // 
            // TiempoPoder
            // 
            this.TiempoPoder.Interval = 500;
            this.TiempoPoder.Tick += new System.EventHandler(this.TiempoPoder_Tick);
            // 
            // poderGoku
            // 
            this.poderGoku.Interval = 1;
            this.poderGoku.Tick += new System.EventHandler(this.PoderGoku_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Energía";
            // 
            // vidaFreezer
            // 
            this.vidaFreezer.Location = new System.Drawing.Point(547, 166);
            this.vidaFreezer.Maximum = 50;
            this.vidaFreezer.Name = "vidaFreezer";
            this.vidaFreezer.Size = new System.Drawing.Size(50, 13);
            this.vidaFreezer.TabIndex = 9;
            this.vidaFreezer.Value = 50;
            // 
            // vidaKrillin
            // 
            this.vidaKrillin.Location = new System.Drawing.Point(547, 255);
            this.vidaKrillin.Maximum = 50;
            this.vidaKrillin.Name = "vidaKrillin";
            this.vidaKrillin.Size = new System.Drawing.Size(50, 13);
            this.vidaKrillin.TabIndex = 10;
            this.vidaKrillin.Value = 50;
            // 
            // vidaGoku
            // 
            this.vidaGoku.Location = new System.Drawing.Point(547, 337);
            this.vidaGoku.Maximum = 50;
            this.vidaGoku.Name = "vidaGoku";
            this.vidaGoku.Size = new System.Drawing.Size(50, 13);
            this.vidaGoku.TabIndex = 11;
            this.vidaGoku.Value = 50;
            // 
            // energiaGoku
            // 
            this.energiaGoku.BackColor = System.Drawing.SystemColors.Control;
            this.energiaGoku.Location = new System.Drawing.Point(547, 373);
            this.energiaGoku.Name = "energiaGoku";
            this.energiaGoku.Size = new System.Drawing.Size(100, 13);
            this.energiaGoku.TabIndex = 12;
            this.energiaGoku.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // relojEnergia
            // 
            this.relojEnergia.Interval = 500;
            this.relojEnergia.Tick += new System.EventHandler(this.RelojEnergia_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Carga";
            // 
            // cargaBarra
            // 
            this.cargaBarra.Location = new System.Drawing.Point(547, 406);
            this.cargaBarra.Name = "cargaBarra";
            this.cargaBarra.Size = new System.Drawing.Size(100, 13);
            this.cargaBarra.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = " ";
            // 
            // ImagenKrillin
            // 
            this.ImagenKrillin.BackgroundImage = global::ejercicio_7_juego.Properties.Resources.krilin;
            this.ImagenKrillin.Image = global::ejercicio_7_juego.Properties.Resources.krilin;
            this.ImagenKrillin.Location = new System.Drawing.Point(457, 255);
            this.ImagenKrillin.Name = "ImagenKrillin";
            this.ImagenKrillin.Size = new System.Drawing.Size(30, 30);
            this.ImagenKrillin.TabIndex = 3;
            this.ImagenKrillin.TabStop = false;
            // 
            // ImagenFreezer
            // 
            this.ImagenFreezer.Image = global::ejercicio_7_juego.Properties.Resources.freezer01;
            this.ImagenFreezer.Location = new System.Drawing.Point(449, 152);
            this.ImagenFreezer.Name = "ImagenFreezer";
            this.ImagenFreezer.Size = new System.Drawing.Size(38, 40);
            this.ImagenFreezer.TabIndex = 2;
            this.ImagenFreezer.TabStop = false;
            // 
            // imagenGoku
            // 
            this.imagenGoku.Image = global::ejercicio_7_juego.Properties.Resources.goku01;
            this.imagenGoku.Location = new System.Drawing.Point(460, 348);
            this.imagenGoku.Name = "imagenGoku";
            this.imagenGoku.Size = new System.Drawing.Size(30, 50);
            this.imagenGoku.TabIndex = 1;
            this.imagenGoku.TabStop = false;
            // 
            // imagenEscenario
            // 
            this.imagenEscenario.BackgroundImage = global::ejercicio_7_juego.Properties.Resources.namek01;
            this.imagenEscenario.Location = new System.Drawing.Point(32, 138);
            this.imagenEscenario.Name = "imagenEscenario";
            this.imagenEscenario.Size = new System.Drawing.Size(400, 300);
            this.imagenEscenario.TabIndex = 0;
            this.imagenEscenario.TabStop = false;
            this.imagenEscenario.Click += new System.EventHandler(this.ImagenEscenario_Click);
            this.imagenEscenario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagenEscenario_MouseDown);
            this.imagenEscenario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagenEscenario_MouseMove);
            this.imagenEscenario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImagenEscenario_MouseUp);
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cargaBarra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.energiaGoku);
            this.Controls.Add(this.vidaGoku);
            this.Controls.Add(this.vidaKrillin);
            this.Controls.Add(this.vidaFreezer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagenKrillin);
            this.Controls.Add(this.ImagenFreezer);
            this.Controls.Add(this.imagenGoku);
            this.Controls.Add(this.imagenEscenario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "juego";
            this.Text = "Batalla";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Juego_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenKrillin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFreezer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEscenario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenEscenario;
        private System.Windows.Forms.PictureBox imagenGoku;
        private System.Windows.Forms.PictureBox ImagenFreezer;
        private System.Windows.Forms.PictureBox ImagenKrillin;
        private System.Windows.Forms.Timer Animaciontimer;
        private System.Windows.Forms.Timer AnimacionKrillin;
        private System.Windows.Forms.Timer TiempoPoder;
        private System.Windows.Forms.Timer poderGoku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar vidaFreezer;
        private System.Windows.Forms.ProgressBar vidaKrillin;
        private System.Windows.Forms.ProgressBar vidaGoku;
        private System.Windows.Forms.ProgressBar energiaGoku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer relojEnergia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar cargaBarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

