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

        public static async Task<List<MarcoCompetenciasDTO>> cargarMarcosCompetencias() 
        {
            List<MarcoCompetenciasDTO> marcos = new List<MarcoCompetenciasDTO>();

            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandMarco = new NpgsqlCommand("SELECT * from public.cargarmarcoscompetencias();", connection);

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

                marco.idDB = resultSet.GetInt32(0);

                marcos.Add(marco);
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


    }
}
