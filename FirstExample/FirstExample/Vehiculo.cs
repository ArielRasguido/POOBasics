using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample
{
    public abstract class Vehiculo
    {
        protected string _tipo;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public Vehiculo(string Marca, string Modelo,string Color,string _tipo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Color = Color;
            this._tipo = _tipo;
        }

        public virtual string MostrarDatos()
        {
            string data = "{ \n Marca: " + Marca + "\n Modelo: " + Modelo + "\n Color: "+Color+" \n}";
            return data;
        }

        public string InformarFallas()
        {
            return "Existe una falla";
        }


    }
}
