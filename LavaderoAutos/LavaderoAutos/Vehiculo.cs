using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        public byte CantRuedas
        {
            get { return _cantRuedas; }
        }

        public string LaPatente
        {
            get { return _patente; }
        }

        public EMarcas LaMarca 
        {
            get { return _marca; }
        }

        public Vehiculo(string patente, EMarcas marca, byte cantidadRuedas)
        {
            this._patente = patente;
            this._marca = marca;
            this._cantRuedas = cantidadRuedas;
        }

        public Vehiculo(string patente, byte cantidadRuedas, EMarcas marca):this(patente,marca,cantidadRuedas)
        {
        }

        private string Mostrar()
        {
            return "Patente: " + this._patente + "/ Marca: " + this.LaMarca + "/ Cantidad Ruedas: " + this._cantRuedas;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            return unVehiculo._patente == otroVehiculo._patente && unVehiculo.LaMarca == otroVehiculo.LaMarca;
        }

        public static bool operator !=(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            return !(unVehiculo == otroVehiculo);
        }
    }
}
