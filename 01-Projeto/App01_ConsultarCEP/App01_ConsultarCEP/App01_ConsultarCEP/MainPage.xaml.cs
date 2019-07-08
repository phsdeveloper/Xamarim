using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btn_BucarCep.Clicked += Btn_BucarCep_Clicked;
        }

        private void Btn_BucarCep_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_CEP.Text))
            {
                DisplayAlert("Aviso Sistema", "Por favor informe um CEP para verificação", "Entendi");
            }
            else
            {
                string st_CepNumeros = new string(txt_CEP.Text.Where(x => char.IsNumber(x)).ToArray());

                if (string.IsNullOrWhiteSpace(st_CepNumeros))
                {
                    DisplayAlert("Aviso Sistema", "Por favor informe um CEP para verificação", "Entendi");
                }
                else if (st_CepNumeros.Length != 8)
                {
                    DisplayAlert("Aviso Sistema", "O cep deve conter apenas 8 numeros.", "Entendi");
                }
                else
                {
                    try
                    {
                        var endereco = Servico.Modelo.ViaCepServico.BuscarEnderecoViaCEP(st_CepNumeros);

                        if (endereco.erro)
                        {
                            DisplayAlert("ERRO", "O cep informado não foi encontrado", "Entendi");
                        }
                        else
                        {
                            lbl_Endereco.Text = $"Endereço: {endereco.logradouro}";
                            lbl_Endereco.Text += Environment.NewLine;
                            lbl_Endereco.Text += $"Bairro: {endereco.bairro}";
                            lbl_Endereco.Text += Environment.NewLine;
                            lbl_Endereco.Text += $"Cidade: {endereco.localidade}";
                            lbl_Endereco.Text += Environment.NewLine;
                            lbl_Endereco.Text += $"Estado: {endereco.uf}";
                            lbl_Endereco.Text += Environment.NewLine;
                            lbl_Endereco.Text += $"CEP: {endereco.cep}";
                            lbl_Endereco.Text += Environment.NewLine;
                            lbl_Endereco.Text += $"Lucas hoje as {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} tem jeito a 27ª?";
                        }



                    }
                    catch (Exception ex)
                    {

                        DisplayAlert("ERRO", $"", "Entendi");
                    }
                }



            

            }
        }
    }
}
