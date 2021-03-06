using ParentalControl.Business.BusinessBO;
using ParentalControl.Business.Enums;
using ParentalControl.Models.Device;
using ParentalControl.Models.InfantAccount;
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
    public partial class FormAddInfantAccount : Form
    {
        public int parentId;
        public FormAddInfantAccount()
        {
            InitializeComponent();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Constants constants = new Constants();
                // Se validan los datos del registro
                InfantAccountModel infantAccountModel = new InfantAccountModel();
                InfantAccountBO infantAccountBO = new InfantAccountBO();

                infantAccountModel.InfantName = txtName.Text;
                if (rbGenderF.Checked)
                {
                    infantAccountModel.InfantGender = constants.Femenino;
                }
                else if(rbGenderM.Checked)
                {
                    infantAccountModel.InfantGender = constants.Masculino;
                }
                
                string message = infantAccountModel.Validate(infantAccountModel);

                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {
                    // Se verifica que no exista un hijo con el mismo nombre
                    List<InfantAccountModel> infantAccountModelList = new List<InfantAccountModel>();
                    List<DeviceUseModel> deviceUseModelList = new List<DeviceUseModel>();
                    infantAccountModelList = infantAccountBO.ValidateInfantAccount(infantAccountModel.InfantName);

                    if (infantAccountModelList.Count == 0)
                    {
                        if (infantAccountBO.CreateInfantAccount(infantAccountModel,parentId))
                        {
                            int infantId = infantAccountBO.GetInfantId(infantAccountModel.InfantName);

                            List<String> listDay = new List<string>()
                            {           
                                "Lunes",
                                "Martes",
                                "Miércoles",
                                "Jueves",
                                "Viernes",
                                "Sábado",
                                "Domingo"
                            };

                            foreach (var day in listDay)
                            {
                                DeviceUseBO deviceUseBO = new DeviceUseBO();
                                DeviceUseModel deviceUseModel = new DeviceUseModel();
                                deviceUseModel.DeviceUseDay = day;
                                deviceUseModel.InfantAccountId = infantId;
                                deviceUseBO.RegisterDeviceUse(deviceUseModel);
                                
                                
                            }

                            MessageBox.Show("¡Se ha creado la cuenta de Hijo satisfactoriamente!");
                            this.Hide();
                            FormInfantAccount formInfantAccount = new FormInfantAccount();
                            formInfantAccount.parentId = this.parentId;
                            formInfantAccount.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una cuenta con el mismo nombre.");
                    }
                }
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
