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
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        private void btn_mudar_click(object sender,EventArgs args)
        {
            DisplayAlert("Aviso Sistema", "Envento chamado", "Entendi");
            Navigation.PushAsync(new Pagina2());
           
        }

        private void btn_chamarModal_click(object sender,EventArgs args)
        {

        }

    }
}