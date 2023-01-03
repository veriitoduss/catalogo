using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto_api
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class papeleria : ContentPage
    {
        public papeleria()
        {
            InitializeComponent();
            Getpapeleria();
            Getpapeleria1();
        }
        private async void Getpapeleria()
        {
            HttpClient client = new HttpClient();
            var productosdepapeleria = await client.GetStringAsync("http://localhost:3000/api/proyecto/papeleriaprimeros");
            var guardaproductosdepapeleria = JsonConvert.DeserializeObject<List<productos>>(productosdepapeleria);
            listaproductospapeleria.ItemsSource = guardaproductosdepapeleria;

        }
        private async void Getpapeleria1()
        {
            HttpClient client = new HttpClient();
            var productosdepapeleria1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/papeleriaultimos");
            var guardaproductosdepapeleria1 = JsonConvert.DeserializeObject<List<productos>>(productosdepapeleria1);
            listaproductospapeleria1.ItemsSource = guardaproductosdepapeleria1;

        }
    }
}