using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolesBinarios.Clases.ArbolBinario
{
    class Nodo
    {
        public object dato;
        public Nodo izquierda;
        public Nodo derecha;

        //CONSTRUCTOR
        public Nodo(object valor)
        {
            dato = valor;
            izquierda = null;
            derecha = null;
        }

        //CONSTRUCTOR
        public Nodo(Nodo ramaIzquierda, object valor, Nodo ramaDerecha)
        {
            dato = valor;
            izquierda = ramaIzquierda;
            derecha = ramaDerecha;
        }

        public void visitar()
        {
            Console.WriteLine(dato + "<->");
        }

        public object valorNodo()
        {
            return dato;
        }

        public Nodo subarbolDerecho()
        {
            return derecha;
        }

        public Nodo subarbolIzquierda()
        {
            return izquierda;
        }

        public void nuevoValor(object nw)
        {
            dato = nw;
        }

        public void ramaIZQ(Nodo n)
        {
            izquierda = n;
        }

        public void ramaDER(Nodo n)
        {
            derecha = n;
        }

    }
}
