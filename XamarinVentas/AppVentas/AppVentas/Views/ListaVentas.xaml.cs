using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppVentas.ViewModels;
using AppVentas.Models;

namespace AppVentas.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaVentas : ContentPage
	{
		public ListaVentas ()
		{
			InitializeComponent ();
		}

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}