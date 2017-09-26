using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    class Camion : Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;

        public Camion(float tara, Vehiculo vehiculo)
            : base(vehiculo.Patente, vehiculo.CantRuedas, vehiculo.Marca)
        {
            this._tara = tara;
        }

        void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar() + "Cantidad asientos: " + this._cantidadAsientos + " Tara: " + this._tara + " Cilindrada: " + this._cilindrada);
        }

    }
}
