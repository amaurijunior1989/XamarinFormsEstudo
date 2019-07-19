using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControlXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void BtnActivyIndicator_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.ActivityIndicatorPage();
            IsPresented = false;
        }

        private void BtnProgressBar_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarPage();
            IsPresented = false;
        }

        private void BtnBoxView_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.BoxViewPage();
            IsPresented = false;
        }

        private void BtnLabel_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.LabelPage();
            IsPresented = false;
        }

        private void BtnButton_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.ButtonPage();
            IsPresented = false;
        }

        private void BtnEntryEditor_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.EntryEditorPage();
            IsPresented = false;
        }

        private void BtnDatePicker_Clicked(object sender, EventArgs e)
        {
            Detail = new Controles.DatePickerPage();
            IsPresented = false;
        }
    }
}