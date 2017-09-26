using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    class Auto : Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;

        public Auto(int _cantidadAsientos, string _patente, EMarcas _marca)
            : base(_patente, 4, _marca)
        {
            this._cantidadAsientos = _cantidadAsientos;
        }

        void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar() + "Cantidad asientos: " + this._cantidadAsientos + " Tara: "+this._tara+" Cilindrada: "+this._cilindrada);
        }

    }
}
