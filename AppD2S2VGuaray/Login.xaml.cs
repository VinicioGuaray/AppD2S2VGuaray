using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppD2S2VGuaray
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                String usuario = txtUsuario.Text;
                String password = txtPassword.Text;
                if(usuario.Trim()=="" || usuario==" ")
                {
                 await   DisplayAlert("Error", "Debe ingresar un usuario", "ok");
                }
                else if(password==" ")
                {
                   await DisplayAlert("Error", "Debe Ingresar una Contraseña","ok");
                }
                else
                {
                    if (usuario == "estudiante2021" && password == "uisrael2021")
                    {
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        await Navigation.PushAsync(new MainPage(usuario));
                    }
                    else{
                      await  DisplayAlert("Error", "Usuario o Password incorrectos", "ok");
                    }
                }
                }
            
            catch (Exception ex)
            {
              await  DisplayAlert("Error", ex.Message, "Ok");
            }
        }

      
    }
}