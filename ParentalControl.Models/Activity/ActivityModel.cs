using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Activity
{
    /// <summary>
    /// Modelo de la tabla Activity
    /// </summary>
    public class ActivityModel
    {
        // Id de la Actividad
        public int ActivityId { get; set; }
        // Id del infante
        public int InfantAccountId { get; set; }
        //Objeto de la actividad
        public string ActivityObject { get; set; }
        // Descripción de la actividad
        public string ActivityDescription { get; set; }
        // Fecha de creación
        public DateTime ActivityCreationDate { get; set; }
    }
}
