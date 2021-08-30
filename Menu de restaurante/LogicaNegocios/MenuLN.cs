using Menu_de_restaurante.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_de_restaurante.LogicaNegocios
{
    public class MenuLN
    {
        public void AnadirListaSopas(MenuCN menu, String nombre, Double precio) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            SopasCN sopa = new SopasCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            sopa.Name = nombre;
            sopa.Precio = precio;
            menu.Sopas.Add(sopa);
        }
        public void AnadirListaArroces(MenuCN menu, String nombre, Double precio) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            ArrozCN arroz = new ArrozCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            arroz.Name = nombre;
            arroz.Precio = precio;
            menu.Arroces.Add(arroz);
        }


        public void AnadirListaCarnes(MenuCN menu, String nombre, Double precio, String coccion) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            CarnesCN carne = new CarnesCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            carne.Name = nombre;
            carne.Precio = precio;
            carne.Coccion = coccion;
            menu.Carnes.Add(carne);
        }


        public void AnadirListaMariscos(MenuCN menu, String nombre, Double precio) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            MariscosCN marisco = new MariscosCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            marisco.Name = nombre;
            marisco.Precio = precio;
            menu.Mariscos.Add(marisco);
        }


        public void ImprimirListaCarnes(MenuCN menu){
            // creacion de una expresion lambda con un delegado Action que indica que no va 
            //retornar ningun valor, pero si recibe un parametro.
            // El tipo de dato de los parametros de la exprexion lambda queda definido
            // implicitamente por el delegado
			Action<MenuCN> listaCarnes = menu =>
		    {
                Console.WriteLine("//////       Carnes      //////////");
                for (int i = 0; i < menu.Carnes.Count; i++)
                {
                    CarnesCN carne = menu.Carnes[i];
                    Console.WriteLine((i + 1) + ") " + carne.Name + "     $" + carne.Precio);
                }
		    };
            listaCarnes(menu);
        }
		
        public void ImprimirListaArroces(MenuCN menu){
            // creacion de una expresion lambda con un delegado Action que indica que no va 
            //retornar ningun valor, pero si recibe un parametro.
            // El tipo de dato de los parametros de la exprexion lambda queda definido
            // implicitamente por el delegado
            Action<MenuCN> listaArroces = menu =>
		    {
			    Console.WriteLine("//////       Arroces      //////////");
			    for (int i = 0; i < menu.Arroces.Count; i++)
			    {
			    	ArrozCN arroz = menu.Arroces[i];
			    	Console.WriteLine((i + 1) + ") " + arroz.Name + "     $" + arroz.Precio);
			    }
		    };
			listaArroces(menu);
		}
        public void ImprimirListaSopas(MenuCN menu){
            // creacion de una expresion lambda con un delegado Action que indica que no va 
            //retornar ningun valor, pero si recibe un parametro.
            // El tipo de dato de los parametros de la exprexion lambda queda definido
            // implicitamente por el delegado
            Action<MenuCN> listaSopas = menu =>
		    {
			    Console.WriteLine("//////       Sopas      //////////");
			    for (int i = 0; i < menu.Sopas.Count; i++)
			    {
			    	SopasCN sopa = menu.Sopas[i];
			    	Console.WriteLine((i + 1) + ") " + sopa.Name + "     $" + sopa.Precio);
			    }
		    };
			listaSopas(menu);
		}
        public void ImprimirListaMariscos(MenuCN menu){
            // creacion de una expresion lambda con un delegado Action que indica que no va 
            //retornar ningun valor, pero si recibe un parametro. 
            // El tipo de dato de los parametros de la exprexion lambda queda definido
            // implicitamente por el delegado
            Action<MenuCN> listaMariscos = menu =>
		    {
					int cont = 1;
					Console.WriteLine("//////       Mariscos      //////////");
                    // utilizamos una exprexion lambda para iterar cada elemento de una lista.
					menu.Mariscos.ForEach(marisco =>
					{
						Console.WriteLine("{0}{1}{2}", cont, ") ", marisco.Name + "      $" + marisco.Precio);
						cont++;
					});
		    };
			listaMariscos(menu);
		}
		
	}
}
