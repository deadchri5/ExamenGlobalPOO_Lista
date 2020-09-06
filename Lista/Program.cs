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
            String line;
            char opcion;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Christian Yesael Ochoa Hdez 20110469");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---- Examen POO ---");
            Console.WriteLine("a) ESTRUCTURA LISTA");
            Console.WriteLine("b) ESTRUCTURA COLA");
            line = Console.ReadLine();
            opcion = char.Parse(line);

            switch (opcion) {
                case 'a':
                    mostrarMenuLista();
                    break;
                case 'b':
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
            int opcion;
            String auxiliarTemporal;
            ListaEnlazada miLista = new ListaEnlazada();
            while (true) {
                Console.Clear();
                Console.WriteLine("## LISTA ENLAZADA ##");
                Console.WriteLine("1) Agregar a la lista");
                Console.WriteLine("2) Imprimir la lista");
                Console.WriteLine("3) Buscar datos");
                Console.WriteLine("4) Borrar nodo");
                auxiliarTemporal = Console.ReadLine();
                opcion = int.Parse(auxiliarTemporal);
                switch (opcion) {
                    case 1:
                        String line = Console.ReadLine();
                        int x = Convert.ToInt32(line);
                        miLista.agregarNodo(x);
                        Console.ReadKey();
                        break;
                    case 2:
                        miLista.imprimir(miLista);
                        Console.ReadKey();
                        break;
                    case 3:
                        miLista.buscarNodo(5, miLista);
                        Console.ReadKey();
                        break;
                    case 4:
                        //miLista.borrarNodo(y);
                        break;
                    default:
                        Console.WriteLine("Porfavor ingrese una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        public static void mostrarMenuCola() {
            Console.Clear();
            Cola miCola = new Cola();
            while (true) { 
                Console.WriteLine("## Menu cola ##");
                Console.WriteLine("1) Establecer tamaño");
                Console.WriteLine("2) Encolar");
                Console.WriteLine("3) Desencolar");
                Console.WriteLine("4) Imprimir");
                Console.WriteLine("5) Buscar");

                String line = Console.ReadLine();
                int op = Convert.ToInt32(line);

                switch (op) {
                    case 1:
                        Console.Write("Ingresa el tamaño de la cola: ");
                        String line1 = Console.ReadLine();
                        int op1 = Convert.ToInt32(line1);
                        miCola.setLimiteDeDatos(op1);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Ingresa dato: ");
                        String line2 = Console.ReadLine();
                        int op2 = Convert.ToInt32(line2);
                        miCola.encolar(op2);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        miCola.desencolar();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        miCola.imprimir(miCola);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        miCola.buscarNodo(5, miCola);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Porfavor ingrese una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
