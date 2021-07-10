using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Fabrica de Companions - Juan Ignacio Cabarcos";

            // Instanciación de Companions de cada tipo
            Cook c1 = new Cook("C-001", new List<ETarea>() { ETarea.Cocinar, ETarea.ComprarComida },
                new List<EUtensilio>() { EUtensilio.Cubiertos, EUtensilio.Ollas });
            Cook c2 = new Cook("C-002", new List<ETarea>() { ETarea.Cocinar },
                new List<EUtensilio>() { EUtensilio.Sartenes });            
            Housekeeper hk1 = new Housekeeper("HK-001", 
                new List<ETarea>() { ETarea.Barrer, ETarea.Limpiar, ETarea.Ordenar });
            Housekeeper hk2 = new Housekeeper("HK-002", 
                new List<ETarea>() { ETarea.Ordenar, ETarea.Barrer });
            Manager m1 = new Manager("M-001", 
                new List<ETarea>() { ETarea.OrganizarGastos }, "Alto");
            Manager m2 = new Manager("M-002",
                new List<ETarea>() { ETarea.OrganizarGastos, ETarea.ComprarComida }, "Medio");

            // Agregar companions a la lista
            Factory.AgregarCompanion(c1);
            Factory.AgregarCompanion(c2);
            Factory.AgregarCompanion(hk1);
            Factory.AgregarCompanion(hk2);
            Factory.AgregarCompanion(m1);
            Factory.AgregarCompanion(m2);     

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
