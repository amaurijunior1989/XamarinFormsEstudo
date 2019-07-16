using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_BuscaCEP.Service;
using App01_BuscaCEP.Service.Model;

namespace App01_BuscaCEP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnBuscarCEP.Clicked += BtnBuscarCEP_Clicked;

        }

        private void BtnBuscarCEP_Clicked(object sender, EventArgs e)
        {
            
            if ((txtCEP.Text == null) || (txtCEP.Text.Length < 8))
            {
                DisplayAlert("Erro", "CEP Inválido!", "CEP não posso ser vazio ou deve conter no minimo 8 caracteres.", "OK");                
                txtCEP.Focus();
            }
               else
            {
                try
                {
                    Endereco endereco = ViaCepService.BuscarEnderecoViaCEP(txtCEP.Text.Trim());
                    

                    if (endereco != null)
                    {
                        txtEndereco.Text = string.Format("Endereço: {0} , {1} , {2}, {3}", endereco.logradouro, endereco.bairro, endereco.localidade, endereco.uf);
                    }
                    else
                    {
                        DisplayAlert("Aviso!", "Endereço não foi encontrado para o cep digitado: " + txtCEP.Text, "OK");
                        txtCEP.Text = "";
                        txtCEP.Focus();
                    }
                }
                catch(Exception ex)
                {
                    DisplayAlert("Erro Crítico", ex.Message, "Ok");
                }
            }

            
        }
    }
}
