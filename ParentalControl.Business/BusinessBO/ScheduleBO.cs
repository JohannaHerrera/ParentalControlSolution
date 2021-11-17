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
        //Horario
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

        public int GetScheduleId(DateTime star,DateTime end)
        {
            int scheduleId = 0;
            ScheduleModel infantAccountModel = new ScheduleModel();

            string query = $"SELECT * FROM Schedule WHERE ScheduleStartTime = '{star}' AND ScheduleEndtTime = '{end}'";

            List<ScheduleModel> scheduleModelList = this.ObtenerListaSQL<ScheduleModel>(query).ToList();

            if (scheduleModelList.Count > 0)
            {
                scheduleId = scheduleModelList.FirstOrDefault().ScheduleId;
            }

            return scheduleId;
        }
        //List

        public List<ScheduleModel> GetSchedule()
        {

            List<ScheduleModel> scheduleModelList = new List<ScheduleModel>();
            ScheduleModel accountNoProtected = new ScheduleModel();
            Constants constants = new Constants();
            /*
            DateTime dt;
            String dth;
            dt = accountNoProtected.ScheduleStartTime;
            dth = dt.ToString("HH:mm:ss");
            dth=constants.NoProtected;
            scheduleModelList.Add(accountNoProtected);
            */
            //string query = $"SELECT convert(char(5), ScheduleStartTime, 108), convert(char(5), ScheduleEndTime, 108) FROM Schedule";

            string query = $"SELECT * FROM Schedule";
            List<ScheduleModel> schedule = this.ObtenerListaSQL<ScheduleModel>(query).ToList();
            scheduleModelList.AddRange(schedule);
            return scheduleModelList;

        }
        //Create
        public bool RegisterSchedule(ScheduleModel scheduleModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var startTime = scheduleModel.ScheduleStartTime.ToString("HH:mm:ss");
            var endTime = scheduleModel.ScheduleEndTime.ToString("HH:mm:ss");
            string query = $"INSERT INTO Schedule VALUES('{startTime}', " +
                           $" '{endTime}', '{creationDate}')";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }
        //delete
        public bool DeleteSchedule(int scheduleId)
        {
            string query = $"DELETE FROM Schedule WHERE ScheduleId = {scheduleId}";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }
        //edit
        public bool UpdateSchedule(ScheduleModel scheduleModel)
        {
            var startTime = scheduleModel.ScheduleStartTime.ToString("HH:mm");
            var endTime = scheduleModel.ScheduleEndTime.ToString("HH:mm");
            string query = $"UPDATE Schedule SET ScheduleStartTime = '{startTime}'," +
                           $" ScheduleEndTime = '{endTime}'" +
                           $" WHERE ScheduleId = {scheduleModel.ScheduleId}";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }
        //Traer el horario especifico
        public ScheduleModel GetScheduleUnique(int scheduleId)
        {
            ScheduleModel scheduleModel = new ScheduleModel();

            string query = $"SELECT * FROM Schedule WHERE ScheduleId  = {scheduleId}";

            List<ScheduleModel> scheduleModelList = this.ObtenerListaSQL<ScheduleModel>(query).ToList();

            scheduleModel = scheduleModelList.FirstOrDefault();

            return scheduleModel;
        }
    }
}
