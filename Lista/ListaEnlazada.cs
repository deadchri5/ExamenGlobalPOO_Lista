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

        public void agregarNodoAlFinal(int _dato) {
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
                Console.WriteLine($"La lista {this.nombre} esta vacia...");
            }
            else {
                Console.Write($"Lista {this.nombre}: ");
                Nodo actual = primero;
                if (actual.getNodoSiguiente() == null) {
                    Console.WriteLine(actual.getDato());
                    return;
                }
                while (actual.getNodoSiguiente() != null) {
                    Console.Write(actual.getDato() + " -> ");
                    actual = actual.getNodoSiguiente();
                    if (actual.getNodoSiguiente() == null) {
                        Console.Write(actual.getDato());
                    }
                }
            }
        }

        public void buscarNodo() {
            if (estaVacia()) {
                Console.WriteLine("Primero debes agregar elementos...");
            }
            else {
                Console.Write("Ingresa el elemento que buscas: ");
                int contador = 0;
                String line = Console.ReadLine();
                int elementoBuscado = int.Parse(line);
                Nodo actual = primero;

                //Si lista solo contiente un elemeto
                if (actual.getNodoSiguiente() == null) {
                    Console.Write($"El elemento buscado esta en la posicion: {contador}");
                }

                while (actual.getNodoSiguiente() != null) {
                    //Busco en mis elementos de la lista
                    if (actual.getDato() == elementoBuscado) {
                        Console.Write(contador);
                        Console.Write(", ");
                    }

                    actual = actual.getNodoSiguiente();
                    contador++;

                    //Busco en mi ultimo elemento de la lista (Que apunta a Null)
                    if (actual.getNodoSiguiente() == null) {
                        if (actual.getDato() == elementoBuscado) {
                            Console.Write(contador);
                        }
                    }
                    
                }
            }
        }

        public void borrarNodo(int _posicion) {
            int contador = 0;
            if (estaVacia()) {
                Console.WriteLine("No hay nodos que eliminar...");
            }
            else {
                Nodo actual = primero;
                //Borra si solo hay un nodo
                if (actual.getNodoSiguiente() == null && _posicion == 0) {
                    primero = null;
                }

                //Borra el primer nodo cuando la lista tiene mas de un elemento
                if (actual.getNodoSiguiente() != null && _posicion == 0) {
                    actual = actual.getNodoSiguiente();
                    Console.WriteLine(actual.getDato());
                    primero = actual;
                }


                while (actual.getNodoSiguiente() != null) {
                    if (_posicion+1 == contador) {
                        actual = null;
                    }
                    actual = actual.getNodoSiguiente();
                    contador++;
                }

            }
        }

    }
}
