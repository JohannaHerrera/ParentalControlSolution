using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Device
{
    /// <summary>
    /// Modelo de la tabla DevicePC
    /// </summary>
    public class DeviceModel
    {
        // Nombre del dispositivo
        public string DeviceName { get; set; }
        // Código del dispositivo
        public string DeviceCode { get; set; }
        // Fecha de creación
        public DateTime DeviceCreationDate { get; set; }
        // Id del Padre
        public int ParentId { get; set; }

    }
}
