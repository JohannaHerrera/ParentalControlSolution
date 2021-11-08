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
    public class LoginBO
    {
        public DataTable validateCredentials(LoginModel loginModel)
        {
            string query = $"SELECT * FROM Parent WHERE ParentEmail = '{loginModel.User}'" +
                           $" AND ParentPassword = '{loginModel.Password}'";

            DataTable dataTable = SQLConexionDataBase.Query(query);
            return dataTable;
        }

        public DataTable validateRegister(string user)
        {
            string query = $"SELECT * FROM Parent WHERE ParentEmail = '{user}'";

            DataTable dataTable = SQLConexionDataBase.Query(query);
            return dataTable;
        }

        public bool registerUser(RegisterModel registerModel)
        {
            var creationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = $"INSERT INTO Parent VALUES('{registerModel.Name}', " +
                           $" '{registerModel.User}', '{registerModel.Password}'," +
                           $" '{creationDate}')";

            bool execute = SQLConexionDataBase.Execute(query);
            return execute;
        }
    }
}
