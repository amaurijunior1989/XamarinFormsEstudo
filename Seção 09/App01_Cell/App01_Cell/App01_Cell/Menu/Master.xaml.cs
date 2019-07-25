using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Cell.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void BtnTextCell_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.TextCellPage());
            IsPresented = false;
        }

        private void BtnImageCell_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ImageCellPage());
            IsPresented = false;
        }

        private void BtnEntryCell_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.EntryCellPage());
            IsPresented = false;
        }

        private void BtnSwitchCell_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.SwitchCellPage());
            IsPresented = false;
        }

        private void BtnViewCell_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ViewCellPage());
            IsPresented = false;
        }

        private void BtnListView_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ListViewPage());
            IsPresented = false;
        }

        private void BtnListViewButon_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ListViewButtonPage());
            IsPresented = false;
        }
    }
}