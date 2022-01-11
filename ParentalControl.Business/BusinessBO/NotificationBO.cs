using ParentalControl.Data;
using ParentalControl.Models.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    /// <summary>
    /// Clase para obtener las notificaciones del padre y los infantes
    /// </summary>
    public class NotificationBO
    {

        /// <summary>
        /// Método para obtener las notificaciones del infante
        /// </summary>
        /// <param name="infantId">contiene el Id del infante</param>
        /// <returns>IList<TModel></returns>
        public List<RequestModel> GetInfantNotifications(int infantId, int deviceId)
        {
            string query = $"SELECT TOP 20 * FROM Request WHERE InfantAccountId = {infantId}" +
                           $" AND DevicePCId = {deviceId}" +
                           $" ORDER BY CASE WHEN RequestState = 0 then 0 else 1 end," +
                           $" RequestCreationDate DESC";

            List<RequestModel> requestModelList = this.ObtenerListaSQL<RequestModel>(query).ToList();

            return requestModelList;
        }

        /// <summary>
        /// Método para obtener las notificaciones del padre
        /// </summary>
        /// <param name="parentId">contiene el Id del padre</param>
        /// <returns>IList<TModel></returns>
        public List<RequestModel> GetParentNotifications(int parentId)
        {
            string query = $"SELECT TOP 20 * FROM Request WHERE ParentId = {parentId}" +
                           $" ORDER BY CASE WHEN RequestState = 0 then 0 else 1 end," +
                           $" RequestCreationDate DESC";

            List<RequestModel> requestModelList = this.ObtenerListaSQL<RequestModel>(query).ToList();

            return requestModelList;
        }

        /// <summary>
        /// Método para convertir una lista DataTable a un TModel (Modelo genérico)
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>IList<TModel></returns>
        private IList<TModel> ObtenerListaSQL<TModel>(string query)
        {
            try
            {
                DataTable dataTableInformacion = SQLConexionDataBase.Query(query);
                var listaResultante = dataTableInformacion.MapDataTableToList<TModel>();

                return listaResultante;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
