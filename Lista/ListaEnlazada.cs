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
                Console.WriteLine($"La lista {this.nombre} esta vacia...");
            }
            else {
                Console.Write($"Lista {this.nombre}: ");
                Nodo actual = primero;
                if (actual.getNodoSiguiente() == null) {
                    Console.WriteLine($"|{actual.getDato()}| -> NULL");
                    return;
                }
                while (actual.getNodoSiguiente() != null) {
                    Console.Write($" |{actual.getDato()}| ->");
                    actual = actual.getNodoSiguiente();
                    if (actual.getNodoSiguiente() == null) {
                        Console.Write($" |{actual.getDato()}| -> NULL");
                    }
                }
            }
        }

        public void buscarNodo(int _dato) {
            if (estaVacia()) {
                Console.WriteLine("Primero debes agregar elementos...");
            }
            else {
                int contador = 0;
                Nodo actual = primero;

                //Si lista solo contiente un elemeto
                if (actual.getNodoSiguiente() == null) {
                    Console.Write($"Se encontro dato en pos: {contador}");
                    return;
                }

                while (actual.getNodoSiguiente() != null) {
                    //Busco en mis elementos de la lista
                    if (actual.getDato() == _dato) {
                        Console.WriteLine($"Se encontro dato en pos: {contador}");
                    }

                    actual = actual.getNodoSiguiente();
                    contador++;

                    //Busco en mi ultimo elemento de la lista (Que apunta a Null)
                    if (actual.getNodoSiguiente() == null) {
                        if (actual.getDato() == _dato) {
                            Console.WriteLine($"Se encontro dato en pos: {contador}");
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

                //Borra si SOLO hay un nodo en la lista
                if (actual.getNodoSiguiente() == null && _posicion == 0) {
                    primero = null;
                    return;
                }

                Nodo anterior = null;
                while (actual.getNodoSiguiente() != null) {
                    if (contador == _posicion) {
                        if (contador == 0) {
                            actual = actual.getNodoSiguiente();
                            primero = actual;
                            return;
                        }
                        anterior.setNodoSiguiente(actual.getNodoSiguiente());
                        return;
                    }

                    contador++;
                    anterior = actual;
                    actual = actual.getNodoSiguiente();

                    //Si se quiere borrar el ultimo nodo
                    if (actual.getNodoSiguiente() == null && contador == _posicion) {
                        anterior.setNodoSiguiente(null);
                        return;
                    }

                }

            }
        }

        ~ListaEnlazada() { 
        
        }

    }
}
