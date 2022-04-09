using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    public class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            this.nodoActual = new Nodo();
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.Enlace == null);
        }
        public void Vaciar()
        {
            nodoInicial.Enlace = null;
        }

        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual != null)
            {
                nodoActual = nodoActual.Enlace;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
    }
}
