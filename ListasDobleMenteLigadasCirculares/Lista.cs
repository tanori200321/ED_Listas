using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobleMenteLigadasCirculares
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Lista()
        {
            nodoInicial = new Nodo();
            nodoInicial.NodoSiguiente = nodoInicial;
            nodoInicial.NodoAnterior = nodoInicial;
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.NodoSiguiente == nodoInicial);
        }
        public void Vaciar()
        {
            nodoInicial.NodoSiguiente = nodoInicial;
            nodoInicial.NodoAnterior = nodoInicial;
        }
        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.NodoSiguiente != nodoInicial)
            {
                nodoActual = nodoActual.NodoSiguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.NodoSiguiente != nodoInicial)
            {
                nodoActual = nodoActual.NodoSiguiente;
            }
            Nodo nodoNuevo = new Nodo(dato, nodoActual, nodoInicial);
            nodoActual.NodoSiguiente = nodoNuevo;
            nodoInicial.NodoAnterior = nodoNuevo;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.NodoSiguiente != nodoInicial)
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
                while (nodoBusqueda.NodoSiguiente != nodoInicial)
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

        public void BorrarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(dato);
                if (nodoActual != null)
                {
                    nodoActual.NodoAnterior.NodoSiguiente = nodoActual.NodoSiguiente;
                    nodoActual.NodoSiguiente.NodoAnterior = nodoActual.NodoAnterior;
                }
            }
        }

    }
}
