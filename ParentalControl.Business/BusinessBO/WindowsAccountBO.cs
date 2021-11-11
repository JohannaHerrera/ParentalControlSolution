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
        /// Método para verificar si ya está registrada una cuenta Windows
        /// </summary>
        /// <param name="windowsAccountName">nombre de la cuenta Windows</param>
        /// <returns>List<WindowsAccountModel></returns>
        public List<WindowsAccountModel> VerifyWindowsAccount(string windowsAccountName)
        {
            string query = $"SELECT * FROM WindowsAccount WHERE WindowsAccountName = '{windowsAccountName}'";

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
        public bool UpdateInfantAccountLinked(string infantAccountName, string windowsAccountName, int parentId)
        {
            string query = $"SELECT * FROM InfantAccount WHERE InfantName = '{infantAccountName}' AND ParentId = {parentId}";
            List<InfantAccountModel> infantAccountModelList = this.ObtenerListaSQL<InfantAccountModel>(query).ToList();

            int infantAccountId = infantAccountModelList.FirstOrDefault().InfantAccountId;
            query = $"UPDATE WindowsAccount SET InfantAccountId = {infantAccountId} WHERE WindowsAccountName = '{windowsAccountName}'";

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
