using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {
        public Trip()
        {
            Crates = new List<Crate>();
        }

        public Trip(Truck truck) : this()
        {

            Truck = truck;

        }

        //Calcula el peso de las cajas que hay de momento en ese viaje.
        public double CalcularPeso()
        {
            double res = 0;
            foreach (Crate c in this.Crates)
            {
                res += c.WeightInParcel;
            }
            return res;
        }

        //Añade a una lista los viajes de un camion entre dos fechas
        public static void ViajeDeCamion(Truck truck, DateTime salida, DateTime llegada, List<Trip> viajes)
        {
            foreach (Trip trip in truck.Trips)
            {

                if (trip.Crates.Any())
                {
                    Group g = trip.Crates.First().Group;
                    if (g.Date >= salida && g.Date <= llegada)
                    {
                        viajes.Add(trip);
                    }
                }
            }
        }
    }
}
