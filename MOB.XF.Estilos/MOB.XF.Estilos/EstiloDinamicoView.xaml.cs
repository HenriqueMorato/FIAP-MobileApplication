using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.Estilos
{
    public partial class EstiloDinamicoView : ContentPage
    {
        bool temaPadrao;

        public EstiloDinamicoView()
        {
            InitializeComponent();

            temaPadrao = true;
            Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
        }

        private void OnClick_AlterarEstilo(object sender, EventArgs args)
        {
            temaPadrao = !temaPadrao;
            if(temaPadrao)
                Resources["TextoEstiloDinamico"] = Resources["TextoBranco"];
            else
                Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
        }

        #region Relógio
        private bool desligarRelogio = false;

        protected override void OnAppearing()
        {
            desligarRelogio = false;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Resources["Hora"] = DateTime.Now.ToString();
                return !desligarRelogio;
            });

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            desligarRelogio = true;
            base.OnDisappearing();
        }

        #endregion
    }
}
