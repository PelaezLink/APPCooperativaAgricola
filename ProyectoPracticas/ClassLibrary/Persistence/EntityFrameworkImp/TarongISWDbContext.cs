using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Entities;
using System.Data.Entity;

namespace TarongISW.Persistence
{
    public class TarongISWDbContext : DbContextISW
    {
        public TarongISWDbContext() : base("Name=TarongISWDbConnection")
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static TarongISWDbContext()
        {
            Database.SetInitializer<TarongISWDbContext>(new DropCreateDatabaseIfModelChanges<TarongISWDbContext>());
        }

        public IDbSet<Contract> Contracts { get; set; }
        public IDbSet<Crate> Crates { get; set; }
        public IDbSet<Group> Groups { get; set; }
        public IDbSet<Parcel> Parcels { get; set; }
        public IDbSet<Permanent> PermanentContracts { get; set; }
        public IDbSet<Person> People { get; set; }
        public IDbSet<Temporary> TemporaryContracts { get; set; }
        public IDbSet<Trip> Trips { get; set; }
        public IDbSet<Truck> Trucks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}
