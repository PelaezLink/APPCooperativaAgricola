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

namespace TarongISW.GUI
{
    public partial class TarongISWApp : Form
    {
        private ITarongISWService service;
        private FormAltaPersona formAltaPersona;
        private FormAltaCuadrilla formAltaCuadrilla;
        private FormAltaContrato formAltaContrato;
        private FormAnadirCajon formAnadirCajon;
        private FormConsultarViajes formConsultarViajes;
        private FormAsignarViaje formAsignarViaje;
        public TarongISWApp(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;

        }

        private void button_alta_persona_Click(object sender, EventArgs e)
        {
            formAltaPersona = new FormAltaPersona(service);
            formAltaPersona.ShowDialog();
        }

        private void button_asignar_viaje_Click(object sender, EventArgs e)
        {
            formAsignarViaje = new FormAsignarViaje(service);
            formAsignarViaje.ShowDialog();
        }

        private void button_alta_contrato_Click(object sender, EventArgs e)
        {
            formAltaContrato = new FormAltaContrato(service);
            formAltaContrato.ShowDialog();
        }

        private void button_alta_cuadrilla_Click(object sender, EventArgs e)
        {
            formAltaCuadrilla = new FormAltaCuadrilla(service);
            formAltaCuadrilla.ShowDialog();
        }

        private void button_asignar_cajon_Click(object sender, EventArgs e)
        {
            formAnadirCajon = new FormAnadirCajon(service);
            formAnadirCajon.ShowDialog();
        }

        private void button_consultar_viajes_Click(object sender, EventArgs e)
        {
            formConsultarViajes = new FormConsultarViajes(service);
            formConsultarViajes.ShowDialog();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
