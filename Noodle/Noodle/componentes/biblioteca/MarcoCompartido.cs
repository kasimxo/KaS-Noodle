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

namespace Noodle.componentes.biblioteca
{
    public partial class MarcoCompartido : UserControl
    {
        public MarcoCompetenciasDTO marco { get; set; }
        public MarcoCompartido(MarcoCompetenciasDTO m)
        {
            InitializeComponent();
            this.marco = m;
            nombre.Text = marco.nombreCortoCSV;
        }

        private void marcoCompartido_Click(object sender, EventArgs e)
        {
            BibliotecaController.verMarco(marco);
        }
    }
}
