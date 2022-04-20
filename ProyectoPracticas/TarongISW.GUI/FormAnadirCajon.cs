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
    public partial class FormAnadirCajon : Form
    {
        private ITarongISWService service;
        public FormAnadirCajon(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {
            List<Parcel> parcelas = service.GetAllParcels();
            comboBox_parcela.Items.Clear();
            if (parcelas != null)
                foreach (Parcel p in parcelas)
                    comboBox_parcela.Items.Add(p.CadastralReference);
            comboBox_parcela.SelectedIndex = -1;
            comboBox_parcela.ResetText();

            Array productos = Enum.GetValues(typeof(Product));
            comboBox_product.Items.Clear();
            if (parcelas != null)
                foreach (Product p in productos)
                    comboBox_product.Items.Add(p);
            comboBox_product.SelectedIndex = -1;
            comboBox_product.ResetText();

            List<Person> trabajadores = service.GetAllPerson();
            listBox_dni.Items.Clear();
            if (trabajadores != null)
                foreach (Person p in trabajadores)
                    listBox_dni.Items.Add(p.Id);
            listBox_dni.SelectedIndex = -1;
            listBox_dni.ResetText();

            List<Truck> trucks = service.GetAllTrucks();
            listBox_matricula.Items.Clear();
            if (trucks != null)
                foreach (Truck t in trucks)
                    listBox_matricula.Items.Add(t.Id);
            listBox_matricula.SelectedIndex = -1;
            listBox_matricula.ResetText();

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (comboBox_parcela.SelectedItem == null || listBox_dni.SelectedItem == null || listBox_matricula.SelectedItem == null 
                || textBox_peso.Text.Length == 0 || comboBox_product.SelectedItem == null)
            {
                MessageBox.Show(this,
                "Seleccione todos los elementos requeridos",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                service.AnadirCajon(comboBox_parcela.SelectedItem.ToString(), listBox_dni.SelectedItem.ToString(), listBox_matricula.SelectedItem.ToString(),
                    (Product) comboBox_product.SelectedItem, double.Parse(textBox_peso.Text));

                Close();
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
