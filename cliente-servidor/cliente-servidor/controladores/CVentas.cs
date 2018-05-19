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

        public CVentas()
        {
        }

        public List<Ventas> request()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/json");
            Byte[] byteArray = Encoding.ASCII.GetBytes(param);
            Byte[] responseArray = webClient.UploadData(this.uri, "GET", byteArray);
            string response = Encoding.ASCII.GetString(responseArray);
            ventas = JsonConvert.DeserializeObject<List<Ventas>>(response);
            return ventas;
        }
    }
}
