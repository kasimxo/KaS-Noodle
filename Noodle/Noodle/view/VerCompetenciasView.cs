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
    public partial class VerCompetenciasView : Form
    {
        public CicloDTO ciclo;
        public CompetenciaDTO competenciaDetalle;

        private Boolean loading;
        public VerCompetenciasView()
        {
            loading = false;
            InitializeComponent();
            initView();

        }

        

        public VerCompetenciasView(CicloDTO ciclo)
        {
            this.ciclo = ciclo;

            InitializeComponent();

            initView();
            titulo.Text = ciclo.denominacion;

            listarCompetencias();
            detalleCompetencia.btn_editar.Click += (sender, e) => {
                navegarEditarCompetencias();
            };


        }

        private void listarCompetencias()
        {
            flp.Controls.Clear();
            foreach (CompetenciaDTO com in ciclo.competencias.Values)
            {
                CompetenciaComponente comp = new CompetenciaComponente(com);
                comp.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com, comp);
                comp.nombre.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.nombre.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com, comp);
                flp.Controls.Add(comp);
            }
        }

        /// <summary>
        /// Devuelve el color azul a todas las competencias y limpia el detalle de competencia
        /// </summary>
        private void limpiarCompetencias()
        {
            foreach (CompetenciaComponente comp in flp.Controls.OfType<CompetenciaComponente>())
            {
                 comp.BackColor = Color.PaleTurquoise;
            }
            detalleCompetencia.limpiar();
        }

        private void VerDetalleCompetencia(Object sender, EventArgs e, CompetenciaDTO com, CompetenciaComponente comp)
        {
            this.competenciaDetalle = com;
            limpiarCompetencias();
            Color green = Color.FromArgb(255, 195, 250, 185);
            detalleCompetencia.nombreCom = com.nombre;
            detalleCompetencia.competencia = com;
            detalleCompetencia.nombre.Text = com.nombre;
            detalleCompetencia.listarDetalles();
            detalleCompetencia.btn_editar.Visible = true;
            detalleCompetencia.BackColor = green;
            
            detalleCompetencia.Visible = true;
            comp.BackColor = green;
        }
        private void VerDetalleCompetencia( CompetenciaDTO com, CompetenciaComponente comp)
        {
            this.competenciaDetalle = com;
            limpiarCompetencias();
            Color green = Color.FromArgb(255, 195, 250, 185);
            detalleCompetencia.nombreCom = com.nombre;
            detalleCompetencia.competencia = com;
            detalleCompetencia.nombre.Text = com.nombre;
            detalleCompetencia.listarDetalles();
            detalleCompetencia.btn_editar.Visible = true;
            detalleCompetencia.BackColor = green;
            detalleCompetencia.Visible = true;
            comp.BackColor = green;
        }

        private void navegarEditarCompetencias() {
            EditarCompetenciaView ecv = new EditarCompetenciaView(this, ciclo, competenciaDetalle);
            ecv.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarCompetenciasView ecv = new ExportarCompetenciasView(ciclo);
            ecv.Show();
            this.Close();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            
            Program.mW.Show();
            this.Close();
        }

        public void updateCompetencia(CompetenciaDTO com)
        {
            try
            {
                ciclo.competencias[com.nombre] = com;
                listarCompetencias();
                VerDetalleCompetencia(com, new CompetenciaComponente(com));
            }
            catch (Exception e) { }
        }

        public void initView()
        {
            ClientSize = Screen.PrimaryScreen.WorkingArea.Size;
            flp.MaximumSize = new Size(0, this.Height - 175);
            detalleCompetencia.MaximumSize = new Size(0, this.Height - 175);
            flp.HorizontalScroll.Visible = false;
            flp.HorizontalScroll.Minimum = 100000;
            flp.VerticalScroll.Enabled = true;
            flp.VerticalScroll.Visible = true;
            flp.AutoScroll = true;
            detalleCompetencia.HorizontalScroll.Visible = false;
            detalleCompetencia.HorizontalScroll.Minimum = 100000;
            detalleCompetencia.VerticalScroll.Enabled = true;
            detalleCompetencia.VerticalScroll.Visible = true;
            detalleCompetencia.AutoScroll = true;
        }
        /*
* 
   ClientSize = Screen.PrimaryScreen.WorkingArea.Size;
   flp.MaximumSize = new Size(0, this.Height - 175);
   detalleCompetencia.MaximumSize = new Size(0, this.Height - 175);
   flp.HorizontalScroll.Visible = false;
   flp.HorizontalScroll.Minimum = 100000;
   flp.VerticalScroll.Enabled = true;
   flp.VerticalScroll.Visible = true;
   flp.AutoScroll = true;
   detalleCompetencia.HorizontalScroll.Visible = false;
   detalleCompetencia.HorizontalScroll.Minimum = 100000;
   detalleCompetencia.VerticalScroll.Enabled = true;
   detalleCompetencia.VerticalScroll.Visible = true;
   detalleCompetencia.AutoScroll = true;
*/
    }
}
