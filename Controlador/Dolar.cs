using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Controlador
{
    public class Dolar
    {
        public string version { get; set; }
        public string autor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public List<Serie> serie { get; set; }
        public Dolar()
        {

        }
        public string StringDolar()
        {
            Dolar dolar = new Dolar();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mindicador.cl/api/dolar");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);

            var json = streamReader.ReadToEnd();
            dolar = JsonConvert.DeserializeObject<Dolar>(json);
            string dolarValor = "";
            foreach (Serie item in dolar.serie)
            {
                dolarValor = item.valor;
            }
            return dolarValor;
        }
        public decimal ObtenerValorDolar()
        {
            Dolar dolar = new Dolar();
            string stringDolar = dolar.StringDolar();
            decimal valorDolar = decimal.Parse(stringDolar);
            return valorDolar;
        }
    }
    public class Serie
    {
        public string fecha { get; set; }
        public string valor { get; set; }
        public Serie()
        {

        }
    }
}
