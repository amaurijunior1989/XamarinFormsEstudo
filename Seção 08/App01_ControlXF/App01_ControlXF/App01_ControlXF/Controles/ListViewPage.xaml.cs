using App01_ControlXF.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App01_ControlXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(new Pessoa { Nome = "Jose", Idade = "20" });
            lista.Add(new Pessoa { Nome = "Amauri", Idade = "22" });
            lista.Add(new Pessoa { Nome = "Teste1", Idade = "24" });
            lista.Add(new Pessoa { Nome = "Teste2", Idade = "30" });
            lista.Add(new Pessoa { Nome = "Teste3", Idade = "34" });
            lista.Add(new Pessoa { Nome = "Teste4", Idade = "35" });

            objListView.ItemsSource = lista;
            
        }
    }
}