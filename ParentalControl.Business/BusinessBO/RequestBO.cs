using ParentalControl.Data;
using ParentalControl.Models.Device;
using ParentalControl.Models.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    public class RequestBO
    {
        /// <summary>
        /// Método para obtener el tipo de peticiones
        /// </summary>
        /// <returns>List<RequestTypeModel></returns>
        public List<RequestTypeModel> GetRequestTypes()
        {
            string query = $"SELECT * FROM RequestType";

            List<RequestTypeModel> requestTypeModelList = this.ObtenerListaSQL<RequestTypeModel>(query).ToList();

            return requestTypeModelList;
        }

        /// <summary>
        /// Método para obtener las aplicaciones bloqueadas
        /// </summary>
        /// <returns>List<ApplicationModel></returns>
        public List<ApplicationModel> GetBlockedApps(int infantId, int deviceId)
        {
            string query = $"SELECT * FROM App WHERE InfantAccountId = {infantId}" +
                           $" AND DevicePCId = {deviceId}" +
                           $" AND (AppAccessPermission <> 0 OR ScheduleId IS NOT NULL)";

            List<ApplicationModel> applicationModelList = this.ObtenerListaSQL<ApplicationModel>(query).ToList();

            return applicationModelList;
        }

        /// <summary>
        /// Método para obtener las categorías web bloqueadas
        /// </summary>
        /// <returns>List<RequestTypeModel></returns>
        public List<ApplicationModel> GetBlockedWebCategory(int infantId, int deviceId)
        {
            string query = $"SELECT * FROM App WHERE InfantAccountId = {infantId}" +
                           $" AND DevicePCId = {deviceId}" +
                           $" AND (AppAccessPermission <> 0 OR ScheduleId IS NOT NULL)";

            List<ApplicationModel> applicationModelList = this.ObtenerListaSQL<ApplicationModel>(query).ToList();

            return applicationModelList;
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
