using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Schedule
{
    /// <summary>
    /// Modelo de la tabla Schedule
    /// </summary>
    public class ScheduleModel
    {
        //Id del horario
        public int ScheduleId { get; set; }
        //Tiempo de inicio
        public DateTime ScheduleStartTime { get; set; }
        //Tiempo de fin
        public DateTime ScheduleEndTime { get; set; }
        //Fecha de creacion
        public DateTime ScheduleCreationDate { get; set; }
    }
}
