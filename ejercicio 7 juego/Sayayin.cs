using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_juego
{
    public class Sayayin : SerVivo //hereda de Ser Vivo
    {
      //  public string nombrePersonaje = "";

        public Sayayin() //constructor 1
            /*Nos permite crear un objeto de la clase "Sayayin" sin parámetros  usando new Sayayin()*/
        {
            //using System.Windows.Forms;
            //Cuando se llama éste constructor, se despliega un messagebox que dice "Sayayin creado"
            MessageBox.Show("Sayayin creado: ");
        }
        public Sayayin(string nombre) //constructor 2
            //Se construye un objeto clase "Sayayin" CON EL PARÁMETRO "nombre"
        {
            //using System.Windows.Forms;
            //Si pide un parámetro, debe ser usado dentro del constructor(funciona igual para métodos)
            //Aquí se concatena "nombre" al string creado con messagebox
            MessageBox.Show("Sayayin creado: " + nombre);
            /*Cuando se construye un objeto con Sayayin con parámetro nombre, la variable "nombrePersonaje" se le asigna 
            el valor del string  nombre, el cual puede ser utilizado por ser heredado de Ser Vivo*/
            nombrePersonaje = nombre;
        }

        public Sayayin(PictureBox nuevoAspecto, string nombre) // constructor 3
        {
            /*Otra forma de construir un objeto clase "Sayayin" con dos parámetros: un objeto cualquiera tipo "PictureBox"
             * con nombre default "nuevoAspecto"; y otra variable tipo string cualquiera con nombre default "nombre" */

            aspecto = nuevoAspecto;// utiliza la variable aspecto heredada de SerVivo, ya que todo SerVivo debe tener un aspecto
            valorX = 10;
            /*Se puede utilizar "valorX" de la clase base "Sprite", por que es heredada de forma transitiva, es decir, 
             * como Sayayin hereda de SerVivo, y SerVivo hereda de Sprite; entonces, Sayayin también hereda de Sprite.
             * Es como decir: si A = B y B = C; entonces A=C. */

            valorY = 200;//coordenadas del objeto 
            valorAncho = aspecto.Width;// dimensiones del objeto
            valorAlto = aspecto.Height;
        }

        public void mover(int x, int y) // creación del método "Mover" con dos parámetros tipo entero x y y.
        {
            valorX = x;
            valorY = y;
            //Se asignan nuevas posiciones del objeto Sayayin al llamar este método con los valores de x y y.
            //Esto permite modificar variables de la clase Base Sprite.
        }
    }
}
