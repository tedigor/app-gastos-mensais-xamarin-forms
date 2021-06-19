using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App_Gastos_Mensais.Database;
using App_Gastos_Mensais.Models;

namespace App_Gastos_Mensais
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ComprasDb.compras.Add(new Compra(25.0, "Cachaça Rainha"));
            ComprasDb.compras.Add(new Compra(5.0, "1Kg de seriguela"));
            ComprasDb.compras.Add(new Compra(30.0, "DVD Bartô Galeno"));
            Compras.ItemsSource = ComprasDb.compras;
        }

        private async void Compras_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Compra selecionar = (Compra)e.SelectedItem;
            Detalhes detalhes = new Detalhes(selecionar);
            await Navigation.PushAsync(detalhes);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(descricaoCompra.Text) || string.IsNullOrEmpty(precoCompra.Text))
            {
                DisplayAlert("Erro", "Campo(s) obrigatório(s) não preenchido(s)!", "Ok");
            }
            else 
            {
                double preco;
                
                if (double.TryParse(precoCompra.Text, out preco))
                {
                    ComprasDb.compras.Add(new Compra(preco, descricaoCompra.Text));
                    descricaoCompra.Text = "";
                    precoCompra.Text = "";

                }
            }
       
        }
    }
}
