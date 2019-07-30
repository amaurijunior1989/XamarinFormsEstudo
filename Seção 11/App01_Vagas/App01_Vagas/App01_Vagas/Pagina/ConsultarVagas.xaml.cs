using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_Vagas.Modelo;
using App01_Vagas.Banco;

namespace App01_Vagas.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultarVagas : ContentPage
    {
        List<Vaga> Lista { get; set; }
        public ConsultarVagas()
        {
            InitializeComponent();

            DataBase database = new DataBase();
            Lista = database.Consultar();
            listVagas.ItemsSource = Lista;
            txtQuantidadeEncontrada.Text = Lista.Count.ToString() + " Vagas Encontradas!";

        }

        private void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina.CadastrarVaga());
        }
        private void BtnMinhasVagas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina.MinhaVagasCadastradas());
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Label lblDetalhe = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter as Vaga;


            Navigation.PushAsync(new Pagina.DetalharVaga(vaga));
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataBase database = new DataBase();
            listVagas.ItemsSource = database.Consultar(e.NewTextValue);

        }
    }
}