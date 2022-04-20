using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Group
    {

        public Group()
        {
            Crates = new List<Crate>();
            Members = new List<Contract>();
        }

        public Group(DateTime Date, Parcel Parcel) : this()
        {

            this.Date = Date;
            this.Parcel = Parcel;
        }

        //Añade una lista de miembros a una cuadrilla
        public void AñadirMiembroGrupo(List<Person> miembros)
        {
            foreach (Person m in miembros)
            {
                Contract contrato_activo = null;
                foreach (Contract c in m.Contracts)
                {
                    if (c is Permanent)
                    {
                        contrato_activo = c;
                        break;
                    }

                    else
                    {

                        if (c is Temporary)
                        {
                            Temporary ct = (Temporary)c;
                            if (ct.FinalDate > DateTime.Today)
                            {
                                contrato_activo = c;
                                break;
                            }
                        }
                    }
                }
                this.Members.Add(contrato_activo);

            }

        }

        //Devuelve si hay algua cuadrilla en esa parcela dado un contrato activo
        public static bool CuadrillaParcelaBool(Contract c, Parcel p)
        {
            bool cuadrilla_parcela = false;
            foreach (Group cuadrilla in c.Groups)
            {
                if (cuadrilla.Parcel.Equals(p))
                {
                    cuadrilla_parcela = true;
                    break;
                }
            }

            return cuadrilla_parcela;
        }


        //Devuelve la cuadrilla activa de una parcela y de un contrato
        public static Group CuadrillaParcela(Contract c, Parcel p)
        {
            Group cuadrilla_parcela = null;
            foreach (Group cuadrilla in c.Groups)
            {
                if (cuadrilla.Parcel.Equals(p))
                {
                    cuadrilla_parcela = cuadrilla;
                    break;
                }
            }

            return cuadrilla_parcela;
        }

    }

}
