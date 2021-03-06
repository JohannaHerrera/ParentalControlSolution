using ParentalControl.Business.Enums;
using ParentalControl.Data;
using ParentalControl.Models.InfantAccount;
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
    ///  
    /// </summary>
    public class InfantAccountBO
    {
        int infantId;
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
            // Crea la cuenta infantil
            string query = $"INSERT INTO InfantAccount VALUES('{infantAccountModel.InfantName}', " +
                           $" '{infantAccountModel.InfantGender}', '{creationDate}'," +
                           $" {parentId})";
            bool execute = SQLConexionDataBase.Execute(query);
            if (this.CreateWebConfiguration(execute,parentId))
            {
                execute = true;
            }
            else
            {
                execute = false;
            }
            return execute;
        }
        public bool CreateWebConfiguration(bool execute, int parentId)
        {
            // Trae las categorias web existentes
            List<WebCategoryModel> webCategoryModelList = new List<WebCategoryModel>();
            string queryWebCatgory = $"SELECT * FROM WebCategory ";
            List<WebCategoryModel> webCategory = this.ObtenerListaSQL<WebCategoryModel>(queryWebCatgory).ToList();
            webCategoryModelList.AddRange(webCategory);
            if (execute)
            {
                // Trae al ultimo registro de cuenta infantil ingresada  por el padre
                List<InfantAccountModel> infantAccountModelList = new List<InfantAccountModel>();
                string queryInfant = $"select TOP(1) * FROM InfantAccount WHERE ParentId = {parentId} ORDER BY InfantAccountId DESC ";
                List<InfantAccountModel> infantAccount = this.ObtenerListaSQL<InfantAccountModel>(queryInfant).ToList();
                Constants constants = new Constants();
                infantAccountModelList.AddRange(infantAccount);
                foreach (var id in infantAccountModelList)
                {
                    this.infantId = id.InfantAccountId;
                }
                // Crea web configuration a la par de una cuenta infantil
                if (webCategoryModelList.Count > 0)
                {
                    try
                    {
                        foreach (var webC in webCategoryModelList)
                        {
                            string queryWebConfi = $"INSERT INTO WebConfiguration VALUES({constants.Access}, " +
                            $" '{webC.CategoryId}', '{this.infantId}')";
                            //Valida el correcto ingreso de los datos a la Base de Datos
                            bool execut = SQLConexionDataBase.Execute(queryWebConfi);
                            if (execut == false)
                            {
                                execute = false;
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Fallo en INGRESAR Configuracion Web");
                    }
                }
            }

            return execute;
        }
        /// <summary>
        /// Método para obtener el Id del Infante
        /// </summary>
        /// <param name="infantAccountModel">modelo que contiene los datos del usuario Infante</param>
        /// <returns>Id del Infante</returns>
        public int GetInfantId(string infantName)
        {
            int infantId = 0;
            InfantAccountModel infantAccountModel = new InfantAccountModel();

            string query = $"SELECT * FROM InfantAccount WHERE InfantName = '{infantName}'";

            List<InfantAccountModel> infantAccountModelList = this.ObtenerListaSQL<InfantAccountModel>(query).ToList();

            if (infantAccountModelList.Count>0)
            {
                infantId = infantAccountModelList.FirstOrDefault().InfantAccountId;
            }

            
            return infantId;
        }

        /// <summary>
        /// Método para obtener una cuenta infantil
        /// </summary>
        /// <param name="infantId">contiene el id del infante</param>
        /// <returns>InfantAccountModel</returns>
        public InfantAccountModel GetInfantAccount(int infantAccountId)
        {
           InfantAccountModel infantAccountModel = new InfantAccountModel();

           string query = $"SELECT * FROM InfantAccount WHERE InfantAccountId = {infantAccountId}";

           List<InfantAccountModel> infantAccountModelList = this.ObtenerListaSQL<InfantAccountModel>(query).ToList();

           infantAccountModel = infantAccountModelList.FirstOrDefault();

           return infantAccountModel;
        }

        /// <summary>
        /// Método para obtener las cuentas Infantiles
        /// </summary>
        /// <param name="InfantAccountModel">contiene la data del dispositivo PC</param>
        /// <returns>List<DeviceModel></returns>
        public List<InfantAccountModel> GetInfantAccounts(int parentId)
        {

            List<InfantAccountModel> infantAccountModelList = new List<InfantAccountModel>();
        
            string query = $"SELECT * FROM InfantAccount WHERE ParentId = {parentId}";
            List<InfantAccountModel> infantAccounts = this.ObtenerListaSQL<InfantAccountModel>(query).ToList();
            infantAccountModelList.AddRange(infantAccounts);

            return infantAccountModelList;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="infantAccountId"></param>
        /// <returns></returns>
        public bool DeleteInfantAccount(int infantAccountId)
        {
            string query = $"DELETE FROM Activity WHERE InfantAccountId = {infantAccountId};" +
                           $" DELETE FROM App where InfantAccountId = {infantAccountId};;" +
                           $" UPDATE DevicePhone SET InfantAccountId = NULL WHERE InfantAccountId = {infantAccountId};" +
                           $" DELETE FROM DeviceUse WHERE InfantAccountId = {infantAccountId};" +
                           $" DELETE FROM Request WHERE InfantAccountId = {infantAccountId};" +
                           $" DELETE FROM WebConfiguration WHERE InfantAccountId = {infantAccountId};" +
                           $" UPDATE WindowsAccount SET InfantAccountId = NULL WHERE InfantAccountId = {infantAccountId};" +
                           $" DELETE FROM InfantAccount WHERE InfantAccountId = {infantAccountId};";


            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }

        public bool UpdateInfantInformation(InfantAccountModel infantAccountModel)
        {
            string query = $"UPDATE InfantAccount SET InfantName = '{infantAccountModel.InfantName}'," +
                           $" InfantGender = '{infantAccountModel.InfantGender}'"+
                           $" WHERE InfantAccountId = {infantAccountModel.InfantAccountId}";

            bool execute = SQLConexionDataBase.Execute(query);

            return execute;
        }

        /// <summary>
        /// Método para convertir una lista DataTable a un TModel (Modelo genérico)
        /// </summary>
        /// <param name=""></param>
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
