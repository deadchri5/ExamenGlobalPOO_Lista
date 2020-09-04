using System;
using System.Collections.Generic;
using System.Text;

/*
 * Christian Yesael Ochoa Hernandez 20110469 2P
 * Clase ListaEnlazada
 */

namespace Lista 
{
    class ListaEnlazada {
        private Nodo primero;
        private String nombre;

        public ListaEnlazada() {
            this.nombre = "Nueva lista";
            this.primero = null;
        }

        public ListaEnlazada(String _nombre) {
            this.nombre = _nombre;
            this.primero = null;
        }

        public bool estaVacia() {
            return primero == null;
        }

        public void agregarNodo(int _dato) {
            if (estaVacia()){
                primero = new Nodo(_dato);
            }
            else {
                Nodo nuevo = new Nodo(_dato);
                Nodo actual = primero;
                while (actual.getNodoSiguiente() != null) {
                    actual = actual.getNodoSiguiente();
                }
                actual.setNodoSiguiente(nuevo);
            }
        }

        public void imprimir() {
            if (estaVacia()) {
                Console.WriteLine("La lista " + this.nombre + " esta vacia....");
            }
            else {
                Console.WriteLine("Lista "+ this.nombre + " :");
                Nodo actual = primero;
                if (actual.getNodoSiguiente() == null) {
                    Console.WriteLine(actual.getDato());
                    return;
                }
                while (actual.getNodoSiguiente() != null) {
                    Console.WriteLine(actual.getDato() +"\r");
                    actual = actual.getNodoSiguiente();
                    if (actual.getNodoSiguiente() == null) {
                        Console.WriteLine(actual.getDato()+"\r");
                    }
                }
            }
        }
    }
}
