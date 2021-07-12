using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class PruebaConsola
    {
        static void Main()
        {
            Console.Title = "Fabrica de Companions - Juan Ignacio Cabarcos";

            // Instanciación de Companions de cada tipo
            Cook c1 = new Cook(new List<ETarea>() { ETarea.Cocinar, ETarea.ComprarComida },
                new List<EUtensilio>() { EUtensilio.Cubiertos, EUtensilio.Ollas });
            Cook c2 = new Cook(new List<ETarea>() { ETarea.Cocinar },
                new List<EUtensilio>() { EUtensilio.Sartenes });            
            Housekeeper hk1 = new Housekeeper(new List<ETarea>() { ETarea.Barrer, ETarea.Limpiar, ETarea.Ordenar });
            Housekeeper hk2 = new Housekeeper(new List<ETarea>() { ETarea.Ordenar, ETarea.Barrer });
            Manager m1 = new Manager(new List<ETarea>() { ETarea.OrganizarGastos }, "Alto");
            Manager m2 = new Manager(new List<ETarea>() { ETarea.OrganizarGastos, ETarea.ComprarComida }, "Medio");

            // Encender la fabrica            
            Factory.EncenderFabrica(true);
            Console.WriteLine("Preparando fábrica...");
            Console.ReadKey();
            Console.Clear();

            // Agregar companions a la lista
            Factory.AgregarCompanionConsola(c1);
            Factory.AgregarCompanionConsola(c2);
            Factory.AgregarCompanionConsola(hk1);
            Factory.AgregarCompanionConsola(hk2);
            Factory.AgregarCompanionConsola(m1);
            Factory.AgregarCompanionConsola(m2);     

            // Mostrar todos los Companions
            Console.WriteLine("LISTA DE TODOS LOS COMPANIONS:\n");
            Console.WriteLine(Factory.MostrarListado<Companion>());
            Console.ReadKey();
            Console.Clear();

            // Mostrar sólo Cooks
            Console.WriteLine("COMPANIONS DEL TIPO COOK:\n");
            Console.WriteLine(Factory.MostrarListado<Cook>());
            Console.ReadKey();
            Console.Clear();

            // Mostrar sólo Housekeepers
            Console.WriteLine("COMPANIONS DEL TIPO HOUSEKEEPER:\n");
            Console.WriteLine(Factory.MostrarListado<Housekeeper>());
            Console.ReadKey();
            Console.Clear();

            // Mostrar sólo Managers
            Console.WriteLine("COMPANIONS DEL TIPO MANAGER:\n");
            Console.WriteLine(Factory.MostrarListado<Manager>());
            Console.ReadKey();
            Console.Clear();

            // Eliminar 3 companions de la lista
            Factory.EliminarCompanion(c1);
            Factory.EliminarCompanion(hk1);
            Factory.EliminarCompanion(m1);

            // Mostrar lista con los cambios realizados
            Console.WriteLine("LISTA CON CAMBIOS REALIZADOS:\n");
            Console.WriteLine(Factory.MostrarListado<Companion>());
            Console.ReadKey();


        }
    }
}
