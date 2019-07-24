using App02_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            CultureInfo culture = new CultureInfo("pt-BR");



            lbDataHoje.Text = DateTime.Now.ToString("dddd",culture) + "," + DateTime.Now.ToString("dd/MM/yyyy",culture);

            CarregarTarefas();
        }

        private void BtnCadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }

        private void CarregarTarefas()
        {
            slTarefas.Children.Clear();

            List<Tarefa> Lista = new GerenciadorTarefa().Listagem();

            int i = 0;

            foreach(Tarefa tarefa in Lista)
            {
                LinhaStackLayout(tarefa,i);
                i++;
            }
        }

        public void LinhaStackLayout(Tarefa tarefa,int index)
        {
            Image imgCheck = new Image() { VerticalOptions = LayoutOptions.Center, Source= ImageSource.FromFile("CheckOff.png") };
            TapGestureRecognizer CheckTap = new TapGestureRecognizer();
            CheckTap.Tapped += delegate
            {
                new GerenciadorTarefa().Finalizar(index, tarefa);
                CarregarTarefas();
            };
            imgCheck.GestureRecognizers.Add(CheckTap);


            View StackCentral = null;
            if (tarefa.DataFinalizacao == null)
            {
                StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.CenterAndExpand, Text = tarefa.Nome };
            }
            else
            {
                StackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.CenterAndExpand, Spacing=0};
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray });
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = "Finalizo em " +tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy - hh:mm")+ "h", TextColor = Color.Gray,FontSize=10 });
                imgCheck.Source = "CheckOn.png";

            }

            Image imgPrior = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("p" + tarefa.Prioridade + ".png") };

            Image imgDel = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("Delete.png") };
            TapGestureRecognizer DeleteTap = new TapGestureRecognizer();
            DeleteTap.Tapped += delegate
            {
                new GerenciadorTarefa().Deletar(index);
                CarregarTarefas();
            };
            imgDel.GestureRecognizers.Add(DeleteTap);


            StackLayout Linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };

            Linha.Children.Add(imgCheck);
            Linha.Children.Add(StackCentral);
            Linha.Children.Add(imgPrior);
            Linha.Children.Add(imgDel);

            slTarefas.Children.Add(Linha);
        }


    }
}