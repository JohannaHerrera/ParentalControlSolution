using ParentalControl.Data;
using ParentalControl.Models.Activity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    public class ActivityBO
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

        /// <summary>
        /// Método para obtener el Id de una actividad
        /// </summary>
        /// <param name="infantAccountId"></param>
        /// <returns>int</returns>
        public int GetActivityId(int infantAccountId)
        {
            int activityId = 0;
            string query = $"SELECT * FROM Activity WHERE ActivityId = {infantAccountId}";

            List<ActivityModel> activityModelList = this.ObtenerListaSQL<ActivityModel>(query).ToList();

            if (activityModelList.Count > 0)
            {
                activityId = activityModelList.FirstOrDefault().ActivityId;
            }

            return activityId;
        }

        /// <summary>
        /// Método para obtener la lista de actividades
        /// </summary>
        /// <param name="infantAccountId"></param>
        /// <returns>List<ActivityModel></returns>
        public List<ActivityModel> GetActivityList(int infantAccountId)
        {

            List<ActivityModel> activityModelList = new List<ActivityModel>();

            string query = $"SELECT * FROM Activity WHERE InfantAccountId = {infantAccountId}";
            List<ActivityModel> activityModel = this.ObtenerListaSQL<ActivityModel>(query).ToList();
            activityModelList.AddRange(activityModel);
            return activityModelList;

        }

        public ActivityModel GetActivity(int infantAccountId)
        {
            string query = $"SELECT * FROM Activity WHERE ActivityId = {infantAccountId}";
            List<ActivityModel> activityModelList = this.ObtenerListaSQL<ActivityModel>(query).ToList();
            ActivityModel activityModel = activityModelList.FirstOrDefault();

            return activityModel;
        }

    }
}
