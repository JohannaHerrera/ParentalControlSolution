using ParentalControl.Business.BusinessBO;
using ParentalControl.Models.Device;
using ParentalControl.Models.Request;
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
    public partial class FormRequest : Form
    {
        private int infantId;
        private int parentId;
        private int deviceId;

        public FormRequest()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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

        private void FormRequest_Load(object sender, EventArgs e)
        {
            try
            {                
                // Verifico si el usuario loggeado tiene una cuenta infantil vinculada
                WindowsAccountBO windowsAccountBO = new WindowsAccountBO();
                DeviceBO deviceBO = new DeviceBO();
                RequestBO requestBO = new RequestBO();
                string deviceCode = deviceBO.GetDeviceIdentifier();               
                List<RequestTypeModel> requestTypeModelList = requestBO.GetRequestTypes();
                List<WindowsAccountModel> windowsAccountModelList = windowsAccountBO.VerifyWindowsAccount(Environment.UserName);
                List<DeviceModel> deviceModelList = deviceBO.VerifyDeviceExist(deviceCode);
                this.deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                this.btnSendRequest.Visible = false;

                if (windowsAccountModelList.Count > 0)
                {
                    this.lblRequestTitle.Visible = true;
                    this.ptBoxRequestImage.Visible = true;
                    this.pnlRequest.Visible = true;
                    this.lblNoProtected.Visible = false;
                    this.ptBoxCheck.Visible = false;
                    this.infantId = windowsAccountModelList.FirstOrDefault().InfantAccountId;
                    this.parentId = deviceModelList.FirstOrDefault().ParentId;

                    // Verifico si no existen notificaciones CORREGIR
                    if(this.dgvNotifications.Rows.Count > 0)
                    {
                        this.lblNoNotifications.Visible = false;
                    }
                    else
                    {
                        this.lblNoNotifications.Visible = true;
                    }

                    // Cargo el combo de los tipos de peticiones                   
                    foreach (var type in requestTypeModelList)
                    {
                        this.cmbRequestType.Items.Add(type.RequestTypeName);
                    }                    
                }
                else
                {
                    this.lblRequestTitle.Visible = false;
                    this.ptBoxRequestImage.Visible = false;
                    this.lblNoProtected.Visible = true;
                    this.lblNoProtected.Location = new System.Drawing.Point(189, 180);
                    this.ptBoxCheck.Visible = true;
                    this.ptBoxCheck.Location = new System.Drawing.Point(350, 289);
                    this.pnlRequest.Visible = false;
                    this.pnlNotifications.Visible = false;
                    this.Line.Visible = false;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRequestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRequestType.SelectedItem != null)
                {
                    this.lblObject.Visible = true;
                    this.cmbObject.Visible = false;
                    this.lblHours.Visible = false;
                    this.lblMinutes.Visible = false;
                    this.cmbHours.Visible = false;
                    this.cmbMinutes.Visible = false;
                    this.btnSendRequest.Visible = true;

                    if (cmbRequestType.SelectedItem.Equals("Desbloqueo Web"))
                    {
                        this.lblObject.Text = "Selecciona la categoría:";
                        this.cmbObject.Visible = true;
                        this.lblHours.Visible = false;
                        this.lblMinutes.Visible = false;
                        this.cmbHours.Visible = false;
                        this.cmbMinutes.Visible = false;
                    }
                    else if (cmbRequestType.SelectedItem.Equals("Desbloqueo de Aplicaciones"))
                    {
                        this.lblObject.Text = "Selecciona la aplicación:";
                        this.cmbObject.Visible = true;
                        this.lblHours.Visible = false;
                        this.lblMinutes.Visible = false;
                        this.cmbHours.Visible = false;
                        this.cmbMinutes.Visible = false;

                        RequestBO requestBO = new RequestBO();
                        List<ApplicationModel> applicationModelList = requestBO.GetBlockedApps(this.infantId, this.deviceId);
                        if (applicationModelList.Count > 0)
                        {
                            foreach (var app in applicationModelList)
                            {
                                this.cmbObject.Items.Add(app.AppName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay aplicaciones registradas.");
                        }
                    }
                    else if (cmbRequestType.SelectedItem.Equals("Ampliar uso del Dispositivo"))
                    {
                        this.lblObject.Text = "Especifica el tiempo que deseas incrementar:";
                        this.cmbObject.Visible = false;
                        this.cmbObject.Visible = false;
                        this.lblHours.Visible = true;
                        this.lblMinutes.Visible = true;
                        this.cmbHours.Visible = true;
                        this.cmbMinutes.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("¡Selecciona el tipo de petición!");
                        this.lblObject.Visible = false;
                        this.cmbObject.Visible = false;
                        this.lblHours.Visible = false;
                        this.lblMinutes.Visible = false;
                        this.cmbHours.Visible = false;
                        this.cmbMinutes.Visible = false;
                        this.btnSendRequest.Visible = false;
                    }
                }
                else
                {
                    this.lblObject.Visible = false;
                    this.cmbObject.Visible = false;
                    this.lblHours.Visible = false;
                    this.lblMinutes.Visible = false;
                    this.cmbHours.Visible = false;
                    this.cmbMinutes.Visible = false;
                    this.btnSendRequest.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
