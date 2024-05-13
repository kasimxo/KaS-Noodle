using Noodle.components;
using Noodle.model.dto;
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
    public partial class EditarCompetenciasView : Form
    {
        public CicloDTO ciclo;
        public List<CompetenciaDTO> competencias;
        public EditarCompetenciasView()
        {
            InitializeComponent();
            initView();
        }

        public EditarCompetenciasView(List<CompetenciaDTO> competencias)
        {
            this.competencias = competencias;

            InitializeComponent();

            initView();

            foreach (CompetenciaDTO com in competencias)
            {
                CompetenciaComponente comp = new CompetenciaComponente(com);
                comp.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com);
                comp.nombre.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.nombre.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com);
                flp.Controls.Add(comp);
            }
        }

        public EditarCompetenciasView(CicloDTO ciclo)
        {
            this.ciclo = ciclo;

            InitializeComponent();

            initView();
            titulo.Text = ciclo.denominacion;

            foreach (CompetenciaDTO com in ciclo.competencias.Values)
            {
                CompetenciaComponente comp = new CompetenciaComponente(com);
                comp.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com);
                comp.nombre.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.nombre.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com);
                flp.Controls.Add(comp);
            }
        }


        private void VerDetalleCompetencia(Object sender, EventArgs e, CompetenciaDTO com)
        {
            
            detalleCompetencia.nombreCom = com.nombre;
            detalleCompetencia.competencia = com;
            detalleCompetencia.nombre.Text = com.nombre;
            detalleCompetencia.listarDetalles();
            detalleCompetencia.nombre.MaximumSize = new Size(0, 0);
            detalleCompetencia.AutoScroll = true;
            detalleCompetencia.MaximumSize = new Size(0, this.Height-50);
            
            detalleCompetencia.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarCompetenciasView ecv = new ExportarCompetenciasView(competencias);
            ecv.Show();
            this.Close();
        }

        public void initView()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
