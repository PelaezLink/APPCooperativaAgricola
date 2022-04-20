using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Persistence;
using TarongISW.Entities;

namespace TarongISW.BusinessLogic.Services
{
    public class TarongISWService : ITarongISWService
    {
        //Iinicializa el DAL
        private readonly IDAL dal;
        public TarongISWService(IDAL dal)
        {
            this.dal = dal;
        }

        //Borrar base de datos
        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        //Confirmar cambios base de datos
        public void Commit()
        {
            dal.Commit();
        }


        //Devuelve todos los contratos de la base de datos
        public List<Contract> GetAllContracts()
        {
            return new List<Contract>(dal.GetAll<Contract>());
        }

        //Devuelve todos las parcelas de la base de datos
        public List<Parcel> GetAllParcels()
        {
            return new List<Parcel>(dal.GetAll<Parcel>());
        }

        //Devuelve todos las parcelas de la base de datos
        public List<Person> GetAllPerson()
        {
            return new List<Person>(dal.GetAll<Person>());
        }

        //Devuelve todos los viajes de la base de datos
        public List<Trip> GetAllTrips()
        {
            return new List<Trip>(dal.GetAll<Trip>());
        }

        public List<Crate> GetAllCrates()
        {
            return new List<Crate>(dal.GetAll<Crate>());
        }
       

        //Devuelve todos los grupos de la base de datos
        public List<Group> GetAllGroups()
        {
            return new List<Group>(dal.GetAll<Group>());
        }

        //Devuelve todos los camiones de la base de datos
        public List<Truck> GetAllTrucks()
        {
            return new List<Truck>(dal.GetAll<Truck>());
        }

        //Devuelve la Parcela de esta cadastral reference
        public Parcel GetParcel(string cr)
        {
            if (dal.GetById<Parcel>(cr) == null)
            {
                throw new ServiceException("La parcela con referencia: " + cr + " no existe.");
            }
            else
            {
                return dal.GetById<Parcel>(cr);
            } 
        }

        public Person GetPersona(string id)
        {
            if (dal.GetById<Person>(id) == null)
            {
                throw new ServiceException("La persona con dni: " + id + " no existe.");
            }
            else
            {
                return dal.GetById<Person>(id);
            }
        }

        public Truck GetTruck(string id)
        {
            if (dal.GetById<Truck>(id) == null)
            {
                throw new ServiceException("El camión con matrícula: " + id + " no existe.");
            }
            else
            {
                return dal.GetById<Truck>(id);
            }
        }

        //Añadir persona a base de datos
        public void AddPerson(Person person)
        {
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        //Añadir cuadrilla a base de datos
        public void AddGroup(Group group)
        {
            if (dal.GetById<Group>(group.Id) == null)
            {
                dal.Insert<Group>(group);
                Commit();
            }
            else throw new ServiceException("Group with Id " + group.Id + " already exists.");
        }

        //Añadir camion a base de datos
        public void AddTruck(Truck truck)
        {
            if (dal.GetById<Truck>(truck.Id) == null)
            {
                dal.Insert<Truck>(truck);
                Commit();
            }
            else throw new ServiceException("Truck with Id " + truck.Id + " already exists.");
        }

        //Añadir parecela a base de datos
        public void AddParcel(Parcel parcel)
        {
            // Restricción: No puede haber dos parcelas con el mismo nombre
            if (!dal.GetWhere<Parcel>(x => x.Name == parcel.Name).Any())
            {
                dal.Insert<Parcel>(parcel);
                dal.Commit();
            }
            else throw new ServiceException("Parcel with Name " + parcel.Name + " already exists.");
        }

        //Añadir contrato temporal a base de datos
        public void AddTemporary(Temporary temporary)
        {
            if (dal.GetById<Temporary>(temporary.Id) == null)
            {
                dal.Insert<Temporary>(temporary);
                Commit();
            }
            else throw new ServiceException("Temporary with Id " + temporary.Id + " already exists.");
        }

        //Añadir contrato fijo a base de datos
        public void AddPermanent(Permanent permanent)
        {
            if (dal.GetById<Permanent>(permanent.Id) == null)
            {
                dal.Insert<Permanent>(permanent);
                Commit();
            }
            else throw new ServiceException("Permanent with Id " + permanent.Id + " already exists.");
        }

        //Añadir caja a base de datos
        public void AddCrate(Crate crate)
        {
            if (dal.GetById<Crate>(crate.Id) == null)
            {
                dal.Insert<Crate>(crate);
                Commit();
                
            }
            else throw new ServiceException("Crate with Id " + crate.Id + " already exists.");
        }

        


        //Añadir un nuevo viaje a la base de datos
        public void AddTrip(Trip trip)
        {
            if (dal.GetById<Trip>(trip.Id) == null)
            {
                dal.Insert<Trip>(trip);
                Commit();
            }
            else throw new ServiceException("Trip with Id " + trip.Id + " already exists.");
        }

        //Dar de alta nueva persona
        public void AltaPersona(string dni, string nombre)
        {
            Person persona = new Person(dni, nombre);
            if (dal.GetById<Person>(persona.Id) != null)
            {
                throw new ServiceException("Person with Id " + persona.Id + " already exists.");

            }

            else
            {
                AddPerson(persona);
            }
        }

        //Dar de alta nueva cuadrilla
        public void AltaCuadrilla(Parcel parcela, List<Person> miembros)
        {

            
            if (miembros.Count != miembros.Distinct().Count())
            {
                throw new ServiceException("Algun trabajador ha sido añadido dos veces a la cuadrilla.");

            }

            foreach (Group cuadrilla in dal.GetAll<Group>())
            {
                foreach (Contract c in cuadrilla.Members)
                {

                    if(c == null)
                    {
                        throw new ServiceException("El trabajador con Id " + c.Hired.Id + " no tiene ningun contrato.");
                    }

                    if (c != null && cuadrilla.Date == DateTime.Today && miembros.Contains(c.Hired))
                    {
                        throw new ServiceException("El trabajador con Id " + c.Hired.Id + " ya esta asignado a ota cuadrilla para el dia de hoy (" + cuadrilla.Date + ")");
                    }
                }
            }

            foreach (Group cuadrilla in dal.GetAll<Group>())
            {
                if (cuadrilla.Date.Equals(DateTime.Today) && cuadrilla.Parcel.Equals(parcela))
                {
                    throw new ServiceException("La parcela "+ parcela.CadastralReference + " no puede tener dos grupos para el dia de hoy ("+ cuadrilla.Date+")");
                }
            }
            
            Group cuadrilla_nueva = new Group(DateTime.Today, parcela);

            cuadrilla_nueva.AñadirMiembroGrupo(miembros);
            

            AddGroup(cuadrilla_nueva);

        }

        //Dar de alta contrato trabajador permanente
        public void AltaContratoPermanente(string dni, string bankAccount, DateTime initialDate, string SSN, double salario) {

            if (dal.GetById<Person>(dni) == null)
            {
                throw new ServiceException("El trabajador con Id " + dni + " aún no existe.");
            }

            bool activo;
            Person p = dal.GetById<Person>(dni);

            activo = p.Comprobar();

            if (activo)
            {
                throw new ServiceException(p.Name + " ya tiene un contrato activo.");
            }
            else 
            {
                if (bankAccount == null  || SSN == null 
                    || salario < 0) 
                {
                    throw new ServiceException("Revisa los datos que has introducido.");
                }
                
                dal.Insert<Permanent>(new Permanent(bankAccount, initialDate, SSN, dal.GetById<Person>(dni), salario)); 
                                
                Commit();
            }         

        }

        //Dar de alta contrato temporal
        public void AltaContratoTemporal(string dni, string bankAccount, DateTime initialDate, string SSN, DateTime finalDate)
        {

            if (dal.GetById<Person>(dni) == null)
            {
                throw new ServiceException("El trabajador con Id " + dni + " aún no existe.");
            }


            bool activo;
            Person p = dal.GetById<Person>(dni);
            
            activo = p.Comprobar();

            if (activo)
            {
                throw new ServiceException(p.Name + " ya tiene un contrato activo.");
            }

            else
            {
                if (bankAccount == null || SSN == null)
                {
                    throw new ServiceException("Revisa los datos que has introducido.");
                }


                Temporary t = new Temporary(bankAccount, initialDate, SSN, dal.GetById<Person>(dni));
                t.FinalDate = finalDate;
                dal.Insert<Temporary>(t);

                Commit();
            }

        }

        //Consultar viajes de camion
        public List<Trip> ConsultarViajes(string Id, DateTime salida, DateTime llegada)
        {
           List<Trip> viajes = new List<Trip>();


            if (dal.GetById<Truck>(Id) == null)
            {
                throw new ServiceException("El camión solicitado con matricula "+ Id +" no existe");
            }

            if (salida>llegada)
            {
                throw new ServiceException("El rango de fechas es incorrecto");
            }

            Truck truck = dal.GetById<Truck>(Id);
            Console.WriteLine("El número de viajes realizados por el camión " + truck.Id + " es: " +truck.Trips.Count);

            Trip.ViajeDeCamion(truck, salida, llegada, viajes);
            return viajes;

        }

        //Asignar viaje a camion
        public void AsignarViaje(string id)
        {

            if (dal.GetById<Truck>(id) == null)
            {
                throw new ServiceException("El camion con matricula "+ id +" no existe.");
            }
            Truck truck = dal.GetById<Truck>(id);

            Trip trip = new Trip(truck);

            AddTrip(trip);
        }
        

    //Añadir cajon a viaje
         public void AnadirCajon(string p, String dni, string matricula, Product product, double peso)
         {
            Parcel parcela;
            if (dal.GetById<Parcel>(p) == null)
            {
                throw new ServiceException("La parecela con referencia catastral: " + p  + " no existe");
            }

            else
            {
                parcela = dal.GetById<Parcel>(p);
            }

            if (dal.GetById<Person>(dni) == null)
            {
                throw new ServiceException("El trabajador con Id " + dni + " aún no existe.");
            }


            if (dal.GetById<Truck>(matricula) == null)
            {
                throw new ServiceException("No existe ningun camion con matricula: " + matricula);
            }

            Person persona = dal.GetById<Person>(dni);
            List<Contract> contratos = (List <Contract>) persona.Contracts;
            if (contratos.Count == 0)
            {
                throw new ServiceException("La persona con dni: " + dni + "no tiene ningun contrato");
            }


            bool contrato_activo_bool = persona.ContratoActivoBool();
            Contract contrato_activo = persona.ContratoActivo();


            if (!contrato_activo_bool)
            {
                throw new ServiceException("La persona con dni: " + dni + "no tiene ningun contrato activo");
            }

            bool cuadrilla_parcela = Group.CuadrillaParcelaBool(contrato_activo, parcela);
            Group cuadrilla_actual = Group.CuadrillaParcela(contrato_activo, parcela);

            if (!cuadrilla_parcela)
            {
                throw new ServiceException(persona.Name+ " no forma parte de la cuadrilla asignada para la parcela "+parcela.Name);
            }


            Truck camion = dal.GetById<Truck>(matricula);

            Trip viaje_actual = camion.UltimoViaje();
            DateTime fecha = camion.UltimoViajeFecha();

            double peso_actual = viaje_actual.CalcularPeso();

            if(peso_actual + peso > camion.MaximunWeight)
            {
                throw new ServiceException("El camion ("+ camion.Id + ") no puede cargar más peso que su tara maxima ("+camion.MaximunWeight + ")" );
            }
            viaje_actual.CarriedWeight = peso_actual + peso; 
            Crate caja = new Crate(product, peso, contrato_activo, cuadrilla_actual, viaje_actual);
            AddCrate(caja);

         }

    }
}