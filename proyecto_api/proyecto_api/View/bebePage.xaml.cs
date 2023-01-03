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
    public partial class bebe : ContentPage
    {
        public bebe()
        {
            InitializeComponent();
            Getproductosbebe();
            Getproductosbebe1();
        }
        private async void Getproductosbebe()
        {
            HttpClient client = new HttpClient();
            var productobebe = await client.GetStringAsync("http://localhost:3000/api/proyecto/bebeprimero");
            var guardaproductobebe = JsonConvert.DeserializeObject<List<productos>>(productobebe);
            listaproductosbebe.ItemsSource = guardaproductobebe;

        }
        private async void Getproductosbebe1()
        {
            HttpClient client = new HttpClient();
            var productobebe1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/bebeultimos");
            var guardaproductobebe1 = JsonConvert.DeserializeObject<List<productos>>(productobebe1);
            listaproductosbebe1.ItemsSource = guardaproductobebe1;

        }
    }
}