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
    public partial class ArrastrarArchivoComponente : UserControl
    {
        public ArrastrarArchivoComponente()
        {
            InitializeComponent();
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void ArrastrarArchivoComponente_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                string[] formats = e.Data.GetFormats();
                return;
            }
        }
    }
}
