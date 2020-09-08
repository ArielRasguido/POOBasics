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
            Automovil auto = new Automovil();

            Console.WriteLine(auto.MostrarTableroDeControl());
            auto.Avanzar();
            Console.WriteLine(auto.MostrarTableroDeControl());

            Vehiculo vehiculo = new Automovil();

            Console.WriteLine(vehiculo.InformarFallas());

            // Automovil auto2 = (Vehiculo)vehiculo;

            IVehiculoTerrrestre vehiculoTerrestre = new Automovil();

            Console.ReadLine();
        }
    }
}
