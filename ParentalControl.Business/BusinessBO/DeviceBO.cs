using ParentalControl.Data;
using ParentalControl.Models.Device;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
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
        public List<DeviceModel> VerifyDevice(DeviceModel deviceModel)
        {
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceModel.DeviceCode}'" +
                           $" AND ParentId = {deviceModel.ParentId}";

            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            return deviceModelList;
        }

        /// <summary>
        /// Método para verificar si el dispositivo está vinculado a una cuenta
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>List<DeviceModel></returns>
        public List<DeviceModel> VerifyDeviceExist(string deviceCode)
        {
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";

            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            return deviceModelList;
        }

        /// <summary>
        /// Método para registrar y vincular el dispositivo al Padre
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterDevice(DeviceModel deviceModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = $"INSERT INTO DevicePC VALUES('{deviceModel.DeviceName}', " +
                           $" '{deviceModel.DeviceCode}', '{creationDate}'," +
                           $" {deviceModel.ParentId})";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }

        /// <summary>
        /// Método para obtener la MAC del dispositivo
        /// </summary>
        /// <returns>macAddresses</returns>
        public string GetMACAddress()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true");
            IEnumerable<ManagementObject> objects = searcher.Get().Cast<ManagementObject>();
            string mac = (from o in objects orderby o["IPConnectionMetric"] select o["MACAddress"].ToString()).FirstOrDefault();
            return mac;
        }

        /// <summary>
        /// Método para obtener el nombre del dispositivo
        /// </summary>
        /// <returns>deviceName</returns>
        public string GetDeviceName(string deviceCode)
        {
            string deviceName = string.Empty;
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";

            DataTable deviceModelList = SQLConexionDataBase.Query(query);
            
            if(deviceModelList.Rows.Count > 0)
            {
                deviceName = deviceModelList.Rows[0][1].ToString();
            }

            return deviceName;
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
