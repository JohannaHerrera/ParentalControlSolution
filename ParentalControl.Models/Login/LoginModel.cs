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
        public string ParentEmail { get; set; }
        //Contraseña
        public string ParentPassword { get; set; }

        //Método para validar los datos
        public string Validate(LoginModel loginModel)
        {
            string message = string.Empty;

            if (string.IsNullOrEmpty(loginModel.ParentEmail) || string.IsNullOrEmpty(loginModel.ParentPassword))
            {
                return "Por favor, ingrese su correo y contraseña";
            }

            if (loginModel.ParentEmail.IndexOf("@") == -1 || loginModel.ParentEmail.IndexOf(".") == -1)
            {
                return "Ingrese una dirección de correo electrónico válida.";
            }

            return message;
        }
    }
}
