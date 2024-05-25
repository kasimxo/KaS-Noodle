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
            await using var connection = await dataSource.OpenConnectionAsync();
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
            var idMarcoGenerado = commandMarco.ExecuteScalar();

            foreach (CompetenciaDTO com in marco.competencias.Values)
            {
                var commandCompetencia = new NpgsqlCommand("insertarcompetencia", connection);

                commandCompetencia.CommandType = System.Data.CommandType.StoredProcedure;

                commandCompetencia.Parameters.AddWithValue("@idPadreCSVIn", com.idPadreCSV);
                commandCompetencia.Parameters.AddWithValue("@idCSVIn", com.idCSV);
                commandCompetencia.Parameters.AddWithValue("@nombreCortoCSVIn", com.nombreCortoCSV);
                commandCompetencia.Parameters.AddWithValue("@descripcionCSVIn", com.descripcionCSV);
                commandCompetencia.Parameters.AddWithValue("@descripcionFormatoCSVIn", com.descripcionFormatoCSV);
                commandCompetencia.Parameters.AddWithValue("@valoresEscalaCSVIn", com.valoresEscalaCSV);
                commandCompetencia.Parameters.AddWithValue("@configuracionEscalaCSVIn", com.configuracionEscalaCSV);
                commandCompetencia.Parameters.AddWithValue("@tipoReglaCSVIn", com.tipoReglaCSV);
                commandCompetencia.Parameters.AddWithValue("@resultadoReglaCSVIn", com.resultadoReglaCSV);
                commandCompetencia.Parameters.AddWithValue("@configuracionReglaCSVIn", com.configuracionReglaCSV);
                commandCompetencia.Parameters.AddWithValue("@idReferenciasCruzadasCompetenciasCSVIn", com.idReferenciasCruzadasCompetenciasCSV);
                commandCompetencia.Parameters.AddWithValue("@idExportacionCSVIn", com.idExportacionCSV);
                commandCompetencia.Parameters.AddWithValue("@esMarcoCompetenciasCSVIn", com.esMarcoCompetenciasCSV);
                commandCompetencia.Parameters.AddWithValue("@taxonomiaCSVIn", com.taxonomiaCSV);
                commandCompetencia.Parameters.AddWithValue("@idPadreMarcoGenerado", idMarcoGenerado);
                commandCompetencia.Parameters.AddWithValue("@idGenerado", 0);

                var idCompetenciaGenerado = commandCompetencia.ExecuteScalar();

                foreach (ResultadoAprendizajeDTO ra in com.ras.Values) 
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

                    var idResultadoAprendizajeGenerado = commandRa.ExecuteScalar();

                    foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
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
                }


                Debug.WriteLine("");
            }

            connection.Close();
            return;
            //await using var reader = await command.ExecuteReaderAsync();
        }


    }
}
