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
    /// Clase para gestionar el uso del dispositivo
    /// </summary>
    public class DeviceUseBO
    {
        /// <summary>
        /// Método para verificar si ya existe el uso del dispositivo con el horario y el niño asignado.
        /// </summary>
        /// <param name="deviceUseModel">contiene la data del uso del dispositivo</param>
        /// <returns>List<DeviceUseModel></returns>
        public List<DeviceUseModel> VerifyDeviceUse(DeviceUseModel deviceUseModel)
        {
            string query = $"SELECT * FROM DeviceUse WHERE InfantAccountId = '{deviceUseModel.InfantAccountId}'" +
                           $" AND ScheduleId = {deviceUseModel.ScheduleId}";

            List<DeviceUseModel> deviceUseModelList = this.ObtenerListaSQL<DeviceUseModel>(query).ToList();

            return deviceUseModelList;
        }

        /// <summary>
        /// Método para verificar si el dispositivo está vinculado a un Horario
        /// </summary>
        /// <param name="deviceUseModel">contiene la data del uso del dispositivo</param>
        /// <returns>List<DeviceUseModel></returns>
        public List<DeviceUseModel> VerifyDeviceUseExist(int infantId,int scheduleId)
        {
            string query = $"SELECT * FROM DeviceUse WHERE InfantAccountId = '{infantId}'" +
                           $" AND ScheduleId = {scheduleId}";

            List<DeviceUseModel> deviceUseModelList = this.ObtenerListaSQL<DeviceUseModel>(query).ToList();

            return deviceUseModelList;
        }

        /// <summary>
        /// Método para verificar si el dispositivo está vinculado a un Horario
        /// </summary>
        /// <param name="deviceUseModel">contiene la data del uso del dispositivo</param>
        /// <returns>List<DeviceUseModel></returns>
        public List<DeviceUseModel> GetDeviceUse(int infantId)
        {
            string query = $"SELECT * FROM DeviceUse WHERE InfantAccountId = '{infantId}'";

            List<DeviceUseModel> deviceUseModelList = this.ObtenerListaSQL<DeviceUseModel>(query).ToList();

            return deviceUseModelList;
        }
        
        /// <summary>
        /// Método para registrar y vincular el uso del dispositivo al infante y al horario.
        /// </summary>
        /// <param name="deviceUseModel">contiene la data del uso del dispositivo</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterDeviceUse(DeviceUseModel deviceUseModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query;

            if (deviceUseModel.ScheduleId == 0)
            {
                
                query = $"INSERT INTO DeviceUse VALUES('{deviceUseModel.DeviceUseDay}', " +
                        $" '{creationDate}', '{deviceUseModel.InfantAccountId}'," +
                        $"NULL)";
            }
            else
            {
                query = $"INSERT INTO DeviceUse VALUES('{deviceUseModel.DeviceUseDay}', " +
                        $" '{creationDate}', '{deviceUseModel.InfantAccountId}'," +
                        $" {deviceUseModel.ScheduleId})";
            }
       
            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }

        /// <summary>
        /// Método para actualizar el nombre del dispositivo
        /// </summary>
        /// <param name="deviceName">nuevo nombre del dispositivo</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool UpdateDeviceUseSchedule(string day,int infatId,string scheduleId)
        {
            
            string query = $"UPDATE DeviceUse SET ScheduleId = {scheduleId} WHERE InfantAccountId = {infatId} " +
                $"AND DeviceUseDay = '{day}'";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }

        /// <summary>
        /// Método para convertir una lista DataTable a un TModel (Modelo genérico)
        /// </summary>
        /// <param name="deviceUseModel">contiene la data del uso del dispositivo</param>
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
