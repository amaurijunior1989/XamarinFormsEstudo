using App01_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Amauri", Cargo = "Presidente",
                Foto = "http://www.blog.natsolutions.com.br/wp-content/uploads/2013/01/user.jpg"
            });
            Lista.Add(new Funcionario() { Nome = "Junior", Cargo = "Gerente De Vendas",
                Foto = "" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente Contabil",
                Foto = "" });
            Lista.Add(new Funcionario() { Nome = "Fabio", Cargo = "Entregado",
                Foto = "" });           

            ListaFuncionario.ItemsSource = Lista;
        }
    }
}