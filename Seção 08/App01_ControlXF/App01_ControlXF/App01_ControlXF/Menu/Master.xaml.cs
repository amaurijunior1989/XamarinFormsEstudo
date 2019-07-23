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
                        Detail = new NavigationPage(new   Controles.ActivityIndicatorPage());
            IsPresented = false;
        }

        private void BtnProgressBar_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.ProgressBarPage());
            IsPresented = false;
        }

        private void BtnBoxView_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.BoxViewPage());
            IsPresented = false;
        }

        private void BtnLabel_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.LabelPage());
            IsPresented = false;
        }

        private void BtnButton_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.ButtonPage());
            IsPresented = false;
        }

        private void BtnEntryEditor_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.EntryEditorPage());
            IsPresented = false;
        }

        private void BtnDatePicker_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.DatePickerPage());
            IsPresented = false;
        }

        private void BtnTimePicker_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.TimerPickerPage());
            IsPresented = false;
        }

        private void BtnPicker_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.PickerPage());
            IsPresented = false;
        }

        private void BtnSearchBar_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.SearchBarPage());
            IsPresented = false;
        }

        private void BtnSliderStep_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.SliderStepPage());
            IsPresented = false;
        }

        private void BtnSwitch_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.SwitchPage());
            IsPresented = false;
        }

        private void BtnImage_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.ImagePage());
            IsPresented = false;
        }

        private void BtnListView_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.ListViewPage());
            IsPresented = false;
        }

        private void BtnTableView_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.TableViewPage());
            IsPresented = false;
        }

        private void BtnWebView_Clicked(object sender, EventArgs e)
        {
                        Detail = new NavigationPage(new  Controles.WebViewPage());
            IsPresented = false;
        }
    }
}