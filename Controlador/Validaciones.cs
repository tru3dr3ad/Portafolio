using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Controlador
{
    public class Validaciones
    {
        #region Validador Rut
        // http://www.qualityinfosolutions.com/validador-de-rut-chileno-en-c/

        /// <summary>
        /// Devuelve true si es valido; false en caso contrario
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public bool ValidarRun(string rut)
        {

            bool validacion = false;
            try
            {
                //Solo permite formato 11111111-1
                char guion = rut[rut.Length - 2];
                if (guion == '-')
                {
                    rut = rut.ToUpper();
                    rut = rut.Replace(".", "");
                    rut = rut.Replace("-", "");
                    int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                    char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                    int m = 0, s = 1;
                    for (; rutAux != 0; rutAux /= 10)
                    {
                        s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                    }
                    if (dv == (char)(s != 0 ? s + 47 : 75))
                    {
                        validacion = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
        #endregion

        #region Validaciones
        public bool ValidarLargoString(int minimo, int maximo, string parametro)
        {
            if (parametro.Length >= minimo && parametro.Length < maximo)
            {
                return true;
            }
            return false;
        }
        public bool ValidarMayoriaEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Date.Year;
            if (edad >= 18)
            {
                return true;
            }
            return false;
        }
        public bool ValidarNumeroTelefono(string numeroString)
        {
            var regex = "^([0-9]){8,9}$";
            int numero = int.Parse(numeroString);
            var match = Regex.Match(numeroString, regex, RegexOptions.IgnoreCase);
            if (match.Success && numero > 9999999)
            {
                return true;
            }
            return false;
        }
        public bool ValidarEmail(string correoElectronico)
        {
            try
            {
                MailAddress emailCorrecto = new MailAddress(correoElectronico);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool ValidarMayorACero(int mayor, int minimo)
        {
            if (mayor > minimo)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Metodos de Email
        public bool EnviarEmail(string correo, string asunto, string body)
        {
            try
            {
                MailMessage Mail = new MailMessage();
                Mail.From = new MailAddress("AlmacenPortafolio@gmail.com");
                Mail.To.Add(correo);
                Mail.Subject = asunto;
                Mail.IsBodyHtml = true;
                Mail.Body = body;
                SmtpClient smpt = new SmtpClient();
                smpt.Credentials = new NetworkCredential("AlmacenPortafolio@gmail.com", "123chocolatexd");
                smpt.Port = 587;
                smpt.Host = "smtp.gmail.com";
                smpt.EnableSsl = true;
                smpt.Send(Mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EnviarEmailConArchivo(string correo, string asunto, string body, string ruta)
        {
            try
            {
                MailMessage Mail = new MailMessage();
                Mail.From = new MailAddress("AlmacenPortafolio@gmail.com");
                Mail.To.Add(correo);
                Mail.Subject = asunto;
                //message.Attachments.Add(new Attachment("Hydrangeas.jpg"));
                Mail.Attachments.Add(new Attachment(ruta));
                Mail.IsBodyHtml = true;
                Mail.Body = body;
                SmtpClient smpt = new SmtpClient();
                smpt.Credentials = new NetworkCredential("AlmacenPortafolio@gmail.com", "123chocolatexd");
                smpt.Port = 587;
                smpt.Host = "smtp.gmail.com";
                smpt.EnableSsl = true;
                smpt.Send(Mail);

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
