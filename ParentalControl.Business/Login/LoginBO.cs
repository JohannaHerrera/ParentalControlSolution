using ParentalControl.Data;
using ParentalControl.Models.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ParentalControl.Business.Login
{
    public class LoginBO
    {
        public DataTable getUser(LoginModel loginModel)
        {
            string query = $"SELECT * FROM Parent WHERE ParentEmail = {loginModel.User}" +
                               $"AND ParentPassword = {loginModel.Password}";

            DataTable dataTable = SQLConexionDataBase.Query(query);
            return dataTable;
        }
    }
}
