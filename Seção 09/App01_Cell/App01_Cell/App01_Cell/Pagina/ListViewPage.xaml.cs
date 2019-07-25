using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_Cell.Modelo;

namespace App01_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Amauri", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Junior", Cargo = "Gerente De Vendas" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente Contabil" });
            Lista.Add(new Funcionario() { Nome = "Fabio", Cargo = "Entregado" });
            Lista.Add(new Funcionario() { Nome = "Marilia", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ListaFuncionario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario func = (Funcionario)e.SelectedItem;

            Navigation.PushModalAsync(new Detalhe.DetailPage(func));
        }

       private void MenuFerias_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuAbono_Clicked(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;
            DisplayAlert("Titulo: " + func.Nome, "Mensagem: " + func.Nome + "-" + func.Cargo + " entrou de férias!","OK");

        }

        private void MenuDemitir_Clicked(object sender, EventArgs e)
        {

        }
    }
}