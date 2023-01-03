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
    public partial class adminropa : ContentPage
    {
        public adminropa()
        {
            InitializeComponent();
            Getadminropa();
            Getadminropa1();
        }
        private async void Getadminropa()
        {
            HttpClient client = new HttpClient();
            var administradoropa = await client.GetStringAsync("http://localhost:3000/api/proyecto/ropaprimeros");
            var guardaadministradoropa = JsonConvert.DeserializeObject<List<productos>>(administradoropa);
            listaradminropa.ItemsSource = guardaadministradoropa;

        }
        private async void Getadminropa1()
        {
            HttpClient client = new HttpClient();
            var administradoropa1 = await client.GetStringAsync("http://localhost:3000/api/proyecto/ropaultimos");
            var guardaadministradoropa1 = JsonConvert.DeserializeObject<List<productos>>(administradoropa1);
            listaradminropa1.ItemsSource = guardaadministradoropa1;

        }
    }
}