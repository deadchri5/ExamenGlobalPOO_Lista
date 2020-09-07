using System;
using System.Collections.Generic;
using System.Text;

/*
 * Christian Yesael Ochoa Hernandez 20110469 
 * Clase Cola (Hereda de clase ListaEnlazada)
 */

namespace Lista
{
    class Cola : ListaEnlazada {

        private Nodo principio;
        private Nodo final;
        private int limiteDeDatos;
        private int contador = 0;

        //Por defecto las colas son de tamaño 10
        public Cola() {
            this.principio = null;
            this.final = null;
            this.limiteDeDatos = 10;
        }

        public Cola(int _limite) {
            this.limiteDeDatos = _limite;
            this.principio = null;
            this.final = null;
        }

        public bool colaVacia() {
            return final == null;
        }

        public void encolar(int _dato) {
            if (colaVacia()) {
                contador++;
                principio = new Nodo(_dato);
                final = principio;
            }
            else {
                if (contador == this.limiteDeDatos) {
                    Console.WriteLine($"Haz llegado al limite de datos que admite la cola ({contador})");
                    Console.ReadLine();
                    return;
                }
                else {
                    Nodo nuevo = new Nodo(_dato);
                    if (principio != final) {
                        nuevo.setNodoSiguiente(principio);
                        principio = nuevo;
                        contador++;
                        return;
                    }
                    principio = nuevo;
                    nuevo.setNodoSiguiente(final);
                }
            }
        }

        public void desencolar() {
            if (colaVacia()) {
                Console.WriteLine("La cola esta vacia...");
            }
            else {
                Nodo actual = principio;
                Nodo anterior = null;

                if (actual.getNodoSiguiente() == null) {
                    principio = null;
                    final = null;
                    contador = 0;
                    return;
                }

                while (actual.getNodoSiguiente() != null) {
                    anterior = actual;
                    actual = actual.getNodoSiguiente();
                    if (actual.getNodoSiguiente() == null) {
                        contador--;
                        anterior.setNodoSiguiente(null);
                    }
                }
            }

        }
        //Set y get
        public void setNodoPrincipio(Nodo _principio) {
            this.principio = _principio;
        }
        public Nodo getNodoPrincipio() {
            return this.principio;
        }
       
        public void setNodoFinal(Nodo _final) {
            this.final = _final;
        }

        public Nodo getNodoFinal() {
            return this.final;
        }

        public void setLimiteDeDatos(int _limite) {
            this.limiteDeDatos = _limite;
            Console.WriteLine($"Hora el limite es {_limite}");
        }

        public int getLimiteDeDatos() {
            return this.limiteDeDatos;
        }

        ~Cola() { 
        
        }
    }
}
