using ParentalControl.Business.BusinessBO;
using ParentalControl.Business.Enums;
using ParentalControl.Models.InfantAccount;
using ParentalControl.Models.Login;
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
    public partial class FormEditInfantAccount : Form
    {

        public int parentId;
        public int infantId;
        private string infantNameEdit;

        public FormEditInfantAccount()
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

        private void imgDevice_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceBO deviceBO = new DeviceBO();
                string deviceCode = deviceBO.GetMACAddress();
                this.Hide();
                FormDevice formDevice = new FormDevice();
                formDevice.deviceName = deviceBO.GetDeviceName(deviceCode);
                formDevice.parentId = this.parentId;
                formDevice.Show();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInfantAccount formInfantAccount = new FormInfantAccount();
            formInfantAccount.infantId = this.infantId;
            formInfantAccount.parentId = this.parentId;
            formInfantAccount.Show();
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

        private void FormEditInfantAccount_Load(object sender, EventArgs e)
        {
            try
            {                
                InfantAccountModel infantAccountModel = new InfantAccountModel();
                InfantAccountBO infantAccountBO = new InfantAccountBO();

                infantAccountModel = infantAccountBO.GetInfantAccount(this.infantId);

                if (infantAccountModel != null)
                {
                    this.txtName.Text = infantAccountModel.InfantName;
                    if (infantAccountModel.InfantGender.Equals("Masculino"))
                    {
                        this.rbGenderM.Checked = true;
                    }
                    else
                    {
                        this.rbGenderF.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al obtener la información de su cuenta.");
                    this.Hide();
                    FormInfantAccount formInfantAccount = new FormInfantAccount();
                    formInfantAccount.parentId = this.parentId;
                    formInfantAccount.Show();
                }

                this.infantNameEdit = this.txtName.Text;
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
                InfantAccountBO infantAccountBO = new InfantAccountBO();
                InfantAccountModel  infantAccountModel = new InfantAccountModel();
                Constants constants = new Constants();
                this.txtName.Enabled = false;
                this.rbGenderF.Enabled = false;
                this.rbGenderM.Enabled = false;
                this.btnCancel.Visible = false;
                this.btnSave.Visible = false;
                this.btnEdit.Visible = true;

                infantAccountModel.InfantName = this.txtName.Text;
                infantAccountModel.InfantAccountId = this.infantId;

                if (rbGenderM.Checked)
                {
                    infantAccountModel.InfantGender = constants.Masculino;
                }
                else
                {
                    infantAccountModel.InfantGender = constants.Femenino;
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

                    if (infantAccountModelList.Count == 0 ||
                        infantAccountModelList.FirstOrDefault().InfantName.ToUpper().Equals(this.infantNameEdit.ToUpper()))
                    {
                        if (infantAccountBO.UpdateInfantInformation(infantAccountModel))
                        {
                            MessageBox.Show("La información se actualizó correctamente.");
                            this.Hide();
                            FormInfantAccount formInfantAccount = new FormInfantAccount();
                            formInfantAccount.parentId = this.parentId;
                            formInfantAccount.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al actualizar la información. Inténtelo de nuevo.");
                            this.Hide();
                            FormInfantAccount formInfantAccount = new FormInfantAccount();
                            formInfantAccount.parentId = this.parentId;
                            formInfantAccount.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una cuenta con el mismo nombre.");
                        this.txtName.Text = this.infantNameEdit;
                    }                   
                }                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtName.Enabled = true;
                this.rbGenderM.Enabled = true;
                this.rbGenderF.Enabled = true;
                this.btnCancel.Visible = true;
                this.btnSave.Visible = true;
                this.btnEdit.Visible = false;
                this.rbGroup.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
