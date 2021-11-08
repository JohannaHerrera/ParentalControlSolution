using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Login
{
    public class RegisterModel
    {
        public string Name { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string Validate(RegisterModel registerModel)
        {
            string message = string.Empty;

            if (string.IsNullOrEmpty(registerModel.Name) || string.IsNullOrEmpty(registerModel.User) 
                || string.IsNullOrEmpty(registerModel.Password))
            {
                return "Por favor, ingrese todos los datos requeridos";
            }

            if (registerModel.User.IndexOf("@") == -1 || registerModel.User.IndexOf(".") == -1)
            {
                return "Ingrese una dirección de correo electrónico válida.";
            }

            return message;
        }
    }
}
