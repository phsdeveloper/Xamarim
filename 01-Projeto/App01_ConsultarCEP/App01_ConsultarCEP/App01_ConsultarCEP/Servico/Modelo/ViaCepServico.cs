using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace App01_ConsultarCEP.Servico.Modelo
{
    public class ViaCepServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";
        public static Endereco BuscarEnderecoViaCEP(string pCEP)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, pCEP);
            System.Net.WebClient wc = new System.Net.WebClient();
            string st_conteudo =  wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(st_conteudo);

            return end;
        }
    }
}
