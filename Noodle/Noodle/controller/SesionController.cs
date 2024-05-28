using Noodle.componentes.iniciarsesion;
using Noodle.model.action;
using Noodle.model.dal;
using Noodle.view;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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
            RegistrarUsuarioComponente registrarUsuarioForm = (RegistrarUsuarioComponente) Program.isW.container.GetControlFromPosition(0, 1);
            
            
            var nombreUsuarioText = registrarUsuarioForm.tb_username.Text;
            var pass1 = registrarUsuarioForm.tb_password1.Text;
            var pass2 = registrarUsuarioForm.tb_password2.Text;

            if (nombreUsuarioText.Length == 0 || pass1.Length == 0 || pass2.Length == 0)
            {
                MessageBox.Show("Debes rellenar todos los campos para poder registrar un nuevo usuario", "Aviso");
                return;
            }
            else if (pass1.CompareTo(pass2) != 0) 
            {
                MessageBox.Show("Las contraseñas no coinciden", "Aviso");
                return;
            }

            var usuarioEncriptado = AESCrypt.Encrypt(nombreUsuarioText);
            var passEncriptada = AESCrypt.Encrypt(pass1);

            var id = SesionDAL.registrarUsuario(usuarioEncriptado, passEncriptada);
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
