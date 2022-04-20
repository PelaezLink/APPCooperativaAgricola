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
    public partial class FormAltaContrato : Form
    {
        private ITarongISWService service;
        public FormAltaContrato(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {

            List<Person> trabajadores = service.GetAllPerson();
            comboBox_dni.Items.Clear();

            if (trabajadores != null)
                foreach (Person p in trabajadores)
                    comboBox_dni.Items.Add(p.Id);
            comboBox_dni.SelectedIndex = -1;
            comboBox_dni.ResetText();

            checkBox_fin.Checked = true;
            radioButton_fijo.Checked = true;
            dateTimePicker_incio.Value = DateTime.Today;
            dateTimePicker_fin.Value = DateTime.Today;

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (comboBox_dni.SelectedItem == null || textBox_cuentaBancaria.Text.Length == 0 || textBox_NSS.Text.Length == 0
                || textBox_salario.Text.Length == 0)
            {
                MessageBox.Show(this,
                "Introduzca todos los datos necesarios",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                if (radioButton_fijo.Checked == true)
                {
                    service.AltaContratoPermanente(comboBox_dni.SelectedItem.ToString(), textBox_cuentaBancaria.Text, dateTimePicker_incio.Value,
                        textBox_NSS.Text, double.Parse(textBox_salario.Text));
                    Close();
                }

                else
                {
                    DateTime fin;
                    if(checkBox_fin.Checked == true)
                    {
                        fin = dateTimePicker_fin.Value;
                    }

                    else
                    {
                        fin = DateTime.MaxValue;
                    }
                    service.AltaContratoTemporal(comboBox_dni.SelectedItem.ToString(), textBox_cuentaBancaria.Text, dateTimePicker_incio.Value,
                    textBox_NSS.Text, fin);
                    Close();
                }
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

        private void textBox_salario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radioButton_fijo_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_fijo.Checked == true)
            {
                dateTimePicker_fin.Enabled = false;
                textBox_salario.Enabled = true;
                checkBox_fin.Enabled = false;
            }

            else
            {
                textBox_salario.Enabled = true;
                dateTimePicker_fin.Enabled = true;
                checkBox_fin.Enabled = true;
                checkBox_fin.Checked = true;
            }
        }

        private void checkBox_fin_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_fin.Checked == true)
            {
                dateTimePicker_fin.Enabled = true;
            }

            else
            {
                dateTimePicker_fin.Enabled = false;
            }
        }
    }
}
