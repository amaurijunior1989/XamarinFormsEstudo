﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControlXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void ObjSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            lbResultado.Text = DateTime.Now.ToString("HH:mm")  + " - " + e.Value.ToString();
        }
    }
}