using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace LCATPA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            imgLogo.Opacity = 0;
            
            await Task.WhenAny<bool>
            (
              imgLogo.FadeTo(1, 3000)
            );
            await Task.WhenAny<bool>
            (
               imgLogo.TranslateTo(-DeviceDisplay.MainDisplayInfo.Width, 0, 300)
            );
            App.Current.MainPage = new MainPage();
        }
    }
}