using App02_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private byte Prioridade { get; set; }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var Stacks = slPrioridades.Children;

            foreach (var Linha in Stacks)
            {
                Label lblPrioridade =((StackLayout)Linha).Children[1] as Label;
                lblPrioridade.TextColor = Color.Gray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            Prioridade = Byte.Parse(Source.File.ToString().Substring(1,1));
        }

        private void BtnSalvar_Clicked(object sender, EventArgs e)
        {
            bool ErroExiste = false;
            if(txtNome.Text ==  null)             
            {
                DisplayAlert("Erro Nome","Nome da Tarefa Deve Ser Digitado!","OK");
                txtNome.Focus();
                ErroExiste = true;
                return;
            }

            if (Prioridade <= 0)
            {
                DisplayAlert("Prioridade", "Prioridade Deve Ser Selecionada!", "OK");
                ErroExiste = true;
                return;
            }

            if (ErroExiste == false)
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = txtNome.Text.Trim().ToUpper();
                tarefa.Prioridade = Prioridade;

                new GerenciadorTarefa().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());
            }
            
        }
    }
}