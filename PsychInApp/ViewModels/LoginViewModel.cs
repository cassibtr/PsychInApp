using Firebase.Auth;
using PsychInApp.Conexions;
using PsychInApp.Models;
using PsychInApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PsychInApp.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        #region Atributos
        private string email;
        private string clave;
        #endregion

        #region Propiedades
        public string TxtUsuario
        {
            get { return email; }
            set { SetValue(ref email, value); }
        }
        public string TxtPassword
        {
            get { return clave; }
            set { SetValue(ref clave, value); }
        }

        #endregion

        #region Command
        public Command LoginCommand { get; }
        #endregion

        #region Metodo
        public async Task LoginUsuario()
        {
            var objusuario = new UserModel()
            {
                EmailField = email,
                PasswordField = clave,
            };
            try
            {

                var autenticacion = new FirebaseAuthProvider(new FirebaseConfig(DBConn.WebApiAuthentication));
                var authuser = await autenticacion.SignInWithEmailAndPasswordAsync(objusuario.EmailField.ToString(), objusuario.PasswordField.ToString());
                string obternertoken = authuser.FirebaseToken;

                var NavigationPage = new NavigationPage(new MyMind());

                NavigationPage.BarBackgroundColor = Color.RoyalBlue;
                App.Current.MainPage = NavigationPage;


            }
            catch (Exception)
            {

                await App.Current.MainPage.DisplayAlert("Advertencia", "Los datos introducidos son incorrectos o el usuario se encuentra inactivo.", "Aceptar");
                //await App.Current.MainPage.DisplayAlert("Advertencia", ex.Message, "Aceptar");
            }
        }
        #endregion

        #region Constructor
        public LoginViewModel(INavigation navegar)
        {
            Navigation = navegar;
            LoginCommand = new Command(async () => await LoginUsuario());

        }
        #endregion
    }
    
}
