using System;


/*
 * Christian Yesael Ochoa Hernandez 20110469 2P
 * Clase Program (Principal)
 */


namespace Lista
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true) {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Christian Yesael Ochoa Hdez 20110469");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---- Examen POO ---");
                Console.WriteLine("1) ESTRUCTURA LISTA");
                Console.WriteLine("2) ESTRUCTURA COLA");

                int opcion = ingresarValor();

                switch (opcion) {
                    case 1:
                        mostrarMenuLista();
                    break;
                    case 2:
                        mostrarMenuCola();
                    break;
                    default:
                        Console.WriteLine("Selecciona una opcion valida....");
                        Console.ReadKey();
                    break;
                }
            }
            
        }

        public static void mostrarMenuLista() {
            Console.Clear();
            int val;
            int opcion;
            ListaEnlazada miLista = new ListaEnlazada();

            while (true) {
                Console.Clear();
                Console.WriteLine("## LISTA ENLAZADA ##");
                Console.WriteLine("1) Agregar a la lista");
                Console.WriteLine("2) Imprimir la lista");
                Console.WriteLine("3) Buscar dato(s)");
                Console.WriteLine("4) Borrar nodo");
                Console.WriteLine("5) Volver al menu principial");
                opcion = ingresarValor();
                switch (opcion) {
                    case 1:
                        Console.WriteLine("Ingresa el ENTERO que deseas agregar a la lista, de no ser entero se asignara el valor 0");
                        val = ingresarValor();
                        miLista.agregarNodo(val);
                        break;
                    case 2:
                        Console.WriteLine("Imprimir la lista.... \n");
                        miLista.imprimir(miLista);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingresa el Valor que quieres buscar (retorna posicion en lista)");
                        val = ingresarValor();
                        miLista.buscarNodo(val, miLista);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Dame la poscion del nodo:");
                        val = ingresarValor();
                        miLista.borrarNodo(val);
                        Console.WriteLine("Ok.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("La lista se ha eliminado, pulsa cualquier tecla para continuar...");
                        Console.ReadKey();
                        return;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        public static void mostrarMenuCola() {
            int val;
            int opcion;
            Cola miCola = new Cola();

            while (true) {
                Console.Clear();
                Console.WriteLine("## Menu cola ##");
                Console.WriteLine("1) Establecer tamaño");
                Console.WriteLine("2) Encolar");
                Console.WriteLine("3) Desencolar");
                Console.WriteLine("4) Imprimir");
                Console.WriteLine("5) Buscar");
                Console.WriteLine("6) Volver al menu principal");

                opcion = ingresarValor();

                switch (opcion) {
                    case 1:
                        Console.WriteLine("Asigna el tamaño de la Cola");
                        val = ingresarValor();
                        miCola.setLimiteDeDatos(val);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el ENTERO a encolar, de no ser ENTERO se encolara un '0'");
                        val = ingresarValor();
                        miCola.encolar(val);
                        break;
                    case 3:
                        Console.Write("Se ha desencolado la estructura en una poscion");
                        miCola.desencolar();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Imprimir cola... \n");
                        miCola.imprimir(miCola);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Ingresa el Valor que quieres buscar (retorna posicion en cola)");
                        val = ingresarValor();
                        miCola.buscarNodo(val, miCola);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("La Cola se ha eliminado, pulsa cualquier tecla para continuar...");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Porfavor ingrese una opcion valida");
                        Console.ReadKey();
                        break;
                }

            }
        }

        public static int ingresarValor() {
            Console.Write("---> ");
            String nuevaLinea = Console.ReadLine();
            try {
                int op = Convert.ToInt32(nuevaLinea);
                return op;
            }
            catch (Exception e) { 
                Console.WriteLine("La entrada no esta en el formato correcto.");
                Console.ReadKey();
                return 0;
            }
        }

    }
}
