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
                    img_ver.BackColor = black;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = black;
                    break;
                case 2:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = green;
                    img_ver.BackColor = black;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = black;
                    break;
                case 3:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = black;
                    img_ver.BackColor = green;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = black;
                    break;
                case 4:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = black;
                    img_ver.BackColor = black;
                    img_editar.BackColor = green;
                    img_exportar.BackColor = black;
                    break;
                case 5:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = black;
                    img_ver.BackColor = black;
                    img_editar.BackColor = black;
                    img_exportar.BackColor = green;
                    break;
                default:
                    img_biblioteca.BackColor = black;
                    img_cargar.BackColor = black;
                    img_ver.BackColor = black;
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

        /// <summary>
        /// Según el estado del programa (idusuario, si hay seleccionada una competencia...)
        /// actualiza las acciones del menu
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void actualizarPermisos()
        {
            //Primero hacemos reset de todo par ir quitando
            //El de cargar siempre está disponible así que no hace falta
            img_biblioteca.Click -= btn_biblioteca;
            lbl_biblioteca.Click -= btn_biblioteca;
            img_biblioteca.Click += btn_biblioteca;
            lbl_biblioteca.Click += btn_biblioteca;
            lbl_biblioteca.ForeColor = Color.White;

            img_ver.Click -= btn_ver;
            lbl_ver.Click -= btn_ver;
            img_ver.Click += btn_ver;
            lbl_ver.Click += btn_ver;
            lbl_ver.ForeColor = Color.White;

            img_editar.Click -= btn_editar;
            lbl_editar.Click -= btn_editar;
            img_editar.Click += btn_editar;
            lbl_editar.Click += btn_editar;
            lbl_editar.ForeColor = Color.White;

            img_exportar.Click -= btn_exportar;
            lbl_exportar.Click -= btn_exportar;
            img_exportar.Click += btn_exportar;
            lbl_exportar.Click += btn_exportar;
            lbl_exportar.ForeColor = Color.White;



            //Usuario invitado, quitamos la opción de biblioteca
            if (Program.idUsuario == 1)
            {
                img_biblioteca.Click -= btn_biblioteca;
                lbl_biblioteca.Click -= btn_biblioteca;
                lbl_biblioteca.ForeColor = Color.Gray;
            }

            //Marco compartido, quitamos la opción de navegar a edición
            if (Program.marco != null && Program.marco.esCompartido)
            {
                img_editar.Click -= btn_editar;
                lbl_editar.Click -= btn_editar;
                lbl_editar.ForeColor = Color.Gray;
            }
            else if (Program.marco != null && !Program.marco.esCompartido)
            {
                img_editar.Click -= btn_editar;
                lbl_editar.Click -= btn_editar;
                img_editar.Click += btn_editar;
                lbl_editar.Click += btn_editar;
                lbl_editar.ForeColor = Color.White;
            } else if (Program.marco == null)
            {
                img_ver.Click -= btn_ver;
                lbl_ver.Click -= btn_ver;
                lbl_ver.ForeColor = Color.Gray;

                img_editar.Click -= btn_editar;
                lbl_editar.Click -= btn_editar;
                lbl_editar.ForeColor = Color.Gray;

                img_exportar.Click -= btn_exportar;
                lbl_exportar.Click -= btn_exportar;
                lbl_exportar.ForeColor = Color.Gray;
            }

            if (Program.competencia == null) 
            {
                img_editar.Click -= btn_editar;
                lbl_editar.Click -= btn_editar;
                lbl_editar.ForeColor = Color.Gray;
            }
        }
    }
}
