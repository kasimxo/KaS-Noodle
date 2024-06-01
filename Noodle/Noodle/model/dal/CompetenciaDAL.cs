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
    public class CompetenciaDAL
    {
        public static void guardarCompetencia(CompetenciaDTO com, NpgsqlConnection connection, Int32 idMarcoGenerado) 
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
            commandCompetencia.Parameters.AddWithValue("@paginaIn", com.pag);
            commandCompetencia.Parameters.AddWithValue("@idGenerado", 0);

            Int32 idCompetenciaGenerado = (int) commandCompetencia.ExecuteScalar();

            foreach (ResultadoAprendizajeDTO ra in com.ras.Values)
            {
                ResultadoAprendizajeDAL.guardarResultadoAprendizaje(ra, connection, idCompetenciaGenerado);
            }
        }
        /// <summary>
        /// Método que carga las competencias que pertenecen a un marco de competencias a partir de la id del marco
        /// </summary>
        /// <param name="idMarcoCargado"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static async Task<Dictionary<string, CompetenciaDTO>> cargarCompetencia(Int32 idMarcoCargado)
        {
            Dictionary<string, CompetenciaDTO> competencias = new Dictionary<string, CompetenciaDTO>();

            //En este caso abrimos y cerramos la conexión aquí mismo porque sino da exception al tener un comando in progress
            await using var dataSource = NpgsqlDataSource.Create(Configuracion.CONNECTION_STRING);
            await using NpgsqlConnection connection = await dataSource.OpenConnectionAsync();
            var commandCompetencias = new NpgsqlCommand("SELECT * from public.cargarcompetencias("+idMarcoCargado+");", connection);

            var resultSet = await commandCompetencias.ExecuteReaderAsync();

            while (resultSet.Read())
            {
                CompetenciaDTO competencia = new CompetenciaDTO();

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
                competencia.fromCSV(partes);

                competencia.idDB = resultSet.GetInt32(0);
                competencia.pag = resultSet.GetInt32(15);

                competencias.Add(competencia.nombreCortoCSV, competencia);
            }
            connection.Close();

            return competencias;
            
        }
    }
}
