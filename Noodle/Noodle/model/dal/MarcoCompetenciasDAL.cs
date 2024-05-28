using Noodle.config;
using Noodle.model.dto;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Noodle.model.dal
{
    public class MarcoCompetenciasDAL
    {

        /// <summary>
        /// Método que guarda un marco de competencias en la bbdd
        /// También guarda las competencias, resultados de aprendizaje y criterios de evaluación
        /// </summary>
        /// <param name="marco"></param>
        public static async void guardarMarcoCompetencias(MarcoCompetenciasDTO marco)
        {
            //Por si no tiene las variables iniciadas
            marco.ToCSV();

            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandMarco = new NpgsqlCommand("insertarmarcocompetencias", connection);

            commandMarco.CommandType = System.Data.CommandType.StoredProcedure;

            commandMarco.Parameters.AddWithValue("@idPadreCSVIn", marco.idPadreCSV);
            commandMarco.Parameters.AddWithValue("@idCSVIn", marco.idCSV);
            commandMarco.Parameters.AddWithValue("@nombreCortoCSVIn", marco.nombreCortoCSV);
            commandMarco.Parameters.AddWithValue("@descripcionCSVIn", marco.descripcionCSV);
            commandMarco.Parameters.AddWithValue("@descripcionFormatoCSVIn", marco.descripcionFormatoCSV);
            commandMarco.Parameters.AddWithValue("@valoresEscalaCSVIn", marco.valoresEscalaCSV);
            commandMarco.Parameters.AddWithValue("@configuracionEscalaCSVIn", marco.configuracionEscalaCSV);
            commandMarco.Parameters.AddWithValue("@tipoReglaCSVIn", marco.tipoReglaCSV);
            commandMarco.Parameters.AddWithValue("@resultadoReglaCSVIn", marco.resultadoReglaCSV);
            commandMarco.Parameters.AddWithValue("@configuracionReglaCSVIn", marco.configuracionReglaCSV);
            commandMarco.Parameters.AddWithValue("@idReferenciasCruzadasCompetenciasCSVIn", marco.idReferenciasCruzadasCompetenciasCSV);
            commandMarco.Parameters.AddWithValue("@idExportacionCSVIn", marco.idExportacionCSV);
            commandMarco.Parameters.AddWithValue("@esMarcoCompetenciasCSVIn", true);
            commandMarco.Parameters.AddWithValue("@taxonomiaCSVIn", marco.taxonomiaCSV);
            commandMarco.Parameters.AddWithValue("@filePathIn", marco.filePath);
            commandMarco.Parameters.AddWithValue("@idUsuarioIn", Program.idUsuario);
            commandMarco.Parameters.AddWithValue("@idGenerado", 0);

            //El id del marco que acabamos de insertar
            Int32 idMarcoGenerado = (int) commandMarco.ExecuteScalar();

            foreach (CompetenciaDTO com in marco.competencias.Values)
            {
                CompetenciaDAL.guardarCompetencia(com, connection, idMarcoGenerado);
            }

            connection.Close();
            return;
            //await using var reader = await command.ExecuteReaderAsync();
        }

        public static async Task<Dictionary<Int32, MarcoCompetenciasDTO>> cargarMarcosCompetencias() 
        {
            Dictionary<Int32, MarcoCompetenciasDTO> marcos = new Dictionary<Int32, MarcoCompetenciasDTO>();

            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandMarco = new NpgsqlCommand("SELECT * from public.cargarmarcoscompetencias("+Program.idUsuario+");", connection);

            var resultSet = await commandMarco.ExecuteReaderAsync();

            while (resultSet.Read()) {
                MarcoCompetenciasDTO marco = new MarcoCompetenciasDTO();

                //En la posicion 0 el resultset tiene el id del marco en la bbdd
                //Esto es útil para rescatar despues las campetencias, RA y CE correspondientes
                String[] partes = {
                    resultSet.GetString(1),
                    resultSet.GetString(2),
                    resultSet.GetString(3),
                    resultSet.GetString(4),
                    resultSet.GetString(5),
                    resultSet.GetString(6),
                    resultSet.GetString(7),
                    resultSet.GetString(8),
                    resultSet.GetString(9),
                    resultSet.GetString(10),
                    resultSet.GetString(11),
                    resultSet.GetString(12),
                    resultSet.GetString(13),
                    resultSet.GetString(14)
                };
                marco.fromCSV(partes);

                try {

                    marco.filePath = resultSet.GetString(15);
                } catch (Exception ex) 
                {
                }


                marco.idDB = resultSet.GetInt32(0);

                marcos.Add(marco.idDB, marco);
            }

            connection.Close();

            /*
            foreach (MarcoCompetenciasDTO marco in marcos) 
            {
                marco.competencias = await CompetenciaDAL.cargarCompetencia(marco.idDB);
            }
            */

            return marcos;
        }

        /// <summary>
        /// Elimina de la base de datos (y de la aplicación) un marco de competencias
        /// Devuelve true si la operación se ha realizado con éxito
        /// </summary>
        /// <param name="marco"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static async Task<Boolean> eliminarMarcoCompetencias(MarcoCompetenciasDTO marco)
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandMarco = new NpgsqlCommand("borrarmarcocompetencias", connection);

            commandMarco.CommandType = System.Data.CommandType.StoredProcedure;

            commandMarco.Parameters.AddWithValue("@idMarcoIn", marco.idDB);
            commandMarco.Parameters.AddWithValue("@idUsuarioIn", Program.idUsuario);
            var resultado = commandMarco.ExecuteNonQuery();

            if (resultado > 0)
            {
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        internal static async Task<long> numeroMarcosCompetencias()
        {

            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandMarco = new NpgsqlCommand("SELECT * from public.numeromarcoscompetencias("+Program.idUsuario+");", connection);
            var numeroMarcos = await commandMarco.ExecuteScalarAsync();

            //var numeroMarcos = resultSet.GetValue(0);
            return (long)numeroMarcos;
        }
    }
}
