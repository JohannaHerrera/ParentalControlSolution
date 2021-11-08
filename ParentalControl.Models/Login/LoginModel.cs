using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Login
{
    public class LoginModel
    {
        public string User { get; set; }
        public string Password { get; set; }

        public string Validate(LoginModel loginModel)
        {
            string message = string.Empty;

            if (string.IsNullOrEmpty(loginModel.User) || string.IsNullOrEmpty(loginModel.Password))
            {
                return "Por favor, ingrese su correo y contraseña";
            }

            if (loginModel.User.IndexOf("@") == -1 || loginModel.User.IndexOf(".") == -1)
            {
                return "Ingrese una dirección de correo electrónico válida.";
            }

            return message;
        }
    }
}
