using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Controlador
{
    public class Validaciones
    {
        #region validadorrut
        // http://www.qualityinfosolutions.com/validador-de-rut-chileno-en-c/

        /// <summary>
        /// devuelve true si esque es valido; false en caso contrario
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
        public bool ValidarLargoString(int minimo, int maximo,string parametro)
        {
            if (parametro.Length >= minimo && parametro.Length < maximo)
            {
                return true;
            }
            return false;
        }
        public bool ValidarMayoriaEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year -fechaNacimiento.Date.Year;
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
            if (match.Success && numero>9999999)
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
            if (true)
            {

            }
            if (mayor > minimo)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
