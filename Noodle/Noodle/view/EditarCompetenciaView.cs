using Microsoft.Web.WebView2.Core;
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
        public string focusPage; //Esta es la página que queremos abrir con el navegador

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
            CompetenciaComponente comp = new CompetenciaComponente(com);
            container.Controls.Add(comp, 1, 0);
            initViewer();
        }

        private async void initViewer()
        {
            focusPage = com.pag.ToString();
            var ub = new UriBuilder(ciclo.filePath);
            var query = new Dictionary<string, string>();
            
            query.Add("page", focusPage);
            ub.Fragment = String.Join("&", query.Select(kv => kv.Key + "=" + WebUtility.UrlEncode(kv.Value)));
            

            var url = ub.Uri;
            viewer.Source = url;
            await viewer.EnsureCoreWebView2Async(null);

            
            //viewer.NavigationCompleted += reloadWithParams;
            /*
            var ub = new UriBuilder(ciclo.filePath);
            var query = new Dictionary<string, string>();
            query.Add("page", focusPage);
            ub.Query = String.Join("&", query.Select(kv => kv.Key+"="+WebUtility.UrlEncode(kv.Value)));


            var url = ub.Uri.AbsoluteUri;

            */

            //viewer.CoreWebView2.Navigate(ciclo.filePath);
            /*
            var request = viewer.CoreWebView2.Environment.CreateWebResourceRequest(
                uri: ciclo.filePath,
                Method: "GET",
                postData: null,
                Headers: ""
                );


            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("page", "2");
            

            viewer.CoreWebView2.NavigateWithWebResourceRequest(request);
            */
            /*
            var request = viewer.CoreWebView2.Environment.CreateWebResourceRequest(
                uri: ciclo.filePath,
                Method: "GET",
                postData: null,
                Headers: ""
                );

            request.Headers.SetHeader("page", focusPage);
            */
            //viewer.CoreWebView2.NavigateWithWebResourceRequest(cic);
            System.Console.WriteLine();
        }

        private void reloadWithParams(Object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            var request = viewer.CoreWebView2.Environment.CreateWebResourceRequest(
                uri: ciclo.filePath,
                Method: "GET",
                postData: null,
                Headers: "page: 2"
                );

            //request.Headers.SetHeader("page", "2");
            var url = request.Uri;
            var h = request.Headers;
            //viewer.CoreWebView2.NavigateWithWebResourceRequest(request);
            
            viewer.NavigationCompleted -= reloadWithParams;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
