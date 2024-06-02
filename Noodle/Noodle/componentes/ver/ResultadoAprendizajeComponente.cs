using Noodle.componentes.ver;
using Noodle.model.dal;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Noodle.components
{
    public partial class ResultadoAprendizajeComponente : UserControl
    {
        public string nombreRa;
        public System.Windows.Forms.Label editando;
        public ResultadoAprendizajeDTO ra;
        public Boolean editable;
        public Boolean editado; //Controla si se ha editado almenos una cosa para mostrar mensaje de confirmación
        public RichTextBox texto;

        public ResultadoAprendizajeComponente(ResultadoAprendizajeDTO ra)
        {
            
            InitializeComponent();
            this.ra = ra;
            this.nombreRa = ra.nombre;
            
            if (ra.criterios == null || ra.criterios.Count == 0)
            {
                cargarCriteriosEvaluacionBaseDeDatos();
            }
            else
            {
                cargarCriteriosEvaluacion();
            }
            nombre.Text = ra.descripcionCSV;
        }


        public void cargarCriteriosEvaluacion()
        {
            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
            {
                CriterioEvaluacionComponente cec = new CriterioEvaluacionComponente(ce);
                flp.Controls.Add(cec);
            }
        }

        public async void cargarCriteriosEvaluacionBaseDeDatos()
        {
            ra.criterios = await CriterioEvaluacionDAL.cargarCriteriosEvaluacion(ra.idDB);

            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Margin = new Padding(2);
                label.Text = ce.nombreCortoCSV;
                label.AutoSize = true;
                //Aqui hay que meter un CriterioEvaluacionComponente, para que pueda tener 
                //Tanto el identificador (nombre corto) como la descripcion
                flp.Controls.Add(label);
            }
        }
        
    }
}
