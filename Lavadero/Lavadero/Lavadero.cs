﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    class Lavadero
    {
        protected List<Vehiculo> _vehiculos;
        protected static float _precioAuto;
        protected static float _precioCamion;
        protected static float _precioMoto;
        protected string _razonSocial;

        public float PrecioAuto
        {
            get
            {
                return _precioAuto;
            }
        }
        public float PrecioCamion
        {
            get
            {
                return _precioCamion;
            }
        }
        public float PrecioMoto
        {
            get
            {
                return _precioMoto;
            }
        }

        private Lavadero()
        {
            Random rnd = new Random();
            _precioAuto = rnd.Next(150, 565);
            _precioCamion = rnd.Next(150, 565);
            _precioMoto = rnd.Next(150, 565);
            List<Vehiculo> list = new List<Vehiculo>();
        }

        public List<Vehiculo> Vehiculo
        {
            get { return this._vehiculos; }
        }

        private float MostrarTotalFacturado(EVehiculos vehiculos)
        {
            float calculoGananciasAuto = 0;
            float calculoGananciasCamion = 0;
            float calculoGananciasMoto = 0;
            foreach (Vehiculo unVehiculo in this.Vehiculo)
            {
                if (unVehiculo is Auto)
                {
                    calculoGananciasAuto += this.PrecioAuto;
                    //((Auto)unVehiculo).;
                }
                else if (unVehiculo is Camion)
                    {
                        calculoGananciasCamion += this.PrecioCamion;
                    //((Camion)unVehiculo).;
                    }
                else if (unVehiculo is Moto)
                {
                    calculoGananciasMoto += this.PrecioMoto;
                    //((Moto)unVehiculo).;
                }
            }
            switch (vehiculos)
            {
                case EVehiculos.Auto:
                    return calculoGananciasAuto;
                case EVehiculos.Camion:
                    return calculoGananciasCamion;
                case EVehiculos.Moto:
                    return calculoGananciasMoto;
/*                case EVehiculos.Todas:
                    return calculoGananciasAuto + calculoGananciasCamion + calculoGananciasMoto;*/
            }
            return 0;
        }


        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            foreach(Vehiculo veh in lavadero.Vehiculo)
            {
                if(veh == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            foreach (Vehiculo veh in lavadero.Vehiculo)
            {
                if (veh == vehiculo)
                {
                    return false;
                }
            }
            return true;
        }

        public static Lavadero operator +(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            if ((unLavadero == unVehiculo) < 0)
            {
                unLavadero._vehiculos.Add(unVehiculo);
            }
            return unLavadero;
        }

        public static Lavadero operator -(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            if ((unLavadero == unVehiculo) >= 0)
            {
                unLavadero._vehiculos.RemoveAt((unLavadero == unVehiculo));
            }
            return unLavadero;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            return string.Compare(unVehiculo.Patente, otroVehiculo.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            return string.Compare(unVehiculo.Marca.ToString(), otroVehiculo.Marca.ToString());
        }

    }
}
