using App02_ListaBrasil.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_ListaBrasil.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Estados : ContentPage
    {
        public Estados()
        {
            InitializeComponent();


            ListaEstado.ItemsSource = Servico.EstadoServico.GetEstados().OrderBy(o => o.nome).ToList();
        }

        private void ListaEstado_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Estado UF = (Estado)e.SelectedItem;

            Navigation.PushAsync(new Pagina.Municipios(UF));

        }
    }
}