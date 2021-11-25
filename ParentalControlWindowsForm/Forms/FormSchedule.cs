using ParentalControl.Business.BusinessBO;
using ParentalControl.Models.Schedule;
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
    public partial class FormSchedule : Form
    {
        public int parentId;
        public int scheduleId;
        public FormSchedule()
        {
            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            ScheduleBO scheduleBO = new ScheduleBO();
            List<ScheduleModel> scheduleList = scheduleBO.GetSchedule(this.parentId);

            if (scheduleList.Count > 0)
            {
                foreach (var schedule in scheduleList)
                {
                    this.editSchedule.Image = global::ParentalControlWindowsForm.Properties.Resources.editar_32;
                    this.deleteSchedule.Image = global::ParentalControlWindowsForm.Properties.Resources.eliminar_32;
                   
                    dgvSchedule.Rows.Add(schedule.ScheduleId.ToString(),schedule.ScheduleStartTime.ToString("HH:mm"), schedule.ScheduleEndTime.ToString("HH:mm"), this.editSchedule.Image, this.deleteSchedule.Image);                   
                }
            }
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHome formHome = new FormHome();
                formHome.parentId = this.parentId;
                formHome.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormScheduleRegister formScheduleRegister = new FormScheduleRegister();
            formScheduleRegister.parentId = this.parentId;
            formScheduleRegister.Show();
        }

        private void imgScheedule_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormSchedule formSchedule = new FormSchedule();
                formSchedule.parentId = this.parentId;
                formSchedule.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgDevice_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceBO deviceBO = new DeviceBO();
                string deviceCode = deviceBO.GetDeviceIdentifier();
                this.Hide();
                FormDevice formDevice = new FormDevice();
                formDevice.parentId = this.parentId;
                formDevice.deviceName = deviceBO.GetDeviceName(deviceCode);
                formDevice.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgInfants_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormInfantAccount formInfantAccount = new FormInfantAccount();
                formInfantAccount.parentId = this.parentId;
                formInfantAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormPersonalAccount formPersonalAccount = new FormPersonalAccount();
                formPersonalAccount.parentId = this.parentId;
                formPersonalAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idSchedule = dgvSchedule.CurrentRow.Cells[0].Value.ToString();
            
            if (e.ColumnIndex == 3)
            {
                String id = dgvSchedule.CurrentRow.Cells[0].Value.ToString();
                String st = dgvSchedule.CurrentRow.Cells[1].Value.ToString();
                String et = dgvSchedule.CurrentRow.Cells[2].Value.ToString();
                DateTime dtSt = DateTime.Parse(st);
                this.scheduleId = Int32.Parse(idSchedule);
                this.Hide();

                FormScheduleEdit formScheduleEdit = new FormScheduleEdit();
                formScheduleEdit.parentId = this.parentId;
                formScheduleEdit.scheduleId = this.scheduleId;
                formScheduleEdit.Show();               
            }   
            else if (e.ColumnIndex == 4)
            {
                try
                {
                    DialogResult res = MessageBox.Show("¿Estás seguro que deseas eliminar el horario?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                    {
                        return;
                    }
                    if (res == DialogResult.Yes)
                    {
                        ScheduleBO scheduleBo = new ScheduleBO();
                        this.scheduleId = Int32.Parse(idSchedule);
                        if (scheduleBo.DeleteSchedule(this.scheduleId))
                        {
                            MessageBox.Show("El horario se eliminó correctamente.");
                            this.Hide();
                            FormSchedule formSchedule = new FormSchedule();
                            formSchedule.parentId = this.parentId;
                            formSchedule.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un problema al eliminar el horario.");
                            this.Hide();
                            FormSchedule formSchedule = new FormSchedule();
                            formSchedule.parentId = this.parentId;
                            formSchedule.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void imgNotifications_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormNotifications formNotifications = new FormNotifications();
                formNotifications.parentId = this.parentId;
                formNotifications.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
