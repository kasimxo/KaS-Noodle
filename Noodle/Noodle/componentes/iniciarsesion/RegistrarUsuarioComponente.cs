using Noodle.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.componentes.iniciarsesion
{
    public partial class RegistrarUsuarioComponente : UserControl
    {
        public RegistrarUsuarioComponente()
        {
            InitializeComponent();
        }

        private void mostrarIniciaSesion(object sender, EventArgs e)
        {
            this.Dispose();
            IniciarSesionComponente isc = new IniciarSesionComponente();
            Program.isW.container.Controls.Add(isc, 0, 1);
        }

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            SesionController.registrarUsuario();
        }
    }
}
