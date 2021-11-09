using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Login
{
    /// <summary>
    /// Modelo para el registro de usuarios Padre
    /// </summary>
    public class RegisterModel
    {
        // Nombre de usuario
        public string Name { get; set; }
        // Correo
        public string User { get; set; }
        // Contraseña
        public string Password { get; set; }

        //Método para validar los datos
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
