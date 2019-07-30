using App01_Vagas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_Vagas.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalharVaga : ContentPage
    {
        public DetalharVaga(Vaga vaga)
        {
            InitializeComponent();

            BindingContext = vaga;
        }
    }
}