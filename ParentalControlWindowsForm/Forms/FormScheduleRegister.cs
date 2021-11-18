using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParentalControl.Models.Schedule;
using ParentalControl.Business.BusinessBO;

namespace ParentalControlWindowsForm.Forms
{
    public partial class FormScheduleRegister : Form
    {
        public int parentId;
        public FormScheduleRegister()
        {
            
            InitializeComponent();
          
        }

        private void FormScheduleRegister_Load(object sender, EventArgs e)
        {
            dudHora.Text = DateTime.Now.ToString("HH");
            dudMinute.Text = DateTime.Now.ToString("mm");
            dudHoraFin.Text = DateTime.Now.ToString("HH");
            dudMinuteEnd.Text = DateTime.Now.ToString("mm");
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd mmmm yyy");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ScheduleModel scheduleModel = new ScheduleModel();
                ScheduleBO scheduleBO = new ScheduleBO();

                //Convertir hora inicio a int
                int ih = Convert.ToInt32(Math.Round(dudHora.Value));
                ////Convertir min inicio a int
                int im = Convert.ToInt32(Math.Round(dudMinute.Value));
                ////Convertir hora fin a int
                int ihf =Convert.ToInt32(Math.Round(dudHoraFin.Value)); 
                ////Convertir min fin a int
                int ime = Convert.ToInt32(Math.Round(dudMinuteEnd.Value));

                scheduleModel.ScheduleStartTime = new DateTime(2021, 11, 11, ih, im, 0);
                scheduleModel.ScheduleEndTime= new DateTime(2021, 11, 11, ihf, ime, 0);
                scheduleModel.ParentId = this.parentId;

                string message = scheduleModel.Validate(scheduleModel);

                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {
                    // Se verifica que no exista un registro con el mismo horario
                    List<ScheduleModel> scheduleModelList = new List<ScheduleModel>();
                    scheduleModelList = scheduleBO.ValidateSchedule(scheduleModel.ScheduleStartTime, scheduleModel.ScheduleEndTime, this.parentId);

                    if(scheduleModelList.Count > 0)
                    {
                        MessageBox.Show("Ya existe un registro con el mismo horario.");
                    }
                    else
                    {                    
                        if (scheduleBO.RegisterSchedule(scheduleModel))
                        {
                            MessageBox.Show("¡Se ha registrado satisfactoriamente!");
                            this.Hide();
                            FormSchedule formSchedule = new FormSchedule();
                            formSchedule.parentId = this.parentId;
                            formSchedule.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error en la creación de horario");
                            this.Hide();
                            FormSchedule formSchedule = new FormSchedule();
                            formSchedule.parentId = this.parentId;
                            formSchedule.Show();
                        }
                    }
                }                              
            }            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}




        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblMnts_Click(object sender, EventArgs e)
        {

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

        private void imgDevice_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceBO deviceBO = new DeviceBO();
                string deviceCode = deviceBO.GetMACAddress();
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
    }
}
