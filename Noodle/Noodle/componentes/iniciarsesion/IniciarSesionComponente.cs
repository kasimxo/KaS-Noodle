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
    public partial class IniciarSesionComponente : UserControl
    {
        public IniciarSesionComponente()
        {
            InitializeComponent();
        }

        private void entrarInvitado(object sender, EventArgs e)
        {
            SesionController.iniciarSesionInvitado();
        }

        private void iniciarSesion(object sender, EventArgs e)
        {
            SesionController.iniciarSesion();
        }

        private void abrirFormRegistrarUsuario(object sender, EventArgs e)
        {
            Program.isW.iniciarSesionComponente1.Dispose();
            RegistrarUsuarioComponente ruc = new RegistrarUsuarioComponente();
            Program.isW.container.Controls.Add(ruc, 0 , 1);
        }
    }
}
