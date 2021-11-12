using ParentalControl.Business.BusinessBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControlWindowsForm.Forms
{
    public partial class FormHome : Form
    {
        public int parentId;

        public FormHome()
        {
            InitializeComponent();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }

        private void imgDevice_Click(object sender, EventArgs e)
        {
            DeviceBO deviceBO = new DeviceBO();
            string deviceCode = deviceBO.GetMACAddress();
            this.Hide();
            FormDevice formDevice = new FormDevice();            
            formDevice.parentId = this.parentId;
            formDevice.deviceName = deviceBO.GetDeviceName(deviceCode);
            formDevice.Show();
        }


        private void imgSchedule_Click_1(object sender, EventArgs e)
        {
            ScheduleBO scheduleBO = new ScheduleBO();
            FormSchedule formSchedule = new FormSchedule();
            this.Hide();
            formSchedule.Show();
        }
    }
}
