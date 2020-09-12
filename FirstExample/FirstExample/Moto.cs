using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample
{
    public class Moto : Vehiculo,IVehiculoTerrrestre
    {
        private string _cilindrada;

        public Moto(string Marca, string Modelo, string Color) 
            : base(Marca, Modelo, Color, "Vehiculo Terrestre")
        {
            _cilindrada = "125 cc";
        }

        public string EncenderLuces()
        {
           return "se encendio la luz delantera principal";
        }

        public void MejorarMoto(string cilindrada)
        {
            _cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            string data = "\n MOTO \n {\n Marca: " + Marca + "\n Modelo: " + Modelo + "\n Color: " + Color + " \n}";
            return data + "\n Datos tecnicos: \n Cilindrada: " + _cilindrada;
        }
    }
}
