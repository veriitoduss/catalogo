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
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
        }

        private async void Btnofertas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new promociones());
        }

        private async void btnhogar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hogar());
        }
        private async void btnbebe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new bebe());
        }
        private async void btnpapeleria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new papeleria());
        }
        private async void btnropa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ropa());
        }
        private async void btncosmetico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cosmetico());
        }
        private async void btnnavidad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new navidad());
        }
    }
}