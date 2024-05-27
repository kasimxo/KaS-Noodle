using Noodle.componentes.editar;
using Noodle.model.dto;
using Noodle.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.components
{
    public partial class EditarCompetenciaComponente : UserControl
    {
        public CompetenciaDTO com { get; set; }
        public EditarCompetenciaComponente(CompetenciaDTO competencia)
        {
            InitializeComponent();
            this.com = competencia;
            inciarCompetencia();
        }

        /// <summary>
        /// Carga todo el contenido de la competencia
        /// </summary>
        private async void inciarCompetencia() 
        { 
            DetalleCompetenciaEditable dce = new DetalleCompetenciaEditable(this.com);
            dce.Dock = DockStyle.Fill;

            //Si no tiene el filepath, quitamos el file viewer y ampliamos todo
            if (Program.marco == null || Program.marco.filePath == null || !File.Exists(Program.marco.filePath))
            {
                container.GetControlFromPosition(0, 0).Dispose();
                container.Controls.Add(dce, 0, 0);
                container.ColumnCount--;
            }
            else 
            {
                container.Controls.Add(dce, 1, 0);
                await viewer.EnsureCoreWebView2Async(null);
                navigateToPage(com.pag);
            }
        }

        public void navigateToPage(Int32 pagina)
        {
            var ub = new UriBuilder(Program.marco.filePath);
            var query = new Dictionary<string, string>();
            //Si la página no es válida, se abrirá en la 1
            query.Add("page", pagina.ToString());
            ub.Fragment = String.Join("&", query.Select(kv => kv.Key + "=" + WebUtility.UrlEncode(kv.Value)));
            var url = ub.Uri;
            viewer.CoreWebView2.Navigate(ub.Uri.AbsoluteUri);
        }
    }
}
