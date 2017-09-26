using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    class Moto : Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;

        public Moto(EMarcas marca, string patente, int cilindrada, byte cantRuedas)
            : base(patente, cantRuedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar() + "Cantidad asientos: " + this._cantidadAsientos + " Tara: " + this._tara + " Cilindrada: " + this._cilindrada);
        }

    }
}
