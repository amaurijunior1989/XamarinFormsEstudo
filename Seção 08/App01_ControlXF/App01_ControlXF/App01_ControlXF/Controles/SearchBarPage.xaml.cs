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
    public partial class SearchBarPage : ContentPage
    {

        private List<String> empresasTI;
        public SearchBarPage()
        {
            InitializeComponent();

            empresasTI = new List<String>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Appler");
            empresasTI.Add("Oracle");
            empresasTI.Add("IBM");
            empresasTI.Add("SAP");
            empresasTI.Add("Uber");
            empresasTI.Add("99Taxi");

            Preencher(empresasTI);            
        }
        
        private void Preencher(List<String> empresasTI)
        {
            ListResult.Children.Clear();

            foreach (var emp in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }
        

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var resultado = empresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();
            Preencher(resultado);
        }
    }
}