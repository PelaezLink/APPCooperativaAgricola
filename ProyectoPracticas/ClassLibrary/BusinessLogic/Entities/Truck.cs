using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Truck
    {
        public Truck()
        {
            //Colecciones
            Trips = new List<Trip>();
        }

        public Truck(string id, double maximumAuthorisedMass, double tareWeight) : this()
        {
            Id = id;
            MaximumAuthorisedMass = maximumAuthorisedMass;
            TareWeight = tareWeight;
            MaximunWeight = maximumAuthorisedMass - tareWeight;
        }

        //Devuelve el ultimo viaje de un camion.
        public Trip UltimoViaje()
        {
            Trip viaje = this.Trips.First();
            DateTime fecha = DateTime.MinValue;
            foreach (Trip v in this.Trips)
            {

                if (v.Crates.Any())
                {
                    Group g = v.Crates.First().Group;
                    if (g.Date > fecha)
                    {
                        fecha = g.Date;
                        viaje = v;
                    }
                }
            }

            return viaje;
        }

        //Devuelve la fecha del ultimo viaje del camion.
        public DateTime UltimoViajeFecha()
        {
            Trip viaje = this.Trips.First();
            DateTime fecha = DateTime.MinValue;
            foreach (Trip v in this.Trips)
            {

                if (v.Crates.Any())
                {
                    Group g = v.Crates.First().Group;
                    if (g.Date > fecha)
                    {
                        fecha = g.Date;
                        viaje = v;
                    }
                }
            }

            return fecha;
        }


    }
}
