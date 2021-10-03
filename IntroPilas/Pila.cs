using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroPilas
{
    class Pila
    {

        static int maxpila = 5;
        public int tope;
        public int[] lista;


        public Pila()
        {
            tope = -1;
            lista = new int[maxpila];
        }

        bool vacia()
        {
            if (tope == -1)
                return true;
            else
                return false;
        }

        bool llena()
        {
            if (tope == maxpila - 1)
                return true;
            else 
                return false;

        }


        public void insertar(int elemento)
        {
            if (llena())
            MessageBox.Show("La pila esta llena no se puede insertar mas elements");
            else
            {
                tope++;
                lista[tope] = elemento;

            }
        }
         
        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("la pila esta vacia, no se uede eliminar mas elementos");
            else
            {
                MessageBox.Show("elemento eliminadod e la pila es: " + lista[tope]);
                tope--;
            }
        }

    }
}
