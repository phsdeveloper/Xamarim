using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposTela.TipoPagina.Carrossel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina(object sender, EventArgs e)
        {
            //Vai forçar uma transição de pagina
            App.Current.MainPage = new NavigationPage(new Navigation.Pagina1("NavigationPage")) { BarBackgroundColor = Color.Blue};
            
        }

        private void Btn_ExmploAula40_Clicked(object sender, EventArgs e)
        {
            //Adiciona a tela a uma parada de abas
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}