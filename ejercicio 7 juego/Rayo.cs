using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    class Rayo:Energía
    {
        private int pK = 0;
        private int pG = 0;
        Random generador = new Random();
        int contaleatorio = 0;
        int num = 0;
        int numerador = 0;
        public Rayo(int nuevaX, int nuevaY, int diametro, int mov, int num)
        {
            colorAtaque = Color.DeepPink;
            valorX = nuevaX;
            valorY = nuevaY;
            valorAncho = diametro;
            valorAlto = diametro;
            lanzamiento = mov;
            forma = num;
            contColision = 0;
            contEnergia = 0;
            puntajeRayo = 20;
            puntajeRayoGigante = 80;
        }

        public void Mover(int x)
        {
            if (lanzamiento == 1)
            {
                 valorY = valorY + tamañoAvance;
            }
            if(lanzamiento==0)
            {
                valorX = x;
            }
        }

        public void AumentarTamañoRayo()
        {
            if(contaleatorio==0)
            {
                num = generador.Next(5, 26);
                contaleatorio++;
            }
            if (valorAlto < num)
            {
                if(lanzamiento==0)
                {
                    valorAlto = valorAlto + 5;
                    puntajeRayo++;
                }
            }
            else
            { 
                lanzamiento = 1;
            }
        }

        public void AumentarTamañoRayoGigante()
        {
            if(contaleatorio==0)
            {
                num = generador.Next(45, 86);
                contaleatorio++;
            }
            if (valorAlto < num)
            {
                if(lanzamiento==0)
                {
                    valorAncho = valorAncho + 2;
                    valorAlto = valorAlto + 2;
                    if (valorAlto > 45)
                    {
                        puntajeRayoGigante++;
                    }
                }
            }
            else
            {
                lanzamiento = 1;
            }
        }

        public void ActivarcontColision()
        {
            contColision++;
        }

        public bool ContadorColision()
        {
            if (contColision == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RestarPuntosRayo(ProgressBar objeto)
        {
            if (objeto.Value >= puntajeRayo)
            {
                    objeto.Value = objeto.Value - puntajeRayo;
            }
            else
            {
                int diferencia = objeto.Value - puntajeRayo;
                puntajeRayo = puntajeRayo + diferencia;
                objeto.Value = objeto.Value - puntajeRayo;
            }
            contColision = 0;
        }

        public void RestarPuntosRayoGigante(ProgressBar objeto)
        {
            if (objeto.Value >= puntajeRayoGigante)
            {
                objeto.Value = objeto.Value - puntajeRayoGigante;
            }
            else
            {
                int diferencia = objeto.Value - puntajeRayoGigante;
                puntajeRayoGigante = puntajeRayoGigante + diferencia;
                objeto.Value = objeto.Value - puntajeRayoGigante;
            }
            contColision = 0;
        }
        public void ColisionRayoEnergiaMayorKame(Kame hola)//
        {
            pK = hola.PuntajeKame;
            if(puntajeRayo!=0)
            {
                numerador = (puntajeRayo - pK) / puntajeRayo;
                valorAlto = valorAlto * (numerador / puntajeRayo);
                valorAncho = valorAncho * (numerador / puntajeRayo);
                puntajeRayo = puntajeRayo - pK;
            }
            
        }

        public void ColisionRayoGiganteEnergiaMayorKame(Kame hola)//
        {
            pK = hola.PuntajeKame;
            numerador = (puntajeRayoGigante - pK) / puntajeRayoGigante;
            valorAlto = valorAlto * (numerador/puntajeRayoGigante);
            valorAncho = valorAncho * (numerador / puntajeRayoGigante);
            puntajeRayoGigante = puntajeRayoGigante - pK;
        }
        public void ColisionRayoEnergiaMayorGenki(Kame hola)//
        {
            pG = hola.PuntajeGenki;
            numerador = (puntajeRayo - pG) / puntajeRayo;
            valorAlto = valorAlto * (numerador / puntajeRayo);
            valorAncho = valorAncho * (numerador / puntajeRayo);
            puntajeRayo = puntajeRayo - pG;
        }
        public void ColisionRayoGiganteEnergiaMayorGenki(Kame hola)//
        {
            pG = hola.PuntajeGenki;
            numerador = (puntajeRayoGigante - pG) / puntajeRayoGigante;
            valorAlto = valorAlto * (numerador / puntajeRayoGigante);
            valorAncho = valorAncho * (numerador / puntajeRayoGigante);
            puntajeRayoGigante = puntajeRayoGigante - pG;
        }
    }
}
