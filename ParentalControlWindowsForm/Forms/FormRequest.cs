using ParentalControl.Business.BusinessBO;
using ParentalControl.Business.Enums;
using ParentalControl.Models.Device;
using ParentalControl.Models.Request;
using ParentalControl.Models.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private string parentEmail;

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
                    this.parentEmail = requestBO.GetParentEmail(this.parentId);
                    int deviceId = deviceModelList.FirstOrDefault().DevicePCId;

                    NotificationBO notificationBO = new NotificationBO();
                    Constants constants = new Constants();
                    List<RequestModel> notifications = notificationBO.GetInfantNotifications(this.infantId, deviceId);
                    int cont = 0;

                    if (notifications.Count > 0)
                    {
                        this.lblNoNotifications.Visible = false;

                        foreach(var notification in notifications)
                        {
                            string request = string.Empty;
                            string state = string.Empty;

                            if(notification.RequestTypeId == constants.WebConfiguration)
                            {
                                request = $"Petición para habilitar el acceso a la categoría" +
                                          $" web: {notification.RequestObject}.";
                            }
                            else if (notification.RequestTypeId == constants.AppConfiguration)
                            {
                                request = $"Petición para habilitar el acceso a la aplicación:" +
                                          $" {notification.RequestObject}.";
                            }
                            else if (notification.RequestTypeId == constants.DeviceConfiguration)
                            {
                                string[] time = notification.RequestTime.ToString().Split('.');
                                int numEntero = 0;
                                int numDecimal = 0;

                                if (time.Count() > 1)
                                {
                                    numEntero = int.Parse(time[0]);
                                    numDecimal = int.Parse(time[1]);
                                }
                                else
                                {
                                    numEntero = int.Parse(time[0]);
                                }

                                if (numEntero > 0)
                                {
                                    if (numEntero == 1)
                                    {
                                        if (numDecimal > 0)
                                        {
                                            request = $"Petición para extender el tiempo de uso del " +
                                              $"dispositivo por {numEntero} hora y {numDecimal}" +
                                              $" minutos.";
                                        }
                                        else
                                        {
                                            request = $"Petición para extender el tiempo de uso del " +
                                              $"dispositivo por {numEntero} hora.";
                                        }                                        
                                    }
                                    else
                                    {
                                        if (numDecimal > 0)
                                        {
                                            request = $"Petición para extender el tiempo de uso del " +
                                              $"dispositivo por {numEntero} horas y {numDecimal}" +
                                              $" minutos.";
                                        }
                                        else
                                        {
                                            request = $"Petición para extender el tiempo de uso del " +
                                              $"dispositivo por {numEntero} horas.";
                                        }                                           
                                    }                                    
                                }
                                else
                                {
                                    request = $"Petición para extender el tiempo de uso del " +
                                              $"dispositivo por {numDecimal} minutos.";
                                }                                
                            }                           

                            this.dgvNotifications.Rows.Add(request, state);

                            if (notification.RequestState == constants.RequestStateCreated)
                            {
                                state = "En espera";
                                this.dgvNotifications.Rows[cont].Cells[1].Value = state;

                                if (notification.RequestTypeId == constants.DeviceConfiguration)
                                {
                                    DateTime now = DateTime.Now;

                                    if (now.Date > notification.RequestCreationDate.Date)
                                    {
                                        requestBO.UpdateRequest(notification.RequestId, constants.RequestStateUnanswered);
                                        state = "Sin Respuesta";
                                        this.dgvNotifications.Rows[cont].Cells[1].Value = state;
                                        this.dgvNotifications.Rows[cont].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.OrangeRed };
                                    }
                                }
                            }
                            else if (notification.RequestState == constants.RequestStateApproved)
                            {
                                state = "Aprobado";
                                this.dgvNotifications.Rows[cont].Cells[1].Value = state;
                                this.dgvNotifications.Rows[cont].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
                            }
                            else if (notification.RequestState == constants.RequestStateDisapproved)
                            {
                                state = "Desaprobado";
                                this.dgvNotifications.Rows[cont].Cells[1].Value = state;
                                this.dgvNotifications.Rows[cont].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else if (notification.RequestState == constants.RequestStateUnanswered)
                            {
                                state = "Sin Respuesta";
                                this.dgvNotifications.Rows[cont].Cells[1].Value = state;
                                this.dgvNotifications.Rows[cont].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.OrangeRed };
                            }

                            cont++;
                        }                       
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
                    this.cmbObject.Items.Clear();
                    this.cmbHours.Items.Clear();
                    this.cmbMinutes.Items.Clear();

                    if (cmbRequestType.SelectedItem.Equals("Desbloqueo Web"))
                    {
                        this.lblObject.Text = "Selecciona la categoría:";
                        this.cmbObject.Visible = true;
                        this.lblHours.Visible = false;
                        this.lblMinutes.Visible = false;
                        this.cmbHours.Visible = false;
                        this.cmbMinutes.Visible = false;
                        this.cmbObject.Items.Clear();

                        RequestBO requestBO = new RequestBO();
                        WebConfigurationBO webConfigurationBO = new WebConfigurationBO();
                        List<WebConfigurationModel> webConfigurationModelList = requestBO.GetBlockedWebCategory(this.infantId);
                        List<WebCategoryModel> webCategoryModelList = webConfigurationBO.GetWebCategory();                       

                        if (webCategoryModelList.Count == 0)
                        {
                            MessageBox.Show("Ocurrió un error al obtener las categorías web.");
                            this.Hide();
                            FormRequest formRequest = new FormRequest();
                            formRequest.Show();
                        }
                        else
                        {
                            if (webConfigurationModelList.Count > 0)
                            {
                                foreach (var webConfiguration in webConfigurationModelList)
                                {
                                    this.cmbObject.Items.Add(
                                        webCategoryModelList.Where(x => x.CategoryId == webConfiguration.CategoryId)
                                        .Select(c => c.CategoryName).FirstOrDefault());
                                }
                            }
                            else
                            {
                                MessageBox.Show("No tienes bloqueada ninguna categoría web.");
                                this.Hide();
                                FormRequest formRequest = new FormRequest();
                                formRequest.Show();
                            }
                        }                        
                    }
                    else if (cmbRequestType.SelectedItem.Equals("Desbloqueo de Aplicaciones"))
                    {
                        this.lblObject.Text = "Selecciona la aplicación:";
                        this.cmbObject.Visible = true;
                        this.lblHours.Visible = false;
                        this.lblMinutes.Visible = false;
                        this.cmbHours.Visible = false;
                        this.cmbMinutes.Visible = false;
                        this.cmbObject.Items.Clear();

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
                            MessageBox.Show("No hay aplicaciones registradas. O no tienes" +
                                            " ninguna app que se encuentre bloqueada.");
                            this.Hide();
                            FormRequest formRequest = new FormRequest();
                            formRequest.Show();
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
                        this.cmbObject.Items.Clear();
                        this.cmbHours.Items.Clear();
                        this.cmbMinutes.Items.Clear();

                        RequestBO requestBO = new RequestBO();
                        DateTime currentDate = DateTime.Now;
                        string day = currentDate.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));

                        ScheduleModel schedule = requestBO.GetDeviceUse(this.infantId, day);

                        if (schedule != null)
                        {
                            int hour = Convert.ToInt32(schedule.ScheduleEndTime.ToString("HH"));
                            int minutes = Convert.ToInt32(schedule.ScheduleEndTime.ToString("mm"));
                            int hoursAvailable = 0;
                            int minutesAvailable = 0;

                            hoursAvailable = 24 - (hour + 1);
                            minutesAvailable = 60 - minutes;                         

                            // Horas
                            int cont = 1;
                            while (cont <= hoursAvailable)
                            {
                                this.cmbHours.Items.Add(cont);
                                cont++;
                            }

                            // Minutos
                            cont = 10;
                            while (cont <= minutesAvailable)
                            {
                                if(cont != 60)
                                {
                                    this.cmbMinutes.Items.Add(cont);                                   
                                }
                                cont = cont + 10;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No tienes restricción de tiempo de uso del dispositivo para este día.");
                            this.Hide();
                            FormRequest formRequest = new FormRequest();
                            formRequest.Show();
                        }
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
                        this.cmbObject.Items.Clear();
                        this.cmbHours.Items.Clear();
                        this.cmbMinutes.Items.Clear();
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
                    this.cmbObject.Items.Clear();
                    this.cmbHours.Items.Clear();
                    this.cmbMinutes.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                RequestBO requestBO = new RequestBO();
                Constants constants = new Constants();
                WindowsAccountBO windowsAccountBO = new WindowsAccountBO();
                DeviceBO deviceBO = new DeviceBO();
                string deviceCode = deviceBO.GetDeviceIdentifier();
                string deviceName = deviceBO.GetDeviceName(deviceCode);

                bool result = false;
                string body = string.Empty;
                string infantName = windowsAccountBO.GetInfantAccountLinked(this.infantId);

                if (cmbRequestType.SelectedItem != null)
                {
                    if (cmbRequestType.SelectedItem.Equals("Desbloqueo Web")
                        && cmbObject.SelectedItem != null)
                    {
                        if (!requestBO.VerifyRequest(constants.WebConfiguration, cmbObject.SelectedItem.ToString(), deviceCode))
                        {
                            body = $"<p>¡Hola! <br> <br> Queremos informarte que <b>{infantName}</b> " +
                               $"está solicitando que le habilites la categoría web " +
                               $"<b>{cmbObject.SelectedItem}</b>. <br>" +
                               $"Para aprobar o desaprobar esta petición ingresa a nuestro " +
                               $"sistema y dirígete a la sección de <b>Notificaciones</b>.<p>";

                            if (requestBO.SendEmail(this.parentEmail, body))
                            {
                                result = requestBO.RegisterRequestWA(cmbRequestType.SelectedItem.ToString(),
                                         this.infantId, this.parentId, cmbObject.SelectedItem.ToString(), deviceCode);
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error, ya enviaste una petición de acceso sobre este recurso.");
                            return;
                        }
                    }
                    else if (cmbRequestType.SelectedItem.Equals("Desbloqueo de Aplicaciones")
                            && cmbObject.SelectedItem != null)
                    {
                        if (!requestBO.VerifyRequest(constants.AppConfiguration, cmbObject.SelectedItem.ToString(), deviceCode))
                        {
                            body = $"<p>¡Hola! <br> <br> Queremos informarte que <b>{infantName}</b> " +
                               $"está solicitando que le habilites la aplicación " +
                               $"<b>{cmbObject.SelectedItem}</b> del dispositivo <b>{deviceName}</b>. <br>" +
                               $"Para aprobar o desaprobar esta petición ingresa a nuestro " +
                               $"sistema y dirígete a la sección de <b>Notificaciones</b>.<p>";

                            if (requestBO.SendEmail(this.parentEmail, body))
                            {
                                result = requestBO.RegisterRequestWA(cmbRequestType.SelectedItem.ToString(),
                                         this.infantId, this.parentId, cmbObject.SelectedItem.ToString(), deviceCode);
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error, ya enviaste una petición de acceso sobre este recurso.");
                            return;
                        }
                    }
                    else if (cmbRequestType.SelectedItem.Equals("Ampliar uso del Dispositivo")
                            && (cmbHours.SelectedItem != null || cmbMinutes.SelectedItem != null))
                    {
                        string time = string.Empty;
                        string extraTime = string.Empty;

                        if(cmbHours.SelectedItem != null)
                        {
                            if (cmbMinutes.SelectedItem != null)
                            {
                                if(Convert.ToInt32(cmbHours.SelectedItem) == 1)
                                {
                                    time = $"{cmbHours.SelectedItem} hora y {cmbMinutes.SelectedItem} minutos";
                                }
                                else
                                {
                                    time = $"{cmbHours.SelectedItem} horas y {cmbMinutes.SelectedItem} minutos";
                                }

                                extraTime = $"{cmbHours.SelectedItem}.{cmbMinutes.SelectedItem}";
                            }
                            else
                            {
                                if (Convert.ToInt32(cmbHours.SelectedItem) == 1)
                                {
                                    time = $"{cmbHours.SelectedItem} hora";
                                }
                                else
                                {
                                    time = $"{cmbHours.SelectedItem} horas";
                                }

                                extraTime = $"{cmbHours.SelectedItem}.0";
                            }
                        }
                        else
                        {
                            time = $"{cmbMinutes.SelectedItem} minutos";
                            extraTime = $"0.{cmbMinutes.SelectedItem}";
                        }

                        if (!requestBO.VerifyRequest(constants.DeviceConfiguration, null, deviceCode))
                        {
                            body = $"<p>¡Hola! <br> <br> Queremos informarte que <b>{infantName}</b> " +
                               $"está solicitando que le amplíes el tiempo de uso del dispositivo PC " +
                               $"por: <b>{time}</b>. <br>" +
                               $"Para aprobar o desaprobar esta petición ingresa a nuestro " +
                               $"sistema y dirígete a la sección de <b>Notificaciones</b>.<p>";

                            if (requestBO.SendEmail(this.parentEmail, body))
                            {
                                decimal timeDecimal = Convert.ToDecimal(extraTime);
                                result = requestBO.RegisterRequestDU(cmbRequestType.SelectedItem.ToString(),
                                         this.infantId, this.parentId, timeDecimal, deviceCode);
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error, ya solicitaste una extensión de tiempo de uso del dispositivo para este día.");
                            return;
                        }                            
                    }
                    else
                    {
                        MessageBox.Show("Especifica toda la información requerida.");
                        return;
                    }

                    // Muestro el mensaje correspondiente según el resultado del envío del correo
                    if (result)
                    {
                        MessageBox.Show("Tu petición ha sido enviada correctamente. " +
                                       "Te estaremos notificando la respuesta de tus padres.");

                        this.Hide();
                        FormRequest formRequest = new FormRequest();
                        formRequest.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al enviar la petición. " +
                                        "Inténtalo de nuevo.");
                    }
                }
                else
                {
                    MessageBox.Show("Especifica toda la información requerida.");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
