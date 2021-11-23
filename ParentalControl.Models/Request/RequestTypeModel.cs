using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Request
{
    /// <summary>
    /// Modelo de la tabla RequestType
    /// </summary>
    public class RequestTypeModel
    {
        // Id del tipo de Petición
        public int RequestTypeId { get; set; }
        // Nombre de la Petición
        public string RequestTypeName { get; set; }
        // Código de la Petición
        public string RequestTypeCode { get; set; }
    }
}
