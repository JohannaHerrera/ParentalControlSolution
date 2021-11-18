using Microsoft.Win32;
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
        /// <summary>
        /// Método para obtener las aplicaciones de una cuenta infantil
        /// </summary>
        /// <param name="infantId">Id del Infante</param>
        /// <param name="deviceId">Id del Dispositivo</param>
        /// <returns>List<ApplicationModel></returns>
        public List<ApplicationModel> GetAppsDevice(int infantId, int deviceId)
        {
            string query = $"SELECT * FROM App WHERE InfantAccountId = {infantId}" +
                           $" AND DevicePCId = {deviceId}";

            List<ApplicationModel> applicationModelList = this.ObtenerListaSQL<ApplicationModel>(query).ToList();

            return applicationModelList;
        }

        /// <summary>
        /// Método para obtener las aplicaciones de una cuenta infantil
        /// </summary>
        /// <param name="infantId">Id del Infante</param>
        /// <param name="appName">Nombre de la App</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterApps(int infantId, string appName)
        {
            DeviceBO deviceBO = new DeviceBO();
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string deviceCode = deviceBO.GetMACAddress();
            bool execute = false;

            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                query = $"INSERT INTO App VALUES (NULL, {infantId}, NULL, {deviceId}, " +
                        $"'{appName}', 0, 0, '{creationDate}')";

                execute = SQLConexionDataBase.Execute(query);
            }

            return execute;
        }

        /// <summary>
        /// Método para eliminar las apps de una cuenta infantil
        /// </summary>
        /// <param name="infantId">Id del Infante</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool DeleteApps(int infantId)
        {
            DeviceBO deviceBO = new DeviceBO();
            string deviceCode = deviceBO.GetMACAddress();
            bool execute = false;

            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                query = $"DELETE FROM App WHERE DevicePCId = {deviceId}" +
                        $" AND InfantAccountId = {infantId}";

                execute = SQLConexionDataBase.Execute(query);
            }

            return execute;
        }

        /// <summary>
        /// Método para obtener las aplicaciones instaladas en la PC
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> GetInstalledApps()
        {
            string displayName;
            string size;

            List<string> gInstalledSoftware = new List<string>();

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", false))
            {
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    size = subkey.GetValue("EstimatedSize") as string;
                    if (string.IsNullOrEmpty(displayName))
                        continue;
                    if (string.IsNullOrEmpty(displayName))
                        continue;

                    gInstalledSoftware.Add(displayName.ToLower());
                }
            }

            return gInstalledSoftware;
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
