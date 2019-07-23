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
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            objView.Source = EnderecoSite.Text;
        }

        private void BtnProximo_Clicked(object sender, EventArgs e)
        {
            if (objView.CanGoForward)
            {
                objView.GoForward();
            }

        }

        private void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            if (objView.CanGoBack)
            {
                objView.GoBack();
            }
        }

        private void ObjView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            lbStatus.Text = "Carregando...";
        }

        private void ObjView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            lbStatus.Text = "Concluido";
        }
    }
}