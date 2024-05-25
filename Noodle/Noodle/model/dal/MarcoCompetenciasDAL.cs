using Noodle.config;
using Noodle.model.dto;
using Npgsql;
using System;
using System.Collections.Generic;
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
        /// </summary>
        /// <param name="marco"></param>
        public static async void guardarMarcoCompetencias(MarcoCompetenciasDTO marco)
        {
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using var connection = await dataSource.OpenConnectionAsync();
            var command = new NpgsqlCommand("insertarmarcocompetencias_alt", connection);
            
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idPadreCSVIn", marco.idPadreCSV);
            command.Parameters.AddWithValue("@idCSVIn", marco.idCSV);
            command.Parameters.AddWithValue("@nombreCortoCSVIn", marco.nombreCortoCSV);
            command.Parameters.AddWithValue("@descripcionCSVIn", marco.descripcionCSV);
            command.Parameters.AddWithValue("@descripcionFormatoCSVIn", marco.descripcionFormatoCSV);
            command.Parameters.AddWithValue("@valoresEscalaCSVIn", marco.valoresEscalaCSV);
            command.Parameters.AddWithValue("@configuracionEscalaCSVIn", marco.configuracionEscalaCSV);
            command.Parameters.AddWithValue("@tipoReglaCSVIn", marco.tipoReglaCSV);
            command.Parameters.AddWithValue("@resultadoReglaCSVIn", marco.resultadoReglaCSV);
            command.Parameters.AddWithValue("@configuracionReglaCSVIn", marco.configuracionReglaCSV);
            command.Parameters.AddWithValue("@idReferenciasCruzadasCompetenciasCSVIn", marco.idReferenciasCruzadasCompetenciasCSV);
            command.Parameters.AddWithValue("@idExportacionCSVIn", marco.idExportacionCSV);
            command.Parameters.AddWithValue("@esMarcoCompetenciasCSVIn", true);
            command.Parameters.AddWithValue("@taxonomiaCSVIn", marco.taxonomiaCSV);

            command.ExecuteNonQuery();
            connection.Close();
            return;
            //await using var reader = await command.ExecuteReaderAsync();
        }


    }
}
