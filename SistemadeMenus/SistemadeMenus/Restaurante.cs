using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeMenus
{
    internal class Restaurante
    {
        static void Main(String[] arg)
        {
            #region atributos
            int _numeroMesa;
            float _cuenta;
            float _totalPagar;
            string nombre;
            string descripcion;
            float precio;
            int opcion;
            Menu _plato = new Menu();


            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("opcion 1: Desea ver el menu?");
            Console.WriteLine("opcion 2: Desea agregar un  nuevo plato al menu?");
            Console.WriteLine("opcion 3: Desea eliminar un plato del menu?");
            Console.WriteLine("opcion 4: Desea actualizar el precio de algun plato en el menu?");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    _plato.mostrarMenu();
                    break;

                case 2:
                    Console.WriteLine("opcion 2: agregar un  nuevo plato al menu?");
                    Console.WriteLine("porfavor indique nombre, descripcion y precio del nuevo plato porfavor");
                    nombre = Console.ReadLine();
                    descripcion = Console.ReadLine();
                    precio = Convert.ToInt32(Console.ReadLine());
                    _plato.agregarPlato(nombre,descripcion,precio);
                    break;

                case 3:
                    Console.WriteLine("opcion 3: eliminar un plato del menu?");
                    Console.WriteLine("Indique acontinuacion el plato que desea retirar del menu actual");
                    nombre = Console.ReadLine();
                    _plato.removerPlato(nombre);
                    break;

                case 4:
                    Console.WriteLine("opcion 4: actualizar el precio de algun plato en el menu?");
                    Console.WriteLine("por favor ingrese el nombre del plato");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Acontinuacion ingrese el nuevo valor del plato");
                    precio= Convert.ToInt32(Console.ReadLine());
                    _plato.actualizarPLato(nombre,precio);
                    break;


            }
















        }
    }
}
#endregion