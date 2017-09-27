using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos
{
    public class Camion:Vehiculo
    {
        protected float _tara;

        public Camion(Vehiculo unCamion, float tara):base(unCamion.LaPatente,unCamion.LaMarca,unCamion.CantRuedas)
        {
            this._tara = tara;  
        }

        public override string ToString()
        {
            return base.ToString()+"/ Tara: "+this._tara+"\n";
        }
    }
}
