using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobleMenteLigadasCirculares
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo NodoAnterior { get; set; }
        public Nodo NodoSiguiente { get; set; }

        public Nodo(string valor = "", Nodo anterior = null, Nodo siguiente = null)
        {
            Valor = valor;
            NodoAnterior = anterior;
            NodoSiguiente = siguiente;
        }
    }
}
