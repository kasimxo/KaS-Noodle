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

namespace Noodle.view
{
    public partial class CompartirMarcoView : Form
    {
        public MarcoCompetenciasDTO marco { get; set; }
        public CompartirMarcoView(MarcoCompetenciasDTO m)
        {
            InitializeComponent();
            this.marco = m;
            titulo.Text += ": " +marco.nombreCortoCSV;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_compartir_Click(object sender, EventArgs e)
        {
            CompartirController.compartirMarco(marco, tb_username.Text);
            CompartirController.actualizarListaCompartidos(this);
        }
    }
}
