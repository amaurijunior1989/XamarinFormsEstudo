using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
            
        }

        private void BtnPagina1_Clicked(object sender, EventArgs e)
        {
            Detail = new Navigation.Pagina1();
            IsPresented = false;
        }

        private void BtnPagin2_Clicked(object sender, EventArgs e)
        {
            Detail = new Navigation.Pagina2();
            IsPresented = false;
        }

        private void BtnConteudo_Clicked(object sender, EventArgs e)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}