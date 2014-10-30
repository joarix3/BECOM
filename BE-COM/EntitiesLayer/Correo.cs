using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace EntitiesLayer
{
    public class Correo : IEntity

    {
        public int _idCorreo;

        public int Id
        {
            get { return _idCorreo; }
            set { _idCorreo = value; }
        }
        public String CorreoElectronico { get; set; }
        public String Contra { get; set; }
        public String correoFrom = "becomSoft506@gmail.com";
        public String contraFrom = "becom506";
        
  

        public Correo()
        {
            CorreoElectronico = "";
            Contra = "";
        }
  
        /// <summary>
        ///  Este metodo envia los correos electronicos para la recuperacion de contraseña
        /// </summary>
        /// <param name="pcorreo">String</param>
        /// <param name="pcontra">String</param>
        public void enviarCorreo(String pcorreo, String pcontra)
        {
      
            DateTime fecha = DateTime.Now; 

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress(correoFrom); // correo de donde se envia 

            correo.To.Add(pcorreo); // correo al que se le envia
            correo.Subject = "Recuperación de contraseña"; // El asunto del correo
            correo.Body = "Su contraseña del correo " + pcorreo + " es "  + pcontra + System.Environment.NewLine
                           + "Solicitada la fecha " + fecha; // el mensaje del correo
            correo.IsBodyHtml = false;
            correo.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential(correoFrom, contraFrom); // la conexion para poder enviar el correo

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            try
            {
              smtp.Send(correo); // envia el correo
            }
            catch
            {

            }
            correo.Dispose();
        }
    }

}
