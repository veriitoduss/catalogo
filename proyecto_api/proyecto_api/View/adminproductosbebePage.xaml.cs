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
    public partial class adminproductosbebe : ContentPage
    {
        public adminproductosbebe()
        {
            InitializeComponent();
            Getadminproductosbebe();
            Getadminproductosbebe1();
        }
        private async void Getadminproductosbebe()
        {
            HttpClient client = new HttpClient();
            var admindeproductobebe = await client.GetStringAsync("http://localhost:3000/api/proyecto/bebeprimero");
            var guardadmindeproductobebe = JsonConvert.DeserializeObject<List<productos>>(admindeproductobebe);
            listaradminproductosbebe.ItemsSource = guardadmindeproductobebe;

        }
        private async void Getadminproductosbebe1()
        {
            HttpClient client = new HttpClient();
            var admindeproductobebe1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/bebeultimos");
            var guardadmindeproductobebe1 = JsonConvert.DeserializeObject<List<productos>>(admindeproductobebe1);
            listaradminproductosbebe1.ItemsSource = guardadmindeproductobebe1;

        }
    }
}