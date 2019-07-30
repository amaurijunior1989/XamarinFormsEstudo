using App01_Vagas.Banco;
using App01_Vagas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Vagas.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhaVagasCadastradas : ContentPage
    {
        List<Vaga> Lista { get; set; }
        public MinhaVagasCadastradas()
        {
            InitializeComponent();
            Atualizar();
        }

        private void Atualizar()
        {
            DataBase database = new DataBase();
            Lista = database.Consultar();
            ListVagas.ItemsSource = Lista;
            txtQuantidadeEncontrada.Text = Lista.Count.ToString() + " Vagas Encontradas!";
        }


        //EDITAR
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Label lblEditar = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblEditar.GestureRecognizers[0]).CommandParameter as Vaga;


            Navigation.PushAsync(new Pagina.EditarVaga(vaga));
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Label lblExcluir = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblExcluir.GestureRecognizers[0]).CommandParameter as Vaga;

            DataBase database = new DataBase();
            database.Exclusao(vaga);
            Atualizar();

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataBase database = new DataBase();
            ListVagas.ItemsSource = database.Consultar(e.NewTextValue);
        }
    }
}