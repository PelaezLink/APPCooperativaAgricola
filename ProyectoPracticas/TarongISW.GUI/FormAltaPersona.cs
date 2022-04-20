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
    public partial class FormAltaPersona : Form
    {
        private ITarongISWService service;
        public FormAltaPersona(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (textBox_nombre.Text.Length == 0 || textBox_dni.Text.Length == 0)
            {
                MessageBox.Show(this,
                "Rellene todos los campos",
                "Error", //Title
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                return;
            }
            try
            {
                service.AltaPersona(textBox_dni.Text, textBox_nombre.Text);

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
