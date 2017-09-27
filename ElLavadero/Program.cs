using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaderoAutos;

namespace ElLavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero unLavadero = new Lavadero("The master Washer");
            Console.WriteLine(unLavadero.ElLavadero);
            Auto autito = new Auto("ASD123", EMarcas.Honda, 5);
            Auto autito2 = new Auto("XSD123", EMarcas.Iveco, 5);
            Auto autito3 = new Auto("SSD123", EMarcas.Zanella, 5);
            Auto autito4 = new Auto("RSD123", EMarcas.Honda, 5);
            Auto autito5 = new Auto("GSD123", EMarcas.Fiat, 5);
            Auto autito6 = new Auto("ASU123", EMarcas.Honda, 5);
            Auto autitoc = new Auto("DFG123", EMarcas.Iveco, 5);
            Camion camion = new Camion(autitoc, 5000);
            unLavadero+=autito;
            unLavadero += autito2;
            unLavadero += autito3;
            unLavadero += autito4;
            unLavadero += autito5;
            unLavadero += autito6;
            unLavadero += camion;
            Console.WriteLine(unLavadero.ElLavadero);
            unLavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(unLavadero.ElLavadero);
            Console.WriteLine(unLavadero.MostrarTotalFacturado(EVehiculos.Camion));
            Console.Read();
        }
    }
}
