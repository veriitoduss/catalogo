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
    public partial class adminproductoshogar : ContentPage
    {
        public adminproductoshogar()
        {
            InitializeComponent();
            Getadminhogar();
            Getadminhogar1();
        }

        private async void Getadminhogar()
        {
            HttpClient client = new HttpClient();
            var productoshogar = await client.GetStringAsync("http://localhost:3000/api/proyecto/hogarprimeros");
            var guardarproductoshorgar = JsonConvert.DeserializeObject<List<productos>>(productoshogar);
            listaradminproductoshogar.ItemsSource = guardarproductoshorgar;

        }
        private async void Getadminhogar1()
        {
            HttpClient client = new HttpClient();
            var productoshogar = await client.GetStringAsync("http://localhost:3000/api/proyecto/hogarultimos");
            var guardarproductoshorgar = JsonConvert.DeserializeObject<List<productos>>(productoshogar);
            listaradminproductoshogar1.ItemsSource = guardarproductoshorgar;

        }
    }
}