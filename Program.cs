using ProyectoArbolesBinarios.Clases.ArbolBinario;
using ProyectoArbolesBinarios.Clases.JuegoAdivina;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolesBinarios
{
    class Program
    {

        //RECORRIDOS
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquierda());
                preorden(r.subarbolDerecho());
            }
        }

        public static void inorden(Nodo r)
        {
            if (r != null)
            {
                inorden(r.subarbolIzquierda());
                r.visitar();
                inorden(r.subarbolDerecho());

            }
        }

        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierda());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }
        //FIN RECORRIDOS

        public static void arbolBasico()
        {
            try
            {
                Arbol arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack(); //TIPO DE DATO PARA APILAR ULTIMO QUE ENTRA PRIMERO EN SALIR
                a1 = Arbol.nuevoArbol(null, "Maria", null);
                a2 = Arbol.nuevoArbol(null, "Fabricio", null);
                a = Arbol.nuevoArbol(a1, "Gaby", a2);
                pila.Push(a);//aplilar

                a1 = Arbol.nuevoArbol(null, "Andrea", null);
                a2 = Arbol.nuevoArbol(null, "Abel", null);
                a = Arbol.nuevoArbol(a1, "Monica", a2);
                pila.Push(a);//apialr

                //DESAPILAR
                /*Pop() desapilando e iliminando d ela pila*/
                a2 = (Nodo)pila.Pop(); //cambiar el orden de las pilas cambia el orden de izq a der y viceversa
                a1 = (Nodo)pila.Pop();

                a = Arbol.nuevoArbol(a1, "Hector", a2);
                arbol = new Arbol(a);


                Console.WriteLine("PREORDEN");
                preorden(a);
                Console.WriteLine("\nPOSTORDEN");
                postorden(a);
                Console.WriteLine("\nINORDEN");
                inorden(a);

                //int pausa;
                //pausa = 0;

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("OPS!! Existe un error: " + ex.Message);
            }
        }

         static void juegoAdivina()
        {
            Console.WriteLine("Juguemos a adivinar algunos animales");
            Boolean otroJuego = true;
            Adivina juego = new Adivina();
          
            //ejecutarlo al menos una vez
            do
            {
                juego.jugar();
                Console.WriteLine("Jugamos otra vez");
                otroJuego = juego.respuesta();


            } while (otroJuego);
        }

        static void Main(string[] args)
        {
            //arbolBasico();

            juegoAdivina();
        }
    }
}
