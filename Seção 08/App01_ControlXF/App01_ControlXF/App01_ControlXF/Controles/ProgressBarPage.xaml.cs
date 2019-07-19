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
    public partial class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            InitializeComponent();
        }

        private void BtnModificarBarras_Clicked(object sender, EventArgs e)
        {
            objProgressBar1.ProgressTo(1, 5000,Easing.Linear);
            objProgressBar2.ProgressTo(1, 3000, Easing.CubicIn);
            objProgressBar3.ProgressTo(1, 7000, Easing.SpringIn);

        }

        private void BtnResetarBarras_Clicked(object sender, EventArgs e)
        {
            objProgressBar1.Progress = 0;
            objProgressBar2.Progress = 0;
            objProgressBar3.Progress = 0;
        }
    }
}