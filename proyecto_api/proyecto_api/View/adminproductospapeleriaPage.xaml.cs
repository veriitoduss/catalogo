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
    public partial class adminproductospapeleria : ContentPage
    {
        public adminproductospapeleria()
        {
            InitializeComponent();
            Getadminpapeleria();
            Getadminpapeleria1();
        }
        private async void Getadminpapeleria()
        {
            HttpClient client = new HttpClient();
            var admindeproductosdepapeleria = await client.GetStringAsync("http://localhost:3000/api/proyecto/papeleriaprimeros");
            var guardaadmindeproductosdepapeleria = JsonConvert.DeserializeObject<List<productos>>(admindeproductosdepapeleria);
            listaadminproductospapeleria.ItemsSource = guardaadmindeproductosdepapeleria;

        }
        private async void Getadminpapeleria1()
        {
            HttpClient client = new HttpClient();
            var admindeproductosdepapeleria1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/papeleriaultimos");
            var guardaadmindeproductosdepapeleria1 = JsonConvert.DeserializeObject<List<productos>>(admindeproductosdepapeleria1);
            listaadminproductospapeleria1.ItemsSource = guardaadmindeproductosdepapeleria1;

        }
    }
}