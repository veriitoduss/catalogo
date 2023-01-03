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
    public partial class principal : ContentPage
    {
        public principal()
        {
            InitializeComponent();
        }

        private async void btninicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }

        private async void btnmenuadministrador_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new menuadministrador());
        }
    }
}