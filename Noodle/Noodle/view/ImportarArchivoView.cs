using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Noodle.controller;
using Noodle.model.action;
using Noodle.model.dto;

namespace Noodle.view
{
    public partial class ImportarArchivoView : Form
    {
        public ImportarArchivoView()
        {
            InitializeComponent();
            initView();
        }
        public void initView()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ImportarArchivoController.procesarArchivoBtn(true);
        }

        /// <summary>
        /// Método que gestiona la acción de arrastrar archivos al componente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arrastrarArchivoComponente1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 1) {
                MessageBox.Show("Error: Se ha detectado más de un archivo");
            } else if (files.Length < 1)
            {
                MessageBox.Show("Error: No se ha detectado ningún archivo");
            } else
            {
                ImportarArchivoController.procesarArchivoGenerico(files[0]);
            }
        }

        private void arrastrarArchivoComponente1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void arrastrarArchivoComponente1_DragOver(object sender, DragEventArgs e)
        {

        }
    }
}
