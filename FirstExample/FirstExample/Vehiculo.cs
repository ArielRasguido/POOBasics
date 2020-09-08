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

        protected void Mover()
        {

        }

        public string InformarFallas()
        {
            return "Exite una falla";
        }

     

    }
}
