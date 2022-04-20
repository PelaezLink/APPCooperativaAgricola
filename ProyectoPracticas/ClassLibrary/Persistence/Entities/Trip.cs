using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {
        public double CarriedWeight
        {
            get;
            set;
        }

        public DateTime? CoopArrival 
        {
            get;
            set;
        }

        [Key]
        public int Id 
        {
            get;
            set;
        }

        public DateTime? ParcelExit
        {
            get;
            set;
        }

        public DateTime? UnloadTime
        {
            get;
            set;
        }

        public virtual ICollection<Crate> Crates
        {
            get;
            set;
        }

        public virtual Truck Truck
        {
            get;
            set;
        }


    }
}
