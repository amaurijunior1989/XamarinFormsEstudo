using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Estilo.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void BtnStyle_Clicked(object sender, EventArgs e)
        {
            //Detail =
        }

        private void BtnImplicitStylePage_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ImplicitStylePage());
            IsPresented = false;
        }

        private void BtnExplicitStylePage_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ExplicitStylePage());
            IsPresented = false;
        }

        private void BtnGlobalStylePage_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.GlobalStylePage());
            IsPresented = false;
        }
    }
}