using PsychInApp.Views.Acceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychInApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

        private async void Siguiente_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new LoginPage());

        }
    }
}