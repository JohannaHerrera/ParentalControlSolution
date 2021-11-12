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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Se validan los datos del registro
                InfantAccountModel infantAccountModel = new InfantAccountModel();
                InfantAccountBO infantAccountBO = new InfantAccountBO();

                infantAccountModel.InfantName = txtName.Text;
                if (rbGenderF.Checked)
                {
                    infantAccountModel.InfantGender = rbGenderF.Text;
                }
                else if(rbGenderM.Checked)
                {
                    infantAccountModel.InfantGender = rbGenderM.Text;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el Género de su hijo.");
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
                    infantAccountModelList = infantAccountBO.ValidateInfantAccount(infantAccountModel.InfantName);

                    if (infantAccountModelList.Count == 0)
                    {
                        if (infantAccountBO.CreateInfantAccount(infantAccountModel,parentId))
                        {
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
    }
}
