using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos
{
    public class Moto:Vehiculo
    {
        protected float _cilindrada;

        public Moto(EMarcas marca, string patente, float cilindrada, byte cantidadRuedas)
            : base(patente, marca, cantidadRuedas)
        {
            this._cilindrada = cilindrada;  
        }

        public override string ToString()
        {
            return base.ToString() + "/ Cilindrada: " + this._cilindrada + "\n";
        }
    }
}
