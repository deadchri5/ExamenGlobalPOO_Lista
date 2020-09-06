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

        public ListaEnlazada() {
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

        public void imprimir(Object tipo) {
            String tipoEstructura = "";
            Nodo actual = null;

            if (tipo.GetType() == typeof(Cola)){
                Cola nueva = (Cola)tipo;
                actual = nueva.getNodoPrincipio();
                tipoEstructura = "Cola: ";
            }

            if (tipo.GetType() == typeof(ListaEnlazada)){
                actual = primero;
                tipoEstructura = "Lista: ";
            }

            if (actual == null) {
                Console.WriteLine($"La lista esta vacia...");
            }
            else {
                Console.Write(tipoEstructura);
                if (actual.getNodoSiguiente() == null) {
                    Console.WriteLine($"|{actual.getDato()}|");
                    return;
                }
                while (actual.getNodoSiguiente() != null) {
                    Console.Write($" |{actual.getDato()}| ->");
                    actual = actual.getNodoSiguiente();
                    if (actual.getNodoSiguiente() == null) {
                        Console.Write($" |{actual.getDato()}|");
                    }
                }
            }
        }

        public void buscarNodo(int _dato, Object tipo) {
            Nodo actual = null;
            int contador = 0;

            if (tipo.GetType() == typeof(Cola)) {
                Cola nueva = (Cola)tipo;
                actual = nueva.getNodoPrincipio();
            }

            if (tipo.GetType() == typeof(ListaEnlazada)) {
                actual = primero;
            }

            //Compruebo que mi nodo no este vacio para poder continuar
            if (actual == null) {
                return;
            }

            //Si lista solo contiente un elemeto
            if (actual.getNodoSiguiente() == null && actual.getDato() == _dato) {
                Console.Write($"Se encontro dato en pos: {contador}");
                return;
            }

            //Busco en mis elementos de la lista
            while (actual.getNodoSiguiente() != null) {
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
