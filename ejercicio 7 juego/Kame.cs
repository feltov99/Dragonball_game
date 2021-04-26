using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    class Kame:Energía //hereda de la clase Energía
    {
        private int pR = 0;
        private int pRG = 0;
        int numerador = 0;
        public Kame(int nuevaX, int nuevaY, int diametro, int mov)
        {
            colorAtaque = Color.Aqua;
            valorX = nuevaX;
            valorY = nuevaY;
            valorAncho = diametro;
            valorAlto = diametro +10;
            forma = 1;
            lanzamiento = mov;
            contColision = 0;
            contEnergia = 0;
            contCarga = 0;
            puntajeKame = 5;
            puntajeGenki = 60;
        }


        public void Mover(int x, int y)
        {
           if(lanzamiento==0)
            {
                valorX = x;
                valorY = y;
            }
            if (lanzamiento == 1)
            {
                 valorY = valorY - tamañoAvance;
            }

        }

        public void ActivarMovimiento()
        {
            lanzamiento = 1;
        }

        public void AumentarTamañoKameKameHa(ProgressBar objeto1, ProgressBar objeto2) //objeto 1 es energia, objeto2 es carga
        {
            if(valorAlto<35 && objeto1.Value!=0)
            {
                valorAncho = valorAncho + 1;
                valorAlto = valorAlto + 1;
                puntajeKame++;
                if (objeto1.Value != 0 && contEnergia == 0)
                {
                    if (objeto1.Value >= 10)
                    {
                        objeto1.Value = objeto1.Value-10;
                    }
                    else
                    {
                        int diferencia = objeto1.Value - 10;
                        int suma = 10 + diferencia;
                        objeto1.Value = objeto1.Value -suma;
                    }
                    contEnergia++;
                }
                if (objeto1.Value != 0 && contEnergia != 0)
                {
                    objeto1.Value--;
                }
                if (objeto2.Value<=objeto2.Maximum && contCarga == 0)
                {
                    objeto2.Value = objeto2.Value + 5;
                    contCarga++;
                }
                if (objeto2.Value != objeto2.Maximum)
                {
                    objeto2.Value++;
                }
            }
        }

        public void AumentarTamañoGenkidama(ProgressBar objeto1, ProgressBar objeto2) //objeto 1 es energia, objeto2 es carga
        {
            if(valorAlto < 55 && objeto1.Value !=0)
            {
                valorAncho = valorAncho + 1;
                valorAlto = valorAlto + 1;
                puntajeGenki++;
                if (objeto1.Value != 0 && contEnergia == 0)
                {
                    if (objeto1.Value >= 60)
                    {
                        objeto1.Value = objeto1.Value - 60;
                    }
                    else
                    {
                        int diferencia = objeto1.Value - 60;
                        int suma = 60 + diferencia;
                        objeto1.Value = objeto1.Value - suma;
                    }
                    contEnergia++;
                }
                if (objeto1.Value != 0 && contEnergia != 0)
                {
                    objeto1.Value--;
                }
                if (contCarga == 0)
                {
                    objeto2.Value = objeto2.Value + 60;
                    contCarga++;
                }
                if (objeto2.Value != objeto2.Maximum)
                {
                    objeto2.Value++;
                }
            }
        }

        public void ActivarcontColision()
        {
            contColision++;
        }

        public bool ContadorColision()
        {
            if(contColision==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RestarPuntosKame(ProgressBar objeto)
        {
            if(objeto.Value>=puntajeKame)
            {
                objeto.Value = objeto.Value - puntajeKame;
            }
            else
            {
                int diferencia = objeto.Value - puntajeKame;
                puntajeKame = puntajeKame + diferencia;
                objeto.Value = objeto.Value - puntajeKame;
            }
            contColision = 0;
        }

        public void RestarPuntosGenki(ProgressBar objeto)
        {
            if (objeto.Value >= puntajeGenki)
            {
                objeto.Value = objeto.Value - puntajeGenki;
            }
            else
            {
                int diferencia = objeto.Value - puntajeGenki;
                puntajeGenki = puntajeGenki + diferencia;
                objeto.Value = objeto.Value - puntajeGenki;
            }
            contColision = 0;
        }

        public void ColisionKameEnergiaMayorRayo(Rayo hola)
        {
            pR = hola.PuntajeRayo;
            numerador = (puntajeKame - pR) / puntajeKame;
            valorAlto = valorAlto * (numerador / puntajeKame);
            valorAncho = valorAncho * (numerador / puntajeKame);
            puntajeKame = puntajeKame - pR;
        }
        public void ColisionKameEnergiaMayorRayoGigante(Rayo hola)
        {
            pRG = hola.PuntajeRayoGigante;
            numerador = (puntajeKame - pRG) / puntajeKame;
            valorAlto = valorAlto * (numerador / puntajeKame);
            valorAncho = valorAncho * (numerador / puntajeKame);
            puntajeKame = puntajeKame - pRG;
        }

        public void ColisionGenkiEnergiaMayorRayo(Rayo hola)
        {
            pR = hola.PuntajeRayo;
            numerador = (puntajeKame - pR) / puntajeGenki;
            valorAlto = valorAlto * (numerador / puntajeGenki);
            valorAncho = valorAncho * (numerador / puntajeGenki);
            puntajeGenki = puntajeGenki - pR;
        }
        public void ColisionGenkiEnergiaMayorRayoGigante(Rayo hola)
        {
            pRG = hola.PuntajeRayo;
            numerador = (puntajeKame - pRG) / puntajeGenki;
            valorAlto = valorAlto * (numerador / puntajeGenki);
            valorAncho = valorAncho * (numerador / puntajeGenki);
            puntajeGenki = puntajeGenki - pRG;
        }
    }
}
