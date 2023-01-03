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
    public partial class navidad : ContentPage
    {
        public navidad()
        {
            InitializeComponent();
            Getproductosnavidad();
            Getproductosnavidad1();
        }
        private async void Getproductosnavidad()
        {
            HttpClient client = new HttpClient();
            var productosdenavidad = await client.GetStringAsync("http://localhost:3000/api/proyecto/navidadprimeros");
            var guardaproductosdenavidad = JsonConvert.DeserializeObject<List<productos>>(productosdenavidad);
            listaproductosnavidad.ItemsSource = guardaproductosdenavidad;

        }
        private async void Getproductosnavidad1()
        {
            HttpClient client = new HttpClient();
            var productosdenavidad1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/navidadultimos");
            var guardaproductosdenavidad1 = JsonConvert.DeserializeObject<List<productos>>(productosdenavidad1);
            listaproductosnavidad1.ItemsSource = guardaproductosdenavidad1;

        }
    }
}