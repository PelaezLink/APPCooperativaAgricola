using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Parcel
    {
        public Parcel()
        {
            Groups = new List<Group>();

        }

        public Parcel(string cr, string Name, Product Product, double Size, Person owner) : this()
        {
            CadastralReference = cr;
            this.Name = Name;
            this.Product = Product;
            this.Size = Size;

            Owner = owner;
        }
    }
}
