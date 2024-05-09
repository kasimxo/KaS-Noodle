using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportarArchivoController.procesarArchivoBtn();
        }
    }
}
