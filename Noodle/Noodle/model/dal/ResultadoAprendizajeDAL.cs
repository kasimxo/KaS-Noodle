using Noodle.config;
using Noodle.model.dto;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dal
{
    public class ResultadoAprendizajeDAL
    {
        public static void guardarResultadoAprendizaje(ResultadoAprendizajeDTO ra, NpgsqlConnection connection, Int32 idCompetenciaGenerado) 
        {
            var commandRa = new NpgsqlCommand("insertarresultadoaprendizaje", connection);

            commandRa.CommandType = System.Data.CommandType.StoredProcedure;

            commandRa.Parameters.AddWithValue("@idPadreCSVIn", ra.idPadreCSV);
            commandRa.Parameters.AddWithValue("@idCSVIn", ra.idCSV);
            commandRa.Parameters.AddWithValue("@nombreCortoCSVIn", ra.nombreCortoCSV);
            commandRa.Parameters.AddWithValue("@descripcionCSVIn", ra.descripcionCSV);
            commandRa.Parameters.AddWithValue("@descripcionFormatoCSVIn", ra.descripcionFormatoCSV);
            commandRa.Parameters.AddWithValue("@valoresEscalaCSVIn", ra.valoresEscalaCSV);
            commandRa.Parameters.AddWithValue("@configuracionEscalaCSVIn", ra.configuracionEscalaCSV);
            commandRa.Parameters.AddWithValue("@tipoReglaCSVIn", ra.tipoReglaCSV);
            commandRa.Parameters.AddWithValue("@resultadoReglaCSVIn", ra.resultadoReglaCSV);
            commandRa.Parameters.AddWithValue("@configuracionReglaCSVIn", ra.configuracionReglaCSV);
            commandRa.Parameters.AddWithValue("@idReferenciasCruzadasCompetenciasCSVIn", ra.idReferenciasCruzadasCompetenciasCSV);
            commandRa.Parameters.AddWithValue("@idExportacionCSVIn", ra.idExportacionCSV);
            commandRa.Parameters.AddWithValue("@esMarcoCompetenciasCSVIn", ra.esMarcoCompetenciasCSV);
            commandRa.Parameters.AddWithValue("@taxonomiaCSVIn", ra.taxonomiaCSV);
            commandRa.Parameters.AddWithValue("@idCompetenciaPadreGenerado", idCompetenciaGenerado);
            commandRa.Parameters.AddWithValue("@idGenerado", 0);

            Int32 idResultadoAprendizajeGenerado = (int) commandRa.ExecuteScalar();

            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
            {
                CriterioEvaluacionDAL.guardarCriterioEvaluacion(ce, connection, idResultadoAprendizajeGenerado);
            }
        }

        public static async Task<Dictionary<string, ResultadoAprendizajeDTO>> cargarResultadosAprendizaje(Int32 idCompetenciaCargado)
        {
            Dictionary<string, ResultadoAprendizajeDTO> ras = new Dictionary<string, ResultadoAprendizajeDTO>();

            //En este caso abrimos y cerramos la conexión aquí mismo porque sino da exception al tener un comando in progress
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandResultadosAprendizaje = new NpgsqlCommand("SELECT * from public.cargarresultadosaprendizaje(" + idCompetenciaCargado + ");", connection);

            var resultSet = await commandResultadosAprendizaje.ExecuteReaderAsync();

            while (resultSet.Read())
            {
                ResultadoAprendizajeDTO ra = new ResultadoAprendizajeDTO();

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
                ra.fromCSV(partes);

                ra.idDB = resultSet.GetInt32(0);

                ras.Add(ra.nombreCortoCSV, ra);
            }
            connection.Close();

            foreach (ResultadoAprendizajeDTO ra in ras.Values)
            {
                ra.criterios = await CriterioEvaluacionDAL.cargarCriteriosEvaluacion(ra.idDB);
            }

            return ras;

        }
    }
}
