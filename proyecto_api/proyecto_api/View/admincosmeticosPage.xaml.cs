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
    public partial class admincosmeticos : ContentPage
    {
        public admincosmeticos()
        {
            InitializeComponent();
            Getadmincosmeticos();
            Getadmincosmeticos1();
        }
        private async void Getadmincosmeticos()
        {
            HttpClient client = new HttpClient();
            var administradordecosmeticos = await client.GetStringAsync("http://localhost:3000/api/proyecto/cosmeticosprimeros");
            var guardaadministradordecosmeticos = JsonConvert.DeserializeObject<List<productos>>(administradordecosmeticos);
            listaradmindcosmeticos.ItemsSource = guardaadministradordecosmeticos;

        }
        private async void Getadmincosmeticos1()
        {
            HttpClient client = new HttpClient();
            var administradordecosmeticos1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/cosmeticosultimos");
            var guardaadministradordecosmeticos1 = JsonConvert.DeserializeObject<List<productos>>(administradordecosmeticos1);
            listaradmindcosmeticos1.ItemsSource = guardaadministradordecosmeticos1;

        }
    }
}