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

        private void arrastrarArchivoComponente1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                string[] formats = e.Data.GetFormats();
                return;
            }
        }

        private void arrastrarArchivoComponente1_DragEnter(object sender, DragEventArgs e)
        {
            return;
        }
    }
}
