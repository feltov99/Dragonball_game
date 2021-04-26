using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    class Humano:SerVivo
    {
        public Humano(PictureBox nuevoAspecto, string nombre) // constructor 3
        {
            aspecto = nuevoAspecto;
            //inicializa la imagan cuando se crea con coordenadas negativas, para que desaparezca del escenario
            valorX = -2*aspecto.Width;
            valorY = -2 * aspecto.Height;
            valorAncho = aspecto.Width;
            valorAlto = aspecto.Height;
        }

        public void mover(int x, int y) 
            //el método permite el cambio de posción de la imagen según lo que se ponga de coordenadas en los parámetros
        {
            valorX = x;
            valorY = y; 
        }
    }
}
