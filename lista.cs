using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLista_JPMR
{
    internal class lista
    {
        private nodo inicio;
        public lista()
        {
            inicio = null;
        }

        //Codigo para insertat nodo
        public void add(int num)
        {
            nodo nuevo = new nodo(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                nodo act = inicio;
                while(act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
            }
        }
        public void Print()
        {
            nodo act = inicio;
            if(act==null)
            {
                Console.WriteLine("La lista esta vaciaa");
            }
            else
            {
                while(act!=null)
                {
                    Console.WriteLine($"{act.Valor}");
                    act = act.Sig;
                }
            }
        }
        public int Count()
        {
            nodo act= inicio;
            int count=0;
            while(act!=null)
            {
                count++;
                act = act.Sig;
            }
            return count;
                
            //Regresa el numero de nbodos en la lista
            //Rergesa 0 si la lista esta vavcia
        }

        public int Find(int pos)
        {
            // Regresa el valor del nodo en la posicion indicada
            // La prmera poscicion es cero (como en un arreglo)
            // Si no esta la poscicion regresa -1
        }

        public int FindValue(int num)
        {
            // Regresa la posicion del nodo del valor indicado
            // La primera poscicion siempre es cero como en los arreglos
            // SI no esta el valor, regresa -1
        }

        public bool Change(int pos, int nuevoValor)
        {
            //Cambia el valor del nodo en la posicion indicada 
            // Y regresa true si el cambio fue exitoso si no encuentra
            // El nodo o la lista esta vacia 
            // Regresa false ya que el cambio no fue exitoso
            // Cambia el valor no el nodo
        }

        public bool Delete(int pos)
        {
            // Elimina el nodo en la posicion indicada 
            // y regresa true si la eliminacion fue extiso
            // Regreas false si la eliminacion no fue exitos
            // Si la lista esta vacia o no esta en la posicion
        }
        // SI utilizas count y find puedes reccorer la lisrta como en un arreglo
    }
}
