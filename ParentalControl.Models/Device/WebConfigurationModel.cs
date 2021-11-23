using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Models.Device
{
    public class WebConfigurationModel
    {
        public int WebConfigurationId { get; set; }
        public bool WebConfigurationAccess { get; set; } // Base de datos es de tipo BIT
        public int CategoryId { get; set; }
        public int InfantAccountId { get; set; }

    }
}
