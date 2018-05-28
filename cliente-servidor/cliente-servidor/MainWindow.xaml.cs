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
                    //uri = "http://localhost:3000/sales/discount";
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
            
            string valor = comboBox.SelectionBoxItem.ToString();
            if (valor == "NodeJs" || valor == "Python" || valor == "GO")
            {
                string url = asignarUrl(valor);
                CVentas inventory = new CVentas(url);
                List<Ventas> lista = inventory.request();
                datos.ItemsSource = lista;
            }
            else if (valor == "Java")
            {
                string url = asignarUrl(valor);
                CVentas inventory = new CVentas(url);
                List<VentasJava> lista = inventory.requestJava();
                datos.ItemsSource = lista;
            }else if(valor == "PHP")
            {
                string url = asignarUrl(valor);
                CVentas inventory = new CVentas(url);
                List<VentasPhp> lista = inventory.requestPhp();
                datos.ItemsSource = lista;
            }else if(valor == "C#")
            {
                string url = asignarUrl(valor);
                CVentas inventory = new CVentas(url);
                List<VentasC> lista = inventory.requestC();
                datos.ItemsSource = lista;
            }
        }



        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(asignarUrl(comboBox.SelectionBoxItem.ToString()));
            crearRequest();
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, RoutedEventArgs e)
        {
            datos.ItemsSource = null;
        }
    }
}
