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

namespace Noodle.components
{
    public partial class MenuComponente : UserControl
    {
        public MenuComponente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Indica en color verde en qué pantalla estamos
        /// </summary>
        /// <param name="estado">1 biblioteca<br>2 cargar<br>3 editar<br>4 exportar</param>
        public void marcarEstado(int estado)
        {
            Color green = Color.FromArgb(105, 195, 250, 185);
            Color black = Color.FromArgb(255, 23, 21, 22);
            switch (estado)
            {
                case 1:
                    img_biblioteca.BackColor = green;
                    img_cargar.BackColor = black;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = black;
                    break;
                case 2:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = green;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = black;
                    break;
                case 3:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = black;
                    img_editar.BackColor = green;
                    img_exportar.BackColor = black;
                    break;
                case 4:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = black;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = green;
                    break;
                default:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = black;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = black;
                    break;
            }
        }

        private void btn_biblioteca(object sender, EventArgs e) { NavegacionController.navegarBiblioteca(); }

        private void btn_cargar(object sender, EventArgs e) { NavegacionController.navegarCargar(); }

        private void btn_ver(object sender, EventArgs e) { NavegacionController.navegarVer(); }
        private void btn_editar(object sender, EventArgs e) { NavegacionController.navegarEditar(); }
        private void btn_exportar(object sender, EventArgs e) { NavegacionController.navegarExportar(); }

    }
}
