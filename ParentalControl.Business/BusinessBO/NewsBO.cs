using ParentalControl.Data;
using ParentalControl.Models.News;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    public class NewsBO
    {
        /// <summary>
        /// Método para obtener los tips y noticias
        /// </summary>
        /// <returns>List<NewsBO></returns>
        public List<NewsModel> GetNews()
        {
            string query = $"SELECT * FROM News";

            List<NewsModel> newsModelList = this.ObtenerListaSQL<NewsModel>(query).ToList();

            return newsModelList;
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
