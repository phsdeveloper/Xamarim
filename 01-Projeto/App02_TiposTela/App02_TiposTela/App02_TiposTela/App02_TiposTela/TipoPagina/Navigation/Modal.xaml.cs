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
	public partial class Modal : ContentPage
	{
		public Modal ()
		{
			InitializeComponent ();
		}

        private void Btn_fechar_Clicked(object sender, EventArgs e)
        {
            /********************************************
             * Navigation.PopModalAsync(): Fecha a tela que foi aberta como uma modal
             * Navigation.PopAsync(); => volta para a pagina anterior, igual a seta que fica na parte superior
             * Navigation.PopToRootAsync(); => Volta para a primeira pagina adicionada na pilha de chamadas.
             */

           
            Navigation.PopModalAsync();

        }
    }
}