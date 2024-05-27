using Noodle.controller;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.components
{
    public partial class TituloMarcoCompetenciasComponente : UserControl
    {

        public MarcoCompetenciasDTO marco { get; set; }
        public TituloMarcoCompetenciasComponente()
        {
            InitializeComponent();
        }

        public TituloMarcoCompetenciasComponente(MarcoCompetenciasDTO marco)
        {
            InitializeComponent();
            this.marco = marco;
            titulo.Text = marco.nombreCortoCSV;
        }

        private void titulo_Click(object sender, EventArgs e)
        {
            BibliotecaController.verMarco(marco);
        }

        private void eliminarMarco_Click(object sender, EventArgs e)
        {
            BibliotecaController.eliminarMarcoCompetencias(marco);
        }

        private void hoverEffect(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = SystemColors.ControlLight;
        }

        private void resetColorEffect(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.Transparent;
        }
    }
}
