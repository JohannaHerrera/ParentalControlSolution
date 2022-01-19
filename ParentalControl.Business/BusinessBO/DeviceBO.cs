using DeviceId;
using ParentalControl.Business.Enums;
using ParentalControl.Data;
using ParentalControl.Models.Device;
using ParentalControl.Models.InfantAccount;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
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
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceModel.DevicePCCode}'" +
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
        /// Método para obtener las cuentas Windows del dispositivo
        /// </summary>
        /// <returns>List<DeviceModel></returns>
        public List<string> GetWindowsAccounts()
        {

            List<string> users = new List<string>();
            var path = string.Format("WinNT://{0},computer", Environment.MachineName);

            using (var computerEntry = new DirectoryEntry(path))
            {
                foreach (DirectoryEntry childEntry in computerEntry.Children)
                {
                    if (childEntry.SchemaClassName == "User")
                    {
                        users.Add(childEntry.Name);
                    }                        
                }                   
            }            

            return users;

        }

        /// <summary>
        /// Método para obtener las cuentas Infantiles
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>List<DeviceModel></returns>
        public List<InfantAccountModel> GetInfantAccounts(int parentId)
        {

            List<InfantAccountModel> infantAccountModelList = new List<InfantAccountModel>();
            InfantAccountModel accountNoProtected = new InfantAccountModel();
            Constants constants = new Constants();

            accountNoProtected.InfantName = constants.NoProtected;
            infantAccountModelList.Add(accountNoProtected);
            string query = $"SELECT * FROM InfantAccount WHERE ParentId = {parentId}";
            List<InfantAccountModel> infantAccounts = this.ObtenerListaSQL<InfantAccountModel>(query).ToList();
            infantAccountModelList.AddRange(infantAccounts);

            return infantAccountModelList;

        }

        /// <summary>
        /// Método para registrar y vincular el dispositivo al Padre
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterDevice(DeviceModel deviceModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = $"INSERT INTO DevicePC VALUES('{deviceModel.DevicePCName}', " +
                           $" '{deviceModel.DevicePCCode}', '{creationDate}'," +
                           $" {deviceModel.ParentId})";

            bool execute = SQLConexionDataBase.Execute(query);

            if (execute)
            {
                ApplicationBO applicationBO = new ApplicationBO();
                List<string> appsInstalled = applicationBO.GetInstalledApps();

                query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceModel.DevicePCCode}'";
                DeviceModel device = this.ObtenerListaSQL<DeviceModel>(query).FirstOrDefault();

                foreach (var app in appsInstalled)
                {
                    query = $"INSERT INTO AppDevice VALUES (NULL, {device.DevicePCId}," +
                           $" '{app}', '{creationDate}')";

                    execute = SQLConexionDataBase.Execute(query);
                }
            }

            return execute;
        }

        /// <summary>
        /// Método para actualizar el nombre del dispositivo
        /// </summary>
        /// <param name="deviceName">nuevo nombre del dispositivo</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool UpdateDeviceName(string deviceName)
        {
            string deviceCode = this.GetDeviceIdentifier();
            string query = $"UPDATE DevicePC SET DevicePCName = '{deviceName}' WHERE DevicePCCode = '{deviceCode}'";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }

        /// <summary>
        /// Método para eliminar el dispositivo
        /// </summary>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool DeleteDevice()
        {
            bool execute = false;
            string deviceCode = this.GetDeviceIdentifier();
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";

            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                query = $" DELETE FROM WindowsAccount WHERE DevicePCId = {deviceId};" +
                        $" DELETE FROM App WHERE DevicePCId = {deviceId};" +
                        $" DELETE FROM AppDevice WHERE DevicePCId = {deviceId};" +
                        $" DELETE FROM Request WHERE DevicePCId = {deviceId};" +
                        $" DELETE FROM DevicePC WHERE DevicePCId = {deviceId};";
                execute = SQLConexionDataBase.Execute(query);
            }

            return execute;
        }

        /// <summary>
        /// Método para obtener el identificador del dispositivo
        /// </summary>
        /// <returns>macAddresses</returns>
        public string GetDeviceIdentifier()
        {
            string deviceId = new DeviceIdBuilder().AddMachineName().ToString();

            return deviceId;
        }

        /// <summary>
        /// Método para obtener el nombre del dispositivo
        /// </summary>
        /// <returns>deviceName</returns>
        public string GetDeviceName(string deviceCode)
        {
            string deviceName = string.Empty;
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";

            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                deviceName = deviceModelList.FirstOrDefault().DevicePCName;
            }

            return deviceName;
        }

        /// <summary>
        /// Método para obtener el nombre del dispositivo PC
        /// </summary>
        /// <returns>deviceName</returns>
        public string GetDevicePCName(int deviceId)
        {
            string deviceName = string.Empty;
            string query = $"SELECT * FROM DevicePC WHERE DevicePCId = '{deviceId}'";

            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                deviceName = deviceModelList.FirstOrDefault().DevicePCName;
            }

            return deviceName;
        }

        /// <summary>
        /// Método para obtener el nombre del dispositivo móvil
        /// </summary>
        /// <returns>deviceName</returns>
        public string GetDevicePhoneName(int deviceId)
        {
            string deviceName = string.Empty;
            string query = $"SELECT * FROM DevicePhone WHERE DevicePhoneId = '{deviceId}'";

            List<DevicePhoneModel> deviceModelList = this.ObtenerListaSQL<DevicePhoneModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                deviceName = deviceModelList.FirstOrDefault().DevicePhoneName;
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
