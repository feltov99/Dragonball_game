using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    class Energía : Sprite
    {
        protected Color colorAtaque;
        protected int tamañoAvance = 5;
        protected int forma;
        protected int lanzamiento;
        protected int contColision;
        protected int contCarga;
        protected int contEnergia;
        public override void Dibujar(Graphics escenario)
        {
            if(forma==1)//dibuja una elipse
            {
                escenario.FillEllipse(new SolidBrush(colorAtaque),valorX,valorY,valorAncho,valorAlto);
            }

            if(forma==2)//dibuja un rectángulo
            {
                valorAncho = 5;
                escenario.FillRectangle(new SolidBrush(colorAtaque), valorX, valorY, valorAncho, valorAlto);
            }
        }

        

    }
}
