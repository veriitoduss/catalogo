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
    public partial class cosmetico : ContentPage
    {
        public cosmetico()
        {
            InitializeComponent();
            Getadmincosmeticos();
            Getadmincosmeticos1();
        }
        private async void Getadmincosmeticos()
        {
            HttpClient client = new HttpClient();
            var cosmeticos = await client.GetStringAsync("http://localhost:3000/api/proyecto/cosmeticosprimeros");
            var guardacosmeticos = JsonConvert.DeserializeObject<List<productos>>(cosmeticos);
            listarcosmeticos.ItemsSource = guardacosmeticos;

        }
        private async void Getadmincosmeticos1()
        {
            HttpClient client = new HttpClient();
            var cosmeticos1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/cosmeticosultimos");
            var guardacosmeticos1 = JsonConvert.DeserializeObject<List<productos>>(cosmeticos1);
            listarcosmeticos1.ItemsSource = guardacosmeticos1;

        }
    }
}
