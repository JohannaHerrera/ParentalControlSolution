using ParentalControl.Business.Enums;
using ParentalControl.Data;
using ParentalControl.Models.Device;
using ParentalControl.Models.Login;
using ParentalControl.Models.Request;
using ParentalControl.Models.Schedule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl.Business.BusinessBO
{
    public class RequestBO
    {
        /// <summary>
        /// Método para obtener el tipo de peticiones
        /// </summary>
        /// <returns>List<RequestTypeModel></returns>
        public List<RequestTypeModel> GetRequestTypes()
        {
            string query = $"SELECT * FROM RequestType";

            List<RequestTypeModel> requestTypeModelList = this.ObtenerListaSQL<RequestTypeModel>(query).ToList();

            return requestTypeModelList;
        }

        /// <summary>
        /// Método para obtener las aplicaciones bloqueadas
        /// </summary>
        /// <returns>List<ApplicationModel></returns>
        public List<ApplicationModel> GetBlockedApps(int infantId, int deviceId)
        {
            string query = $"SELECT * FROM App WHERE InfantAccountId = {infantId}" +
                           $" AND DevicePCId = {deviceId}" +
                           $" AND (AppAccessPermission <> 0 OR ScheduleId IS NOT NULL)";

            List<ApplicationModel> applicationModelList = this.ObtenerListaSQL<ApplicationModel>(query).ToList();

            return applicationModelList;
        }

        /// <summary>
        /// Método para obtener las categorías web bloqueadas
        /// </summary>
        /// <returns>List<WebConfigurationModel></returns>
        public List<WebConfigurationModel> GetBlockedWebCategory(int infantId)
        {
            string query = $"SELECT * FROM WebConfiguration WHERE InfantAccountId = {infantId}" +
                           $" AND WebConfigurationAccess <> 0";

            List<WebConfigurationModel> webConfigurationModelList = this.ObtenerListaSQL<WebConfigurationModel>(query).ToList();

            return webConfigurationModelList;
        }

        /// <summary>
        /// Método para obtener la configuración del uso del dispositivo de ese día
        /// </summary>
        /// <returns>List<ScheduleModel></returns>
        public ScheduleModel GetDeviceUse(int infantId, string day)
        {
            ScheduleModel scheduleModel = null;
            string query = $"SELECT * FROM DeviceUse WHERE InfantAccountId = {infantId}" +
                           $" AND DeviceUseDay = '{day}'";
            List<DeviceUseModel> deviceUseModelList = this.ObtenerListaSQL<DeviceUseModel>(query).ToList();

            if (deviceUseModelList.Count > 0 )
            {
                int scheduleId = deviceUseModelList.FirstOrDefault().ScheduleId;

                if (scheduleId != 0)
                {
                    query = $"SELECT * FROM Schedule WHERE ScheduleId = {scheduleId} ";
                    List<ScheduleModel> scheduleModelList = this.ObtenerListaSQL<ScheduleModel>(query).ToList();
                    scheduleModel = scheduleModelList.FirstOrDefault();
                }
            }

            return scheduleModel;
        }

        /// <summary>
        /// Método para obtener el email del Padre
        /// </summary>
        /// <returns>string</returns>
        public string GetParentEmail(int parentId)
        {
            string parentEmail = string.Empty;
            string query = $"SELECT * FROM Parent WHERE ParentId = {parentId}";
            List<ParentModel> parentModelList = this.ObtenerListaSQL<ParentModel>(query).ToList();

            if (parentModelList.Count > 0)
            {
                parentEmail = parentModelList.FirstOrDefault().ParentEmail;
            }
            return parentEmail;
        }

        /// <summary>
        /// Método para registrar la petición en caso de categorías web y aplicaciones
        /// </summary>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterRequestWA(string requestType, int infantId, int parentId, string objecto, string deviceCode)
        {
            Constants constants = new Constants();
            var dateCreation = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool execute = false;
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            int deviceId = this.ObtenerListaSQL<DeviceModel>(query).FirstOrDefault().DevicePCId;
            query = $"SELECT * FROM RequestType WHERE RequestTypeName = '{requestType}'";
            List<RequestTypeModel> requestTypeModelList = this.ObtenerListaSQL<RequestTypeModel>(query).ToList();

            if (requestTypeModelList.Count > 0)
            {
                int idRequestType = requestTypeModelList.FirstOrDefault().RequestTypeId;
                query = $"INSERT INTO Request VALUES ({idRequestType}, {infantId}," +
                        $" '{objecto}', NULL, {constants.RequestStateCreated}," +
                        $" '{dateCreation}', {parentId}, {deviceId}, NULL)";
                execute = SQLConexionDataBase.Execute(query);
            }
            return execute;
        }

        /// <summary>
        /// Método para registrar la petición en caso del uso del dispositivo
        /// </summary>
        /// <returns>bool: TRUE(registro exitoso), FALSE(error al registrar)</returns>
        public bool RegisterRequestDU(string requestType, int infantId, int parentId, decimal time, string deviceCode)
        {
            Constants constants = new Constants();
            var dateCreation = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool execute = false;
            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            int deviceId = this.ObtenerListaSQL<DeviceModel>(query).FirstOrDefault().DevicePCId;
            query = $"SELECT * FROM RequestType WHERE RequestTypeName = '{requestType}'";
            List<RequestTypeModel> requestTypeModelList = this.ObtenerListaSQL<RequestTypeModel>(query).ToList();

            if (requestTypeModelList.Count > 0)
            {
                int idRequestType = requestTypeModelList.FirstOrDefault().RequestTypeId;
                query = $"INSERT INTO Request VALUES ({idRequestType}, {infantId}," +
                        $" NULL, {time}, {constants.RequestStateCreated}," +
                        $" '{dateCreation}', {parentId}, {deviceId}, NULL)";
                execute = SQLConexionDataBase.Execute(query);
            }
            return execute;
        }

        /// <summary>
        /// Método para actualizar el estado de la petición
        /// </summary>
        /// <returns>bool: TRUE(actualización exitosa), FALSE(error al actualizar)</returns>
        public bool UpdateRequest(int requestId, int state)
        {
            string query = $"UPDATE Request SET RequestState = {state} WHERE RequestId = {requestId}";
            bool execute = SQLConexionDataBase.Execute(query);
            
            return execute;
        }

        /// <summary>
        /// Método para aprobar una petición de configuración web
        /// </summary>
        /// <returns>bool: TRUE(actualización exitosa), FALSE(error al actualizar)</returns>
        public bool ApproveWebAccess(string webCategory, int infantId)
        {
            Constants constants = new Constants();
            bool execute = false;
            string query = $"SELECT * FROM WebCategory WHERE CategoryName = '{webCategory}'";
            List<WebCategoryModel> webCategoryModelList = this.ObtenerListaSQL<WebCategoryModel>(query).ToList();

            if(webCategoryModelList.Count > 0)
            {
                int webCategoryId = webCategoryModelList.FirstOrDefault().CategoryId;
                query = $"UPDATE WebConfiguration SET WebConfigurationAccess = {constants.Access}" +
                        $" WHERE CategoryId = {webCategoryId}";
                execute = SQLConexionDataBase.Execute(query);
            }       

            return execute;
        }

        /// <summary>
        /// Método para aprobar una petición de configuración de apps
        /// </summary>
        /// <returns>bool: TRUE(actualización exitosa), FALSE(error al actualizar)</returns>
        public bool ApproveAppAccess(string appName, int infantId)
        {
            Constants constants = new Constants();
            DeviceBO deviceBO = new DeviceBO(); 
            bool execute = false;
            string deviceCode = deviceBO.GetDeviceIdentifier();

            string query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{deviceCode}'";
            List<DeviceModel> deviceModelList = this.ObtenerListaSQL<DeviceModel>(query).ToList();

            if (deviceModelList.Count > 0)
            {
                int deviceId = deviceModelList.FirstOrDefault().DevicePCId;
                query = $"SELECT * FROM App WHERE AppName = '{appName}' AND DevicePCId = {deviceId}";
                List<ApplicationModel> applicationModelList = this.ObtenerListaSQL<ApplicationModel>(query).ToList();

                if (applicationModelList.Count > 0)
                {
                    int appId = applicationModelList.FirstOrDefault().AppId;
                    query = $"UPDATE App SET AppAccessPermission = {constants.Access}" +
                            $" WHERE AppId = {appId}";
                    execute = SQLConexionDataBase.Execute(query);
                }                              
            }

            return execute;
        }

        public bool VerifyRequest(int requestType, string requestObject, string devicePcCode)
        {
            Constants constants = new Constants();
            bool exist = true;
            var dateNow = DateTime.Now.ToString("yyyy-MM-dd");
            string query = string.Empty;
            List<RequestModel> requestModelList = new List<RequestModel>();

            query = $"SELECT * FROM DevicePC WHERE DevicePCCode = '{devicePcCode}'";
            int deviceId = this.ObtenerListaSQL<DeviceModel>(query).FirstOrDefault().DevicePCId;

            if (requestType == constants.WebConfiguration || requestType == constants.AppConfiguration)
            {
                query = $"SELECT * FROM Request WHERE RequestState = 0" +
                        $" AND RequestObject = '{requestObject}'" +
                        $" AND DevicePCId = {deviceId}";
            }
            else if (requestType == constants.DeviceConfiguration)
            {
                query = $"SELECT * FROM Request WHERE RequestState = 0" +
                        $" AND CAST(RequestCreationDate AS date) = '{dateNow}'" +
                        $" AND RequestTime IS NOT NULL" +
                        $" AND DevicePCId = {deviceId}";
            }

            requestModelList = this.ObtenerListaSQL<RequestModel>(query).ToList();

            if (requestModelList.Count > 0)
            {
                exist = true;
            }
            else
            {
                exist = false;
            }

            return exist;
        }

        /// <summary>
        /// Método para enviar el correo de notificación al Padre
        /// </summary>
        /// <returns>bool: TRUE(envío exitoso), FALSE(error al enviar)</returns>
        public bool SendEmail(string parentEmail, string body)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("prueba.controlparental.jkn@gmail.com", "JKN", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(parentEmail); //Correo destino
                correo.Subject = "Notificación Control Parental"; //Asunto
                correo.Body = body; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida
                smtp.Credentials = new System.Net.NetworkCredential("prueba.controlparental.jkn@gmail.com", "JKN123456a");//Cuenta de correo
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true; //True si el servidor de correo permite ssl
                smtp.Send(correo);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }           
        }

        /// <summary>
        /// Método para convertir una lista DataTable a un TModel (Modelo genérico)
        /// </summary>
        /// <param name="deviceModel">contiene la data del dispositivo PC</param>
        /// <returns>IList<TModel></returns>
        private IList<TModel> ObtenerListaSQL<TModel>(string query)
        {
            try
            {
                DataTable dataTableInformacion = SQLConexionDataBase.Query(query);
                var listaResultante = dataTableInformacion.MapDataTableToList<TModel>();

                return listaResultante;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
