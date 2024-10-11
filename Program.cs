using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLista_JPMR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lista miLista = new lista();
            miLista.add(4);
            miLista.add(5);
            miLista.add(9);
            miLista.add(12);
            miLista.Print();
            Console.ReadLine();

            //Imprimir lista
            Console.WriteLine("Mi lista actual");
            miLista.Print();
            Console.ReadLine();
            //Contar los nodos 
            Console.WriteLine($"Tamaño de la lista{miLista.Count()}");
            Console.ReadLine();
        }
    }
}
