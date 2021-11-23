using System;
using System.Collections.Generic;
using System.Data;
using ParentalControl.Data;
using ParentalControl.Models.Device;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParentalControl.Business.Enums;
using ParentalControl.Models.InfantAccount;
using System.DirectoryServices;
using System.Management;

namespace ParentalControl.Business.BusinessBO
{
    public class WebConfigurationBO
    {
        int webAccess;
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
        public List<WebConfigurationModel> GetWebConfiguration(int infantId)
        {

            List<WebConfigurationModel> webConfigurationModelList = new List<WebConfigurationModel>();

            string query = $"SELECT * FROM WebConfiguration WHERE InfantAccountId = {infantId}";
            List<WebConfigurationModel> webConfiguration= this.ObtenerListaSQL<WebConfigurationModel>(query).ToList();
            webConfigurationModelList.AddRange(webConfiguration);
            return webConfigurationModelList;

        }
        public List<WebCategoryModel> GetWebCategory()
        {

            List<WebCategoryModel> webCategoryModelList = new List<WebCategoryModel>();

            string query = $"SELECT * FROM WebCategory";
            List<WebCategoryModel> webCategory = this.ObtenerListaSQL<WebCategoryModel>(query).ToList();
            webCategoryModelList.AddRange(webCategory);
            return webCategoryModelList;

        }
         public bool UpdateWebConfiguration(WebConfigurationModel webConfig)
        {
            
            
            if (webConfig.WebConfigurationAccess == true)
            {
                this.webAccess = 1;
            }
            else
            {
                if (webConfig.WebConfigurationAccess == false)
                {
                    this.webAccess = 0;
                }
                
            }
            string query = $"UPDATE WebConfiguration " +
                           $" SET WebConfigurationAccess = {this.webAccess}"
                         + $" WHERE WebConfigurationId = {webConfig.WebConfigurationId}";
            bool execute = SQLConexionDataBase.Execute(query);
            return execute;
        }
    }
}
