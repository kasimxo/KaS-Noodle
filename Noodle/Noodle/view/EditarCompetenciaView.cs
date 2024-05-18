﻿using Microsoft.Web.WebView2.Core;
using Noodle.components;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Noodle.view
{
    public partial class EditarCompetenciaView : Form
    {
        public VerCompetenciasView parent;
        public CicloDTO ciclo;
        public CompetenciaDTO com;

        public EditarCompetenciaView()
        {
            InitializeComponent();
        }

        public EditarCompetenciaView(VerCompetenciasView parent, CicloDTO ciclo, CompetenciaDTO competencia)
        {
            InitializeComponent();
            this.parent = parent;
            this.ciclo = ciclo;
            this.com = competencia;
            CompetenciaComponente comp = new CompetenciaComponente(com, false, true);
            comp.HorizontalScroll.Visible = false;
            comp.HorizontalScroll.Minimum = 100000;
            comp.VerticalScroll.Enabled = true;
            comp.VerticalScroll.Visible = true;
            comp.AutoScroll = true;
            container.Controls.Add(comp, 1, 0);
            comp.listarDetalles();

            initViewer();
        }

        private async void initViewer()
        {
            await viewer.EnsureCoreWebView2Async(null);
            navigateToPage(com.pag.ToString());
        }

        /// <summary>
        /// Método que carga una página especifica en el visualizador 
        /// </summary>
        /// <param name="pagina"></param>
        public void navigateToPage(string pagina) {
            var ub = new UriBuilder(ciclo.filePath);
            var query = new Dictionary<string, string>();

            query.Add("page", pagina);
            ub.Fragment = String.Join("&", query.Select(kv => kv.Key + "=" + WebUtility.UrlEncode(kv.Value)));

            var url = ub.Uri;

            viewer.CoreWebView2.Navigate(ub.Uri.AbsoluteUri);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
