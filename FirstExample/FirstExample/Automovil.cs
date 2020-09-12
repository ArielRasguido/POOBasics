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
        private int _combustible;

        public Automovil(string Marca, string Modelo, string Color)
            :base(Marca,Modelo,Color, "Vehiculo Terrestre")
        {
            _kilometraje = 0;
            _combustible = 100;
        }

        public void Avanzar()
        {
            _kilometraje++;
            _combustible--;
        }

        public string Parar()
        {
            return "El auto se detuvo";
        }

        public string MostrarTableroDeControl()
        {
            string title = "Tablero de control:\n";
            string info = " El vehiculo tiene un kilometraje de: " + _kilometraje + " KM. \n Le queda el " + _combustible + "% de combustible.";
            return title + info;
        }

        public string TocarBocina()
        {
            return "La bocina esta sonando..";
        }

        public override string MostrarDatos()
        {
            string data = "\n AUTO \n{\n Marca: " + Marca + "\n Modelo: " + Modelo + "\n Color: " + Color + " \n}";
            return data + "\n Datos tecnicos: \n Kilometraje: " + _kilometraje + " Combustible: " + _combustible;
        }

        public string EncenderLuces()
        {
            return "Luces prendidas";
        }
    }
}
