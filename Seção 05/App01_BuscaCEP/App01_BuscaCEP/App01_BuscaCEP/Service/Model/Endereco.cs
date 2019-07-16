using System;
using System.Collections.Generic;
using System.Text;

namespace App01_BuscaCEP.Service.Model
{
    public class Endereco
    {

        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string erro { get; set; }

        //Modelo JSON
        //        {
        //  "cep": "01001-000",
        //  "logradouro": "Praça da Sé",
        //  "complemento": "lado ímpar",
        //  "bairro": "Sé",
        //  "localidade": "São Paulo",
        //  "uf": "SP",
        //  "unidade": "",
        //  "ibge": "3550308",
        //  "gia": "1004"
        //}
    }
}
