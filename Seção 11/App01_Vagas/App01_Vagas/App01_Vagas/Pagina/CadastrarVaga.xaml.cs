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
    public partial class CadastrarVaga : ContentPage
    {
        public CadastrarVaga()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Clicked(object sender, EventArgs e)
        {

            //TODO - Validar Dados Cadastro
            Vaga vaga = new Vaga();
            vaga.NomeVaga = txtNomeVaga.Text;
            vaga.Empresa = txtEmpresa.Text;
            vaga.QuantidadeVaga = short.Parse(txtQuantidade.Text);
            vaga.Cidade = txtCidade.Text;
            vaga.Salario = float.Parse(txtSalario.Text);
            vaga.Descricao = txtDescricaoCargo.Text;
            vaga.TipoContratacao = (swtTipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = txtTelefone.Text;
            vaga.Email = txtEmail.Text;

            
            Banco.DataBase database = new Banco.DataBase();
            database.Cadastro(vaga);

            //TODO - Tela Pesquisa
            App.Current.MainPage = new NavigationPage(new Pagina.ConsultarVagas());
        }
    }
}