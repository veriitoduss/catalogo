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
    public partial class adminproductosnavidad : ContentPage
    {
        public adminproductosnavidad()
        {
            InitializeComponent();
            Getadminproductosnavidad();
            Getadminproductosnavidad1();
        }
        private async void Getadminproductosnavidad()
        {
            HttpClient client = new HttpClient();
            var admindeproductosdenavidad = await client.GetStringAsync("http://localhost:3000/api/proyecto/navidadprimeros");
            var guardadmindeproductosdenavidad = JsonConvert.DeserializeObject<List<productos>>(admindeproductosdenavidad);
            listaradminproductosnavidad.ItemsSource = guardadmindeproductosdenavidad;

        }
        private async void Getadminproductosnavidad1()
        {
            HttpClient client = new HttpClient();
            var admindeproductobebe1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/navidadultimos");
            var guardadmindeproductobebe1 = JsonConvert.DeserializeObject<List<productos>>(admindeproductobebe1);
            listaradminproductosnavidad1.ItemsSource = guardadmindeproductobebe1;

        }
    }
}