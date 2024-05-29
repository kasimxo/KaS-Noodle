using Noodle.config;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Noodle.model.dal
{
    public class SesionDAL
    {
        /// <summary>
        /// Método que registra a un nuevo usuario en la base de datos
        /// Devuelve la id del usuario generado
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static async Task<Int32> registrarUsuario(byte[] nombreUsuarioByte, string nombreUsuarioText, byte[] password) 
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandRegistro = new NpgsqlCommand("registrarusuario", connection);
            commandRegistro.CommandType = System.Data.CommandType.StoredProcedure;

            commandRegistro.Parameters.AddWithValue("@nombreUsuarioByteIn", nombreUsuarioByte);
            commandRegistro.Parameters.AddWithValue("@nombreUsuarioTextIn", nombreUsuarioText);
            commandRegistro.Parameters.AddWithValue("@passwordIn", password);
            commandRegistro.Parameters.AddWithValue("@idUsuarioOut", 0);

            var idUsuario = await commandRegistro.ExecuteScalarAsync();

            connection.Close();
            return (int) idUsuario;
        }

        /// <summary>
        /// Comprueba si en la bbdd hay un usuario con ese mismo nombre
        /// Devuelve TRUE si EXISTE OTRO USUARIO
        /// FALSE si no existe ese usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <returns></returns>
        public static async Task<Boolean> comprobarUsuarioDuplicado(byte[] nombreUsuario)
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandComprobarUsuario = new NpgsqlCommand("comprobarusuario", connection);
            commandComprobarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

            commandComprobarUsuario.Parameters.AddWithValue("@nombreUsuarioIn", nombreUsuario);
            commandComprobarUsuario.Parameters.AddWithValue("@existe", false);


            var resultado = await commandComprobarUsuario.ExecuteScalarAsync();


            connection.Close();
            return (Boolean) resultado;
        }

        /// <summary>
        /// Método que consulta la bbdd para ver si está el usuario registrado y devuelve 
        /// su id
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static async Task<Int32> iniciarSesion(byte[] nombreUsuario, byte[] password) 
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandIniciarSesion = new NpgsqlCommand("iniciarsesion", connection);
            commandIniciarSesion.CommandType = System.Data.CommandType.StoredProcedure;

            commandIniciarSesion.Parameters.AddWithValue("@nombreUsuarioIn", nombreUsuario);
            commandIniciarSesion.Parameters.AddWithValue("@passwordIn", password);
            commandIniciarSesion.Parameters.AddWithValue("@idUsuarioOut", 0);

            var id = await commandIniciarSesion.ExecuteScalarAsync();

            if (id == null) 
            {
                MessageBox.Show("No se ha podido iniciar sesión", "Aviso");
                return 0;
            }

            return (int) id;
        }

        public static async Task<Int32> seleccionarIdUsuario(byte[] nombreEncriptado)
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandMarco = new NpgsqlCommand("seleccionaridusuario", connection);

            commandMarco.CommandType = System.Data.CommandType.StoredProcedure;

            commandMarco.Parameters.AddWithValue("@nombreUsuarioIn", nombreEncriptado);
            commandMarco.Parameters.AddWithValue("@idUsuarioOut", 0);
            var resultado = commandMarco.ExecuteScalar();

            connection.Close();
            return (int) resultado;
        }
    }
}
