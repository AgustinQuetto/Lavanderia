using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        public string Patente
        {
            get
            {
                return this._patente;
            }

        }

        public byte CantRuedas
        {
            get
            {
                return this._cantRuedas;
            }
        }

        public EMarcas Marca
        {
            get
            {
                return this._marca;
            }
        }

        public Vehiculo(string _patente, byte _cantRuedas, EMarcas _marca)
        {
            this._patente = _patente;
            this._cantRuedas = _cantRuedas;
            this._marca = _marca;
        }

        protected string Mostrar()
        {
            return "Patente: " + this._patente + " | Ruedas: " + this._cantRuedas + " | Marca: " + this._marca;
        }

        public override string ToString()
        {
            return base.ToString();
        }


        public int OrdenarVehiculosPorPatente(Vehiculo uno, Vehiculo dos)
        {
            if (String.Compare(uno.Patente, dos.Patente))
                return 1;
            else if (uno.Patente.Length < dos.Patente.Length)
                return -1;
            else
                return 0;
        }


        public bool operator ==(Vehiculo uno, Vehiculo dos)
        {

            if (uno == dos)
            {
                return true;
            }
            return false;
        }

        public void operator +(Lavadero lav, Vehiculo veh) { 
            if(!lav.Vehiculo.Contains(veh){
               lav.Vehiculo.Add(veh);
            }
        }

        public void operator -(Lavadero lav, Vehiculo veh) { 
            if(lav.Vehiculo.Contains(veh){
               lav.Vehiculo.Remove(veh);
            }
        }

    }
}
