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

namespace Noodle.view
{
    public partial class MainWindowView : Form
    {
        public MainWindowView()
        {
            InitializeComponent();
            menu.marcarEstado(1);
        }

        private void hideForm(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Program.idUsuario = 0;
                Program.isW.Show();
            }

        }
    }
}
