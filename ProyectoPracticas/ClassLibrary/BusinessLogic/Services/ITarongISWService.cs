using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Entities;

namespace TarongISW.BusinessLogic.Services
{
    public interface ITarongISWService
    {
        void RemoveAllData();
        void Commit();
        void AddPerson(Person p);
        void AddParcel(Parcel parcel);
        void AddTruck(Truck truck);
        void AddPermanent(Permanent permanenent);
        void AddTemporary(Temporary temporary);
        void AddGroup(Group group);
        void AddCrate(Crate crate);
        List<Contract> GetAllContracts();
        List<Group> GetAllGroups();
        List<Trip> GetAllTrips();
        List<Crate> GetAllCrates();
        List<Truck> GetAllTrucks();
        Parcel GetParcel(string cr);
        Person GetPersona(string id);
        Truck GetTruck(string id);
        List<Parcel> GetAllParcels();
        List<Person> GetAllPerson();
        void AltaPersona(string dni, string nombre);
        void AltaCuadrilla(Parcel parcela, List<Person> miembros);
        List<Trip> ConsultarViajes(string Id, DateTime salida, DateTime llegada);
        void AltaContratoPermanente(string dni, string bankAccount, DateTime initialDate, string SSN, double salario);
        void AltaContratoTemporal(string dni, string bankAccount, DateTime initialDate, string SSN, DateTime finalDate);
        void AddTrip(Trip trip);
        void AsignarViaje(string id);
        void AnadirCajon(string p, String dni, string matricula, Product product, double peso);
    }
}
