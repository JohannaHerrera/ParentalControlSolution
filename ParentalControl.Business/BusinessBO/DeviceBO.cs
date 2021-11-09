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
    /// Clase para gestionar los dispositivos
    /// </summary>
    public class DeviceBO
    {
        /// <summary>
        /// Método para verificar si ya existe el dispositivo vinculado al Padre
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>List<DeviceModel></returns>
        public List<DeviceModel> verifyDevice(DeviceModel deviceModel)
        {
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceModel.DeviceCode}'" +
                           $" AND ParentId = {deviceModel.ParentId}";

            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            return deviceModelList;
        }

        /// <summary>
        /// Método para registrar y vincular el dispositivo al Padre
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool registerDevice(DeviceModel deviceModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = $"INSERT INTO DevicePC VALUES('{deviceModel.DeviceName}', " +
                           $" '{deviceModel.DeviceCode}', '{creationDate}'," +
                           $" {deviceModel.ParentId})";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
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
