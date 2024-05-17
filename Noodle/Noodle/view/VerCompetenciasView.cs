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
        public List<CompetenciaDTO> competencias;
        public VerCompetenciasView()
        {
            InitializeComponent();
            initView();
        }

        public VerCompetenciasView(List<CompetenciaDTO> competencias)
        {
            this.competencias = competencias;

            InitializeComponent();

            initView();

            foreach (CompetenciaDTO com in competencias)
            {
                CompetenciaComponente comp = new CompetenciaComponente(com);
                comp.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com, comp);
                comp.nombre.MouseClick -= comp.CompetenciaComponente_MouseClick;
                comp.nombre.MouseClick += (sender, e) => VerDetalleCompetencia(sender, e, com, comp);
                flp.Controls.Add(comp);
            }
        }

        public VerCompetenciasView(CicloDTO ciclo)
        {
            this.ciclo = ciclo;

            InitializeComponent();

            initView();
            titulo.Text = ciclo.denominacion;

            listarCompetencias();



        }

        private void listarCompetencias()
        {
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

        private void limpiarCompetencias()
        {
            foreach (CompetenciaComponente comp in flp.Controls.OfType<CompetenciaComponente>())
            {
                Color white = Color.FromArgb(255, 255, 255, 255);
                comp.BackColor = white;
            }
            detalleCompetencia.limpiar();
        }

        private void VerDetalleCompetencia(Object sender, EventArgs e, CompetenciaDTO com, CompetenciaComponente comp)
        {
            limpiarCompetencias();
            Color green = Color.FromArgb(255, 195, 250, 185);
            detalleCompetencia.nombreCom = com.nombre;
            detalleCompetencia.competencia = com;
            detalleCompetencia.nombre.Text = com.nombre;
            detalleCompetencia.listarDetalles();
            //detalleCompetencia.nombre.MaximumSize = new Size(0, 0);
            //detalleCompetencia.AutoScroll = true;
            //detalleCompetencia.MaximumSize = new Size(0, this.Height-25);
            detalleCompetencia.btn_editar.Visible = true;
            detalleCompetencia.BackColor = green;
            detalleCompetencia.btn_editar.Click += (sender, e) => {
                EditarCompetenciaView ecv = new EditarCompetenciaView(this, ciclo, com);
                ecv.Visible = true;
                this.Hide();
            };
            

            detalleCompetencia.Visible = true;

            comp.BackColor = green;

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
