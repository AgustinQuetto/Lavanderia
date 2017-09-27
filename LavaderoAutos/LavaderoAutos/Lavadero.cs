using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;

        public string ElLavadero 
        {
            
            get {
                string lista = "";
                    foreach (Vehiculo autito in Vehiculos)
                    {
                        lista += autito.ToString();
                    }
                return "Razon Social: " + this._razonSocial + "/ Precio Auto: " + Lavadero._precioAuto + "/ Precio Moto: " + Lavadero._precioMoto + "/ Precio Camion: " + Lavadero._precioCamion+" \n/ Lista de vehiculos: "+ lista;
                }
        }

        public List<Vehiculo> Vehiculos
        {
            get 
            {
                return this._vehiculos;
            }
        }
        static Lavadero()
        {
            Random precioRan = new Random();
            _precioAuto = precioRan.Next(150, 565);
            _precioCamion = precioRan.Next(150, 565);
            while(_precioAuto==_precioCamion)
            {
                _precioCamion = precioRan.Next(150, 565);
            }
            _precioMoto = precioRan.Next(150, 565);
            while (_precioAuto == _precioMoto || _precioCamion == _precioMoto)
            {
                _precioMoto = precioRan.Next(150, 565);
            }
        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(string razonSocial)
            : this()
        {
            this._razonSocial = razonSocial;
        }

        public double MostrarTotalFacturado()
        {
            double ganancia=0;
            foreach (Vehiculo autito in _vehiculos)
            {
                if (autito is Auto)
                {
                    ganancia += _precioAuto;
                }
                if (autito is Camion)
                {
                    ganancia += _precioCamion;
                }
                if (autito is Moto)
                {
                    ganancia += _precioMoto;
                }
            }
            return ganancia;
        }

        public double MostrarTotalFacturado(EVehiculos unVehiculo)
        {
            double ganancia = 0;
            foreach (Vehiculo autito in _vehiculos)
            {
                if (autito is Auto && unVehiculo.ToString()=="Auto")
                {
                    ganancia += _precioAuto;
                }
                else 
                {
                    if (autito is Camion && unVehiculo.ToString() == "Camion")
                    {
                        ganancia += _precioCamion;
                    }
                    else 
                    {
                        if (autito is Moto && unVehiculo.ToString() == "Moto")
                        {
                            ganancia += _precioMoto;
                        }
                    }
                }
            }
            return ganancia;
        }

        public static int operator ==(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            int encontrado = 0;
            foreach(Auto autito in unLavadero._vehiculos)
            { 
                if (autito == unVehiculo)
                {
                    return encontrado;
                }
                encontrado++;
            }
            return -1;
        }

        public static int operator !=(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            foreach (Auto autito in unLavadero._vehiculos)
            {
                if (autito == unVehiculo)
                {
                    return 0;
                }
            }
            return 1;
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
            return string.Compare(unVehiculo.LaPatente, otroVehiculo.LaPatente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            return string.Compare(unVehiculo.LaMarca.ToString(), otroVehiculo.LaMarca.ToString());
        }
    }
}
