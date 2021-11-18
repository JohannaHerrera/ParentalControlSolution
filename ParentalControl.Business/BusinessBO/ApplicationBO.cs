using ParentalControl.Data;
using ParentalControl.Models.Device;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    /// <summary>
    /// Clase para gestionar las aplicaciones del dispositivo
    /// </summary>
    public class ApplicationBO
    {

        public List<ApplicationModel> GetAppsDevice(int infantId, int deviceId)
        {
            string query = $"SELECT * FROM App WHERE InfantAccountId = {infantId}" +
                           $" AND DevicePCId = {deviceId}";

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
