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
                    Console.Clear();
                    break;
            }
            }
            
        }

        public static void mostrarMenuLista() {
            Console.Clear();
            int opcion;
            String auxiliarTemporal;
            ListaEnlazada miLista = new ListaEnlazada("Numeros");
            while (true) {
                Console.WriteLine("## LISTA ENLAZADA ##");
                Console.WriteLine("1) Agregar a la lista");
                Console.WriteLine("2) Imprimir la lista");
                Console.WriteLine("3) Buscar datos");
                Console.WriteLine("4) Borrar nodo");
                auxiliarTemporal = Console.ReadLine();
                opcion = int.Parse(auxiliarTemporal);
                switch (opcion) {
                    case 1:
                        int x;
                        String xy;
                        Console.WriteLine("Numero: ");
                        xy = Console.ReadLine();
                        x = int.Parse(xy);
                        miLista.agregarNodoAlFinal(x);
                        Console.Clear();
                        break;
                    case 2:
                        miLista.imprimir();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        miLista.buscarNodo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        int y;
                        String yx;
                        Console.Write("Nodo a elminar: ");
                        yx= Console.ReadLine();
                        y = int.Parse(yx);
                        miLista.borrarNodo(y);
                        Console.ReadKey();
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

        public static void mostrarMenuCola() { 
            
        }
    }
}
