using System;
using System.Collections.Generic;
using System.Text;
using App01_BuscaCEP.Service.Model;
using Newtonsoft.Json;
using System.Net;

namespace App01_BuscaCEP.Service
{
    public class ViaCepService
    {
        private static string enderecoViaCEP = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string novoEnderecoViaCEP = string.Format(enderecoViaCEP, cep);

            WebClient WC = new WebClient();
            string Conteudo = WC.DownloadString(novoEnderecoViaCEP);
                                 
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;

            return end;


        }


    }
}
