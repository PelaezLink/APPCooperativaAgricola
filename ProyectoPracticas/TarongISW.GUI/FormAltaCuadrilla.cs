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
    public partial class FormAltaCuadrilla : Form
    {
        private ITarongISWService service;
        public FormAltaCuadrilla(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {
            List<Parcel> parcelas = service.GetAllParcels();
            List<Person> trabajadores = service.GetAllPerson();
            comboBox_parcela.Items.Clear();
            listBox_trabajadores.Items.Clear();
            if (parcelas != null)
                foreach (Parcel p in parcelas)
                    comboBox_parcela.Items.Add(p.CadastralReference);
            comboBox_parcela.SelectedIndex = -1;
            comboBox_parcela.ResetText();

            if (trabajadores != null)
                foreach (Person p in trabajadores)
                {
                    if(p.Contracts.Count > 0)
                    {
                        listBox_trabajadores.Items.Add(p.Id);
                    }
                }
                    

            listBox_trabajadores.SelectedIndex = -1;
            listBox_trabajadores.ResetText();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if(comboBox_parcela.SelectedItem == null || listBox_trabajadores.SelectedItems.Count == 0)
            {
                MessageBox.Show(this,
                "Seleccione todos los elementos requeridos",
                "Error", // Title
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                return;
            }

            try 
            {
                List<Person> personas = new List<Person>();
                foreach(string dni in listBox_trabajadores.CheckedItems)
                {
                    personas.Add(service.GetPersona(dni));
                    Console.WriteLine(dni);
                }
                service.AltaCuadrilla(service.GetParcel(comboBox_parcela.SelectedItem.ToString()), personas);

                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(this,
                ex.Message.ToString(),
                "Error", // Title
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
    }
}
