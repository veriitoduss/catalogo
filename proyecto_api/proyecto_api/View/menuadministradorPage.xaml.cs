using proyecto_api.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto_api
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menuadministrador : ContentPage
    {
        public menuadministrador()
        {
            InitializeComponent();
        }
        private async void btnadminhogar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new adminproductoshogar());
        }
        private async void btnadminproductosbebe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new adminproductosbebe());
        }
        private async void btnadminproductospapeleria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new adminproductospapeleria());
        }
        private async void btnadminbtnadminropa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new adminropa());
        }
        private async void btnadmincosmeticos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new admincosmeticos());
        }
        private async void btnadminproductosnavidad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new adminproductosnavidad());
        }
        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new agregarproductosPage());
        }
    }
}