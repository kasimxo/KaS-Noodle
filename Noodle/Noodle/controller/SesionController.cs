using Noodle.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.controller
{
    /// <summary>
    /// Controllador para lo referente a la sesión
    /// Iniciar sesión, registrar usuario, entrar como invitado, cerrar sesión...
    /// </summary>
    public class SesionController
    {
        public static void iniciarSesion() 
        {
            var nombreUsuario = Program.isW.iniciarSesionComponente1.tb_username.Text;
            var pass = Program.isW.iniciarSesionComponente1.tb_password.Text;
            if (nombreUsuario != null && pass != null && nombreUsuario.Length > 0 && pass.Length > 0)
            {
            }
            else 
            {
                return;
            }
        }

        public static void registrarUsuario() 
        { 
            
        }

        public static void iniciarSesionInvitado()
        {
            Program.idUsuario = 1;
            NavegacionController.navegarCargar();

            Program.mW.Show();
            Program.isW.Hide();
        }
    }
}
