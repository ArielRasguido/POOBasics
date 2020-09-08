using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample
{
    public class Automovil : Vehiculo, IVehiculoTerrrestre
    {
        private int _kilometraje;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public Automovil()
        {
            _kilometraje = 0;
            _tipo = "Vehiculo Terrestre";
        }


        public void Avanzar()
        {
            _kilometraje++;
        }

        public void Parar()
        {

        }

        public string MostrarTableroDeControl()
        {
            return "El vehiculo tiene un kilometraje de: " + _kilometraje + " KM.";
        }


        public void TocarBocina()
        {

        }

        public string EncenderLuces()
        {
            return "Luces prendidas";
        }
    }
}
