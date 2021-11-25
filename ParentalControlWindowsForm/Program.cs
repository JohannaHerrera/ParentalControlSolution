using ParentalControl.Business.BusinessBO;
using ParentalControl.Models.Device;
using ParentalControlWindowsForm.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControlWindowsForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DeviceBO deviceBO = new DeviceBO();
            string deviceCode = deviceBO.GetDeviceIdentifier();
            List<DeviceModel> deviceModelList = deviceBO.VerifyDeviceExist(deviceCode);

            if(deviceModelList.Count > 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormRequest());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
            }           
        }
    }
}
