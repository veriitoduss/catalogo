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
    public partial class hogar : ContentPage
    {
        public hogar()
        {
            InitializeComponent();
            Getproductoshogar();
            Getproductoshogar1();
        }

        private async void Getproductoshogar()
        {
            HttpClient client = new HttpClient();
            var productohogar = await client.GetStringAsync("http://localhost:3000/api/proyecto/hogarprimeros");
            var guardaproductoshogar = JsonConvert.DeserializeObject<List<productos>>(productohogar);
            productoshogar.ItemsSource = guardaproductoshogar;

        }
        private async void Getproductoshogar1()
        {
            HttpClient client = new HttpClient();
            var productohogar1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/hogarultimos");
            var guardaproductoshogar1 = JsonConvert.DeserializeObject<List<productos>>(productohogar1);
            productoshogar1.ItemsSource = guardaproductoshogar1;

        }
    }
}