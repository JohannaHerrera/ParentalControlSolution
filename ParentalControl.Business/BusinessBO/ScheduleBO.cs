using System;
using System.Collections.Generic;
using System.Data;
using ParentalControl.Data;
using ParentalControl.Models.Schedule;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParentalControl.Business.Enums;
using ParentalControl.Models.Device;
using ParentalControl.Models.InfantAccount;
using System.DirectoryServices;
using System.Management;


namespace ParentalControl.Business.BusinessBO
{
    public class ScheduleBO
    {

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
        //List
    
        public List<ScheduleModel> GetSchedule()
        {

            List<ScheduleModel> scheduleModelList = new List<ScheduleModel>();
            ScheduleModel accountNoProtected = new ScheduleModel();
            Constants constants = new Constants();
            DateTime dt;
            String dth;
            dt = accountNoProtected.ScheduleStartTime;
            dth = dt.ToString("yyyy-MM-dd hh:mm:ss");
            dth=constants.NoProtected;
            scheduleModelList.Add(accountNoProtected);
            string query = $"SELECT ScheduleStartTime, ScheduleEndTime FROM Schedule";
            List<ScheduleModel> schedule = this.ObtenerListaSQL<ScheduleModel>(query).ToList();
            scheduleModelList.AddRange(schedule);

            return scheduleModelList;

        }
        //Create
        public bool RegisterSchedule(ScheduleModel scheduleModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            var startTime = scheduleModel.ScheduleStartTime.ToString("hh:mm:ss");
            var endTime = scheduleModel.ScheduleStartTime.ToString("hh:mm:ss");
            string query = $"INSERT INTO Schedule VALUES('{startTime}', " +
                           $" '{endTime}', '{creationDate}')";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }


    }
}
