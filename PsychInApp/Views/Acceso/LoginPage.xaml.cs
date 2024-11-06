using PsychInApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychInApp.Views.Acceso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }

        //private bool IsValidData(string username, string password)
        //{
        //    return username == "cassibtr@gmail.com" && password == "1234";
        //}

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        //private async void TxtIngresar_Clicked(object sender, EventArgs e)
        //{
        //    string username = TxtUsuario.Text;
        //    string password = TxtPassword.Text;

        //    if (IsValidData(username, password))
        //    {
        //        await DisplayAlert("Inicio de Sesión", "Acceso Correcto", "Ok");
        //        await Navigation.PushAsync(new MenuPage());
        //    }
        //    else
        //    {
        //        await DisplayAlert("Error", "Datos no válidos", "Ok");

        //    }

        //}

        //private void TxtRegistrarse_Clicked(object sender, EventArgs e)
        //{

        //}
    }
}