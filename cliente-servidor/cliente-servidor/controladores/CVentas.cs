using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cliente_servidor.modelos;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using System.Windows;

namespace cliente_servidor.controladores
{
    class CVentas
    {
        string uri = "";
        string requestStr = "";
        string param = "";
        public List<Ventas> ventas = new List<Ventas>();
        public List<VentasJava> ventasJava = new List<VentasJava>();
        public List<VentasPhp> ventasPhp = new List<VentasPhp>();
        public List<VentasC> ventasC = new List<VentasC>();

        public CVentas(string uri)
        {
            this.uri = uri;
        }


        public List<Ventas> request()
        {
            try
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
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema.  Revise su conexión.");
                return null;
            }
        }

        public List<VentasJava> requestJava() {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", "application/json");
                param = webClient.DownloadString(uri);
                //System.Windows.MessageBox.Show(param);
                Byte[] byteArray = Encoding.ASCII.GetBytes(param);
                //System.Windows.MessageBox.Show(byteArray.ToString());
                //Byte[] responseArray = webClient.UploadData(uri, "GET", byteArray);
                string response = Encoding.ASCII.GetString(byteArray);
                ventasJava = JsonConvert.DeserializeObject<List<VentasJava>>(response);
                return ventasJava;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema.  Revise su conexión.");
                return null;
            }
        }

        public List<VentasPhp> requestPhp()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", "application/json");
                param = webClient.DownloadString(uri);
                //System.Windows.MessageBox.Show(param);
                Byte[] byteArray = Encoding.ASCII.GetBytes(param);
                //System.Windows.MessageBox.Show(byteArray.ToString());
                //Byte[] responseArray = webClient.UploadData(uri, "GET", byteArray);
                string response = Encoding.ASCII.GetString(byteArray);
                ventasPhp = JsonConvert.DeserializeObject<List<VentasPhp>>(response);
                return ventasPhp;
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema.  Revise su conexión.");
                return null;
            }
        }

        public List<VentasC> requestC()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", "application/json");
                param = webClient.DownloadString(uri);
                //System.Windows.MessageBox.Show(param);
                Byte[] byteArray = Encoding.ASCII.GetBytes(param);
                //System.Windows.MessageBox.Show(byteArray.ToString());
                //Byte[] responseArray = webClient.UploadData(uri, "GET", byteArray);
                string response = Encoding.ASCII.GetString(byteArray);
                ventasC = JsonConvert.DeserializeObject<List<VentasC>>(response);
                return ventasC;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema.  Revise su conexión.");
                return null;
            }
        }
    }
}
