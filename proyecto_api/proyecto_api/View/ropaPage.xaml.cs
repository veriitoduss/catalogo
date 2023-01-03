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
    public partial class ropa : ContentPage
    {
        public ropa()
        {
            InitializeComponent();
            Getropa();
            Getropa1();
        }

        private async void Getropa()
        {
            HttpClient client = new HttpClient();
            var ropa = await client.GetStringAsync("http://localhost:3000/api/proyecto/ropaprimeros");
            var guardaropa = JsonConvert.DeserializeObject<List<productos>>(ropa);
            listarropa.ItemsSource = guardaropa;
        }
        private async void Getropa1()
        {
            HttpClient client = new HttpClient();
            var ropa1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/ropaultimos");
            var guardaropa1 = JsonConvert.DeserializeObject<List<productos>>(ropa1);
            listarropa1.ItemsSource = guardaropa1;
        }
    }
}