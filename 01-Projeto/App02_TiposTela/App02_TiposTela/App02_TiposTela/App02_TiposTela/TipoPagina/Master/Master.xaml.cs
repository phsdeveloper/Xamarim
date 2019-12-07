using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposTela.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}
        
        private void Btn_Item1_Clicked(object sender, EventArgs e)
        {
            Detail = new Navigation.Pagina1();
        }

        private void Btn_Item2_Clicked(object sender, EventArgs e)
        {
            Detail = new Navigation.Pagina2();
        }

        private void Btn_Item3_Clicked(object sender, EventArgs e)
        {
            Detail = new Conteudo();
        }
    }
}