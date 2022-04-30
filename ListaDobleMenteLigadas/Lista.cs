using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleMenteLigadas
{
    public class Lista //Constructor//
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            this.nodoInicial = new Nodo();
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.NodoAnterior == null);
            return (nodoInicial.NodoSiguiente == null);
        }
        public void Vaciar()
        {
            nodoInicial.NodoSiguiente = null;
        }

        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.NodoSiguiente != null)
            {
                nodoActual = nodoActual.NodoSiguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.NodoSiguiente != null)
            {
                nodoActual = nodoActual.NodoSiguiente;
            }
            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.NodoSiguiente = nodoNuevo;
            nodoNuevo.NodoAnterior = nodoActual;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda != null)
                {
                    nodoBusqueda = nodoBusqueda.NodoSiguiente;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }


            }
            return null;
        }
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.NodoSiguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.NodoSiguiente;
                    Indice++;
                    if (Indice == indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarAnterior(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.NodoSiguiente != null && nodoBusqueda.NodoSiguiente.Valor != dato)
                {
                    nodoBusqueda = nodoBusqueda.NodoSiguiente;
                    if (nodoBusqueda.NodoSiguiente.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public void BorrarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(dato);
                if (nodoActual != null)
                {
                    Nodo nodoAnterior = BuscarAnterior(dato);
                    nodoAnterior.NodoSiguiente = nodoActual.NodoSiguiente;
                    nodoActual.NodoSiguiente = null;
                    nodoActual.NodoAnterior = null;
                    nodoActual.Valor = null;
                }
            }
        }



    }

}
