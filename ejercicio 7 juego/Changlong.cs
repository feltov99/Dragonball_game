using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    class Changlong : SerVivo
    {
        protected int tamañoAvance=3;//variable que se puede heredar
        public Changlong(PictureBox nuevoaspecto, string nombre)
            //cuando se crea este objeto clase "Changlong", se realizan todas estas instrucciones en sus llaves
        {
            aspecto = nuevoaspecto;
            valorX = 0;
            valorY = 0;
            valorAncho = aspecto.Width;
            valorAlto = aspecto.Height;
            nombrePersonaje = nombre;
        }

        public void Mover(int AnchoEscenario)
            //este método usa como parámetro una variable entero que indica el ancho del escenario del juego (un picturebox)
        {
            if((valorX+valorAncho)>AnchoEscenario || valorX<0)
                /*cuando la imagen de freezer toca ambos límites del picturebox "escenario", se cambia de sentido el valor
                 * del "tamaño avance" para moverse hacia el otro lado */
            {
                tamañoAvance = -tamañoAvance;
            }
            /*Esta acción siempre sucede, independientemente de la condición (if) anterior, produce la animación del personaje
              cambiando de posición */
            valorX = valorX + tamañoAvance;
        }
    }
}
