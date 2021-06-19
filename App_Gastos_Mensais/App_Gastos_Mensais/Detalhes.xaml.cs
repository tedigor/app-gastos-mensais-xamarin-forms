using App_Gastos_Mensais.Database;
using App_Gastos_Mensais.Models;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Gastos_Mensais
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
       private Compra compra;
        public Detalhes(Compra compra)
        {
            InitializeComponent();
            Title = "Descrição da Compra";
            this.compra = compra;
            descricaoLabel.Text = compra.Descricao;
            precoLabel.Text = compra.Preco.ToString();
        }

        private async void Button_Clicked_Voltar(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void Button_Clicked_Remover(object sender, System.EventArgs e)
        {
            ComprasDb.compras.Remove(this.compra);
            await Navigation.PopAsync();
        }
    }
}