using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleMenteLigadasCirculares
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo EnlaceSiguiente { get; set; }
        public Nodo EnlaceAnterior{ get; set; }


        public Nodo(string valor = "", Nodo enlaceSiguiente = null, Nodo enlaceAnterior = null)
        {
            Valor = valor;
            EnlaceSiguiente = enlaceSiguiente;
            enlaceAnterior = enlaceAnterior;
        }
    }
}