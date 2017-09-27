using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos
{
    public class Auto:Vehiculo
    {
        private int _cantidadAsientos; 

        public Auto(string patente, EMarcas marca, int cantidadAsientos):base(patente,marca,4)
        {
            this._cantidadAsientos = cantidadAsientos;  
        }

        public override string ToString()
        {
            return base.ToString() + "/ Cantidad Asientos: " + this._cantidadAsientos + "\n";
        }


    }
}
