using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolesBinarios.Clases.ArbolBinario
{
    class Arbol
    {
        protected Nodo raiz;//PROPIEDAD

        public Arbol()
        {
            raiz = null;
        }

        public Arbol(Nodo valorRaiz)
        {
            this.raiz = valorRaiz;
        }

        public Nodo rizArbol()
        {
            return raiz;
        }

        bool esVacio()
        {
            return raiz == null;
        }

        public static Nodo nuevoArbol(Nodo ramaIzqda, object dato, Nodo ramaDrercha)
        {
            return new Nodo(ramaIzqda, dato, ramaDrercha);//DEVUELVE EL OBJETO NODO
        }

    }
}
