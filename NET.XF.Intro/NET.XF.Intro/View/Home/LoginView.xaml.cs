using NET.XF.Intro.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NET.XF.Intro.View.Home
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnEnter_Clicked(object sender, EventArgs args)
        {
            UserViewModel userVM = new UserViewModel();

            if (userVM.Users.Where(u => u.Name == txtUser.Text
             && u.Password == txtPassword.Text).Any())
            {
                // Navegar para página Home do Usuário com uma View mostrando os usuários existentes
            }
            else
            {
                DisplayAlert("Error", 
                    string.Format("Usuário: {0} inválido", txtUser.Text), "Ok");
            }
        }
    }
}
