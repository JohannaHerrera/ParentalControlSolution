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
        public string ParentUsername { get; set; }
        // Correo
        public string ParentEmail { get; set; }
        // Contraseña
        public string ParentPassword { get; set; }

        //Método para validar los datos
        public string Validate(RegisterModel registerModel)
        {
            string message = string.Empty;

            if (string.IsNullOrEmpty(registerModel.ParentUsername) || string.IsNullOrEmpty(registerModel.ParentEmail) 
                || string.IsNullOrEmpty(registerModel.ParentPassword))
            {
                return "Por favor, ingrese todos los datos requeridos";
            }

            if (registerModel.ParentEmail.IndexOf("@") == -1 || registerModel.ParentEmail.IndexOf(".") == -1)
            {
                return "Ingrese una dirección de correo electrónico válida.";
            }

            return message;
        }
    }
}
