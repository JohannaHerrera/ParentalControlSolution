using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Login
{
    /// <summary>
    /// Modelo para el Login
    /// </summary>
    public class LoginModel
    {
        //Correo
        public string User { get; set; }
        //Contraseña
        public string Password { get; set; }

        //Método para validar los datos
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
