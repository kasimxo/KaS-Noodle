using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.componentes.compartir
{
    public partial class UsuarioCompartidoComponente : UserControl
    {
        public string nombreUsuarioCompartido { get; set; }
        public Int32 idUsuarioCompartido { get; set; }
        public UsuarioCompartidoComponente(string nombreUsuario, Int32 idUsuario)
        {
            InitializeComponent();
            this.nombreUsuarioCompartido = nombreUsuario;
            this.idUsuarioCompartido = idUsuario;
            nombre.Text = nombreUsuarioCompartido;
        }
        public UsuarioCompartidoComponente(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuarioCompartido = nombreUsuario;
            //this.idUsuarioCompartido = idUsuario;
            nombre.Text = nombreUsuarioCompartido;
        }
    }
}
