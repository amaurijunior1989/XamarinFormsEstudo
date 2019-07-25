using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App02_ListaBrasil.Modelo;

using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace App02_ListaBrasil.Servico
{
    public class EstadoServico
    {
        private static  string URLEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static  string URLMunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";  

        public static List<Estado> GetEstados()
        {
           
            string conteudo = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URLEstado);
            request.AutomaticDecompression = DecompressionMethods.GZip;


            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                conteudo = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);

        }

        public static List<Municipio> GetMunicipio(int estado)
        {

            string NewURL = string.Format(URLMunicipio, estado);        

            string conteudo = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(NewURL);
            request.AutomaticDecompression = DecompressionMethods.GZip;


            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                conteudo = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);
        }
    }
}
