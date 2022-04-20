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
    public partial class FormAsignarViaje : Form
    {
        private ITarongISWService service;
        public FormAsignarViaje(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {
            List<Truck> camiones = service.GetAllTrucks();
            comboBox_matricula.Items.Clear();
            if (camiones != null)
                foreach (Truck c in camiones)
                    comboBox_matricula.Items.Add(c.Id);
            comboBox_matricula.SelectedIndex = -1;
            comboBox_matricula.ResetText();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (comboBox_matricula.SelectedItem == null)
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
                service.AsignarViaje(comboBox_matricula.SelectedItem.ToString());


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
