using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Person
    {
        public Person()
        {

            Parcels = new List<Parcel>();
            Contracts = new List<Contract>();

        }
        public Person(string Id, string Name) : this()
        {
            this.Id = Id;
            this.Name = Name;
        }

        //Comprueba si tiene un contrato activo
        public bool Comprobar()
        {
            List<Contract> contratos = (List<Contract>)this.Contracts;
            bool activo = false;
            foreach (Contract c in contratos)
            {
                if (c is Permanent)
                {
                    activo = true;

                }
                if (c is Temporary)
                {
                    Temporary c1 = (Temporary)c;

                    if (c1.FinalDate >= DateTime.Today && !activo)
                    {
                        activo = true;
                    }
                }
            }
            return activo;
        }


        //Returnea true o false depende de si una persona tiene algun contrato activo
        public bool ContratoActivoBool()
        {

            bool contrato_activo_bool = false;

            foreach (Contract c in this.Contracts)
            {

                if (c is Permanent)
                {
                    contrato_activo_bool = true;
                    break;
                }

                if (c is Temporary)
                {
                    Temporary temporal = (Temporary)c;
                    if (temporal.FinalDate > DateTime.Today)
                    {
                        contrato_activo_bool = true;
                        break;
                    }
                }
            }

            return contrato_activo_bool;
        }

        //Devuelve el contrato activo de una persona.
        public Contract ContratoActivo()
        {
            Contract contrato_activo = null;

            foreach (Contract c in this.Contracts)
            {

                if (c is Permanent)
                {
                    contrato_activo = c;
                    break;
                }

                if (c is Temporary)
                {
                    Temporary temporal = (Temporary)c;
                    if (temporal.FinalDate > DateTime.Today)
                    {
                        contrato_activo = c;
                        break;
                    }
                }
            }

            return contrato_activo;
        }
        

    }
}
