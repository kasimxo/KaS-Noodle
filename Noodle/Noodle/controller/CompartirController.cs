using Noodle.model.action;
using Noodle.model.dal;
using Noodle.model.dto;
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
                MarcoCompetenciasDAL.compartirMarcoCompetencias(marco.idDB, idUsuarioCompartido);
            }
        }
    }
}
