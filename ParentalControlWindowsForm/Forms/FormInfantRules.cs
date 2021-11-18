﻿using ParentalControl.Business.BusinessBO;
using ParentalControl.Models.Device;
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
    public partial class FormInfantRules : Form
    {
        public int parentId;
        public int infantId;

        public FormInfantRules()
        {
            InitializeComponent();
        }

        private void FormInfantRules_Load(object sender, EventArgs e)
        {
            try
            {

                InfantAccountBO infantAccountBO = new InfantAccountBO();               
                lblInfantAccountName.Text= infantAccountBO.GetInfantAccount(this.infantId).InfantName;

                // ***************** CATEGORÍAS WEB ***************** 
                dgvWebLock.Rows.Add("Category", false);
                dgvWebLock.Rows.Add("Category", false);
                dgvWebLock.Rows.Add("Category", false);
                dgvWebLock.Rows.Add("Category", false);


                // ***************** APLICACIONES ***************** 
                List<ApplicationModel> applicationModelList = new List<ApplicationModel>();
                List<DeviceModel> deviceModelList = new List<DeviceModel>();
                List<ScheduleModel> scheduleModelList = new List<ScheduleModel>();
                DeviceBO deviceBO = new DeviceBO();
                ScheduleBO scheduleBO = new ScheduleBO();
                ApplicationBO applicationBO = new ApplicationBO();

                //Obtengo los horarios
                scheduleModelList = scheduleBO.GetSchedule(this.parentId);
                foreach (var schedule in scheduleModelList)
                {
                    string horaInicio = schedule.ScheduleStartTime.ToString("HH:mm");
                    string horaFin = schedule.ScheduleEndTime.ToString("HH:mm");
                    this.Schedule.Items.Add($"{horaInicio} - {horaFin}");
                }

                // Obtengo el Id del Dispositivo
                string deviceCode = deviceBO.GetMACAddress();
                deviceModelList = deviceBO.VerifyDeviceExist(deviceCode);
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;

                // Obtengo las aplicaciones de este Dispositivo
                applicationModelList = applicationBO.GetAppsDevice(this.infantId, deviceId);

                foreach (var app in applicationModelList)
                {
                    dgvAppLock.Rows.Add(app.AppName);
                }
               

                // ***************** USO DEL DISPOSITIVO ***************** 
                dgvTimeUseDevice.Rows.Add("Day");
                dgvTimeUseDevice.Rows.Add("Day");
                dgvTimeUseDevice.Rows.Add("Day");
                dgvTimeUseDevice.Rows.Add("Day");
                dgvTimeUseDevice.Rows.Add("Day");
                dgvTimeUseDevice.Rows.Add("Day");
                dgvTimeUseDevice.Rows.Add("Day");

                // ***************** HISTORIAL ***************** 
                dgvActivityRecord.Rows.Add("Activity");
                dgvActivityRecord.Rows.Add("Activity");
                dgvActivityRecord.Rows.Add("Activity");
                dgvActivityRecord.Rows.Add("Activity");

                

                //dgvWebLock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void imgNotifications_Click(object sender, EventArgs e)
        {

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

        private void btnWebLock_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnWebLock.Location = new System.Drawing.Point(0, 0);
                this.btnAppLock.Location = new System.Drawing.Point(0, 237);
                this.btnTimeUseDevice.Location = new System.Drawing.Point(0, 283);
                this.btnActivityRecord.Location = new System.Drawing.Point(0, 329);
                this.dgvWebLock.Location = new System.Drawing.Point(17, 46);
                this.dgvWebLock.Visible = true;
                this.dgvAppLock.Visible = false;
                this.dgvTimeUseDevice.Visible = false;
                this.dgvActivityRecord.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAppLock_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnWebLock.Location = new System.Drawing.Point(0, 0);
                this.btnAppLock.Location = new System.Drawing.Point(0, 46);
                this.btnTimeUseDevice.Location = new System.Drawing.Point(0, 283);
                this.btnActivityRecord.Location = new System.Drawing.Point(0, 329);
                this.dgvAppLock.Location = new System.Drawing.Point(18, 92);
                this.dgvWebLock.Visible = false;
                this.dgvAppLock.Visible = true;
                this.dgvTimeUseDevice.Visible = false;
                this.dgvActivityRecord.Visible = false;                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimeUseDevice_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnWebLock.Location = new System.Drawing.Point(0, 0);
                this.btnAppLock.Location = new System.Drawing.Point(0, 46);
                this.btnTimeUseDevice.Location = new System.Drawing.Point(0, 92);
                this.btnActivityRecord.Location = new System.Drawing.Point(0, 329);
                this.dgvTimeUseDevice.Location = new System.Drawing.Point(18, 138);
                this.dgvWebLock.Visible = false;               
                this.dgvAppLock.Visible = false;
                this.dgvTimeUseDevice.Visible = true;
                this.dgvActivityRecord.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActivityRecord_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnWebLock.Location = new System.Drawing.Point(0, 0);
                this.btnAppLock.Location = new System.Drawing.Point(0, 46);
                this.btnTimeUseDevice.Location = new System.Drawing.Point(0, 92);
                this.btnActivityRecord.Location = new System.Drawing.Point(0, 138);
                this.dgvActivityRecord.Location = new System.Drawing.Point(17, 184);
                this.dgvWebLock.Visible = false;                
                this.dgvAppLock.Visible = false;
                this.dgvTimeUseDevice.Visible = false;
                this.dgvActivityRecord.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
