using Newtonsoft.Json;
using proyecto_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto_api.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class agregarproductosPage : ContentPage
    {
        public agregarproductosPage()
        {
            InitializeComponent();
        }
        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            string nombres = (nombre_producto.Text);
            string valor = (valor_producto.Text);
            string foto = (foto_producto.Text);
            string departamento = (id_departamento.Text);

            HttpClient client = new HttpClient();
            productoadmin agregar = new productoadmin();
            agregar.nombre_producto = nombres;
            agregar.valor_producto = valor;
            agregar.foto_producto = foto;
            agregar.id_departamento = departamento;

            String jsonAgregar = JsonConvert.SerializeObject(agregar);
            var content = new StringContent(jsonAgregar, Encoding.UTF8, "application/json");
            string url = "http://localhost:3000/api/proyecto/agregarproductos";
            var json = await client.PostAsync(url, content);
            await Navigation.PushAsync(new menuadministrador());

        }
    }
}