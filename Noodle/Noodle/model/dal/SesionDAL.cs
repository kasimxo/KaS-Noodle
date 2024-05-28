﻿using Noodle.config;
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
        public static async Task<Int32> registrarUsuario(byte[] nombreUsuario, byte[] password) 
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandRegistro = new NpgsqlCommand("registrarusuario", connection);
            commandRegistro.CommandType = System.Data.CommandType.StoredProcedure;

            commandRegistro.Parameters.AddWithValue("@nombreUsuarioIn", nombreUsuario);
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
            var commandRegistro = new NpgsqlCommand("registrarusuario", connection);
            commandRegistro.CommandType = System.Data.CommandType.StoredProcedure;

            commandRegistro.Parameters.AddWithValue("@nombreUsuarioIn", nombreUsuario);
            commandRegistro.Parameters.AddWithValue("@idUsuarioOut", 0);

            var resultado = await commandRegistro.ExecuteScalarAsync();

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
        public static async Task<Int32> iniciarSesion(string nombreUsuario, string password) 
        {
            
            return 0;
        }
    }
}