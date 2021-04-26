using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    public partial class juego : Form
    {
        //Aquí estamos instanciando las diferentes variables con su clase
        private Graphics planeta;
        private Random generador;
        private Sayayin goku;//goku es un objeto recién creado de la clase Sayayin, que es global, es decir, se puede usar a lo largo del Form1
        private Changlong freezer;
        private Humano krillin;
        private Kame poder;
        private Kame genki;
        private Rayo rayo;
        private Rayo rayoGigante;
        private SoundPlayer musicadeFondo;
        private string tipoPoder = "";
        private int pR = 0;
        private int pRG = 0;
        private int pK = 0;
        private int pG = 0;
        private Boolean muerteKrillin = false;
        private Boolean ActivarSuperSayayin = true;
        private int numtransFrezer = 1;
        public juego()
        {
            InitializeComponent();
            imagenEscenario.BackgroundImage = Properties.Resources.namek01;
            planeta = imagenEscenario.CreateGraphics();/*permite dibujar dentro de planeta, osea dentro del pictureBox 
                                                        "imagenEscenario" */
            generador = new Random();
            Animaciontimer.Interval = 1; /*le damos un intervalod e 1 milisegundo, cada milisegundo se repite el programa
                            haciendo funcionar la animación */
            Nuevojuego(); //se inicializa junto al programa, así como todas las instrucciones que engloba dentro de sí mismo
        }
        private void Nuevojuego()//creación del método antes solicitado
        {
            //creamos los objetos con los pictureboxes vacantes, con su respectiva clase
            goku = new Sayayin(imagenGoku, "Goku");
            freezer = new Changlong(ImagenFreezer, "Freezer");
            krillin = new Humano(ImagenKrillin, "Krillin");
           // musicadeFondo = new SoundPlayer();
           // musicadeFondo.Load();
            Animaciontimer.Start();
            AnimacionKrillin.Start();
            TiempoPoder.Start();
            relojEnergia.Start();
            //musicadeFondo.SoundLocation = "C:/Users/lftn9/Desktop/el-Ansioso.wav";
           // musicadeFondo.PlayLooping();
            
        }
        
        private void Animaciontimer_Tick(object sender, EventArgs e)
        {
            //Cada milisegundo se repite esto estos métodos siempre se repiten cada milisegundo
            MoverTodo();
            DibujarTodo();
            ComprobarColision();
            Transformaciones();
            label2.Text = vidaFreezer.Value + "";
            label6.Text = vidaKrillin.Value + "";
            label7.Text = vidaGoku.Value + "";
            label8.Text = energiaGoku.Value + "";
            label10.Text = cargaBarra.Value + "";
            if(vidaGoku.Value==0)
            {
                Animaciontimer.Stop();
                MessageBox.Show("Has perdido, suerte para la próxima");
            }
        }

        private void Transformaciones()
        {
          if(ActivarSuperSayayin==true && muerteKrillin==true)
          {
             label11.Text = "Presionar Enter para SuperSayayin";
          }

          switch(numtransFrezer)
            {
                case 1:
                    if(vidaFreezer.Value==0)
                    {
                        numtransFrezer=2;
                        ImagenFreezer.Image = Properties.Resources.frezzer02;
                        vidaFreezer.Maximum = 60;
                        vidaFreezer.Value = vidaFreezer.Maximum;
                    }
                    break;
                case 2:
                    if (vidaFreezer.Value == 0)
                    {
                        numtransFrezer = 3;
                        ImagenFreezer.Image = Properties.Resources.frezzer03;
                        vidaFreezer.Maximum = 70;
                        vidaFreezer.Value = vidaFreezer.Maximum;
                    }
                    break;
                case 3:
                    if (vidaFreezer.Value == 0)
                    {
                        numtransFrezer = 4;
                        ImagenFreezer.Image = Properties.Resources.frezzer04;
                        vidaFreezer.Maximum = 80;
                        vidaFreezer.Value = vidaFreezer.Maximum;
                        imagenEscenario.Image = Properties.Resources.namek02;
                    }
                    break;
                case 4:
                    if (vidaFreezer.Value == 0)
                    {
                        numtransFrezer = 5;
                        ImagenFreezer.Image = Properties.Resources.frezzer05;
                        vidaFreezer.Maximum = 90;
                        vidaFreezer.Value = vidaFreezer.Maximum;
                    }
                    break;
                case 5:
                    if (vidaFreezer.Value == 0)
                    {
                        numtransFrezer = 6;
                        ImagenFreezer.Image = Properties.Resources.freezer06;
                        vidaFreezer.Maximum = 100;
                        vidaFreezer.Value = vidaFreezer.Maximum;
                        imagenEscenario.Image = Properties.Resources.namek03;
                    }
                    break;
                case 6:
                    if (vidaFreezer.Value == 0)
                    {
                        Animaciontimer.Stop();
                        MessageBox.Show("¡Felicidades! Has ganado");
                    }
                    break;
            }

        }

        private void FinJuego()
        {
            
        }

        private void ComprobarColision()
        {
            if (poder != null)
            {
                if (Colision(poder, freezer) == true && vidaFreezer.Value != 0 && poder.ContadorColision() == true)
                {
                    poder.RestarPuntosKame(vidaFreezer);
                    poder.ActivarcontColision();
                }
                if(krillin!=null)
                {
                    if (Colision(poder, krillin) && vidaKrillin.Value != 0)
                    {
                        poder.RestarPuntosKame(vidaKrillin);
                        poder.ActivarcontColision();
                    }
                }
                //////////////------------------------------
                if(rayo!=null)
                {
                    if(Colision(poder,rayo))
                    {
                        if(pK<pR)
                        {
                            rayo.ColisionRayoEnergiaMayorKame(poder);
                            poder = null;
                        }
                        else if(pK>pR)
                        {
                            poder.ColisionKameEnergiaMayorRayo(rayo);
                            rayo = null;
                        }else if(pK==pR)
                        {
                            poder = null;
                            rayo = null;
                        }
                    }
                }
                if(rayoGigante!=null)
                {
                    if(Colision(poder,rayoGigante))
                    {
                        if(pK<pRG)
                        {
                            rayoGigante.ColisionRayoGiganteEnergiaMayorKame(poder);
                            poder = null;
                        }
                        else if(pK>pRG)
                        {
                            poder.ColisionKameEnergiaMayorRayoGigante(rayoGigante);
                            rayoGigante = null;
                        }
                        else if(pK==pRG)
                        {
                            poder = null;
                            rayoGigante = null;
                        }
                    }
                }
                ///--------------------------------------------------------------------
            }
            if (genki != null)
            {
                if (Colision(genki, freezer) == true && vidaFreezer.Value != 0 && genki.ContadorColision() == true)
                {
                    genki.RestarPuntosGenki(vidaFreezer);
                    genki.ActivarcontColision();
                }
                if (krillin != null)
                {
                    if (Colision(genki, krillin) && vidaKrillin.Value != 0 && genki.ContadorColision())
                    {
                        genki.RestarPuntosGenki(vidaKrillin);
                        genki.ActivarcontColision();
                    }
                } 
                ////----------------------------------
                if(rayo!=null)
                {
                    if (Colision(genki, rayo))
                    {
                        if (pG < pR)
                        {
                            rayo.ColisionRayoEnergiaMayorKame(genki);
                            genki = null;
                        }
                        else if (pG > pR)
                        {
                            genki.ColisionKameEnergiaMayorRayo(rayo);
                            rayo = null;
                        }
                        else if(pG==pR)
                        {
                            genki = null;
                            rayo = null;
                        }
                    }
                }
                if(rayoGigante!=null)
                {
                    if (Colision(genki, rayoGigante))
                    {
                        if (pG < pRG)
                        {
                            rayoGigante.ColisionRayoGiganteEnergiaMayorKame(genki);
                            genki = null;
                        }
                        else if (pG > pRG)
                        {
                            genki.ColisionKameEnergiaMayorRayoGigante(rayoGigante);
                            rayoGigante = null;
                        }
                        else if(pG==pRG)
                        {
                            genki= null;
                            rayoGigante = null;
                        }
                    }
                }
                /////-----------------------------------------------------------------
            }
            if(rayo!=null)
            {
                if (Colision(rayo, goku) && vidaGoku.Value != 0 && rayo.ContadorColision())
                {
                    rayo.RestarPuntosRayo(vidaGoku);
                    rayo.ActivarcontColision();
                }
                if(krillin!=null)
                {
                    if (Colision(rayo, krillin) && vidaKrillin.Value != 0 && rayo.ContadorColision())
                    {
                        rayo.RestarPuntosRayo(vidaKrillin);
                        rayo.ActivarcontColision();
                    }
                }
            }
            if (rayoGigante != null)
            {
                if (Colision(rayoGigante, goku) && vidaGoku.Value != 0 && rayoGigante.ContadorColision())
                {
                    rayoGigante.RestarPuntosRayo(vidaGoku);
                    rayoGigante.ActivarcontColision();
                }
                if(krillin!=null)
                {
                    if (Colision(rayoGigante, krillin) && vidaKrillin.Value != 0 && rayoGigante.ContadorColision())
                    {
                        rayoGigante.RestarPuntosRayo(vidaKrillin);
                        rayoGigante.ActivarcontColision();
                    }
                }
            }

        }

        private bool Colision(Sprite obj1, Sprite obj2)
        {
           if(obj1==null || obj2==null)
            {
                return false;
            }
           else
            {
                int izquierda1 = obj1.X;
                int derecha1 = obj1.X + obj1.Ancho;
                int arriba1 = obj1.Y;
                int abajo1 = obj1.Y + obj1.Alto;
                int izquierda2 = obj2.X;
                int derecha2 = obj2.X + obj2.Ancho;
                int arriba2 = obj2.Y;
                int abajo2 = obj2.Y + obj2.Alto;
                
                //si obj1 es más grande que obj2
                if(izquierda1>izquierda2 && derecha1<derecha2 && arriba1<abajo2 && abajo1>arriba2)
                {
                    return true;
                }

                //si obj1 es más chico que obj2
                else if(izquierda1<derecha2 && derecha1>izquierda2 && arriba1<abajo2 && abajo1>arriba2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void MoverTodo()
        {
            //metodo creado en clase Changlong
            freezer.Mover(imagenEscenario.Width);
            if(poder!=null)
            {
                poder.Mover(goku.X, goku.Y - 20);
                if (poder.Y < 0-poder.Alto)
                {
                    poder = null;
                }
            }
            if (genki != null)
            {
                genki.Mover(goku.X, goku.Y - 20);
                if (genki.Y < 0 - genki.Alto)
                {
                    genki = null;
                }
            }
            if (rayo!=null)
            {
              rayo.Mover(freezer.X + freezer.Ancho/2 - rayo.Ancho/2);
                if(rayo.Y > imagenEscenario.Height)
                {
                    rayo = null;
                }
            }
            if (rayoGigante != null)
            {
                rayoGigante.Mover(freezer.X + freezer.Ancho / 2 - rayoGigante.Ancho / 2);
                if (rayoGigante.Y > imagenEscenario.Height)
                {
                    rayoGigante = null;
                }
            }

        }

        private void DibujarTodo()
        {
            imagenEscenario.Refresh();
            goku.Dibujar(planeta);
            freezer.Dibujar(planeta);
            if(krillin!=null)
            {
                krillin.Dibujar(planeta);
            }
            if (poder != null) // SI poder existe
            {
                poder.Dibujar(planeta);
            }
            if (genki != null) 
            {
                genki.Dibujar(planeta);
            }
            if (rayo!=null)
            {
                rayo.Dibujar(planeta);
                rayo.AumentarTamañoRayo();
            }
            if (rayoGigante != null)
            {
                rayoGigante.Dibujar(planeta);
                rayoGigante.AumentarTamañoRayoGigante();
            }

        }

        private void imagenEscenario_MouseMove(object sender, MouseEventArgs e)
        {
            if(energiaGoku.Value >= 20)
            {
                int limite = imagenEscenario.Height / 2;

                if(e.X<=0)
                {
                    if (e.Y > limite && e.Y < imagenEscenario.Height - 50)
                    {
                        goku.mover(0, e.Y);
                    }
                    else if (e.Y == limite)
                    {
                        goku.mover(0, limite);
                    }
                    else if (e.Y == imagenEscenario.Height - 50)
                    {
                        goku.mover(0, imagenEscenario.Height - 50);
                    }
                }
                if (e.X >=imagenEscenario.Width-30)
                {
                    if (e.Y > limite && e.Y < imagenEscenario.Height - 50)
                    {
                        goku.mover(imagenEscenario.Width - 30, e.Y);
                    }
                    else if (e.Y == limite)
                    {
                        goku.mover(imagenEscenario.Width - 30, limite);
                    }
                    else if (e.Y == imagenEscenario.Height - 50)
                    {
                        goku.mover(imagenEscenario.Width - 30, imagenEscenario.Height - 50);
                    }
                }
                if(e.X>0 && e.X<imagenEscenario.Width-30)
                {
                    if(e.Y<=limite)
                    {
                       goku.mover(e.X, limite);
                    }
                    if(e.Y>=imagenEscenario.Height-50)
                    {
                        goku.mover(e.X, imagenEscenario.Height-50);
                    }
                    if(e.Y>limite && e.Y<imagenEscenario.Height-50)
                    {
                        goku.mover(e.X, e.Y);
                    }
                }
            }
        }

        private void AnimacionKrillin_Tick(object sender, EventArgs e)
        {
            if(krillin!=null)
            {
                int limiteX = imagenEscenario.Width;
                int limiteY = imagenEscenario.Height;
                if (krillin.X < 0 && krillin.Y < 0)
                {
                    krillin.mover(generador.Next(0, limiteX - 30), generador.Next(limiteY / 2, limiteY - 30));
                }
                else
                {
                    krillin.mover(-2 * krillin.Ancho, -2 * krillin.Alto);
                }
            }
            if(vidaKrillin.Value==0 && muerteKrillin == false)
            {
                krillin = null;
                muerteKrillin = true;
            }
            
        }

        private void TiempoPoder_Tick(object sender, EventArgs e)
        {
            int tamaño = 5;
            TiempoPoder.Interval = generador.Next(100, 600);// el timer que decide cuando debe tirar energía frezeer
            if (rayo == null && rayoGigante == null)
            {
                if(generador.Next(1,11)<10-numtransFrezer)
                {
                    rayo = new Rayo(freezer.X + freezer.Ancho / 2 - tamaño / 2, freezer.Y + Convert.ToInt32(1.1 * tamaño), tamaño, 0,2);
                    pR = rayo.PuntajeRayo;
                }
                else
                {
                   rayoGigante = new Rayo(freezer.X + freezer.Ancho / 2 - tamaño / 2, freezer.Y + Convert.ToInt32(1.1 * tamaño), tamaño, 0,1);
                    pRG = rayoGigante.PuntajeRayoGigante;
                }
                
            }
        }

        private void ImagenEscenario_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                tipoPoder = "Genkidama";
            }
            if(e.Button==MouseButtons.Left)
            {
                tipoPoder = "KameHameHa";
            }
            poderGoku.Start();

        }


        private void PoderGoku_Tick(object sender, EventArgs e)
        {
            int tamaño = 5;
            if (tipoPoder=="KameHameHa")
            {
                if(poder ==null)
                {
                    poder = new Kame(goku.X + (goku.Ancho / 2), goku.Y - tamaño * 4, tamaño, 0);
                    pR = poder.PuntajeKame;
                }
                if (poder != null)
                {
                    poder.AumentarTamañoKameKameHa(energiaGoku, cargaBarra);
                }
            }
            if(tipoPoder=="Genkidama")
            {
                    if (genki == null)
                    {
                        genki=new Kame(goku.X + (goku.Ancho / 2), goku.Y - tamaño * 4, tamaño, 0);
                         pG = genki.PuntajeGenki;
                    }
                    if (genki != null)
                    {
                        genki.AumentarTamañoGenkidama(energiaGoku, cargaBarra);
                    }
                
            }
        }

        private void ImagenEscenario_MouseUp(object sender, MouseEventArgs e)
        {
            poderGoku.Stop();
            cargaBarra.Value = 0;
           if(poder!=null)
            {
                poder.ActivarMovimiento();
            }
            if (genki != null)
            {
                genki.ActivarMovimiento();
            }
        }

        private void RelojEnergia_Tick(object sender, EventArgs e)
        {
            if(energiaGoku.Value <=energiaGoku.Maximum-5)
            {
                energiaGoku.Value = energiaGoku.Value + 5;
            }
            else
            {
                energiaGoku.Value = energiaGoku.Maximum;
            }
        }

        private void Juego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(muerteKrillin==true && ActivarSuperSayayin==true)
            {
                if(e.KeyChar==Convert.ToChar(Keys.Enter))
                {
                    imagenGoku.Image = Properties.Resources.goku02;
                    vidaGoku.Maximum = 100;
                    vidaGoku.Value = vidaGoku.Maximum;
                    energiaGoku.Maximum = 200;
                    energiaGoku.Value = energiaGoku.Maximum;
                    label11.Text = " ";
                    ActivarSuperSayayin = false;
                }
            }
        }

        private void ImagenEscenario_Click(object sender, EventArgs e)
        {

        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }
    }
}
