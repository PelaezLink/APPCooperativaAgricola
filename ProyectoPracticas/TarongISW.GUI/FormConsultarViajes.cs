using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.BusinessLogic.Services;
using TarongISW.Entities;

namespace TarongISW.GUI
{
    public partial class FormConsultarViajes : Form
    {
        private ITarongISWService service;
        public FormConsultarViajes(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }
        public void LoadData()
        {
            List<Truck> camiones = service.GetAllTrucks();
            List<Person> trabajadores = service.GetAllPerson();
            comboBox_camion.Items.Clear();
            if (camiones != null)
                foreach (Truck c in camiones)
                    comboBox_camion.Items.Add(c.Id);
            comboBox_camion.SelectedIndex = -1;
            comboBox_camion.ResetText();
            bindingSource1.DataSource = null;
            salida.Value = DateTime.Today;
            llegada.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void consultar_Click(object sender, EventArgs e)
        {
            try
            {
                string matricula = (string)comboBox_camion.SelectedItem;
                DateTime fechaSalida = salida.Value;
                DateTime fechaLlegada = llegada.Value;
                ICollection<Trip> viajes = service.ConsultarViajes(matricula, fechaSalida, fechaLlegada);
                BindingList<object> bindinglist = new BindingList<object>();
                foreach (Trip t in viajes)

                    bindinglist.Add(new
                    {
                        ds_Parcela = t.Crates.First().Group.Parcel.CadastralReference,
                        ds_Fecha = t.Crates.First().Group.Date,
                        ds_Cajas = t.Crates.Count,
                        ds_Peso = t.CarriedWeight
                    });
                bindingSource1.DataSource = bindinglist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                ex.Message.ToString(),
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
    }
}
