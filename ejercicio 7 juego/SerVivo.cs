using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    public class SerVivo : Sprite //Servivo hereda de la clase Sprite
    {
        protected PictureBox aspecto; // los seres vivos pueden tener una imagen(nueva propiedad)
        //Todo ser vivo tiene un aspecto
        //"protected" significa que el objeto "aspecto" tipo PictureBox, puede ser usado hereditariamente por otras clases
        //Esto nos sirve para usar pictureboxes llamando a la clase, "aspecto" sólo es un nombre default, puede cambiar
        protected string nombrePersonaje;
        //Todo ser vivo tiene un nombre
        //lo mismo de arriba, pero para una variable tipo string, con "nombrePeronaje" como nombre default
        public override void Dibujar(Graphics escenario)
            //es "override" por ser un método (por eso lleva "void") de la clase madre Sprite que se heredó a Servivo
            /* Siempre se pone override a objetos, métodos o variables que son usadas de una clase heredada que declaró
             * sus variables, objetos y métodos con "protected". */
        {
            escenario.DrawImage(aspecto.Image, valorX, valorY, valorAncho, valorAlto);
            /*Aquí, una vez implentada la biblioteca Drawing para usar Graphics, se llama al método DrawImage para dibujar
             * la imagen "aspecto.Image" con las coordenadas y dimensiones solicitados, en el picturebox asociado con el objeto
             * "escenario", que nos permite realizar acciones gráficas sobre él. */

        }
    }
}
