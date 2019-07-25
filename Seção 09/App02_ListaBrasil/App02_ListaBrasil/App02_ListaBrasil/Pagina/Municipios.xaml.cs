using App02_ListaBrasil.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

namespace App02_ListaBrasil.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Municipios : ContentPage
    {

        private List<Municipio> ListarInternaMunicipio { get; set; }
        private List<Municipio> ListarFiltradaMunicipio { get; set; }
        public Municipios(Estado estado)
        {
            InitializeComponent();

            ListarInternaMunicipio =  Servico.EstadoServico.GetMunicipio(estado.id);
            ListaMunicipio.ItemsSource = ListarInternaMunicipio.OrderBy(o=>o.nome).ToList() ;
        }

        private void TxtPesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListarFiltradaMunicipio = ListarInternaMunicipio.Where(o => o.nome.ToUpper().Contains(e.NewTextValue.ToUpper())).OrderBy(o=>o.nome).ToList();
            ListaMunicipio.ItemsSource = ListarFiltradaMunicipio;
        }
    }
}