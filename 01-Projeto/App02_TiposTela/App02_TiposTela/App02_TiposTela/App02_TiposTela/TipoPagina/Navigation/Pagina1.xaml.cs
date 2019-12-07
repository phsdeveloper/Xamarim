using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposTela.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        private string st_Classe = "";
        public Pagina1()
        {
            InitializeComponent();
        }
        public Pagina1(string Classe)
        {
            st_Classe = Classe;
            InitializeComponent();
        }

        private void btn_mudar_click(object sender, EventArgs args)
        {
            if (st_Classe.Equals("NavigationPage"))
            {
                DisplayAlert("Aviso Sistema", "Envento chamado", "Entendi");
                Navigation.PushAsync(new Pagina2());
            }
            else
            {
                DisplayAlert("Aviso Sistema", "Esse tipo de Tela não comporta esse Evento", "Entendi");
            }


        }

        private void btn_chamarModal_click(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void Tbi_Ordenar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (tbi_Ordenar.Icon.File.Equals("sort_descending.png"))
                    tbi_Ordenar.Icon = "sort_ascending.png";

                else
                    tbi_Ordenar.Icon = "sort_descending.png";

                DisplayAlert("Aviso Sistema", $"Ordenar: {(tbi_Ordenar.Icon.File.Contains("ascending")? "ascending": "descending")}", "Entendi");
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void Btn_Voltar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new TipoPagina.Carrossel.IntroducaoApp();
        }
    }
}