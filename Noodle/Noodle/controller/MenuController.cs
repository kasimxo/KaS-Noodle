using Noodle.componentes.cargar;
using Noodle.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.controller
{
    public class MenuController
    {
        public static void navegarBiblioteca() 
        {
            MenuComponente menu = (MenuComponente)Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(1);

            if (Program.mW.layout.GetControlFromPosition(1, 0) != null)
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }

            BibliotecaComponente bc = new BibliotecaComponente();
            bc.Dock = DockStyle.Fill;
            Program.mW.layout.Controls.Add(bc, 1, 0);
        }
        public static void navegarCargar() 
        {
            MenuComponente menu = (MenuComponente)Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(2);

            if (Program.mW.layout.GetControlFromPosition(1, 0) != null)
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }

            CargarArchivosComponente cac = new CargarArchivosComponente();

            Program.mW.layout.Controls.Add(cac, 1, 0);
        }
        public static void navegarVer() 
        {
            if (Program.marco == null) 
            {
                return;
            }
            MenuComponente menu = (MenuComponente)Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(3);

            if (Program.mW.layout.GetControlFromPosition(1, 0) != null)
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }

            VerCompetenciasComponente vcc = new VerCompetenciasComponente(Program.marco);

            Program.mW.layout.Controls.Add(vcc, 1, 0);
        }
        public static void navegarEditar() 
        {
            if (Program.competencia == null) {
                return;
            }
            MenuComponente menu = (MenuComponente)Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(3);

            if (Program.mW.layout.GetControlFromPosition(1, 0) != null)
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }

            EditarCompetenciaComponente vcc = new EditarCompetenciaComponente(Program.competencia);

            Program.mW.layout.Controls.Add(vcc, 1, 0);
        }
        public static void navegarExportar() 
        {
            if (Program.marco == null) 
            {
                return;
            }
            MenuComponente menu = (MenuComponente)Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(4);

            if (Program.mW.layout.GetControlFromPosition(1, 0) != null)
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }

            ExportarCompetenciasComponente ecc = new ExportarCompetenciasComponente(Program.marco);
            Program.mW.layout.Controls.Add(ecc, 1, 0);
        }
    }
}
