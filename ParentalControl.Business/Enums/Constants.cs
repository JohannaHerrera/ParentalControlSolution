using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.Enums
{
    public class Constants
    {
        public string Masculino
        {
            get
            {
                return "Masculino";
            }
        }
        public string Femenino
        {
            get
            {
                return "Femenino";
            }
        }
        public string NoProtected
        {
            get
            {
                return "No Protegido";
            }
        }

        public string Ninguno
        {
            get
            {
                return "Ninguno";
            }
        }

        public int Access
        {
            get
            {
                return 0;
            }
        }

        public int NoAccess
        {
            get
            {
                return 1;
            }
        }

        public int RequestStateCreated
        {
            get
            {
                return 0;
            }
        }

        public int RequestStateApproved
        {
            get
            {
                return 1;
            }
        }

        public int RequestStateDisapproved
        {
            get
            {
                return 2;
            }
        }

        public int WebConfiguration
        {
            get
            {
                return 1;
            }
        }

        public int AppConfiguration
        {
            get
            {
                return 2;
            }
        }

        public int DeviceConfiguration
        {
            get
            {
                return 3;
            }
        }
    }
}
