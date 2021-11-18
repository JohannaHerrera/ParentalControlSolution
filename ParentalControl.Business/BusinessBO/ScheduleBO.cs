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

        public int GetScheduleId(DateTime start, DateTime end, int parentId)
        {
            int scheduleId = 0;
            var startTime = start.ToString("HH:mm");
            var endTime = end.ToString("HH:mm");

            string query = $"SELECT * FROM Schedule WHERE CAST(ScheduleStartTime AS time) =" +
                           $" '{startTime}' AND CAST(ScheduleEndTime AS time) = '{endTime}'" +
                           $" AND ParentId = {parentId}";

            List<ScheduleModel> scheduleModelList = this.ObtenerListaSQL<ScheduleModel>(query).ToList();

            if (scheduleModelList.Count > 0)
            {
                scheduleId = scheduleModelList.FirstOrDefault().ScheduleId;
            }

            return scheduleId;
        }

        public List<ScheduleModel> ValidateSchedule(DateTime start, DateTime end, int parentId)
        {
            var startTime = start.ToString("HH:mm");
            var endTime = end.ToString("HH:mm");

            string query = $"SELECT * FROM Schedule WHERE CAST(ScheduleStartTime AS time) =" +
                           $" '{startTime}' AND CAST(ScheduleEndTime AS time) = '{endTime}'" +
                           $" AND ParentId = {parentId}";

            List<ScheduleModel> scheduleModelList = this.ObtenerListaSQL<ScheduleModel>(query).ToList();

            return scheduleModelList;
        }

        //List

        public List<ScheduleModel> GetSchedule(int parentId)
        {

            List<ScheduleModel> scheduleModelList = new List<ScheduleModel>();

            string query = $"SELECT * FROM Schedule WHERE ParentId = {parentId}";
            List<ScheduleModel> schedule = this.ObtenerListaSQL<ScheduleModel>(query).ToList();
            scheduleModelList.AddRange(schedule);
            return scheduleModelList;

        }

        public ScheduleModel GetSpecificSchedule(int scheduleId)
        {
            string query = $"SELECT * FROM Schedule WHERE ScheduleId = {scheduleId}";
            List<ScheduleModel> scheduleModelList = this.ObtenerListaSQL<ScheduleModel>(query).ToList();
            ScheduleModel scheduleModel = scheduleModelList.FirstOrDefault();

            return scheduleModel;
        }

        //Create
        public bool RegisterSchedule(ScheduleModel scheduleModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var startTime = scheduleModel.ScheduleStartTime.ToString("HH:mm");
            var endTime = scheduleModel.ScheduleEndTime.ToString("HH:mm");
            string query = $"INSERT INTO Schedule VALUES('{startTime}', " +
                           $" '{endTime}', '{creationDate}', {scheduleModel.ParentId})";

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
