using Noodle.componentes.compartir;
using Noodle.model.action;
using Noodle.model.dal;
using Noodle.model.dto;
using Noodle.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.controller
{
    public class CompartirController
    {
        public static async void compartirMarco(MarcoCompetenciasDTO marco, string username) 
        {
            if (username == null || username.Length == 0) 
            {
                MessageBox.Show("Debes introducir el nombre de usuario al que quieres compartirle el marco de competencias", "Aviso");
                return;
            }
            var nombreEncriptado = AESCrypt.Encrypt(username);
            var existe = await SesionDAL.comprobarUsuarioDuplicado(nombreEncriptado);
            if (!existe) 
            {
                MessageBox.Show("No existe un usuario con ese nombre", "Aviso");
                return;
            } else 
            {
                //La id del usuario con el que vamos compartir la competencia
                var idUsuarioCompartido = await SesionDAL.seleccionarIdUsuario(nombreEncriptado);
                CompartirDAL.compartirMarcoCompetencias(marco.idDB, idUsuarioCompartido);
            }
        }

        /// <summary>
        /// Método que recupera la lista de usuarios a los que se les ha compartido este marco
        /// y lo muestra en el form
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public static async void actualizarListaCompartidos(CompartirMarcoView cmv)
        {
            List<string> usuariosRaw = await CompartirDAL.listadoUsuariosCompartidos(cmv.marco.idDB);

            cmv.flp.Controls.Clear();
            
            foreach (string usuario in usuariosRaw)
            {
                UsuarioCompartidoComponente ucc = new UsuarioCompartidoComponente(usuario);
                cmv.flp.Controls.Add(ucc);
            }

            if (cmv.flp.Controls.Count == 0)
            {
                cmv.texto_compartidocon.Text = "No has compartido este marco de competencias";
            }
            else 
            {
                cmv.texto_compartidocon.Text = "Actualmente este marco está compartido con:";
            }
        }
    }
}
