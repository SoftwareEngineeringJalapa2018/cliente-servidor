using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using cliente_servidor.controladores;
using cliente_servidor.modelos;

namespace cliente_servidor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public string asignarUrl(string backend)
        {
            string uri;
            switch (backend)
            {
                case "PHP":
                    uri = "http://192.168.1.113:5000/inventory/stock";
                    return uri;
                case "C#":
                    uri = "http://192.168.1.110:5000/inventory/stock";
                    return uri;
                case "Java":
                    uri = "http://192.168.1.111:5000/inventory/stock";
                    return uri;
                case "Go":
                    uri = "http://192.168.1.112:5000/inventory/stock";
                    return uri;
                case "NodeJs":
                    uri = "http://192.168.1.115:5000/inventory/stock";
                    return uri;
                case "Python":
                    uri = "http://192.168.1.114:5000/inventory/stock";
                    return uri;
                default:
                    return null;
            }
        }

        public void crearRequest()
        {
            
            CVentas inventory = new CVentas();
            List<Ventas> lista = inventory.request();
            
        }

    }
}
