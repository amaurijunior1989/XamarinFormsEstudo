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
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();
        }

        private void TxtIdade_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbDuplicado.Text = e.NewTextValue;
        }

        private void TxtComentario_Completed(object sender, EventArgs e)
        {
            lbQuantidadeCaracteres.Text = txtComentario.Text.Length.ToString();
        }
    }
}