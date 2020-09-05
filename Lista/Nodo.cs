using System;
using System.Collections.Generic;
using System.Text;


/*
 * Christian Yesael Ochoa Hernández 20110469 2P 
 * Clase Nodo
 */

namespace Lista
{
    class Nodo {
        private int dato;
        private Nodo siguiente;

        public Nodo(int _dato) {
            this.dato = _dato;
            this.siguiente = null;
        }

        public Nodo(int _dato, Nodo _siguiente) {
            this.dato = _dato;
            this.siguiente = _siguiente;
        }

        //Metodos set y get
        public void setNodoSiguiente(Nodo _siguiente) {
            this.siguiente = _siguiente;
        }

        public Nodo getNodoSiguiente() {
            return this.siguiente;
        }

        public void setDato(int _dato) {
            this.dato = _dato;
        }

        public int getDato() {
            return this.dato;
        }

        ~Nodo() {
        }
    }
}
