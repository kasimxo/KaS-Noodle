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
    public class CriterioEvaluacionDAL
    {
        public static void guardarCriterioEvaluacion(CriterioEvaluacionDTO ce, NpgsqlConnection connection, Int32 idResultadoAprendizajeGenerado) 
        {

            var commandCe = new NpgsqlCommand("insertarcriterioevaluacion", connection);

            commandCe.CommandType = System.Data.CommandType.StoredProcedure;

            commandCe.Parameters.AddWithValue("@idPadreCSVIn", ce.idPadreCSV);
            commandCe.Parameters.AddWithValue("@idCSVIn", ce.idCSV);
            commandCe.Parameters.AddWithValue("@nombreCortoCSVIn", ce.nombreCortoCSV);
            commandCe.Parameters.AddWithValue("@descripcionCSVIn", ce.descripcionCSV);
            commandCe.Parameters.AddWithValue("@descripcionFormatoCSVIn", ce.descripcionFormatoCSV);
            commandCe.Parameters.AddWithValue("@valoresEscalaCSVIn", ce.valoresEscalaCSV);
            commandCe.Parameters.AddWithValue("@configuracionEscalaCSVIn", ce.configuracionEscalaCSV);
            commandCe.Parameters.AddWithValue("@tipoReglaCSVIn", ce.tipoReglaCSV);
            commandCe.Parameters.AddWithValue("@resultadoReglaCSVIn", ce.resultadoReglaCSV);
            commandCe.Parameters.AddWithValue("@configuracionReglaCSVIn", ce.configuracionReglaCSV);
            commandCe.Parameters.AddWithValue("@idReferenciasCruzadasCompetenciasCSVIn", ce.idReferenciasCruzadasCompetenciasCSV);
            commandCe.Parameters.AddWithValue("@idExportacionCSVIn", ce.idExportacionCSV);
            commandCe.Parameters.AddWithValue("@esMarcoCompetenciasCSVIn", ce.esMarcoCompetenciasCSV);
            commandCe.Parameters.AddWithValue("@taxonomiaCSVIn", ce.taxonomiaCSV);
            commandCe.Parameters.AddWithValue("@idRAPadreGenerado", idResultadoAprendizajeGenerado);
            commandCe.Parameters.AddWithValue("@idGenerado", 0);

            var idCriterioEvaluacionGenerado = commandCe.ExecuteScalar();
        }

        public static async Task<Dictionary<string, CriterioEvaluacionDTO>> cargarCriteriosEvaluacion(Int32 idResultadoAprendizajeCargado)
        {
            Dictionary<string, CriterioEvaluacionDTO> ces = new Dictionary<string, CriterioEvaluacionDTO>();

            //En este caso abrimos y cerramos la conexión aquí mismo porque sino da exception al tener un comando in progress
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandCriteriosEvaluacion = new NpgsqlCommand("SELECT * from public.cargarcriteriosevaluacion(" + idResultadoAprendizajeCargado + ");", connection);

            var resultSet = await commandCriteriosEvaluacion.ExecuteReaderAsync();

            while (resultSet.Read())
            {
                CriterioEvaluacionDTO ce = new CriterioEvaluacionDTO();

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
                ce.fromCSV(partes);

                ce.idDB = resultSet.GetInt32(0);

                ces.Add(ce.nombreCortoCSV, ce);
            }
            connection.Close();

            return ces;
        }
    }
}
