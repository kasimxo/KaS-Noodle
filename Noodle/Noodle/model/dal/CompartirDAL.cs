using Noodle.config;
using Noodle.model.action;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dal
{
    /// <summary>
    /// Clase que gestiona todas las operaciones relacionadas con
    /// compartir marcos de competencias en la base de datos
    /// </summary>
    public class CompartirDAL
    {

        /// <summary>
        /// Método que crea una 'instancia' de marco compartido
        /// Es decir, inserta en la tabla de compartidos de la base de datos
        /// un nuevo registro
        /// </summary>
        /// <param name="idMarco"></param>
        /// <param name="idUsuarioCompartido"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static async void compartirMarcoCompetencias(Int32 idMarco, Int32 idUsuarioCompartido)
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandMarco = new NpgsqlCommand("insertarinstanciacompartido", connection);

            commandMarco.CommandType = System.Data.CommandType.StoredProcedure;

            commandMarco.Parameters.AddWithValue("@idMarcoIn", idMarco);
            commandMarco.Parameters.AddWithValue("@idUsuarioPropietarioIn", Program.idUsuario);
            commandMarco.Parameters.AddWithValue("@idUsuarioCompartidoIn", idUsuarioCompartido);
            try
            {
                var resultado = commandMarco.ExecuteNonQuery();
                connection.Close();
                return;
            }
            catch (PostgresException pe) 
            {
                if (pe.ConstraintName.CompareTo("claveprimaria_compartidos") == 0) 
                {
                    MessageBox.Show("Ya has compartido este marco de competencias con este usuario", "Aviso");
                }
                connection.Close();
                return;
            }
            
        }

        public static async Task<List<string>> listadoUsuariosCompartidos(Int32 idMarco)
        {
            List<string> usuariosRaw = new List<string>();

            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();

            var commandCompartir = new NpgsqlCommand("SELECT * FROM public.consultarusuarioscompartidos("+Program.idUsuario+","+idMarco+");", connection);

            string vacio = "cadena";

            try
            {
                
                NpgsqlDataReader reader = await commandCompartir.ExecuteReaderAsync();

                while (reader.Read()) {
                    var nombre = reader.GetString(0);
                    usuariosRaw.Add(nombre);
                }

                return usuariosRaw;
            }
            catch (Exception ex) 
            {
                connection.Close();
                return usuariosRaw;
            }

        }
    }
}
