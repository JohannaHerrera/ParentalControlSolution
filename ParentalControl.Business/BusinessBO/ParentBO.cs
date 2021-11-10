using ParentalControl.Data;
using ParentalControl.Models.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    /// <summary>
    /// Clase para gestionar la cuenta del Padre
    /// </summary>
    public class ParentBO
    {
        /// <summary>
        /// Método para obtener el Id del Padre
        /// </summary>
        /// <param name="registerModel">modelo que contiene los datos del usuario Padre</param>
        /// <returns>Id del Padre</returns>
        public int GetParentId(LoginModel loginModel)
        {
            int parentId = 0;

            string query = $"SELECT * FROM Parent WHERE ParentEmail = '{loginModel.ParentEmail}'" +
                           $" AND ParentPassword = '{loginModel.ParentPassword}'";

            List<ParentModel> registerModelList = this.ObtenerListaSQL<ParentModel>(query).ToList();

            if (registerModelList.Count > 0)
            {
                parentId = registerModelList.FirstOrDefault().ParentId;
            } 

            return parentId;
        }

        // <summary>
        /// Método para obtener el Nombre de Usuario del Padre
        /// </summary>
        /// <param name="loginModel">modelo que contiene los datos del usuario Padre</param>
        /// <returns>Nombre del Padre</returns>
        public string GetParentName(LoginModel loginModel)
        {
            string parentName = string.Empty;

            string query = $"SELECT * FROM Parent WHERE ParentEmail = '{loginModel.ParentEmail}'" +
                           $" AND ParentPassword = '{loginModel.ParentPassword}'";

            List<ParentModel> registerModelList = this.ObtenerListaSQL<ParentModel>(query).ToList();

            if (registerModelList.Count > 0)
            {
                parentName = registerModelList.FirstOrDefault().ParentUsername;
            }

            return parentName;
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
