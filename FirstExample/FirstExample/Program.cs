using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto 1
            Console.WriteLine("_______AUTO_______");
            Automovil auto = new Automovil("Mazda", "CX-3", "Negro");
            Console.WriteLine(auto.MostrarTableroDeControl());
            Console.WriteLine("El auto esta avanzando...");
            auto.Avanzar();
            Console.WriteLine(auto.MostrarTableroDeControl());

            //Auto 2
            Console.WriteLine("\n_______MOTO_______");
            Vehiculo vehiculo = new Moto("Toyota", "Yaris", "Plomo");
            Console.WriteLine(vehiculo.InformarFallas());
            Moto moto = (Moto)vehiculo;
            Console.WriteLine(moto.MostrarDatos());

            IVehiculoTerrrestre vehiculoTerrestre = new Automovil("Toyota", "Yaris", "Plomo");

            List<Vehiculo> VehiculosList = new List<Vehiculo> { };

            VehiculosList.Add(auto);
            VehiculosList.Add(moto);
            Console.WriteLine("______LISTA DE VEHICULOS_______");
            foreach (var v in VehiculosList)
            {
                Console.WriteLine("\n------------");
                Console.WriteLine(v.MostrarDatos());
                Console.WriteLine("------------\n");
            }

            Console.ReadLine();
        }
    }
}
