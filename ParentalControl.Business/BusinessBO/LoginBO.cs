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
    /// Clase para gestionar los usuarios Padre
    /// </summary>
    public class LoginBO
    {
        /// <summary>
        /// Método para validar las credenciales del Padre
        /// </summary>
        /// <param name="loginModel">contiene el usuario y la contraseña</param>
        /// <returns>List<LoginModel></returns>
        public List<LoginModel> ValidateCredentials(LoginModel loginModel)
        {
            string query = $"SELECT * FROM Parent WHERE ParentEmail = '{loginModel.User}'" +
                           $" AND ParentPassword = '{loginModel.Password}'";

            List<LoginModel> loginModelList = this.ObtenerListaSQL<LoginModel>(query).ToList();

            return loginModelList;
        }

        /// <summary>
        /// Método para validar si ya existe un usuario (valida el correo)
        /// </summary>
        /// <param name="user">correo del Padre</param>
        /// <returns>List<RegisterModel></returns>
        public List<RegisterModel> ValidateRegister(string user)
        {
            string query = $"SELECT * FROM Parent WHERE ParentEmail = '{user}'";

            List<RegisterModel> registerModelList = this.ObtenerListaSQL<RegisterModel>(query).ToList();
            
            return registerModelList;
        }

        /// <summary>
        /// Método para registrar un nuevo usuario
        /// </summary>
        /// <param name="registerModel">modelo que contiene los datos del usuario Padre</param>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterUser(RegisterModel registerModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = $"INSERT INTO Parent VALUES('{registerModel.Name}', " +
                           $" '{registerModel.User}', '{registerModel.Password}'," +
                           $" '{creationDate}')";

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
