using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Validation;
using System.IO.Ports;

using TarongISW.Entities;
using TarongISW.Persistence;
using TarongISW.BusinessLogic.Services;


namespace BusinessLogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ITarongISWService service = new TarongISWService(new EntityFrameworkDAL(new TarongISWDbContext()));

                new Program(service);
            }
            catch (Exception e)
            {
                printError(e);
                Console.WriteLine("Press any key.");
                Console.ReadLine();
            }


        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        private ITarongISWService service;

        Program(ITarongISWService service)
        {
            this.service = service;

            DBInitialization();
/*
            AddPermanentContracts();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddTemporaryContracts();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddGroups();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddTripToTruck();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddCratesToTrip();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            QueryTravelsMadeByTruck();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
*/

        }

        void DBInitialization()
        {
            service.RemoveAllData();

            Console.WriteLine("INITIALIZATING DB...");

            Person p1;
            p1 = new Person("12345678Z", "Juan Abelló"); 
            service.AddPerson(p1);

            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Orange, 10000, p1);
            service.AddParcel(parcel);

            p1 = new Person("23456789D", "José María Aristrian"); 
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB9999C0001DE", "Valdepuercas, Alia (Cáceres)", Product.Avocado, 18000, p1);
            service.AddParcel(parcel);

            p1 = new Person("34567890V", "Junta de Andalucía"); 
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB1111C0001DE", "La Almoraima (Cadiz)", Product.Kiwi, 16000, p1);
            service.AddParcel(parcel);

            Truck t = new Truck("1234AAA", 3200, 3000);
            service.AddTruck(t);

            t = new Truck("1234BJP", 3500, 2660);
            service.AddTruck(t);

            t = new Truck("1234LKP", 18000, 3660);
            service.AddTruck(t);

            Console.WriteLine("DATA CREATED.");
        }


        void AddPermanentContracts() {
            Console.WriteLine();
            Console.WriteLine("ADDING PERMANENT CONTRACTS...");

            try
            {
                //Caso 1.1
                service.AltaPersona("76543210S", "Andrés Trozado");
                service.AltaContratoPermanente("76543210S", "ES9812340100951757864321", DateTime.Today.AddYears(-6), "SSN0033111144", 14000.00);
            }


            catch (Exception e)
            {
                printError(e);
            }


            try
            {
                //Caso 1.2
                service.AltaPersona("65432109F", "Helen Chufe");
                service.AltaContratoPermanente("65432109F", "ES9812340100951757864321", DateTime.Today.AddYears(-2), "SSN4433221100", 18000.00);
            }


            catch (Exception e)
            {
                printError(e);
            }

            try
            {

                //Caso 1.3
                service.AltaContratoPermanente("76543210S", "ES9812340100951757864321", DateTime.Today.AddYears(-1), "SSN0033111144", 17000.00);
            }


            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 1.4
                service.AltaPersona("76543210S", "Andrés Petido");

            }

            catch (Exception e)
            {
                printError(e);
            }

         
            //MUESTRA POR PANTALLA LOS CONTRATOS AÑADIDOS 
            
            foreach (Contract c in service.GetAllContracts())
            {
                Console.WriteLine("Contract: " + c.Id + ", Id: " + c.Hired.Id + ", Name: " + c.Hired.Name);
            }
            
        }

       void AddTemporaryContracts()
       {
           Console.WriteLine();
           Console.WriteLine("ADDING TEMPORARY CONTRACTS...");


            try
            {
                // ESCRIBA EL CÓDIGO PARA EJECUTAR LOS CASOS DE PRUEBA PARA AÑADIR CONTRATOS TEMPORALES
                //Caso 2.1
                service.AltaPersona("87654321X", "Juan Sin Nombre");
                service.AltaContratoTemporal("87654321X", "ES8912340100951757864321", DateTime.Today, "SSN0011223344", DateTime.Today.AddDays(10));
            }


            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 2.2
                service.AltaPersona("98765432M", "Aitor Tilla");
                service.AltaContratoTemporal("98765432M", "ES8912340100951757864321", DateTime.Today.AddDays(-20), "SSN0112233354", DateTime.MaxValue);
            }

            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 2.3
                service.AltaContratoTemporal("98765432M", "ES9812340100951757864321", DateTime.Today, "SSN0112233354", DateTime.Today.AddDays(10));
            }


            catch (Exception e)
            {
                printError(e);
            }

            try
            {

                //Caso 2.4
                service.AltaContratoTemporal("87654321X", "ES9812340100951757864321", DateTime.Today, "SSN0112233354", DateTime.Today.AddDays(10));
            }

            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                    //Caso 2.5
                    service.AltaContratoTemporal("76543210S", "ES9812340100951757864321", DateTime.Today, "SSN0112233354", DateTime.Today.AddDays(10));
                }

             catch (Exception e)
                {
                    printError(e);
                }

            
            //MUESTRA POR PANTALLA LOS CONTRATOS AÑADIDOS 
           
            foreach (Contract c in service.GetAllContracts())
            {
                if (c is Temporary)
                    Console.WriteLine("Contract: " + c.Id + ", Id: " + c.Hired.Id + ", Name: " + c.Hired.Name);
            }
           
        }
        
       void AddGroups()
       {
            Console.WriteLine();
            Console.WriteLine("ADDING GROUPS AND ASSIGN PEOPLE...");



            try
            {
                //Caso 3.1
                List<Person> people = new List<Person>();
                people.Add(service.GetPersona("76543210S"));
                people.Add(service.GetPersona("98765432M"));
                Parcel pa1 = service.GetParcel("1234567AB9999C0001DE");
                service.AltaCuadrilla(pa1, people);
            }


            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 3.2
                List<Person> people = new List<Person>();
                Parcel pa1 = service.GetParcel("1234567AB9999C0001DE");
                service.AltaCuadrilla(pa1, people);
            }


            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 3.3
                List<Person> people = new List<Person>();
                people.Add(service.GetPersona("98765432M"));
                people.Add(service.GetPersona("98765432M"));
                Parcel pa1 = service.GetParcel("1234567AB9999C0001DE");
                service.AltaCuadrilla(pa1, people);
            }

            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 3.4
                List<Person> people = new List<Person>();
                people.Add(service.GetPersona("65432109F"));
                Parcel pa2 = service.GetParcel("7654321AB9999C0001DE");
                service.AltaCuadrilla(pa2, people);
            }


            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 3.5
                List<Person> people = new List<Person>();
                people.Add(service.GetPersona("98765432M"));
                Parcel pa2 = service.GetParcel("7654321AB9999C0001DE");
                service.AltaCuadrilla(pa2, people);
            }
            catch (Exception e)
            {
                printError(e);
            }

            
            // Mostrar la información almacenada de los grupos y sus miembros
            
             foreach (Group group in service.GetAllGroups())
            {
                    Console.WriteLine("Group: " + group.Id + ", Date: " + group.Date + ", Parcel: " + group.Parcel.CadastralReference + ", Parcel.Name: " + group.Parcel.Name);
                foreach(Contract contract in group.Members)
                {
                    Console.WriteLine("   Member: " + contract.Hired.Name);
                }
            } 
            
        }

            
        void AddTripToTruck()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING TRIPS TO TRUCK...");


            try
            {
                // ESCRIBA EL CÓDIGO PARA EJECUTAR LOS CASOS DE PRUEBA PARA AÑADIR VIAJES A CAMIÓN
                //Caso 4.1
                service.AsignarViaje("1234BJP");

            }

            catch (Exception e)
            {
                printError(e);
            }

            try
            {

            //Caso 4.2
            service.AsignarViaje("1234AAA");

            }

            catch (Exception e)
            {
                    printError(e);
            }

            // Mostrar la información de los viajes creados
            
            
             foreach (Trip tr in service.GetAllTrips())
            {
                Console.WriteLine("Trip: " + tr.Id + ", Truck: " + tr.Truck.Id);
            }
            
            
        }

        void AddCratesToTrip()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING CRATES TO TRIP...");


            try
            {
                //Caso 5.1
                Parcel pa2 = service.GetParcel("7654321AB9999C0001DE");
                service.AnadirCajon(pa2.CadastralReference, "65432109F", "1234AAA", pa2.Product, 20);
                service.AnadirCajon(pa2.CadastralReference, "65432109F", "1234AAA", pa2.Product, 30);
                service.AnadirCajon(pa2.CadastralReference, "65432109F", "1234AAA", pa2.Product, 25.5);
            }

            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 5.2
                Parcel pa1 = service.GetParcel("1234567AB9999C0001DE");
                service.AnadirCajon(pa1.CadastralReference, "98765432M", "1234BJP", pa1.Product, 50);
                service.AnadirCajon(pa1.CadastralReference, "98765432M", "1234BJP", pa1.Product, 45);
                service.AnadirCajon(pa1.CadastralReference, "98765432M", "1234BJP", pa1.Product, 35.5);
            }

            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                //Caso 5.3
                Parcel pa1 = service.GetParcel("1234567AB9999C0001DE");
                service.AnadirCajon(pa1.CadastralReference, "65432109F", "1234BJP", pa1.Product, 50);
            }

            catch (Exception e)
            {
                printError(e);
            }

            try 
            {
                //Caso 5.4
                Parcel pa2 = service.GetParcel("7654321AB9999C0001DE");
                service.AnadirCajon(pa2.CadastralReference, "65432109F", "1234AAA", pa2.Product, 125);

            }
            catch (Exception e)
            {
                printError(e);
            }

            // Mostrar la información de las cajas creadas
            
             foreach (Crate cr in service.GetAllCrates())
                Console.WriteLine("Crate: " + cr.Id + ", Member:" + cr.Contract.Hired.Name + ", Weight: " + cr.WeightInParcel + ", Truck: " + cr.Trip.Truck.Id + ", Parcel: " + cr.Group.Parcel.Name);
            
        }

        void QueryTravelsMadeByTruck()
        {
                Console.WriteLine();
                Console.WriteLine("QUERY TRIPS MADE BY TRUCK...");

            try
            {
                // Caso 6.1
                Truck t1 = service.GetTruck("1234BJP");

                List<Trip> viajes = service.ConsultarViajes(t1.Id, DateTime.Today, DateTime.Today);

                foreach (Trip tr in viajes)
                {
                    Console.WriteLine("Trip: " + tr.Id + ", Trip Date: " + tr.Crates.First().Group.Date + ", Number of crates: " + tr.Crates.Count + ", Total Weight: " + tr.CarriedWeight);
                }


            }
            catch (Exception e)
            {
                    printError(e);
            }
            

        } 


    }


}
