using System;
using System.Collections.Generic;
using System.Drawing;//se pone por usar la clase Graphics, esta clase no se puede heredar
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_juego
{
    public abstract class Sprite//Clase Base ("madre") por ser abstract  Para tener orden en el programa
        /*esta clase nos permite usar valores de variables inaccesibles, para usarlas en form1, así evitamos
        que el form1 modifique las demás clases necesarias para construir el programa*/
    {
        //este constructor está implícito
        //SI ES abstract, debe haber un método tipo abstract para funcionar
        
        protected int valorX, valorY, valorAncho, valorAlto, puntajeKame, puntajeGenki, puntajeRayo, puntajeRayoGigante;
        //"protected" permite usar las variables aquí o si se heredan en otra clase

        public int X// este valor se utiliza en el form1 de forma pública
        {
            get 
           /*"get" junto con "return" (van siempre juntos), se utilizan para obtener el valor protected de "valorX" y asignarlo
            a la variable pública "X". Así, nos permite modificar y usar la variable protegida "valorX" a través de las 
            clases heredándola, y pasar el valor a "X" para ser usada en form1. Esto nos permite usar nuestra variable 
            "valorX" de forma secreta a través de clases, y valor "X" sólo obtiene el valor para ser usado en form1, ya que es 
            una variable pública. 
            /*Por ejemplo:  goku.X, utiliza X por ser pública, pero goku.valorX no se puede por ser protected, pero dicho 
            valor de valorX, se pasa a X utilizando get y return*/     
            {
                return valorX;
            }
        }

        public int Y
        {
            get
            {
                return valorY;
            }
        }

        public int Ancho
        {
            get
            {
                return valorAncho;
            }
        }

        public int Alto
        {
            get
            {
                return valorAlto;
            }
        }
        public int PuntajeKame
        {
            get
            {
                return puntajeKame;
            }
        }

        public int PuntajeGenki
        {
            get
            {
                return puntajeGenki;
            }
        }

        public int PuntajeRayo
        {
            get
            {
                return puntajeRayo;
            }
        }

        public int PuntajeRayoGigante
        {
            get
            {
                return puntajeRayoGigante;
            }
        }


        public abstract void Dibujar(Graphics escenario); /*  Se crea un método llamado "Dibujar"sin cuerpo
        (osea, que todavía no hace nada)utilizando abstract,
        usando como parámetro un objeto tipo Graphics llamado "escenario" que se puede utilizar dentro del método*/
        //el objeto "escenario" de tipo Graphics significa que se puede realizar acciones gráficas en ella
    }
}
