using Menu_de_restaurante.CapaNegocios;
using Menu_de_restaurante.LogicaNegocios;
using System;

namespace Menu_de_restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuLN logicaMenu = new MenuLN();
            MenuCN menu1 = new MenuCN(); //Aplicamos el patron de diseño "Abstract Factory", ya que estamos creando una interfaz que se muestre por pantalla el "Menu 1" //
            String[] nombresSopas = { "Sopa de Camaron", "Sopa de Pollo", "Sopa de Carne", "Sopa de Queso" }; // aqui estamos creando familias de objetos relacionados sin especificar el nombre de la clase//
            Double[] preciosSobas = { 2.50, 1.50, 2, 1 };
            for (int i = 0; i < nombresSopas.Length; i++)
            {
                logicaMenu.AnadirListaSopas(menu1, nombresSopas[i], preciosSobas[i]);
            }


            String[] nombresArroces = { "Arroz Colorado", "Chaulafan", "Arroz Blanco", "Arroz Sopudo" };
            Double[] preciosArroces = { 3, 4, 1.50, 1.25 };
            for (int i = 0; i < nombresArroces.Length; i++)
            {
                logicaMenu.AnadirListaArroces(menu1, nombresArroces[i], preciosArroces[i]);
            }


            String[] nombresCarnes = { "Carne de Res", "Carne de Cerdo", "Carnde de Chivo" };
            String[] coccionCarnes = { "Asado Termino Medio", "Asado", "Asado" };
            Double[] preciosCarnes = { 3, 5, 3.50 };
            for (int i = 0; i < nombresCarnes.Length; i++)
            {
                logicaMenu.AnadirListaCarnes(menu1, nombresCarnes[i], preciosCarnes[i], coccionCarnes[i]);
            }

            MenuCN menu2 = new MenuCN(); //Aplicamos el patron de diseño "Abstract Factory", para mostrar en la interfaz "Menu 2 " 
            String[] nombresSopas2 = { "Sopa de Espinacas", "Sopa de Brocoli", "Sopa de Zanahoria" }; // aqui estamos creando familias de objetos relacionados sin especificar el nombre de la clase//
            Double[] preciosSobas2 = { 3.50, 2.50, 3 };
            for (int i = 0; i < nombresSopas2.Length; i++)
            {
                logicaMenu.AnadirListaSopas(menu2, nombresSopas2[i], preciosSobas2[i]);
            }


            String[] nombresArroces2 = { "Arroz Blanco", "Arroz Integral" };
            Double[] preciosArroces2 = { 3, 5 };
            for (int i = 0; i < nombresArroces2.Length; i++)
            {
                logicaMenu.AnadirListaArroces(menu2, nombresArroces2[i], preciosArroces2[i]);
            }


            String[] nombreMariscos = { "Pescado", "Camaron", "Pulpo", "Calamar" };
            Double[] precioMariscos = { 3, 5, 3.50, 3.50 };
            for (int i = 0; i < nombreMariscos.Length; i++)
            {
                logicaMenu.AnadirListaMariscos(menu2, nombreMariscos[i], precioMariscos[i]);
            }
            startApp(menu1,menu2 );
        }

        static void startApp(MenuCN menu1, MenuCN menu2) { //Gracias al patron de diseño "Abstract Factory" hemos conseguido una interfaz de conjuntos de objetos//
            MenuLN logicaMenu = new MenuLN();
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Este es el menu digital del restaurante 3A");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("Seleccione un Menú de la lista");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("/////////////     Menus      //////////////");
            Console.WriteLine("/////////////    1) Menu 1      //////////////");
            Console.WriteLine("/////////////    2) Menu 2     //////////////");
            Console.WriteLine("/////////////    3) Salir     //////////////");
            String respuesta = Console.ReadLine();

            // Declararar una funcion lambda con el delegado Predicate indicando que nos va a retornar un valor booleano, sabiendo que un delegado es una funcion anonima
			Predicate<string> validate1 = n => n.Equals("1");
			Predicate<string> validate2 = n => n.Equals("2");

			if (validate1(respuesta))
            {
                Console.Clear();
                // creacion de una expresion lambda con un delegado Action que indica que no va 
                //retornar ningun valor, pero si recibe un parametro.
                // El tipo de dato de los parametros de la exprexion lambda queda definido
                // implicitamente por el delegado, sabiendo que un delegado es una una funcion anonima
				Action<MenuCN> imprimirMenu1 = menu =>
				{
				    Console.WriteLine("///// Este es el menu 1 /////////");
                    logicaMenu.ImprimirListaSopas(menu);
                    Console.WriteLine("");
                    logicaMenu.ImprimirListaArroces(menu);
                    Console.WriteLine("");
                    logicaMenu.ImprimirListaCarnes(menu);
                    Console.WriteLine("");
				};
				imprimirMenu1(menu1);
			}
            else
            {
                if (validate2(respuesta))
                {
                    Console.Clear();
                    // creacion de una expresion lambda con un delegado Action que indica que no va 
                    //retornar ningun valor, pero si recibe un parametro.
                    // El tipo de dato de los parametros de la exprexion lambda queda definido
                    // implicitamente por el delegado, sabiendo que un deleado es una funcion anonima
					Action<MenuCN> imprimirMenu2 = menu =>
					{
                        Console.WriteLine("///// Este es el menu 2 /////////");
                        logicaMenu.ImprimirListaSopas(menu);
                        Console.WriteLine("");
                        logicaMenu.ImprimirListaArroces(menu);
                        Console.WriteLine("");
                        logicaMenu.ImprimirListaMariscos(menu);
                        Console.WriteLine("");
					};
					imprimirMenu2(menu2);
				}
                else {
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Presione una tecla para volver");
            Console.ReadKey();
            Console.Clear();
            startApp(menu1,menu2);
        }
    }
}
