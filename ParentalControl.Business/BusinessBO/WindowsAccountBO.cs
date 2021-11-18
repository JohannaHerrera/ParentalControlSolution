using ParentalControl.Data;
using ParentalControl.Models.Device;
using ParentalControl.Models.InfantAccount;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    /// <summary>
    /// Clase para gestionar las cuentas Windows
    /// </summary>
    public class WindowsAccountBO
    {

        /// <summary>
        /// Método para verificar si ya está registrada una cuenta Windows de la PC
        /// </summary>
        /// <param name="windowsAccountName">nombre de la cuenta Windows</param>
        /// <returns>List<WindowsAccountModel></returns>
        public List<WindowsAccountModel> VerifyWindowsAccount(string windowsAccountName)
        {
            DeviceBO deviceBO = new DeviceBO();
            string deviceCode = deviceBO.GetMACAddress();
            string query = $"SELECT wa.WindowsAccountId, wa.WindowsAccountName, wa.InfantAccountId" +
                           $" FROM WindowsAccount wa INNER JOIN DevicePC pc" +
                           $" ON wa.DevicePCId = pc.DevicePCId" +
                           $" WHERE pc.DevicePCCode = '{deviceCode}'" +
                           $" AND wa.WindowsAccountName = '{windowsAccountName}'";

            List<WindowsAccountModel> deviceModelList = this.ObtenerListaSQL<WindowsAccountModel>(query).ToList();

            return deviceModelList;
        }

        /// <summary>
        /// Método para verificar si ya está vinculada una cuenta Windows a una cuenta infantil
        /// </summary>
        /// <param name="windowsAccountName">nombre de la cuenta Windows</param>
        /// <returns>List<WindowsAccountModel></returns>
        public List<WindowsAccountModel> VerifyWindowsInfantAccount(string windowsAccountName, int infantId)
        {
            DeviceBO deviceBO = new DeviceBO();
            string deviceCode = deviceBO.GetMACAddress();
            string query = $"SELECT wa.WindowsAccountId, wa.WindowsAccountName" +
                           $" FROM WindowsAccount wa INNER JOIN DevicePC pc" +
                           $" ON wa.DevicePCId = pc.DevicePCId" +
                           $" WHERE pc.DevicePCCode = '{deviceCode}'" +
                           $" AND wa.InfantAccountId = {infantId}" +
                           $" AND wa.WindowsAccountName = '{windowsAccountName}'";

            List<WindowsAccountModel> deviceModelList = this.ObtenerListaSQL<WindowsAccountModel>(query).ToList();

            return deviceModelList;
        }

        /// <summary>
        /// Método para obtener el nombre del Infante que está vinculado a una cuenta Windows
        /// </summary>
        /// <param name="windowsAccountName">nombre de la cuenta Windows</param>
        /// <returns>List<WindowsAccountModel></returns>
        public string GetInfantAccountLinked(int infantAccountId)
        {
            string infantAccpuntName = string.Empty;
            string query = $"SELECT * FROM InfantAccount WHERE InfantAccountId = {infantAccountId}";

            List<InfantAccountModel> infantAccountModelList = this.ObtenerListaSQL<InfantAccountModel>(query).ToList();

            if (infantAccountModelList.Count > 0)
            {
                infantAccpuntName = infantAccountModelList.FirstOrDefault().InfantName;
            }

            return infantAccpuntName;
        }

        /// <summary>
        /// Método para actualizar la cuenta infantil vinculada
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool UpdateInfantAccountLinked(int infantAccountIdActual, string windowsAccountName, int infantAccountIdAnterior)
        {
            DeviceBO deviceBO = new DeviceBO();
            bool execute = false;
            string deviceCode = deviceBO.GetMACAddress();

            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                query = $"UPDATE WindowsAccount SET InfantAccountId = {infantAccountIdActual} " +
                           $" WHERE WindowsAccountName = '{windowsAccountName}'" +
                           $" AND DevicePCId = {deviceId}" +
                           $" AND InfantAccountId = {infantAccountIdAnterior}";

                execute = SQLConexionDataBase.Execute(query);
            }          

            return execute;
        }

        /// <summary>
        /// Método para vincular la cuenta Windows con una cuenta Infantil
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterWindowsAccount(int infantId, string windowsAccountName)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            DeviceBO deviceBO = new DeviceBO();
            string deviceCode = deviceBO.GetMACAddress();
            bool execute = false;

            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                query = $"INSERT INTO WindowsAccount VALUES ('{windowsAccountName}'," +
                               $" '{creationDate}', {deviceId}, {infantId})";

                execute = SQLConexionDataBase.Execute(query);
            }           

            return execute;
        }

        /// <summary>
        /// Método para eliminar la cuenta Windows
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool DeleteWindowsAccount(int infantId, string windowsAccountName)
        {
            DeviceBO deviceBO = new DeviceBO();
            string deviceCode = deviceBO.GetMACAddress();
            bool execute = false;

            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                query = $"DELETE FROM WindowsAccount WHERE DevicePCId = {deviceId}" +
                        $" AND InfantAccountId = {infantId}" +
                        $" AND WindowsAccountName = '{windowsAccountName}'";

                execute = SQLConexionDataBase.Execute(query);
            }

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
