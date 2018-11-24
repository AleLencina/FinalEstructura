using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace FinalEstructura
{
    class Program 
    {
        static void Main(string[] args)
        {
            string me;
            int indice = 1;

            Queue cola = new Queue();
            ArrayList array = new ArrayList(cola.Count);
            array.Add("hola");
            cola.Enqueue("1");
            menu();

            void menu()
            {
                // SE MUESTRA EN PANTALLA ENCABEZADO Y MENU
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     \n                   ================================================================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                      ░▒▓||||     ** FINAL - ESTRUCTURA DE DATOS   **   ||||▓▒░ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                   ================================================================ \n\n\n");

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(" SELECCIONE UNA OPCION: ");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("                             1) CREAR COLA.");
                Console.WriteLine("                             2) BORRAR COLA. ");
                Console.WriteLine("                          -  3) CREAR TXT COLA. ");
                Console.WriteLine("                             4) AGREGAR PEDIDO. ");
                Console.WriteLine("                             5) BORRAR PEDIDO. ");
                Console.WriteLine("                          -  6) BUSCAR PEDIDO. ");
                Console.WriteLine("                             7) LISTAR TODOS LOS PEDIDOS. ");
                Console.WriteLine("                             8) LISTAR ULTIMO PEDIDO. ");
                Console.WriteLine("                             9) LISTAR PRIMER PEDIDO. ");
                Console.WriteLine("                             10) CANTIDAD DE PEDIDOS. \n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                             s) SALIR. \n\n");



                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("             ->>  ");

                me = Console.ReadLine();

                // SE ENVIA EL NRO ELEGIDO DEL MENU AL SWITCH Y SE EJECUTA EL BLOQUE
                switch (me)
                {
                    case "1":
                        crearCola();
                        break;
                    case "2":
                        borrarCola();
                        ; break;
                    case "3":
                        txt();
                        break;

                    case "4":
                        agregar();
                        break;
                    case "5":
                        borrarPedido();
                        break;
                    case "6":
                        buscar();
                        break;
                    case "7":
                        listarTodos();
                        break;
                    case "8":
                        listarUltimo();
                        break;
                    case "9":
                        listarPrimero();
                        break;
                    case "10":
                        cantidad();
                        break;
                    case "s":
                        salir();
                        break;

                }
                void crearCola()
                {
                    try
                    {
                        //comprobar que el objeto este creado
                        if (cola.Count != 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n * Ya hay una COLA creada. *\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("PRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                            Console.ReadKey();
                            menu();

                        }
                        else
                        {
                            Queue newCola = new Queue();
                            Console.WriteLine("\n\n El contenedor COLA se creo correctamente!");
                            Console.ReadKey();
                            menu();

                        }
                    
                    }   
                    catch
                    {

                    }
                
                }
                void borrarCola()
                {
                    string a;
                    Console.Clear();
                    Console.WriteLine(" /n              -- BORRAR COLA. -- \n\n");
                    Console.WriteLine(" Desea BORRAR todos los elementos del contenedor COLA !?\n\n ");
                    Console.WriteLine(" SI (s) / NO (n) :    ");

                    a = Console.ReadLine();

                    if (a == "s")
                    {
                        try
                        {
                            cola.Clear();

                            Console.WriteLine("/n El contenido de la cola se borro CORRECTAMENTE! \n\n");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n PRESIONE [ ENTER ] PARA VOLVER AL MENU PRINCIPAL \n\n");
                            menu();
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("/n No hay una cola creada por lo tanto no hay nada para borrar.");
                            Console.ReadKey();
                            menu();
                        }
                    }

                }
                void txt()
                {
                    List<string> list = new List<string>();
                    
                    Console.Clear();
                    Console.WriteLine("\n <>   SU ARCHIVO TXT SE GENERO CORRECTAMENTE! \n");

                    using (StreamWriter outputfile = new StreamWriter("C:\\Users\\Kamui\\Desktop\\EstructuraFinal.txt"))
                    {
                        /*foreach(int a in cola)
                        {
                             list.Add(Convert.ToString(a));
                        }*/

                        foreach (var b in cola)
                        {
                            outputfile.WriteLine(Convert.ToString(b));
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                    Console.ReadKey();
                    menu();


                }
                void agregar()
                {
                    Console.Clear();

                    int pedido;
                    string r;
                    Console.WriteLine("\n\n INGRESE EL NRO DEL PEDIDO QUE DESEA AGREGAR: \n\n");
                    pedido = int.Parse(Console.ReadLine());

                   if (pedido > 0 && pedido < 999)
                   {
                        Console.Clear();
                        cola.Enqueue(pedido);

                        Console.WriteLine("\n\n El pedido se ingreso correctamente !\n\n");
                        Console.WriteLine("Desea ingresar otro pedido?   \n    SI (s) - NO (n): \n\n");
                        r = Console.ReadLine();

                        if (r == "s")
                        {
                            Console.Clear();
                            agregar();
                        }
                        else
                        {
                            menu();
                        }
                   }
                   else
                   {
                        Console.Clear();
                        Console.WriteLine("* SU NUMERO DE PEDIDO NO CUMPLE CON LOS REQUISITOS. \n - DEBE ESTAR ENTRE EL 0 Y EL 999.");
                        Console.ReadKey();
                        agregar();
                   }
                
                    Console.ReadKey();
                    
                }
                void borrarPedido()
                {
                    int borrar;
                    
                    Console.Clear();
                    Console.WriteLine("\n\n INGRESE EL NUMERO DE PEDIDO QUE DESEA BORRAR: ");
                    borrar =int.Parse( Console.ReadLine());

                    if (cola.Contains(borrar))
                    {
                        
                        foreach (var i in cola)
                            array.Add(i);
                            
                        array.Remove(borrar);

                        foreach (var a in array)
                            cola.Enqueue(a);

                        Console.WriteLine("\n\n SU PEDIDO HA SIDO BORRADO CORRECTAMENTE DEL CONTENEDOR.\n\n");

                    }
                    else
                    {
                        Console.WriteLine("\n\n EL PEDIDO QUE SELECCIONO PARA BORRAR NO SE ENCUENTRA EN EL CONTENEDOR.");

                    }


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                    Console.Read();
                    menu();


                }
                void buscar()
                {
                    int pedido;

                    Console.Clear();
                    Console.WriteLine("\n Ingrese en numero de PEDIDO que desea buscar: ");
                    pedido = int.Parse(Console.ReadLine());

                    try
                    {
                        if (cola.Contains(pedido))
                        {
                            Console.WriteLine(" <>  Su numero de PEDIDO: " + pedido + " se encuentra en la cola!");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                            Console.Read();
                            menu();
                        }
                        else
                        {
                            Console.WriteLine(" <>  Su numero de PEDIDO no se encuentra en la cola");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                            Console.Read();
                            menu();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ocurrio un error al buscar en el contenedor, tal vez la Cola no este creada correctamente.");
                    }



                }
                void listarTodos()
                {
                    
                    Console.Clear();
                
                    if (cola.Count > 0)
                    {
                        Console.WriteLine("Su contenedor tiene los siguientes PEDIDOS: \n");

                        
                        foreach (var itm in cola)
                            Console.Write("\n"  + indice++ + " - " + itm);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                        Console.ReadKey();
                        menu();

                    }
                    else
                    {
                        Console.WriteLine(" Su Contenedor no tiene elementos.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                        Console.Read();
                        menu();

                    }

                }
                void listarUltimo()
                {
                    int ultimo;
                    ultimo = cola.Count - 1;

                    foreach (var i in cola)
                        array.Add(i);

                    Console.Clear();
                    Console.WriteLine("\n\n EL ULTIMO VALOR DE LA COLA ES: " + array[ultimo]);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                    Console.Read();
                    menu();

                }
                void listarPrimero()
                {
                    Console.Clear();
                    Console.WriteLine(" EL PRIMER VALOR DE LA COLA ES: \n\n" + cola.Peek());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nPRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                    Console.Read();
                    menu();

                }
                void cantidad()
                {
                    Console.Clear();
                    Console.WriteLine("\n\n   <>  Su contenedor contiene: " + cola.Count + " PEDIDO/S \n\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" PRESIONE [ENTER] PARA VOLVER AL MENU PRINCIPAL.");
                    Console.ReadKey();
                    menu();

                }
                void salir()
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("SALIENDO ...");
                    Console.ReadKey();
                }
            }
        }
    }
}
