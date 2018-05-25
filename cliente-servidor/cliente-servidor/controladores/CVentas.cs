using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cliente_servidor.modelos;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace cliente_servidor.controladores
{
    class CVentas
    {
        string uri = "";
        string requestStr = "";
        string param = "";
        public List<Ventas> ventas = new List<Ventas>();

        public CVentas(string uri)
        {
            this.uri = uri;
        }


        public List<Ventas> request()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/json");
            param = webClient.DownloadString(uri);
            //System.Windows.MessageBox.Show(param);
            Byte[] byteArray = Encoding.ASCII.GetBytes(param);
            //System.Windows.MessageBox.Show(byteArray.ToString());
            //Byte[] responseArray = webClient.UploadData(uri, "GET", byteArray);
            string response = Encoding.ASCII.GetString(byteArray);
            ventas = JsonConvert.DeserializeObject<List<Ventas>>(response);
            return ventas;
           
        }
    }
}
