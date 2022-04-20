using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Contract
    {
        public Contract()
        {
            // Colecciones
            Crates = new List<Crate>();
            Groups = new List<Group>();
        }
        public Contract(string bankAccount, DateTime initialDate, string SSN, Person
        hired) : this()
        {
            // No se le da valor a Id porque se lo dará EF
            this.BankAccount = bankAccount;
            this.InitialDate = initialDate;
            this.SSN = SSN;
            // Relaciones a 1
            Hired = hired;
        }


    }
}
