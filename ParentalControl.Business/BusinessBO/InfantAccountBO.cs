using ParentalControl.Data;
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
    ///  
    /// </summary>
    public class InfantAccountBO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="childName"></param>
        /// <returns></returns>
        public List<InfantAccountModel> ValidateInfantAccount(string childName)
        {
            string query = $"SELECT * FROM InfantAccount WHERE InfantName = '{childName}'";

            List<InfantAccountModel> infantAccountModelList = this.ObtenerListaSQL<InfantAccountModel>(query).ToList();

            return infantAccountModelList;
        }

        /// <summary>
        /// Método para registrar un nuevo hijo
        /// </summary>
        /// <param name="InfantAccountModel">modelo que contiene los datos del usuario hijo</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al crear)</returns>
        public bool CreateInfantAccount(InfantAccountModel infantAccountModel, int parentId)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = $"INSERT INTO InfantAccount VALUES('{infantAccountModel.InfantName}', " +
                           $" '{infantAccountModel.InfantGender}', '{creationDate}'," +
                           $" {parentId})";

            bool execute = SQLConexionDataBase.Execute(query);

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
