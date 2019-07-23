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
    public partial class SliderStepPage : ContentPage
    {
        public SliderStepPage()
        {
            InitializeComponent();
        }

        private void ObjSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbSlider.Text = e.NewValue.ToString();
        }

        private void ObjStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbStepper.Text = e.NewValue.ToString();
        }
    }
}