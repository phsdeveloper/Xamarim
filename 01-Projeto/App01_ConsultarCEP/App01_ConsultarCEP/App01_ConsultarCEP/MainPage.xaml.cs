﻿using System;
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
            string st_CepNumeros = new string(txt_CEP.Text.Where(x=> char.IsNumber(x)).ToArray());

            if(string.IsNullOrWhiteSpace(st_CepNumeros))
            {
                lbl_Endereco.Text = "Por favor informe um CEP para verificação";
            }
            else if(st_CepNumeros.Length!=8)
            {
                lbl_Endereco.Text = "O cep deve conter apenas 8 numeros.";
            }
            else
            {
                var endereco = Servico.Modelo.ViaCepServico.BuscarEnderecoViaCEP(st_CepNumeros);

                lbl_Endereco.Text = $"Endereço: {endereco.logradouro}";
                lbl_Endereco.Text += Environment.NewLine;
                lbl_Endereco.Text += $"Bairro: {endereco.bairro}";
                lbl_Endereco.Text += Environment.NewLine;
                lbl_Endereco.Text += $"Cidade: {endereco.localidade}";
                lbl_Endereco.Text += Environment.NewLine;
                lbl_Endereco.Text += $"Estado: {endereco.uf}";
                lbl_Endereco.Text += Environment.NewLine;
                lbl_Endereco.Text += $"CEP: {endereco.cep}";
            }
        }
    }
}