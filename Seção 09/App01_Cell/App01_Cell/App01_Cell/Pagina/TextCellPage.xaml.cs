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
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
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
    }
}